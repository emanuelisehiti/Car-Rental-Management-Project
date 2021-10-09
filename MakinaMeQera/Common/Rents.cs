using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakinaMeQera
{
    class Rents
    {
        public int id;
        public DateTime dtFrom;
        public DateTime dtTo;
        public string brand;
        public string model;
        public string engine;
        public double totPrice;
        public string client;

        public static Rents Get(int Id)
        {
            var rents = new Rents();
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbCoonectionString))
                {
                    using (var cmd = new SqlCommand("[dbo].[RentsGetAll]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                        conn.Open();
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            rents.dtFrom = (DateTime)reader["DitaFill"];
                            rents.dtTo = (DateTime)reader["DitaMbar"];
                            rents.brand = (string)reader["Marka"];
                            rents.model = (string)reader["Modeli"];
                            rents.engine = (string)reader["Motorri"];
                            rents.totPrice = (float)reader["Pagesa"];
                            rents.client = (string)reader["Klienti"];


                        }

                        conn.Close();
                    }
                }
            }
            catch
            {

            }
            return rents;
        }
    }
    class RentsList : List<Rents>
    {
        public static RentsList Get()
        {
            var list = new RentsList();
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbCoonectionString))
                {
                    using (var cmd = new SqlCommand("[dbo].[RentsGetAll]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            var rents = new Rents();

                            rents.id = (int)reader["Id"];
                            rents.dtFrom = (DateTime)reader["DitaFill"];
                            rents.dtTo = (DateTime)reader["DitaMbar"];
                            rents.brand = (string)reader["Marka"];
                            rents.model = (string)reader["Modeli"];
                            rents.engine = (string)reader["Motorri"];
                            rents.totPrice = (double)reader["Pagesa"];
                            rents.client = (string)reader["Klienti"];


                            list.Add(rents);
                        }

                        conn.Close();
                    }
                }
            }
            catch (Exception myex)
            {

            }
            return list;
        }
    }

}
