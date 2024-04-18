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
using test.User_Control;

namespace test.Employee
{
    public partial class Form_Employee_Job : System.Windows.Forms.Form
    {
        DB db;
        public Form_Employee_Job()
        {
            InitializeComponent();
            db = new DB();
        }
        int count = 0 ;
        public Color GetTheme()
        {
            if (count == 0)
            {
                count++;
                return Color.White;
            }
            else
            {
                return Color.WhiteSmoke;
            }
        }
        private async void LoadProductsAsync(int page, int pagesize)
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();

                var Jobs = await db.GetJobAsync(page, pagesize);

                await Task.Run(() =>
                {
                    for (int i = 0; i < Jobs.Count; i++)
                    {
                        Available_Job menuItemControl = new Available_Job(Jobs[i]);
                        menuItemControl.Tag = i;
                        menuItemControl.BackColor = GetTheme();

                        // avoid cross thread exception
                        this.Invoke((MethodInvoker)delegate
                        {
                            menuItemControl.Dock = DockStyle.Top;
                            flowLayoutPanel1.Controls.Add(menuItemControl);
                        });
                        //menuItemControl.Click += new EventHandler(this.MyUserControl_OnClick);
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void airButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int pagesize = 50;
                int page = 1*pagesize;

                await Task.Run(() => flowLayoutPanel1.Invoke(new Action(() => { LoadProductsAsync(page, pagesize); })));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
