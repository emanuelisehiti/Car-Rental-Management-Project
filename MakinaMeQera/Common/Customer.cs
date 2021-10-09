using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakinaMeQera
{
    class Customer
    {
        public int customerId;

        public string client;
        public string adress;
        public string tel;
        public string id;
   

        public static Customer currentCustomer;

        public static Customer Get(int custId)
        {
            var cust = new Customer();
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbCoonectionString))
                {
                    using (var cmd = new SqlCommand("[dbo].[CustomerGet]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = custId;
                        conn.Open();
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            cust.customerId= (int)reader["Id"];
                            cust.client = (string)reader["Klienti"];

                            cust.adress = (string)reader["Adresa"];
                            cust.tel = (string)reader["Tel"];
                            cust.id = (string)reader["Nid"];
                          
                            
                        }

                        conn.Close();
                    }
                }
            }
            catch
            {

            }
            return cust;
        }
        public static Customer Insert(Customer customer)
        {
            var newCust = new Customer();

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbCoonectionString))
                {
                    using (var cmd = new SqlCommand("[dbo].[CustomerInsert]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@emriKlientit", SqlDbType.VarChar).Value = customer.client;
                        cmd.Parameters.Add("@adresa", SqlDbType.VarChar).Value = customer.adress;
                        cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = customer.tel;
                        cmd.Parameters.Add("@nid", SqlDbType.VarChar).Value = customer.id;
                     
                        conn.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            newCust.customerId = (int)reader["Id"];
                            newCust.client = (string)reader["Klienti"];
                            newCust.adress = (string)reader["Adresa"];
                            newCust.tel = (string)reader["Tel"];
                            newCust.id = (string)reader["Nid"];
                           


                        }
                        conn.Close();
                    }
                }
            }
            catch
            {

            }
            return newCust;
        }


    }

     class CustList : List<Customer>
    {
        public static CustList Get()
        {
            var list = new CustList();
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbCoonectionString))
                {
                    using (var cmd = new SqlCommand("[dbo].[CustomerGet]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            var cust = new Customer();
                            cust.customerId = (int)reader["Id"];
                            cust.client = (string)reader["Klienti"];

                            cust.adress = (string)reader["Adresa"];
                            cust.tel = (string)reader["Tel"];
                            cust.id = (string)reader["Nid"];
                            

                            list.Add(cust);
                        }

                        conn.Close();
                    }
                }
            }
            catch
            {

            }
            return list;
        }
    }
}
