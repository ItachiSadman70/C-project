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
using System.Linq.Expressions;
using System.IO;

namespace Famracy
{
    public partial class AddMedicine : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\C# project\Drugs.mdf"";Integrated Security=True;Connect Timeout=30");

        public AddMedicine()
        {
            InitializeComponent();
            displaymedicineData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void displaymedicineData() { 
        
            medicineData md = new medicineData();
            List<medicineData> listdata = md.medicinelistData();

            dataGridView1.DataSource = listdata;
        }

        private void addMed_addBtn_Click(object sender, EventArgs e)
        {
            if (addMed_id.Text == "" || addMed_name.Text == "" || addMed_gener.Text == "" || addMed_Indication.Text == ""
                || addMed_price.Text == "" || addMed_status.Text == "" || addMed_pic.Image == null)
            {
                MessageBox.Show("Please fill the all fileds", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkmdid = "SELECT COUNT(*) FROM medicine WHERE drug_id = @mdid AND delete_date IS NULL";
                        using (SqlCommand checkMed = new SqlCommand(checkmdid, connect)) 
                        {
                            checkMed.Parameters.AddWithValue("@mdid", addMed_id.Text.Trim());
                            int count = (int)checkMed.ExecuteScalar();
                            if (count >= 1)
                            {
                                MessageBox.Show(addMed_id.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertdata = "INSERT INTO medicine " +
                                    "(drug_id,drug_name,generic,indication,price," +
                                    "image,insert_date,status)" +
                                    "VALUES (@drug_id,@drug_name,@gener,@indication,@price, " +
                                    "@image,@insert_date,@status) ";

                                string path = Path.Combine(@"F:\Level 2 Semester 2\C# project\EmployeeManagementSystem\EmployeeManagementSystem\Directory\"
                                                          + addMed_id.Text.Trim() + " .jpg ");
                                string directorypath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directorypath))
                                { 
                                    Directory.CreateDirectory(directorypath);

                                }

                                File.Copy(addMed_pic.ImageLocation, path ,true);

                                using (SqlCommand cmd = new SqlCommand(insertdata, connect))
                                {
                                    cmd.Parameters.AddWithValue("@drug_id", addMed_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@drug_name", addMed_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gener", addMed_gener.Text.Trim());
                                    cmd.Parameters.AddWithValue("@indication", addMed_Indication.Text.Trim());
                                    cmd.Parameters.AddWithValue("@price", addMed_price.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@insert_date", today);
                                    cmd.Parameters.AddWithValue("@status", addMed_status.Text.Trim());

                                    cmd.ExecuteNonQuery();
                                    displaymedicineData();
                                    MessageBox.Show("Added Succesfully " , "Information Message" , MessageBoxButtons.OK ,MessageBoxIcon.Information);
                                    clearFields();
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error : "+ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {

                        connect.Close();
                    
                    } 
                    

                }
            
            }
        }

        private void addMed_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addMed_pic.ImageLocation = imagePath;

                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error: "+ex, "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                addMed_id.Text = row.Cells[0].Value.ToString();
                addMed_name.Text = row.Cells[1].Value.ToString();
                addMed_gener.Text = row.Cells[2].Value.ToString();
                addMed_Indication.Text = row.Cells[3].Value.ToString();
                addMed_price.Text = row.Cells[4].Value.ToString();

                string imagePath = row.Cells[5].Value.ToString();
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    addMed_pic.Image = Image.FromFile(imagePath);
                }
                else
                {
                    addMed_pic.Image = null;
                }

                addMed_status.Text = row.Cells[7].Value.ToString();

            }
        }

        public void clearFields() 
        {
            addMed_id.Text = "";
            addMed_name.Text = "";
            addMed_gener.SelectedIndex = -1;
            addMed_Indication.Text = "";
            addMed_price.Text = "";
            addMed_status.SelectedIndex = -1;
            addMed_pic.Image = null;
        }
        private void addMed_updateBtn_Click(object sender, EventArgs e)
        {
            if (addMed_id.Text == "" || addMed_name.Text == "" || addMed_gener.Text == "" || addMed_Indication.Text == ""
               || addMed_price.Text == "" || addMed_status.Text == "" || addMed_pic.Image == null)
            {
                MessageBox.Show("Please fill the all fileds", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure want to update " +
                    "Medicine Id : " + addMed_id.Text.Trim() + "?", "Confirmation Message",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;
                        string updateData = "UPDATE medicine SET drug_name=@drug_name,generic=@gener,indication=@indication,price=@price,upate_date=@upate_date,status=@status " +
                            "WHERE drug_id = @drug_id ";
                        using (SqlCommand cmd = new SqlCommand(updateData, connect)) 
                        {
                            
                            cmd.Parameters.AddWithValue("@drug_name", addMed_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@gener", addMed_gener.Text.Trim());
                            cmd.Parameters.AddWithValue("@indication", addMed_Indication.Text.Trim());
                            cmd.Parameters.AddWithValue("@price", addMed_price.Text.Trim());
                            cmd.Parameters.AddWithValue("@upate_date", today);
                            cmd.Parameters.AddWithValue("@status", addMed_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@drug_id", addMed_id.Text.Trim());

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
                else 
                {
                    MessageBox.Show("Cancelled. ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            }

        private void addMed_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addMed_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addMed_id.Text == "" || addMed_name.Text == "" || addMed_gener.Text == "" || addMed_Indication.Text == ""
               || addMed_price.Text == "" || addMed_status.Text == "" || addMed_pic.Image == null)
            {
                MessageBox.Show("Please fill the all fileds", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure want to Delete " +
                    "Medicine Id : " + addMed_id.Text.Trim() + "?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;
                        string updateData = "UPDATE medicine SET delete_date=@delete_date " +
                            "WHERE drug_id = @drug_id ";
                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {

                            cmd.Parameters.AddWithValue("@delete_date", today);
                            cmd.Parameters.AddWithValue("@drug_id", addMed_id.Text.Trim());

                            cmd.ExecuteNonQuery();
                            displaymedicineData();
                            MessageBox.Show("Deleted Succesfully ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    MessageBox.Show("Cancelled. ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
