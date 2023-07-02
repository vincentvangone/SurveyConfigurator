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
                    if (column.ColumnName == "Select")
                        continue;

                    column.ReadOnly = true;
                }



            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[0].Value.Equals(true))
                {
                    QuesId = int.Parse(row.Cells[1].Value.ToString());
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete question " + QuesId + " ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.OK)
                    {
                        // Define a t-SQL query string that has a parameter for question id
                        //const string delQuestion = "DELETE FROM SurveyConfigurator.Question WHERE QuestionID=@QuestionId";
                        // Create a SqlCommand object.
                        using (SqlConnection connection = new SqlConnection(SurveryConfigurator.Properties.Settings.Default.connString))
                        {
                            // Create a SqlCommand object.
                            using (SqlCommand sqlCommand = new SqlCommand("SurveyConfigurator.delQuestion", connection))
                            {
                                sqlCommand.CommandType = CommandType.StoredProcedure;

                                // Define the @orderID parameter and set its value.
                                sqlCommand.Parameters.Add(new SqlParameter("@QuestionID", SqlDbType.Int));
                                sqlCommand.Parameters["@QuestionID"].Value = QuesId;


                                try
                                {
                                    connection.Open();
                                    sqlCommand.ExecuteNonQuery();

                                }
                                catch
                                {
                                    MessageBox.Show("The question could not be deleted.");
                                }
                                finally
                                {
                                    // Close the connection.
                                    connection.Close();
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
                    UC_Create uC_Create = new UC_Create();
                    new Form().ShowDialog(uC_Create);
                }
            }
        }
    }
}
