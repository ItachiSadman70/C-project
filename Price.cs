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
    public partial class Price : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\C# project\Drugs.mdf"";Integrated Security=True;Connect Timeout=30");
        public Price()
        {
            InitializeComponent();
            displaymedicineData();
            disablefields();
        }
        public void disablefields() 
        {
            price_drug_id.Enabled = false;
            price_drug_name.Enabled = false;
        }
        public void displaymedicineData()
        {

            pricedata md = new pricedata();
            List<pricedata> listdata = md.pricemedicinelistData();

            dataGridView1.DataSource = listdata;
        }

        private void price_update_Click(object sender, EventArgs e)
        {
            if (price_drug_id.Text == "" || price_drug_name.Text == "" || price_drug_indication.Text == ""
                || price_drug_price.Text == "")
            {
                MessageBox.Show("Please fill the all fileds", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                DialogResult check = MessageBox.Show("Are you sure want to update " +
                   "Medicine Name : " + price_drug_name.Text.Trim() + "?", "Confirmation Message",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed) 
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE medicine SET indication=@indication,price=@price,upate_date=@upate_date " +
                            "WHERE drug_id = @drug_id ";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {

                                cmd.Parameters.AddWithValue("@indication", price_drug_indication.Text.Trim());
                                cmd.Parameters.AddWithValue("@price", price_drug_price.Text.Trim());
                                cmd.Parameters.AddWithValue("@upate_date", today);
                                cmd.Parameters.AddWithValue("@drug_id", price_drug_id.Text.Trim());

                                cmd.ExecuteNonQuery();
                                displaymedicineData();
                                MessageBox.Show("Update Succesfully ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally 
                        {
                            connect.Close();
                        
                        }

                    }


                }
                else 
                {
                    MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }
        public void clearFields()
        {
            price_drug_id.Text = "";
            price_drug_name.Text = "";
            price_drug_indication.Text = "";
            price_drug_price.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                price_drug_id.Text = row.Cells[0].Value.ToString();
                price_drug_name.Text = row.Cells[1].Value.ToString();
                price_drug_indication.Text = row.Cells[2].Value.ToString();
                price_drug_price.Text = row.Cells[3].Value.ToString();

            }
        }

        private void price_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
