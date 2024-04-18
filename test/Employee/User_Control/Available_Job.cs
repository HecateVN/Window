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

        public Available_Job(Job item)
        {
            InitializeComponent();
            db = new DB();
            this.Item = item;
        }

        private Job item;
        public Job Item
        {
            get { return item; }
            set
            {
                item = value;

                this.label1.Text = item.Companyname;
                this.label2.Text = item.Location;
                this.label3.Text = item.JobPosition;
                this.label4.Text = item.Salary;
                this.label5.Text = item.JobDescription;
            }
        }

        private void AddEvent()
        {

        }

        private void Available_Job_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
