using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Famracy;
using System.Runtime.Remoting.Contexts;

namespace PharmacyManagementSystem
{
    internal class salesData
    {
        //public string customer_name { set; get; } 
        public string customer_medname { set; get; }
        public string customer_quantity { set; get; } 
        public string customer_price { set; get; }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\C# project\PharmacyManagementSystem\PharmacyManagementSystem\customer&sales.mdf"";Integrated Security=True;Connect Timeout=30");

        public List<salesData> saleslistData()
        {
            List<salesData> listdata = new List<salesData>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string selectData = " SELECT * FROM sales WHERE customer_name = customer_name ";

                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            salesData sd = new salesData();
                            sd.customer_medname = reader["customer_medname"].ToString();
                            sd.customer_quantity = reader["customer_quantity"].ToString();
                            sd.customer_price = reader["customer_price"].ToString();

                            listdata.Add(sd);
                        }
                    }


                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error : " + ex);

                }
                finally
                {

                    con.Close();

                }
            }

            return listdata;
        }
    }
}
