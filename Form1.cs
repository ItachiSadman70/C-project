using Famracy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\C# project\grugs.mdf"";Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm regform = new RegisterForm();
            regform.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fill the all information ", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (connect.State  == ConnectionState.Closed) {
                    try
                    {
                        connect.Open();
                        string selectData = "select * from users where username = @username " +
                            "and password = @password";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect)) {
                            cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1) {
                                MessageBox.Show("Login Successfully",
                                    "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               
                                MainForm mForm = new MainForm();
                                mForm.Show();
                                this.Hide();

                            }
                            else {
                                MessageBox.Show("Incorrect Username/Password",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                                                   
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error : " + ex, "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {

                        connect.Close();
                    }
                }
              
            
            }
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }
    }
}
