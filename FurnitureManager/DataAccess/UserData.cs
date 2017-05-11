using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using FurnitureManager.Model;

namespace FurnitureManager.DataAccess
{
    class UserData
    {
        private string connString;

        public UserData()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public User GetUser(string username, string password)
        {

            using (MySqlConnection conn = new MySqlConnection(connString))
            {

                conn.Open();
                string statement = "SELECT * FROM Users where username=\"" + username + "\";";

                MySqlCommand cmd = new MySqlCommand(statement, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    {
                        User user = new User();
                        user.ID = reader.GetInt32("id");
                        user.Name = reader.GetString("name");
                        user.Address = reader.GetString("address");
                        user.Username = reader.GetString("username");
                        user.Password = reader.GetString("password");
                        user.IsAdmin = reader.GetBoolean("isAdmin");
                       


                        return user;
                    }
                }
            }
            return null;
        }





        public IList<User> RetrieveUsers()
        {
            IList<User> usersList = new List<User>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM users";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.ID = reader.GetInt32("ID");
                        user.Name = reader.GetString("Name");
                        user.Address = reader.GetString("Address");
                        user.Username = reader.GetString("Username");
                        user.Password = reader.GetString("Password");
                        user.IsAdmin = reader.GetBoolean("isAdmin");

                        usersList.Add(user);
                    }
                }
            }

            return usersList;
        }

        public void AddUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO users(id, name, address, username, password, isAdmin) VALUES(@id, @name, @address, @username, @password, @isAdmin)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", user.ID);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@address", user.Address);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@isAdmin", user.IsAdmin);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE users SET name = @name, address = @address, username= @username, password=@password, isAdmin=@isAdmin  WHERE id = @id;";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", user.ID);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@address", user.Address);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@isAdmin", user.IsAdmin);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM users WHERE id=@id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", user.ID);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@address", user.Address);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@isAdmin", user.IsAdmin);
                cmd.ExecuteNonQuery();



            }


        }
        /*public User GetById(int id)
        {
            User user = new User();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM regularuser WHERE Id = @Id";

                MySqlCommand cmd = new MySqlCommand(statement, conn);

                cmd.Parameters.AddWithValue("@Id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user.ID = reader.GetInt32("Id");
                        user.Username = reader.GetString("UserName");
                        user.Password = reader.GetString("Password");
                    }
                }
            }

            return user;
        }*/
    }
}
