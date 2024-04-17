using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Model;

namespace test.User_Control
{
    public partial class Available_Job : UserControl
    {
        DB db;
        public Available_Job()
        {
            InitializeComponent();
            db = new DB();  
        }
        
        private Job item;
        public Job Item
        {
            get { return item;}
            set
            {
                item = value;

                this.label1.Text = item.Companyname;
                this.label2.Text = item.Location;
                this.label3.Text = item.JobPosition;
                this.label4.Text = item.Salary.ToString();
                this.label5.Text = item.JobDescription;
            }
        }

        private void Available_Job_Load(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void poisonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void aloneButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void aloneButton2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        
    }
}
