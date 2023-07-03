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

namespace SurveryConfigurator
{
    public partial class temporaryEdit : Form
    {
        private int QuesId;
        private string QuestText;
        public temporaryEdit(int quesId, string questText)
        {
            QuesId = quesId;
            QuestText = questText;
            InitializeComponent();
            textBox1.Text = questText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to save changes to question " + this.QuesId + " ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                using (SqlConnection connection = new SqlConnection(SurveryConfigurator.Properties.Settings.Default.connString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("SurveyConfigurator.editQuestion", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlCommand.Parameters.Add(new SqlParameter("@QuestionText", SqlDbType.VarChar,1000));
                        sqlCommand.Parameters["@QuestionText"].Value = textBox1.Text.ToString();
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
                            MessageBox.Show("Question number " + this.QuesId + " has been edited.");


                        }
                        catch
                        {
                            MessageBox.Show("The question could not be edited.");
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
