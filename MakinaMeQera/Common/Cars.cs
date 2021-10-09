using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System;

namespace MakinaMeQera
{
    
        public class Car
        {
          
            public byte id;
            public string model;
            public string brand;
            public string engine;
            public int price;

        
           

            public static Car Get(int id)
            {
                var car = new Car();
                try
                {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbCoonectionString))
                {
                        using (var cmd = new SqlCommand("[dbo].[CarsGet]", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@carId", SqlDbType.Int).Value = id;

                            conn.Open();
                            var reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                car.id = (byte)reader["carId"];
                                car.model = (string)reader["Modeli"];
                                car.brand = (string)reader["Marka"];
                                car.engine = (string)reader["Motorri"];
                                car.price= (int)reader["Cmimi"];
                               
                            }

                            conn.Close();
                        }
                    }
                }
                catch
                {

                }
                return car;
            }
 

        internal static Car Insert(Car car)
            {
                var car1 = new Car();
                try
                {
                    using (var conn = new SqlConnection(Properties.Settings.Default.dbCoonectionString))
                    {
                        using (var cmd = new SqlCommand("[dbo].[CarsInsert]", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@model", SqlDbType.VarChar).Value = car.model;
                            cmd.Parameters.Add("@brand", SqlDbType.VarChar).Value = car.brand;
                            cmd.Parameters.Add("@motorri", SqlDbType.VarChar).Value = car.engine;
                            cmd.Parameters.Add("@price", SqlDbType.Int).Value = car.price;
                           
                            conn.Open();
                            var reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                car1.id = (byte)reader["carId"];
                                car1.model = (string)reader["Modeli"];
                                car1.brand = (string)reader["Marka"];
                                car1.engine = (string)reader["Motorri"];
                                car1.price= (int)reader["Cmimi"];
                                
                            }

                            conn.Close();
                        }
                    }
                }
                catch
                {

                }
                return car1;
            }
        public static Car Delete(byte carId)
        {
            var car = new Car();
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbCoonectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[CarsDelete]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Id", SqlDbType.TinyInt).Value = carId;
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            car.id = (byte)reader["carId"];
                            car.model = (string)reader["Modeli"];
                            car.brand = (string)reader["Marka"];
                            car.engine = (string)reader["Motorri"];
                            car.price = (int)reader["Cmimi"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
            }

            return car;
        }


        internal static Car Update(Car car)
        {
            var res = new Car();
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbCoonectionString))
                {
                    using (var cmd = new SqlCommand("[dbo].[CarsUpdate]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@carId", SqlDbType.Int).Value = car.id;
                        cmd.Parameters.Add("@model", SqlDbType.VarChar).Value = car.model;
                        cmd.Parameters.Add("@brand", SqlDbType.VarChar).Value = car.brand;
                        cmd.Parameters.Add("@motorri", SqlDbType.VarChar).Value = car.engine;
                        cmd.Parameters.Add("@price", SqlDbType.Int).Value = car.price;

                        conn.Open();
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            res.id = (byte)reader["carId"];
                            res.model = (string)reader["Modeli"];
                            res.brand = (string)reader["Marka"];
                            res.engine = (string)reader["Motorri"];
                            res.price = (int)reader["Cmimi"];

                        }

                        conn.Close();
                    }
                }
            }
            catch
            {

            }
            return res;
        }


        }

        public class CarsList : List<Car>
        {
            public static CarsList Get()
            {
                var list = new CarsList();
                try
                {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbCoonectionString))
                {
                        using (var cmd = new SqlCommand("[dbo].[CarsGet]", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            conn.Open();
                            var reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                var car = new Car();
                                car.id = (byte)reader["carId"];
                                car.model = (string)reader["Modeli"];
                                car.brand = (string)reader["Marka"];
                                car.engine = (string)reader["Motorri"];
                                car.price = (int)reader["Cmimi"];

                                list.Add(car);
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
    public class CarsAvailableList : List<Car>
    {
        public static CarsAvailableList GetAvailable(DateTime dtFrom, DateTime dtTo)
        {
            var list = new CarsAvailableList();
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbCoonectionString))
                {
                    using (var cmd = new SqlCommand("[dbo].[CarsGetAvailable]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@dtFrom", SqlDbType.DateTime).Value = dtFrom;
                        cmd.Parameters.Add("@dtTo", SqlDbType.DateTime).Value = dtTo;

                        conn.Open();
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            var car = new Car();
                            car.id = (byte)reader["carId"];
                            car.model = (string)reader["Modeli"];
                            car.brand = (string)reader["Marka"];
                            car.engine = (string)reader["Motorri"];
                            car.price = (int)reader["Cmimi"];
                            list.Add(car);
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
