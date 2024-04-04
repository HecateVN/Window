using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test.Start
{
    public partial class login : Form
    {
        Home_User employee_menu;

        public login()
        {
            InitializeComponent();
            employee_menu = new Home_User();
        }

        private void dungeonTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            employee_menu.Show();
        }
    }
}
