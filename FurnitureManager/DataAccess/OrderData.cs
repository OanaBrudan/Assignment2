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
    class OrderData
    {
        private string connString;
        public OrderData()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public IList<Order> RetrieveOrders()
        {
            IList<Order> ordersList = new List<Order>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM orders";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Order orders = new Order();
                        orders.ID = reader.GetInt32("ID");
                        orders.Customer = reader.GetString("Customer");
                        orders.Address = reader.GetString("Address");
                        orders.Date = reader.GetDateTime("Date");
                        orders.Status = reader.GetString("Status");
                        // orders.Product = reader.("Product");
                        ordersList.Add(orders);
                    }
                }
            }

            return ordersList;
        }

        public void AddOrder(Order orders)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO orders(id, customer, date, address, status) VALUES(@id, @customer, @date, @address, @status)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", orders.ID);
                cmd.Parameters.AddWithValue("@customer", orders.Customer);
                cmd.Parameters.AddWithValue("@date", orders.Date);
                cmd.Parameters.AddWithValue("@address", orders.Address);
                cmd.Parameters.AddWithValue("@status", orders.Status);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateOrder(Order orders)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE orders SET customer = @customer, date = @date, address= @address, status=@status  WHERE id = @id;";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", orders.ID);
                cmd.Parameters.AddWithValue("@customer", orders.Customer);
                cmd.Parameters.AddWithValue("@date", orders.Date);
                cmd.Parameters.AddWithValue("@address", orders.Address);
                cmd.Parameters.AddWithValue("@status", orders.Status);
                cmd.ExecuteNonQuery();
            }
        }

        public Order GetById(int id)
        {
            Order orders = new Order();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM orders WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(statement, conn);

                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        orders.ID = reader.GetInt32("ID");
                        orders.Customer = reader.GetString("Customer");
                        orders.Address = reader.GetString("Address");
                        orders.Date = reader.GetDateTime("Date");
                        orders.Status = reader.GetString("Status");
                        // orders.Product = reader.("Product");
                        
                    }
                }
            }

            return orders;
        }

    }
}
