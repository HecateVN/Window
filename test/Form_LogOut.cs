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
    public partial class Form_LogOut : Form
    {
        public Form_LogOut()
        {
            InitializeComponent();
        }

        private void Form_LogOut_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
