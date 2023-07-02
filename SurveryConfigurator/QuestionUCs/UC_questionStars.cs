using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SurveryConfigurator.Objects;
using System.Runtime.InteropServices;

namespace SurveyConfigurator
{
    public partial class UC_questionStars : UserControl
    {
        quesStars RefQuestion;
        private int NoOfStars { get; set; }
        
        public UC_questionStars(ref quesStars question)
        {
            InitializeComponent();
            RefQuestion = question;
        }


        //methods to set the number of stars depending on the user's choice 
        private void pictureStar10_Click(object sender, EventArgs e)
        {
            RefQuestion.NoOfStars = 10;
            resizeStars(10);
        }
        private void pictureStar9_Click(object sender, EventArgs e)
        {
            RefQuestion.NoOfStars = 9;
            resizeStars(9);
        }
        private void pictureStar8_Click(object sender, EventArgs e)
        {
            RefQuestion.NoOfStars = 8;
            resizeStars(8);
        }
        private void pictureStar7_Click(object sender, EventArgs e)
        {
            RefQuestion.NoOfStars = 7;
            resizeStars(7);
        }
        private void pictureStar6_Click(object sender, EventArgs e)
        {
            RefQuestion.NoOfStars = 6;
            resizeStars(6);
        }
        private void pictureStar5_Click(object sender, EventArgs e)
        {
            RefQuestion.NoOfStars = 5;
            resizeStars(5);
        }
        private void pictureStar4_Click(object sender, EventArgs e)
        {
            RefQuestion.NoOfStars = 4;
            resizeStars(4);
        }
        private void pictureStar3_Click(object sender, EventArgs e)
        {
            RefQuestion.NoOfStars = 3;
            resizeStars(3);
        }
        private void pictureStar2_Click(object sender, EventArgs e)
        {
            RefQuestion.NoOfStars = 2;
            resizeStars(2);
        }
        private void pictureStar1_Click(object sender, EventArgs e)
        {
            RefQuestion.NoOfStars = 1;
            resizeStars(1);
        }

        // to prevent repetitive code, i added a method that receives the number of stars to resize them
        // make n stars bigger and 10-n smaller 
        private void resizeStars(int n)
        {
            comboBoxNoOfStars.SelectedIndex = n-1;

            if (n >= 1) 
            {
                pictureStar10.Size = new Size(42, 61);
                pictureStar9.Size = new Size(42, 61);
                pictureStar8.Size = new Size(42, 61);
                pictureStar7.Size = new Size(42, 61);
                pictureStar6.Size = new Size(42, 61);
                pictureStar5.Size = new Size(42, 61);
                pictureStar4.Size = new Size(42, 61);
                pictureStar3.Size = new Size(42, 61);
                pictureStar2.Size = new Size(42, 61);
                pictureStar1.Size = new Size(84, 123);
            }
            if (n >= 2)
            {
                pictureStar2.Size = new Size(84, 123);
            }
            if (n >= 3)
            {
                pictureStar3.Size = new Size(84, 123);
             }
            if (n >= 4)
            {
                pictureStar4.Size = new Size(84, 123);
            }
            if (n >= 5)
            {
                pictureStar5.Size = new Size(84, 123);
            }
            if (n >= 6)
            {
                pictureStar6.Size = new Size(84, 123);
            }
            if (n >= 7)
            {
                pictureStar7.Size = new Size(84, 123);
            }
            if (n >= 8)
            {
                pictureStar8.Size = new Size(84, 123);
            }
            if (n >= 9) 
            {
                pictureStar9.Size = new Size(84, 123);
            }
            if (n == 10)
                pictureStar10.Size = new Size(84, 123);
        }

        // for optimal ux - the user can change the number of stars either by clicking on the stars or modifying it from the combobox 
        // synced
        private void comboBoxNoOfStars_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxNoOfStars.SelectedIndex)
            {
                case 0:
                    pictureStar1_Click(sender, e);
                    break;
                case 1:
                    pictureStar2_Click(sender, e);
                    break;
                case 2:
                    pictureStar3_Click(sender, e);
                    break;
                case 3:
                    pictureStar4_Click(sender, e);
                    break;
                case 4:
                    pictureStar5_Click(sender, e);
                    break;
                case 5:
                    pictureStar6_Click(sender, e);
                    break;
                case 6:
                    pictureStar7_Click(sender, e);
                    break;
                case 7:
                    pictureStar8_Click(sender, e);
                    break;
                case 8:
                    pictureStar9_Click(sender, e);
                    break;
                case 9:
                    pictureStar10_Click(sender, e);
                    break;
            }
        }

        
    }
}
