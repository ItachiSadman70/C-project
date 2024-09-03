using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Famracy
{
    internal class pricedata
    {


        public string drug_id { set; get; } //0
        public string drug_name { set; get; } //1
        public string indication { set; get; } //2
        public string price { set; get; } //3




        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\C# project\Drugs.mdf"";Integrated Security=True;Connect Timeout=30");


        public List<pricedata> pricemedicinelistData()
        {
            List<pricedata> listdata = new List<pricedata>();

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
                            pricedata pd = new pricedata();
                            pd.drug_id = reader["drug_id"].ToString();
                            pd.drug_name = reader["drug_name"].ToString();
                            pd.indication = reader["indication"].ToString();
                            pd.price = reader["price"].ToString();

                            listdata.Add(pd);
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
