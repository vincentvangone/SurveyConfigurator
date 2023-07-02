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
    public partial class UC_View : UserControl
    {
        public UC_View()
        {
            InitializeComponent();
        }

        private void UC_View_Load(object sender, EventArgs e)
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
                adapter.Fill(table);
                this.dataGridView.DataSource = table;
                
            }
        }
    }
}
