using SurveyConfigurator.QuestionUCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SurveryConfigurator.Objects;
using System.Diagnostics;

namespace SurveyConfigurator.Tabs
{

    public partial class UC_Create : UserControl
    {
        //to return id from datebase
        private int QuesID;

        //question objects
        public quesSmiley smileyQuestion = new quesSmiley();
        public quesStars starQuestion = new quesStars();
        public quesSlider sliderQuestion = new quesSlider();

        public UC_Create()
        {
            InitializeComponent();
            panelCommonInput.Hide();

        }

        //user control addition -> switching panel content depending on user's choice
        private void addQuestionUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelAddQuestion.Controls.Clear();
            panelAddQuestion.Controls.Add(userControl);
            userControl.BringToFront();
        }

        // when user changes selected type -> load different UC in panel
        private void comboBoxQuesTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

            panelCommonInput.Show();
            switch (comboBoxQuesTypes.SelectedIndex)
            {
                case 0:
                    smileyQuestion.QuesType = "Smiley";
                    UC_questionSmiley ucSmiley = new UC_questionSmiley(ref smileyQuestion);
                    addQuestionUserControls(ucSmiley);
                    break;
                case 1:
                    starQuestion.QuesType = "Stars";
                    UC_questionStars ucStars = new UC_questionStars(ref starQuestion);
                    addQuestionUserControls(ucStars);
                    break;
                case 2:
                    sliderQuestion.QuesType = "Slider";
                    UC_questionSlider ucSlider = new UC_questionSlider(ref sliderQuestion);
                    addQuestionUserControls(ucSlider);
                    break;
            }
        }




        //clear panel and question type whenever the question is added to survey
        //send data to sql server
        private void buttonAddQues_Click(object sender, EventArgs e)
        {
            //check if question text is empty first
            if (textBoxQuesText.Text != "")
            {
                //if not empty start sql connection
                using (SqlConnection connection = new SqlConnection(SurveryConfigurator.Properties.Settings.Default.connString))
                {

                    //if the selected question type is smiley -> use smiley object + add to smiley table
                    if (comboBoxQuesTypes.SelectedItem.ToString() == "Smiley Faces")
                    {
                        smileyQuestion.QuesText = textBoxQuesText.Text;

                        //creates new smiley question by calling SurveyConfigurator.insertQuestion and insertSmileyQuestion
                        using (SqlCommand sqlCommand = new SqlCommand("SurveyConfigurator.insertQuestion", connection))
                        {
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            // Add input parameter for the stored procedure and specify what to use as its value.
                            sqlCommand.Parameters.Add(new SqlParameter("@QuestionText", SqlDbType.VarChar, 1000));
                            sqlCommand.Parameters["@QuestionText"].Value = smileyQuestion.QuesText;
                            sqlCommand.Parameters.Add(new SqlParameter("@QuestionType", SqlDbType.VarChar, 20));
                            sqlCommand.Parameters["@QuestionType"].Value = smileyQuestion.QuesType;

                            // Add the output parameter.
                            sqlCommand.Parameters.Add(new SqlParameter("@QuestionID", SqlDbType.Int));
                            sqlCommand.Parameters["@QuestionID"].Direction = ParameterDirection.Output;

                            try
                            {
                                connection.Open();

                                //run previously stored procedure
                                sqlCommand.ExecuteNonQuery();

                                // Question ID is an IDENTITY value from the database.
                                this.QuesID = (int)sqlCommand.Parameters["@QuestionID"].Value;
                            }
                            catch
                            {
                                MessageBox.Show("Question ID was not returned. Question could not be created.");
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                        // Create a SqlCommand, and identify it as a stored procedure.
                        using (SqlCommand sqlCommand = new SqlCommand("SurveyConfigurator.insertQuestionSmiley", connection))
                        {
                            
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            // Add input parameter for the stored procedure and specify what to use as its value.
                            sqlCommand.Parameters.Add(new SqlParameter("@noOfSmileys", SqlDbType.Int));
                            sqlCommand.Parameters["@noOfSmileys"].Value = smileyQuestion.NoOfSmileys;

                            // Add the @QuestionID input parameter, which was obtained from insertQuestion.
                            sqlCommand.Parameters.Add(new SqlParameter("@QuestionID", SqlDbType.Int));
                            sqlCommand.Parameters["@QuestionID"].Value = this.QuesID;

                            // Add the return value for the stored procedure, which is  the question ID.
                            sqlCommand.Parameters.Add(new SqlParameter("@RC", SqlDbType.Int));
                            sqlCommand.Parameters["@RC"].Direction = ParameterDirection.ReturnValue;


                            try
                            {
                                connection.Open();

                                //run previously stored procedure
                                sqlCommand.ExecuteNonQuery();
                                //RETURN COUNTER OF THE QUESTION ID
                                //display question's number
                                this.QuesID = (int)sqlCommand.Parameters["@QuestionID"].Value;
                                MessageBox.Show("Question number " + this.QuesID + " has been created.");
                            }
                            catch
                            {
                                MessageBox.Show("Question could not be created.");
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }

                    //if the selected question type is stars -> use stars object + add to stars table
                    else if (comboBoxQuesTypes.SelectedItem.ToString() == "Stars")
                    {
                        starQuestion.QuesText = textBoxQuesText.Text;
                        using (SqlCommand sqlCommand = new SqlCommand("SurveyConfigurator.insertQuestion", connection))
                        {

                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            // Add input parameter for the stored procedure and specify what to use as its value.
                            sqlCommand.Parameters.Add(new SqlParameter("@QuestionText", SqlDbType.VarChar, 1000));
                            sqlCommand.Parameters["@QuestionText"].Value = starQuestion.QuesText;
                            sqlCommand.Parameters.Add(new SqlParameter("@QuestionType", SqlDbType.VarChar, 20));
                            sqlCommand.Parameters["@QuestionType"].Value = starQuestion.QuesType;

                            // Add the output parameter.
                            sqlCommand.Parameters.Add(new SqlParameter("@QuestionID", SqlDbType.Int));
                            sqlCommand.Parameters["@QuestionID"].Direction = ParameterDirection.Output;

                            try
                            {

                                connection.Open();

                                //run previously stored procedure
                                sqlCommand.ExecuteNonQuery();

                                // display question's id
                                this.QuesID = (int)sqlCommand.Parameters["@QuestionID"].Value;
                                MessageBox.Show("Question number " + this.QuesID + " has been created.");
                            }
                            catch
                            {
                                MessageBox.Show("Question ID was not returned. Question could not be created.");
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                        using (SqlCommand sqlCommand = new SqlCommand("SurveyConfigurator.insertQuestionStar", connection))
                        {
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            // Add input parameter for the stored procedure and specify what to use as its value.
                            sqlCommand.Parameters.Add(new SqlParameter("@noOfStars", SqlDbType.Int));
                            sqlCommand.Parameters["@noOfStars"].Value = starQuestion.NoOfStars;

                            // Add the @QuestionID input parameter, which was obtained from insertQuestion.
                            sqlCommand.Parameters.Add(new SqlParameter("@QuestionID", SqlDbType.Int));
                            sqlCommand.Parameters["@QuestionID"].Value = this.QuesID;

                            // Add the return value for the stored procedure, which is  the question ID.
                            sqlCommand.Parameters.Add(new SqlParameter("@RC", SqlDbType.Int));
                            sqlCommand.Parameters["@RC"].Direction = ParameterDirection.ReturnValue;


                            try
                            {
                                connection.Open();

                                //run previously stored procedure
                                sqlCommand.ExecuteNonQuery();
                                //RETURN COUNTER OF THE QUESTION ID
                                this.QuesID = (int)sqlCommand.Parameters["@RC"].Value;
                            }
                            catch
                            {
                                MessageBox.Show("Question could not be created.");
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }
                    //if the selected question type is stars -> use stars object + add to stars table
                    else if (comboBoxQuesTypes.SelectedItem.ToString() == "Slider")
                    {
                        starQuestion.QuesText = textBoxQuesText.Text;
                        using (SqlCommand sqlCommand = new SqlCommand("SurveyConfigurator.insertQuestion", connection))
                        {

                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            // Add input parameter for the stored procedure and specify what to use as its value.
                            sqlCommand.Parameters.Add(new SqlParameter("@QuestionText", SqlDbType.VarChar, 1000));
                            sqlCommand.Parameters["@QuestionText"].Value = sliderQuestion.QuesText;
                            sqlCommand.Parameters.Add(new SqlParameter("@QuestionType", SqlDbType.VarChar, 20));
                            sqlCommand.Parameters["@QuestionType"].Value = sliderQuestion.QuesType;

                            // Add the output parameter.
                            sqlCommand.Parameters.Add(new SqlParameter("@QuestionID", SqlDbType.Int));
                            sqlCommand.Parameters["@QuestionID"].Direction = ParameterDirection.Output;

                            try
                            {

                                connection.Open();

                                //run previously stored procedure
                                sqlCommand.ExecuteNonQuery();

                                // display question's id
                                this.QuesID = (int)sqlCommand.Parameters["@QuestionID"].Value;
                                MessageBox.Show("Question number " + this.QuesID + " has been created.");
                            }
                            catch
                            {
                                MessageBox.Show("Question ID was not returned. Question could not be created.");
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                        using (SqlCommand sqlCommand = new SqlCommand("SurveyConfigurator.insertQuestionSlider", connection))
                        {
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            // Add input parameter for the stored procedure and specify what to use as its value.
                            sqlCommand.Parameters.Add(new SqlParameter("@startValue", SqlDbType.Int));
                            sqlCommand.Parameters["@startValue"].Value = sliderQuestion.StartValue;
                            sqlCommand.Parameters.Add(new SqlParameter("@endValue", SqlDbType.Int));
                            sqlCommand.Parameters["@endValue"].Value = sliderQuestion.EndValue;

                            sqlCommand.Parameters.Add(new SqlParameter("@startCaption", SqlDbType.VarChar,50));
                            sqlCommand.Parameters["@startCaption"].Value = sliderQuestion.StartCaption;
                            sqlCommand.Parameters.Add(new SqlParameter("@endCaption", SqlDbType.VarChar, 50));
                            sqlCommand.Parameters["@endCaption"].Value = sliderQuestion.EndCaption;

                            // Add the @QuestionID input parameter, which was obtained from insertQuestion.
                            sqlCommand.Parameters.Add(new SqlParameter("@QuestionID", SqlDbType.Int));
                            sqlCommand.Parameters["@QuestionID"].Value = this.QuesID;

                            // Add the return value for the stored procedure, which is  the question ID.
                            sqlCommand.Parameters.Add(new SqlParameter("@RC", SqlDbType.Int));
                            sqlCommand.Parameters["@RC"].Direction = ParameterDirection.ReturnValue;


                            try
                            {
                                connection.Open();

                                //run previously stored procedure
                                sqlCommand.ExecuteNonQuery();
                                //RETURN COUNTER OF THE QUESTION ID
                                this.QuesID = (int)sqlCommand.Parameters["@RC"].Value;
                            }
                            catch
                            {
                                MessageBox.Show("Question could not be created.");
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }


                    comboBoxQuesTypes.SelectedIndex = -1;
                    textBoxQuesText.Clear();
                    panelAddQuestion.Controls.Clear();
                    panelCommonInput.Hide();
                }
            }
            else
                MessageBox.Show("Please enter question text.");

        }

       
    }

    

}

