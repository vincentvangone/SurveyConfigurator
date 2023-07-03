using SurveryConfigurator.Objects;
using SurveyConfigurator.QuestionUCs;
using SurveyConfigurator;
using SurveyConfigurator.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveryConfigurator
{
    public partial class FormEdit : Form
    {
        //to return id from edit page
        private int QuesID;

        //question objects to be passed from edit page
        public quesSmiley smileyQuestion = new quesSmiley();
        public quesStars starQuestion = new quesStars();
        public quesSlider sliderQuestion = new quesSlider();

        public FormEdit(int QuesID)
        {
            InitializeComponent();
            QuesID = this.QuesID;
            UC_Create ucCreate = new UC_Create();
            addQuestionUserControls(ucCreate);
            
        }


        //user control addition -> switching panel content depending on user's choice
        private void addQuestionUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelUCEdit.Controls.Clear();
            panelUCEdit.Controls.Add(userControl);
            userControl.BringToFront();
        }

        
    }
}
