using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.IO;
using System.Diagnostics.Contracts;
using System.Xml.Linq;
using System.Net.NetworkInformation;
using Famracy;
using System.Drawing.Printing;

namespace PharmacyManagementSystem
{
    public partial class sales : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\C# project\Drugs.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\C# project\PharmacyManagementSystem\PharmacyManagementSystem\customer&sales.mdf"";Integrated Security=True;Connect Timeout=30");

        public sales()
        {
            InitializeComponent();
            FillCombo();
            DisplayName();
            clearallFields();
        }
        public void invoice_number()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                string selectData = "select count(id) from customer ";

                using (SqlCommand checkMed = new SqlCommand(selectData, con))
                {
                    int count = Convert.ToInt32(checkMed.ExecuteScalar());
                    customer_invoice_number.Text = count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        public void displaysalesData()
        {

            salesData md = new salesData();
            List<salesData> listdata = md.saleslistData();

            dataGridView1.DataSource = listdata;
        }
        public void DisplayName()
        {
            try
            {
                con.Open();

                string selectData = "SELECT customer_name FROM customer";
                using (SqlCommand cmd = new SqlCommand(selectData, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string c_name = reader.GetString(reader.GetOrdinal("customer_name"));
                        invoice_cutomername.Text = c_name;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                    con.Close();
            }
            DateTime today = DateTime.Today;
            invoice_date.Text = today.ToString("yyyy-MM-dd");

        }


        void FillCombo()
        {
            try
            {
                connect.Open();

                string selectData = "SELECT * FROM medicine WHERE delete_date IS NULL";

                using (SqlCommand checkMed = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = checkMed.ExecuteReader();
                    while (reader.Read())
                    {
                        string m_name = reader.GetString(reader.GetOrdinal("drug_name"));
                        customer_medname.Items.Add(m_name);
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


        private void sales_Load(object sender, EventArgs e)
        {
            //accidently clicked
        }
        public void clearFields1()
        {
            customer_name.Text = "";
            contact.Text = "";
        }
        public void clearFields2()
        {
            customer_medname.Text = "";
            customer_quantity.Text = "";
        }
        public void clearallFields()
        {
            customer_name.Text = "";
            contact.Text = "";
            customer_medname.Text = "";
            customer_quantity.Text = "";
            invoice_cutomername.Text = "";
            invoice_date.Text = "";
            cutomer_paid.Text = "";
            paid.Text = "";
            back.Text = "";
            totalprice.Text = "";
            customer_invoice_number.Text = "";
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            try 
            {
                con.Open();
                string clear = "DELETE FROM sales;";
                using (SqlCommand clearCommand = new SqlCommand(clear, con))
                {
                    clearCommand.ExecuteNonQuery();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                con.Close();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearFields1();
        }

        private void cutomer_clear_Click(object sender, EventArgs e)
        {
            clearFields2();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            try
            {
                con.Open();
                string clear = "DELETE FROM sales;";
                using (SqlCommand clearCommand = new SqlCommand(clear, con))
                {
                    clearCommand.ExecuteNonQuery();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                con.Close();

            }
        }
        public void disablefields()
        {
            customer_name.Enabled = false;
            contact.Enabled = false;
        }
        public void enablefields()
        {
            customer_name.Enabled = true;
            contact.Enabled = true;
        }

        private void cutomer_select1_Click(object sender, EventArgs e)
        {
            if (customer_name.Text == "" || contact.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    string insertData = "INSERT INTO customer " +
                                        " (customer_name, contact) " +
                                        "VALUES (@customer_name, @contact)";
                    using (SqlCommand cmd = new SqlCommand(insertData, con))
                    {
                        cmd.Parameters.AddWithValue("@customer_name", customer_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@contact", contact.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }

               disablefields();
               DisplayName();
               invoice_number();
            }
        }



        private void clearall_Click(object sender, EventArgs e)
        {
            clearallFields();
            enablefields();
        }

        private void customer_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cutomer_select1_Click(sender, e);
            }
        }

        private void contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cutomer_select1_Click(sender, e);
            }
        }

        private void cutomer_select_Click(object sender, EventArgs e)
        {
            if (customer_medname.Text == "" || customer_quantity.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    connect.Open();

                    string selectData = "SELECT customer_name FROM customer";
                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string c_name = reader.GetString(reader.GetOrdinal("customer_name"));
                            reader.Close();

                            string priceDataQuery = "SELECT price FROM medicine WHERE drug_name = @customer_medname";
                            using (SqlCommand priceCmd = new SqlCommand(priceDataQuery, connect))
                            {
                                priceCmd.Parameters.AddWithValue("@customer_medname", customer_medname.Text.Trim());

                                SqlDataReader priceReader = priceCmd.ExecuteReader();

                                if (priceReader.Read())
                                {
                                    string c_price = priceReader.GetString(priceReader.GetOrdinal("price"));
                                    priceReader.Close();
                                    string insertData = "INSERT INTO sales " +
                                                        "(customer_name, customer_medname, customer_quantity, customer_price) " +
                                                        "VALUES (@customer_name, @customer_medname, @customer_quantity, @customer_price)";

                                    using (SqlCommand insertCmd = new SqlCommand(insertData, con))
                                    {
                                        insertCmd.Parameters.AddWithValue("@customer_name", c_name);
                                        insertCmd.Parameters.AddWithValue("@customer_medname", customer_medname.Text.Trim());
                                        if (int.TryParse(customer_quantity.Text, out int quantity))
                                        {
                                            insertCmd.Parameters.AddWithValue("@customer_quantity", quantity);
                                            if (decimal.TryParse(c_price, out decimal price))
                                            {
                                                decimal result = quantity * price;
                                                string resultStr = result.ToString();

                                                insertCmd.Parameters.AddWithValue("@customer_price", resultStr);
                                                insertCmd.ExecuteNonQuery();
                                                
                                                
                                                clearFields2();

                                                displaysalesData();
                                               
                                            }
                                            else
                                            {
                                               
                                            }
                                        }
                                        else
                                        {
                                           
                                        }
                                    }
                                    

                                }
                            }
                        }
                    }
                    string countprice = "SELECT SUM(CAST(customer_price AS DECIMAL(6,2))) AS total_sum FROM sales;";

                    using (SqlCommand tot = new SqlCommand(countprice, con))
                    {
                        object resultprice = tot.ExecuteScalar();
                        if (resultprice != DBNull.Value)
                        {
                            totalprice.Text = resultprice.ToString();
                        }
                        else
                        {
                            totalprice.Text = "0";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                    connect.Close();
                }

            }
            
        }

        private void customer_confirm_Click(object sender, EventArgs e)
        {
            if ( cutomer_paid.Text == "")
            {
                MessageBox.Show("Please fill the all fileds", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                paid.Text = cutomer_paid.Text;
                decimal total = decimal.Parse(totalprice.Text);
                decimal paidAmount = decimal.Parse(paid.Text);
                back.Text = ( paidAmount - total).ToString();
            }
        }

        private void cutomer_paid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                customer_confirm_Click(sender, e);
            }
        }

        private void customer_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cutomer_select_Click(sender, e);
            }
        }

        private void customer_print_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPage);
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap originalBmp = new Bitmap(print_panel.Width, print_panel.Height);
            print_panel.DrawToBitmap(originalBmp, new Rectangle(0, 0, print_panel.Width, print_panel.Height));
            int desiredWidth = 467;
            int desiredHeight = 533;
            Bitmap resizedBmp = new Bitmap(desiredWidth, desiredHeight);
            using (Graphics g = Graphics.FromImage(resizedBmp))
            {
                g.DrawImage(originalBmp, new Rectangle(0, 0, desiredWidth, desiredHeight));
            }
            e.Graphics.DrawImage(resizedBmp, e.PageBounds);
            originalBmp.Dispose();
            resizedBmp.Dispose();

        }
    }
}
