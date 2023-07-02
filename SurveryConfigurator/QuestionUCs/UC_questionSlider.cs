using SurveryConfigurator.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyConfigurator.QuestionUCs
{
    public partial class UC_questionSlider : UserControl
    {
        quesSlider RefQuestion;

        public UC_questionSlider(ref quesSlider question)
        {
            RefQuestion = question;
            InitializeComponent();
        }

        private void textBoxStCaption_TextChanged(object sender, EventArgs e)
        {
            RefQuestion.StartCaption = textBoxStCaption.Text;
        }

        private void textBoxEndCaption_TextChanged(object sender, EventArgs e)
        {
            RefQuestion.EndCaption = textBoxEndCaption.Text;
        }

        private void numericStValue_ValueChanged(object sender, EventArgs e)
        {
            if (numericStValue.Value < 0 || numericStValue.Value > 100)
            {
                throw new ArgumentOutOfRangeException("Start Value must be a positive integer under 100.");
            }
            else
            {
                numericEndValue.Minimum = numericStValue.Value + 1;
                RefQuestion.StartValue = int.Parse(numericStValue.Text);
            }
        }

        private void numericEndValue_ValueChanged(object sender, EventArgs e)
        {
            if (numericEndValue.Value < 0 || numericEndValue.Value > 100)
            {
                throw new ArgumentOutOfRangeException("End Value must be a positive integer under 100.");
            }
            else if (numericEndValue.Value < numericStValue.Value)
                throw new ArgumentOutOfRangeException("End Value must be bigger than start value.");
            else
                RefQuestion.EndValue = int.Parse(numericStValue.Text);
        }
        
    }
}
