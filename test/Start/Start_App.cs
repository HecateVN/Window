using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Start;

namespace test
{
    public partial class Start_App : System.Windows.Forms.Form
    {
        login Btn_Login;
        Registration Btn_SignUp;


        public Start_App()
        {
            InitializeComponent();
        }

        private void Start_App_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Btn_Login == null)
            {
                Btn_Login = new login();
                Btn_Login.FormClosed += Login_FormClosed;
                Btn_Login.MdiParent = this;
                Btn_Login.Dock = DockStyle.Fill;
                Btn_Login.Show();
            }
            else
            {
                Btn_Login.Activate();
            }
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Btn_Login = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Btn_SignUp == null)
            {
                Btn_SignUp = new Registration();
                Btn_SignUp.FormClosed += SignUp_FormClosed;
                Btn_SignUp.MdiParent = this;
                Btn_SignUp.Dock = DockStyle.Fill;
                Btn_SignUp.Show();
            }
            else
            {
                Btn_SignUp.Activate();
            }
        }
        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Btn_SignUp = null;
        }


    }
}
