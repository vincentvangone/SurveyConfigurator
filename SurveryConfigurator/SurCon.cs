using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using SurveyConfigurator.Tabs;

namespace SurveyConfigurator
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();

            //load home screen layout when the app is started
            UC_Home ucHome = new UC_Home();
            addUserControls(ucHome);
        }

        //method to clear previous content and display new
        private void addUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelMainContainer.Controls.Clear();
            panelMainContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        //logo click -> display Home page
        private void picLogo_Click(object sender, EventArgs e)
        {
            UC_Home ucHome = new UC_Home();
            addUserControls(ucHome);
        }

        //"create"  click -> display create new question page
        private void buttonNavCreate_Click(object sender, EventArgs e)
        {
            UC_Create ucCreate = new UC_Create();
            addUserControls(ucCreate);

        }


        //"view"  click -> display show all questions page 
        private void buttonNavView_Click(object sender, EventArgs e)
        {

        }

        //"edit"  click -> display edit all questions page 
        private void buttonNavEdit_Click(object sender, EventArgs e)
        {

        }

        //"help"  click -> display help page 
        private void buttonNavHelp_Click(object sender, EventArgs e)
        {
            UC_Help ucHelp = new UC_Help();
            addUserControls(ucHelp);
        }

        
    }
}
