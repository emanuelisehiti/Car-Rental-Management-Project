using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MakinaMeQera

{
    class Users
    {
        public int id;
        public string Username;
  
        public string Firstname;
        public string Lastname;
        public string email;
        public bool admin;
        public static Users currentUser ;

        public static Users Get(int id)
        {
            var user = new Users();
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbCoonectionString))
                {
                    using (var cmd = new SqlCommand("[dbo].[UsersGet]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                        conn.Open();
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            user.id = (int)reader["Id"];
                            user.Username = (string)reader["Perdoruesi"];
                        
                            user.Firstname = (string)reader["Emri"];
                            user.Lastname= (string)reader["Mbiemri"];
                            user.email = (string)reader["Email"];
                            user.admin = (bool)reader["Admin"];



                        }
                        conn.Close();
                    }
                }
            }
            catch
            {

            }
            return user;
        }
        public static bool Login(string username, string password)
        {
            bool result = false;
            var user = new Users();
            var passHash = Utils.GetStringSha256Hash(password);
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbCoonectionString))
                {
                    using (var cmd = new SqlCommand("[dbo].[UsersLogin]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                        cmd.Parameters.Add("@passwordHash", SqlDbType.VarChar).Value = passHash;
                        conn.Open();
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            user.id = (int)reader["Id"];
                            user.Username = (string)reader["Perdoruesi"];
                            user.Firstname = (string)reader["Emri"];
                            user.Lastname = (string)reader["Mbiemri"];
                            user.email = (string)reader["Email"];
                            user.admin = (bool)reader["Admin"];

                            currentUser = user;
                            result = true;

                        }

                        conn.Close();
                    }
                }
            }
            catch(Exception my)
            {

            }
            return result;
        }
        public static bool UpdatePasswordHash(int userId, string passwordHash)
        {
            bool result = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbCoonectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[UsersUpdatePasswordHash]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                        cmd.Parameters.Add("@passwordHash", SqlDbType.VarChar).Value = passwordHash;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
                
            }

            return result;
        }
        internal static Users Update(Users user)
        {
            var res = new Users();

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbCoonectionString))
                {
                    using (var cmd = new SqlCommand("[dbo].[UsersUpdate]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = user.id;
                        cmd.Parameters.Add("@perdoruesi", SqlDbType.VarChar).Value = user.Username;
                        cmd.Parameters.Add("@emri", SqlDbType.VarChar).Value = user.Firstname;
                        cmd.Parameters.Add("@mbiemri", SqlDbType.VarChar).Value = user.Lastname;
                        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = user.email;
                        cmd.Parameters.Add("@admin", SqlDbType.Bit).Value = user.admin;
                    
                     
                        conn.Open();
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            res.id = (int)reader["Id"];
                            res.Username = (string)reader["Perdoruesi"];
                            res.Firstname = (string)reader["Emri"];
                            res.Lastname = (string)reader["Mbiemri"];
                            res.email = (string)reader["Email"];

                            res.admin = (bool)reader["Admin"];
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


        public static Users Insert(Users users,string password)
        {
            var newUser = new Users();
            var passHash = Utils.GetStringSha256Hash(password);
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbCoonectionString))
                {
                    using (var cmd = new SqlCommand("[dbo].[UserInsert]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@perdoruesi", SqlDbType.VarChar).Value = users.Username;
                        cmd.Parameters.Add("@fjalekalimi", SqlDbType.VarChar).Value = passHash;
                        cmd.Parameters.Add("@emri", SqlDbType.VarChar).Value = users.Firstname;
                        cmd.Parameters.Add("@mbiemri", SqlDbType.VarChar).Value = users.Lastname;
                        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = users.email;
                        cmd.Parameters.Add("@admin", SqlDbType.Bit).Value = users.admin;
                        conn.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            newUser.id = (int)reader["Id"];
                            newUser.Username = (string)reader["Perdoruesi"];
                            newUser.Firstname = (string)reader["Emri"];
                            newUser.Lastname = (string)reader["Mbiemri"];
                            newUser.email = (string)reader["Email"];
                            newUser.admin = (bool)reader["Admin"];


                        }
                        conn.Close();
                    }
                }
            }
            catch
            {

            }
            return newUser;
        }


    }

    class UsersList : List<Users>
    {
        public static UsersList Get()
        {
            var list = new UsersList();
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbCoonectionString))
                {
                    using (var cmd = new SqlCommand("[dbo].[UsersGet]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            var user = new Users();
                            user.id = (int)reader["Id"];
                            user.Username = (string)reader["Perdoruesi"];
                            user.Firstname = (string)reader["Emri"];
                            user.Lastname = (string)reader["Mbiemri"];
                            user.email = (string)reader["Email"];
                            user.admin = (bool)reader["Admin"];



                            list.Add(user);
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
