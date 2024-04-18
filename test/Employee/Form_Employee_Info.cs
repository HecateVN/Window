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
using ReaLTaiizor.Controls;
using test.Model;

namespace test
{
    public partial class Form_Employee_Info : System.Windows.Forms.Form
    {
        public Form_Employee_Info()
        {
            InitializeComponent();
            SetTextBoxesReadOnly(true);
        }

        private void Form_User_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void SetTextBoxesReadOnly(bool readOnly)
        {
            dungeonTextBox2.ReadOnly = readOnly;
            dungeonTextBox3.ReadOnly = readOnly;
            dungeonTextBox4.ReadOnly = readOnly;
            dungeonTextBox1.ReadOnly = readOnly;
            dungeonRichTextBox1.ReadOnly = readOnly;
            dungeonRichTextBox2.ReadOnly = readOnly;
            dungeonRichTextBox3.ReadOnly = readOnly;
            dungeonRichTextBox4.ReadOnly = readOnly;
            dungeonRichTextBox5.ReadOnly = readOnly;
            dungeonRichTextBox6.ReadOnly = readOnly;
            dungeonRichTextBox7.ReadOnly = readOnly;

        }
        private void parrotPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dungeonLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dungeonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dungeonRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Edit") 
            {
                SetTextBoxesReadOnly(false);
                button2.Text = "Save";
            }
            else
            {
                DB mydb = new DB();
                try
                {
                    mydb.openConnection();
                    string query = @"INSERT INTO Emloyeesinfo (Experience, TechnicalSkills, InterestsAndHobbies, Education,
                    CoursesAndCertifications,WorkExperience, CareerObjective)  VALUES ( @Experience, @TechnicalSkills,
                    @InterestsAndHobbies, @Education, @CoursesAndCertifications, @WorkExperience, @CareerObjective)";
                    using (SqlCommand cmd = new SqlCommand(query, mydb.getConnection))
                    {
                        //cmd.Parameters.AddWithValue("@FirstName", dungeonTextBox2.Text);
                        //cmd.Parameters.AddWithValue("@LastName", dungeonTextBox3.Text);
                        //cmd.Parameters.AddWithValue("@Email", dungeonTextBox4.Text);
                        cmd.Parameters.AddWithValue("@Experience", dungeonTextBox1.Text);
                        cmd.Parameters.AddWithValue("@TechnicalSkills", dungeonRichTextBox1.Text);
                        cmd.Parameters.AddWithValue("@InterestsAndHobbies", dungeonRichTextBox2.Text);
                        //cmd.Parameters.AddWithValue("@References", dungeonRichTextBox3.Text);
                        cmd.Parameters.AddWithValue("@Education", dungeonRichTextBox4.Text);
                        cmd.Parameters.AddWithValue("@CoursesAndCertifications", dungeonRichTextBox5.Text);
                        cmd.Parameters.AddWithValue("@WorkExperience", dungeonRichTextBox6.Text);
                        cmd.Parameters.AddWithValue("@CareerObjective", dungeonRichTextBox7.Text);
                        cmd.ExecuteNonQuery();

                    }

                    MessageBox.Show("Information saved successfully.");
                    button2.Text = "Edit";
                    SetTextBoxesReadOnly(true);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }    
            
        }
    }
}
