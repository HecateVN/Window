using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Home_User : Form
    {
        Form_HomePage HomePage;
        Form_LogOut LogOut;
        Form_User UserInfo;
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

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        bool Sub_con_Expand = false;
        private void Sub_Con_Transition_Tick(object sender, EventArgs e)
        {
            if (Sub_con_Expand == false)
            {
                SubContainer.Height += 10;
                if (SubContainer.Height >= 141)
                {
                    Sub_Con_Transition.Stop();
                    Sub_con_Expand = true;
                }
            }
            else
            {
                SubContainer.Height -= 10;
                if (SubContainer.Height <= 47)
                {
                    Sub_Con_Transition.Stop();
                    Sub_con_Expand = false;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sub_Con_Transition.Start();
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


        private void Btn_HomePage_Click(object sender, EventArgs e)
        {
            if (HomePage == null)
            {
                HomePage = new Form_HomePage();
                HomePage.FormClosed += HomePage_FormClosed;
                HomePage.MdiParent = this;
                HomePage.Show();
            }
            else
            {
                HomePage.Activate();
            }
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserInfo == null)
            {
                UserInfo = new Form_User();
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


    }
}
