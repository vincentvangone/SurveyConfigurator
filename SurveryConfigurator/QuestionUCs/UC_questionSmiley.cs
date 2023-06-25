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

namespace SurveyConfigurator
{
    public partial class UC_questionSmiley : UserControl
    {
        quesSmiley Sim;
        private int noOfFaces;
        public UC_questionSmiley()
        {
            
            InitializeComponent();
            comboBoxNoOfFaces.SelectedIndex = 3;
        }

        //hide or display faces depending on the number specified by the user
       

        private void UC_questionSmiley_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxNoOfFaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxNoOfFaces.SelectedIndex)
            {
                //user selected 2 faces
                case 0:
                    noOfFaces = 2;
                    pictureFace2.Hide();
                    pictureFace3.Hide();
                    pictureFace4.Hide();
                    break;
                //user selected 3 faces
                case 1:
                    noOfFaces = 3;
                    pictureFace2.Hide();
                    pictureFace3.Show();
                    pictureFace4.Hide();
                    break;
                //user selected 4 faces
                case 2:
                    noOfFaces = 4;
                    pictureFace2.Show();
                    pictureFace3.Hide();
                    pictureFace4.Show();
                    break;
                //user selected 5 faces
                case 3:
                    noOfFaces = 5;
                    pictureFace2.Show();
                    pictureFace3.Show();
                    pictureFace4.Show();
                    break;
            }

        }
    }
}
