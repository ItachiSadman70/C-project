using EmployeeManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Famracy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainform_logout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure want to logout ?",
                "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes) {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
            
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addMedicine1.Visible = false;
            price1.Visible = false;
            sales1.Visible = false;
        }

        private void addMed_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addMedicine1.Visible = true;
            price1.Visible = false;
            sales1.Visible = false;
        }

        private void price_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addMedicine1.Visible = false;
            price1.Visible = true;
            sales1.Visible = false;
        }

        private void salesbtn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addMedicine1.Visible = false;
            price1.Visible = false;
            sales1.Visible = true;
        }
    }
}
