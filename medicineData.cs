using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Famracy
{
    internal class medicineData
    {
        private int id;

        public string drug_id { set; get; } //1
        public string drug_name { set; get; } //2
        public string gener { set; get; } //3
        public string indication { set; get; } //4
        public string price { set; get; } //5
        public string image { set; get; } //6
        public string insert_date { set; get; } //7
        public string status { set; get; } //8





        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\C# project\Drugs.mdf"";Integrated Security=True;Connect Timeout=30");

        public List<medicineData> medicinelistData()
        { 
            List<medicineData> listdata = new List<medicineData>();

            if (connect.State != ConnectionState.Open)
            {
                try 
                { 
                    connect.Open();
                    string selectData = " SELECT * FROM medicine WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData,connect)) { 
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read()) { 
                            medicineData md = new medicineData();
                            md.id = (int)reader["id"];
                            md.drug_id = reader["drug_id"].ToString();
                            md.drug_name = reader["drug_name"].ToString();
                            md.gener = reader["generic"].ToString();
                            md.indication = reader["indication"].ToString();
                            md.price = reader["price"].ToString();
                            md.image = reader["image"].ToString();
                            md.insert_date = reader["insert_date"].ToString();
                            md.status= reader["status"].ToString();

                            listdata.Add(md);
                        }
                    }
                
                }catch (Exception ex)
                {

                    Console.WriteLine("Error : "+ex);

                }finally 
                {
                
                connect.Close();

                }
            }

            return listdata;
        }

        public List<medicineData> pricemedicinelistData()
        {
            List<medicineData> listdata = new List<medicineData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = " SELECT * FROM medicine WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            medicineData md = new medicineData();
                            md.drug_id = reader["drug_id"].ToString();
                            md.drug_name = reader["drug_name"].ToString();
                            md.indication = reader["indication"].ToString();
                            md.price = reader["price"].ToString();

                            listdata.Add(md);
                        }
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error : " + ex);

                }
                finally
                {

                    connect.Close();

                }
            }

            return listdata;
        }
    }
}
