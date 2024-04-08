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
using test.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ReaLTaiizor.Controls;
namespace test.Start
{
    public partial class login : Form
    {
        private bool isEmployeeChecked = false;
        private bool isEmployerChecked = false;
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
            DB mydb = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string username = dungeonTextBox1.Text;
            string password = dungeonTextBox2.Text;
            try
            {
                if (!isEmployeeChecked && !isEmployerChecked)
                {
                    MessageBox.Show("Vui lòng chọn loại tài khoản (Employee hoặc Employer).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra các trường bắt buộc
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (isEmployeeChecked)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Employees WHERE Username = @User AND Password = @Pass", mydb.getConnection);
                    command.CommandTimeout = 120;
                    command.Parameters.Add("@User", SqlDbType.VarChar).Value = dungeonTextBox1.Text;
                    command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = dungeonTextBox2.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {

                        string storedPassword = table.Rows[0]["Password"].ToString();

                        if (storedPassword == dungeonTextBox2.Text)
                        {
                            // Lấy giá trị ID từ bảng table
                            string userID = table.Rows[0]["EmployeeID"].ToString();
                            // Gán giá trị ID vào biến userID trong class Global
                            string usernames = table.Rows[0]["Username"].ToString();
                            // Mở ứng dụng nếu đúng username và pass
                            this.Hide();
                            employee_menu.Show();
                        }
                        else
                        {

                        }
                    }

                }
                if (isEmployerChecked)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Employer WHERE Username = @User AND Password = @Pass", mydb.getConnection);
                    command.CommandTimeout = 120;
                    command.Parameters.Add("@User", SqlDbType.VarChar).Value = dungeonTextBox1.Text;
                    command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = dungeonTextBox2.Text;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        string storedPassword = table.Rows[0]["Password"].ToString();
                        if (storedPassword == dungeonTextBox2.Text)
                        {
                            string userID = table.Rows[0]["EmployeeID"].ToString();
                            string usernames = table.Rows[0]["Username"].ToString();
                            this.Hide();
                            employee_menu.Show();
                        }
                        else
                        {

                        }
                    }
                }

                else
                {
                  
                }
            }
            catch
            {
                
            }
            this.Close();
        }
        private void dungeonLabel1_Click(object sender, EventArgs e)
        {

        }
        private void airRadioButton1_CheckedChanged(object sender)
        {
            isEmployeeChecked = airRadioButton1.Checked;
        }

        private void airRadioButton2_CheckedChanged(object sender)
        {
            isEmployerChecked = airRadioButton2.Checked;
        }
        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
