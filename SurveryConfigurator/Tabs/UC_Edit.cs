using SurveyConfigurator.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveryConfigurator.Tabs
{
    public partial class UC_Edit : UserControl
    {
        private int QuesId;
        public UC_Edit()
        {
            InitializeComponent();
        }

        private void UC_Edit_Load(object sender, EventArgs e)
        {
            //string to select all questions and group columns that arent common in to one - question properties column
            string selectQuery =
            "SELECT Question.QuestionID,Question.QuestionText,Question.QuestionType,concat('Number of Smileys: ',noOfSmileys) as 'Question Properties' FROM SurveyConfigurator.QuesSmiley LEFT JOIN SurveyConfigurator.Question ON SurveyConfigurator.QuesSmiley.QuestionID = SurveyConfigurator.Question.QuestionID " +
            "UNION " +
            "SELECT Question.QuestionID,Question.QuestionText,Question.QuestionType,concat('Number of Stars: ', noOfStars) as 'Question Properties' FROM SurveyConfigurator.QuesStars LEFT JOIN SurveyConfigurator.Question ON SurveyConfigurator.QuesStars.QuestionID = SurveyConfigurator.Question.QuestionID " +
            "UNION " +
            "SELECT Question.QuestionID,Question.QuestionText,Question.QuestionType,concat('Start Value: ',startValue, '  Start Caption: ', startCaption,'  End Value: ', endValue, '  End Caption: ' ,endCaption) as 'Question Properties' FROM SurveyConfigurator.QuesSlider LEFT JOIN SurveyConfigurator.Question ON SurveyConfigurator.QuesSlider.QuestionID = SurveyConfigurator.Question.QuestionID";

            using (SqlConnection connection = new SqlConnection(SurveryConfigurator.Properties.Settings.Default.connString))
            using (var adapter = new SqlDataAdapter(selectQuery, connection))
            {
                var table = new DataTable();

                table.Columns.Add("Select", typeof(bool));
                adapter.Fill(table);
                this.dataGridView.DataSource = table;

                foreach (DataColumn column in table.Columns)
                {
                    //disable user editing of any column except the checkbox
                    if (column.ColumnName == "Select" )
                        continue;

                    column.ReadOnly = true;
                }
                connection.Close();
                 

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[0].Value.Equals(true))
                {
                    this.QuesId = int.Parse(row.Cells[1].Value.ToString());
                    //flag to make sure parent question was deleted
                    bool halfDelete = false;
                    //confirm delete?
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete question " + this.QuesId + " ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.OK)
                    {
                        // Create a SqlCommand object.
                        using (SqlConnection connection = new SqlConnection(SurveryConfigurator.Properties.Settings.Default.connString))
                        {
                            if (row.Cells[3].Value.ToString() == "Smiley")
                            {
                                using (SqlCommand sqlCommand = new SqlCommand("SurveyConfigurator.deleteQuestionSmiley", connection))
                                {
                                    sqlCommand.CommandType = CommandType.StoredProcedure;

                                    sqlCommand.Parameters.Add(new SqlParameter("@QuestionID", SqlDbType.Int));
                                    sqlCommand.Parameters["@QuestionID"].Value = this.QuesId;

                                    try
                                    {
                                        connection.Open();

                                        //run previously stored procedure
                                        sqlCommand.ExecuteNonQuery();
                                        //RETURN COUNTER OF THE QUESTION ID
                                        //display question's number

                                        MessageBox.Show("the question is almost deleted.");
                                        halfDelete = true;


                                    }
                                    catch
                                    {
                                        MessageBox.Show("The question could not be deleted.");
                                    }
                                    finally
                                    {
                                        // close the connection.
                                        connection.Close();
                                    }
                                }
                            }
                            else if (row.Cells[3].Value.ToString() == "Stars")
                            {
                                using (SqlCommand sqlCommand = new SqlCommand("SurveyConfigurator.deleteQuestionStars", connection))
                                {
                                    sqlCommand.CommandType = CommandType.StoredProcedure;

                                    sqlCommand.Parameters.Add(new SqlParameter("@QuestionID", SqlDbType.Int));
                                    sqlCommand.Parameters["@QuestionID"].Value = this.QuesId;

                                    try
                                    {
                                        connection.Open();

                                        //run previously stored procedure
                                        sqlCommand.ExecuteNonQuery();
                                        //RETURN COUNTER OF THE QUESTION ID
                                        //display question's number

                                        MessageBox.Show("the question is almost deleted.");
                                        halfDelete = true;

                                    }
                                    catch
                                    {
                                        MessageBox.Show("the question could not be deleted.");
                                    }
                                    finally
                                    {
                                        // close the connection.
                                        connection.Close();
                                    }
                                }
                            }
                            else if (row.Cells[3].Value.ToString() == "Slider")
                            {
                                using (SqlCommand sqlCommand = new SqlCommand("SurveyConfigurator.deleteQuestionSlider", connection))
                                {
                                    sqlCommand.CommandType = CommandType.StoredProcedure;

                                    sqlCommand.Parameters.Add(new SqlParameter("@QuestionID", SqlDbType.Int));
                                    sqlCommand.Parameters["@QuestionID"].Value = this.QuesId;

                                    try
                                    {
                                        connection.Open();

                                        //run previously stored procedure
                                        sqlCommand.ExecuteNonQuery();
                                        //RETURN COUNTER OF THE QUESTION ID
                                        //display question's number
                                        halfDelete = true;
                                    }
                                    catch
                                    {
                                        MessageBox.Show("The question could not be deleted.");
                                    }
                                    finally
                                    {
                                        // close the connection.
                                        connection.Close();
                                    }
                                }
                            }
                            if (halfDelete)
                            {
                                using (SqlCommand sqlCommand = new SqlCommand("SurveyConfigurator.delQuestion", connection))
                                {
                                    sqlCommand.CommandType = CommandType.StoredProcedure;

                                    sqlCommand.Parameters.Add(new SqlParameter("@QuestionID", SqlDbType.Int));
                                    sqlCommand.Parameters["@QuestionID"].Value = this.QuesId;


                                    try
                                    {
                                        connection.Open();

                                        //run previously stored procedure
                                        sqlCommand.ExecuteNonQuery();
                                        //RETURN COUNTER OF THE QUESTION ID
                                        //display question's number
                                        this.QuesId = (int)sqlCommand.Parameters["@QuestionID"].Value;
                                        MessageBox.Show("Question number " + this.QuesId + " has been deleted.");


                                    }
                                    catch
                                    {
                                        MessageBox.Show("The question could not be deleted.");
                                    }
                                    finally
                                    {
                                        // close the connection.
                                        connection.Close();
                                    }
                                }

                            }
                        }
                    }
                }
            }
        }
            
        

        
        private void buttonEditQues_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[0].Value.Equals(true))
                {
                    temporaryEdit temp = new temporaryEdit(int.Parse(row.Cells[1].Value.ToString()), row.Cells[2].Value.ToString());
                    temp.ShowDialog();
                    //FormEdit formEdit = new FormEdit(int.Parse(row.Cells[1].Value.ToString()));
                    //formEdit.ShowDialog();
                }
            }
        }
    }
}
