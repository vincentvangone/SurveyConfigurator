﻿using SurveryConfigurator.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyConfigurator
{
    public partial class UC_questionSmiley : UserControl
    {
        quesSmiley RefQuestion;
       
        //passing object by reference to edit on it
        public UC_questionSmiley(ref quesSmiley question)
        {
            RefQuestion = question;
            InitializeComponent();
            comboBoxNoOfFaces.SelectedIndex = 3;
        }

        //hide or display faces depending on the number specified by the user
        private void comboBoxNoOfFaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxNoOfFaces.SelectedIndex)
            {
                //user selected 2 faces
                case 0:
                    RefQuestion.NoOfSmileys = 2;
                    pictureFace2.Hide();
                    pictureFace3.Hide();
                    pictureFace4.Hide();
                    break;
                //user selected 3 faces
                case 1:
                    RefQuestion.NoOfSmileys = 3;
                    pictureFace2.Hide();
                    pictureFace3.Show();
                    pictureFace4.Hide();
                    break;
                //user selected 4 faces
                case 2:
                    RefQuestion.NoOfSmileys = 4;
                    pictureFace2.Show();
                    pictureFace3.Hide();
                    pictureFace4.Show();
                    break;
                //user selected 5 faces
                case 3:
                    RefQuestion.NoOfSmileys = 5;
                    pictureFace2.Show();
                    pictureFace3.Show();
                    pictureFace4.Show();
                    break;
            }
        
        }
    }
}
