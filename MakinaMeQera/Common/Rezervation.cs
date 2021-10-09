using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakinaMeQera
{
    class Rezervation
    {
        public int rezId;
        public DateTime dtFrom;
        public DateTime dtTo;
        public byte carId;
        public float totPrice;
        public string client;

        
        public static Rezervation Get(int rezId)
        {
            var rez = new Rezervation();
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbCoonectionString))
                {
                    using (var cmd = new SqlCommand("[dbo].[RentsGet]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = rezId;
                        conn.Open();
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            rez.dtFrom = (DateTime)reader["DitaFill"];
                            rez.dtTo = (DateTime)reader["DitaMbar"];
                            rez.carId = (byte)reader["CarId"];
                            rez.totPrice = (float)reader["Pagesa"];
                            rez.client = (string)reader["Klienti"];


                        }

                        conn.Close();
                    }
                }
            }
            catch
            {

            }
            return rez;
        }

        public static Rezervation Insert(Rezervation rezervation)
        {
            var newRez = new Rezervation();

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbCoonectionString))
                {
                    using (var cmd = new SqlCommand("[dbo].[RentsInsert]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@ditaFill", SqlDbType.DateTime).Value = rezervation.dtFrom;
                        cmd.Parameters.Add("@ditaMbar", SqlDbType.DateTime).Value = rezervation.dtTo;
                        cmd.Parameters.Add("@carId", SqlDbType.TinyInt).Value = rezervation.carId;
                        cmd.Parameters.Add("@pagesa", SqlDbType.Float).Value = rezervation.totPrice;
                        cmd.Parameters.Add("@klienti", SqlDbType.VarChar).Value = rezervation.client;

                        conn.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            newRez.rezId = (int)reader["Id"];
                            newRez.dtFrom = (DateTime)reader["DitaFill"];
                            newRez.dtTo = (DateTime)reader["DitaMbar"];
                            newRez.carId = (byte)reader["CarId"];
                            newRez.totPrice = (float)reader["Pagesa"];
                            newRez.client = (string)reader["Klienti"];



                        }
                        conn.Close();
                    }
                }
            }
            catch
            {

            }
            return newRez;
        }
        class RezList: List<Rezervation>
        {
            public static RezList Get()
            {
                var list = new RezList();
                try
                {
                    using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbCoonectionString))
                    {
                        using (var cmd = new SqlCommand("[dbo].[RentsGet]", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            conn.Open();
                            var reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                var rez= new Rezervation();
                                rez.rezId = (int)reader["Id"];
                                rez.dtFrom = (DateTime)reader["DitaFill"];
                                rez.dtTo = (DateTime)reader["DitaMbar"];
                                rez.carId = (byte)reader["CarId"];
                                rez.totPrice = (float)reader["Pagesa"];
                                rez.client = (string)reader["Klienti"];


                                list.Add(rez);
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
    
}
