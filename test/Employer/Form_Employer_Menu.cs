using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Employer;

namespace test.Employer
{
    public partial class Home_Employer : System.Windows.Forms.Form
    {
        Form_Employer_Info UserInfo;
        Form_Employer_ManageJob ManageJob;
        Start_App startApp;
        public Home_Employer()
        {
            InitializeComponent();
        }


        bool SideExpand = true;
        private void Side_Transition_Tick(object sender, EventArgs e)
        {
            if (SideExpand)
            {
                SideBar.Width -= 10;
                if (SideBar.Width <= 45)
                {
                    SideExpand = false;
                    Side_Transition.Stop();
                }
            }
            else
            {
                SideBar.Width += 10;
                if (SideBar.Width >= 170)
                {
                    SideExpand = true;
                    Side_Transition.Stop();
                }
            }
        }

        private void SideBar_Control_Click(object sender, EventArgs e)
        {
            Side_Transition.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (UserInfo == null)
            {
                UserInfo = new Form_Employer_Info();
                UserInfo.FormClosed += UserInfo_FormClosed;
                UserInfo.MdiParent = this;
                UserInfo.Dock = DockStyle.Fill;
                UserInfo.Show();
            }
            else
            {
                UserInfo.Activate();
            }
        }
        private void UserInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserInfo = null;
        }

        private void ManageJob_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManageJob = null;
        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_UserInfo_Click_1(object sender, EventArgs e)
        {
            if (UserInfo == null)
            {
                UserInfo = new Form_Employer_Info();
                UserInfo.FormClosed += UserInfo_FormClosed;
                UserInfo.MdiParent = this;
                UserInfo.Dock = DockStyle.Fill;
                UserInfo.Show();
            }
            else
            {
                UserInfo.Activate();
            }
        }

        private void Btn_LogOut_Click_1(object sender, EventArgs e)
        {
            this.Close();
            startApp = new Start_App();
            startApp.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (ManageJob == null)
            {
                ManageJob = new Form_Employer_ManageJob();
                ManageJob.FormClosed += ManageJob_FormClosed;
                ManageJob.MdiParent = this;
                ManageJob.Dock = DockStyle.Fill;
                ManageJob.Show();
            }
            else
            {
                ManageJob.Activate();
            }
        }
    }
}
