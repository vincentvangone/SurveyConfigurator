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

namespace SurveyConfigurator.Tabs
{
    public partial class UC_Create : UserControl
    {
       // public quesSmiley smileyQuestion;
       // public quesStars starQuestion;
        //public quesSlider sliderQuestion;

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
                   // smileyQuestion.QuesType = "Smiley";
                    UC_questionSmiley ucSmiley = new UC_questionSmiley();
                    addQuestionUserControls(ucSmiley);
                    break;
                case 1:
                  //  starQuestion.QuesType = "Stars";
                    UC_questionStars ucStars = new UC_questionStars();
                    addQuestionUserControls(ucStars);
                    break;
                case 2:
                  //  sliderQuestion.QuesType = "Slider";
                    UC_questionSlider ucSlider = new UC_questionSlider();
                    addQuestionUserControls(ucSlider);
                    break;
            }
        }


        //make sure question isnt blank
        private bool isQuestionTextValid()
        {
            if (textBoxQuesText.Text == "")
            {
                MessageBox.Show("Please enter a valid question.");
                return false;
            }
            else
            {
                return true;
            }
        }

        //private bool isQuestionInputValid()
        //{
        //    if (QuesType == "Smiley")
        //    {
        //      return 
        //    }
        //}


        //clear panel and question type whenever the question is added to survey
        //send data to sql server
        private void buttonAddQues_Click(object sender, EventArgs e)
        {
           // System.Console.WriteLine(smileyQuestion.NoOfSmileys);

            //if (isQuestionTextValid())
            //{
            //
            //    comboBoxQuesTypes.SelectedIndex = -1;
            //    panelAddQuestion.Controls.Clear();
            //    panelCommonInput.Hide();
            //}
        }

    }
}
