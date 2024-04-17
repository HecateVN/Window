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
using System.Data.SqlClient;
using ReaLTaiizor.Controls;

namespace test.Start
{
    public partial class Registration : Form
    {
        private bool isEmployeeChecked = false;
        private bool isEmployerChecked = false;
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB mydb = new DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string username = dungeonTextBox1.Text;
            string email = dungeonTextBox3.Text;
            string password = dungeonTextBox4.Text;
            string gender = aloneComboBox1.SelectedItem.ToString();


            // Kiểm tra xem người dùng đã chọn loại tài khoản nào
            if (!isEmployeeChecked && !isEmployerChecked)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản (Employee hoặc Employer).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thực hiện đăng ký tài khoản
            if (isEmployeeChecked)
            {
                SqlCommand command = new SqlCommand("INSERT INTO Employees (Username, Email, Password, Gender) VALUES (@Username, @Email, @Password, @Gender)", mydb.getConnection);
                command.CommandTimeout = 120;
                command.Parameters.Add("@Username", SqlDbType.VarChar).Value = dungeonTextBox1.Text;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = dungeonTextBox4.Text;
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = dungeonTextBox3.Text;
                command.Parameters.Add("@Gender", SqlDbType.VarChar).Value = aloneComboBox1.SelectedItem.ToString();
                adapter.SelectCommand = command;
                adapter.Fill(table);

            }

            if (isEmployerChecked)
            {
                SqlCommand command = new SqlCommand("INSERT INTO Employer (Username, Email, Password, Gender) VALUES (@Username, @Email, @Password, @Gender)", mydb.getConnection);
                command.CommandTimeout = 120;
                command.Parameters.Add("@Username", SqlDbType.VarChar).Value = dungeonTextBox1.Text;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = dungeonTextBox4.Text;
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = dungeonTextBox3.Text;
                command.Parameters.Add("@Gender", SqlDbType.VarChar).Value = aloneComboBox1.SelectedItem.ToString();
                adapter.SelectCommand = command;
                adapter.Fill(table);
            }

            // Hiển thị thông báo thành công
            MessageBox.Show("Đăng ký tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa dữ liệu sau khi đăng ký
            ResetForm();
        }

        private void airRadioButton1_CheckedChanged(object sender)
        {
            isEmployeeChecked = airRadioButton1.Checked;
        }

        private void airRadioButton2_CheckedChanged(object sender)
        {
            isEmployerChecked = airRadioButton2.Checked;
        }
        private void ResetForm()
        {
            dungeonTextBox1.Text = "";
            dungeonTextBox3.Text = "";
            dungeonTextBox4.Text = "";
            aloneComboBox1.SelectedIndex = -1;

        }

        private void dungeonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
