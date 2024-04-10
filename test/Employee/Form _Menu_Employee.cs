using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Employee;

namespace test
{
    public partial class Home_User : System.Windows.Forms.Form
    {
        Form_Employee_Info UserInfo;
        Form_Job_Employee FindJob;
        public Home_User()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (UserInfo == null)
            {
                UserInfo = new Form_Employee_Info();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserInfo == null)
            {
                UserInfo = new Form_Employee_Info();
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

        private void button6_Click(object sender, EventArgs e)
        {
            if (FindJob == null)
            {
                FindJob = new Form_Job_Employee();
                FindJob.FormClosed += FindJob_FormClosed;
                FindJob.MdiParent = this;
                FindJob.Dock = DockStyle.Fill;
                FindJob.Show();
            }
            else
            {
                FindJob.Activate();
            }
        }

        private void FindJob_FormClosed(object sender, FormClosedEventArgs e)
        {
            FindJob = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
