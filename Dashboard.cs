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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Famracy
{
    public partial class Dashboard : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\C# project\Drugs.mdf"";Integrated Security=True;Connect Timeout=30");
        public Dashboard()
        {
            InitializeComponent();
            DisplayTm();
            DisplayAm();
            DisplaySm();
            displaymedicineData(); 
            //disablefields();
        }
       /* public void disablefields()
        {
            dataGridView1.Enabled = false;
        }*/
        public void displaymedicineData()
        {

            medicineData md = new medicineData();
            List<medicineData> listdata = md.medicinelistData();

            dataGridView1.DataSource = listdata;
        }
        public void DisplayTm()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                    connect.Open();

                string selectData = "SELECT COUNT(drug_id) FROM medicine WHERE delete_date IS NULL";

                using (SqlCommand checkMed = new SqlCommand(selectData, connect))
                {
                    int count = Convert.ToInt32(checkMed.ExecuteScalar());
                    dashboard_Tm.Text = count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }



        public void DisplayAm()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                    connect.Open();

                string selectData = "SELECT COUNT(drug_id) FROM medicine WHERE status='Available' AND delete_date IS NULL";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    dashboard_Am.Text = count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }



        public void DisplaySm()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                    connect.Open();

                string selectData = "SELECT COUNT(drug_id) FROM medicine WHERE status='Not Available' AND delete_date IS NULL";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    dashboard_Sm.Text = count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //accidently Clicked :)
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchkey.Text))
            {
                MessageBox.Show("Please fill all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        using (DataTable dt = new DataTable("medicine"))
                        {
                            string selectQuery = "SELECT * FROM medicine WHERE drug_name LIKE @drug_name OR indication LIKE @indication OR price LIKE @price OR status LIKE @status";

                            using (SqlCommand cmd = new SqlCommand(selectQuery, connect))
                            {
                                cmd.Parameters.AddWithValue("@drug_name", $"%{searchkey.Text}%");
                                cmd.Parameters.AddWithValue("@indication", $"%{searchkey.Text}%");
                                cmd.Parameters.AddWithValue("@price", $"%{searchkey.Text}%");
                                cmd.Parameters.AddWithValue("@status", $"%{searchkey.Text}%");

                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }


        private void searchkey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && searchkey != null)
            {
                search_Click(sender, e);
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            displaymedicineData();
        }
    }
}
