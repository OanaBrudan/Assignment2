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
    class ProductData
    {
        private string connString;
        public ProductData()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public IList<Product> RetrieveProducts()
        {
            IList<Product> productsList = new List<Product>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM product";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.ID = reader.GetInt32("ID");
                        product.Title = reader.GetString("Title");
                        product.Description = reader.GetString("Description");
                        product.Color = reader.GetString("Color");
                        product.Size = reader.GetString("Size");
                        product.Price = reader.GetInt32("Price");
                        product.Stock = reader.GetInt32("Stock");
                        productsList.Add(product);
                    }
                }
            }

            return productsList;
        }

        public void AddProduct(Product product)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO product(id, title, description, color, size, price, stock) VALUES(@id, @title, @description, @color, @size, @price, @stock)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", product.ID);
                cmd.Parameters.AddWithValue("@title", product.Title);
                cmd.Parameters.AddWithValue("@description", product.Description);
                cmd.Parameters.AddWithValue("@color", product.Color);
                cmd.Parameters.AddWithValue("@size", product.Size);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@stock", product.Stock);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE product SET title = @title, description = @description, color= @color, size=@size, price=@price, stock=@stock  WHERE id = @id;";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", product.ID);
                cmd.Parameters.AddWithValue("@title", product.Title);
                cmd.Parameters.AddWithValue("@description", product.Description);
                cmd.Parameters.AddWithValue("@color", product.Color);
                cmd.Parameters.AddWithValue("@size", product.Size);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@stock", product.Stock);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProduct(Product product)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM product WHERE id=@id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", product.ID);
                cmd.Parameters.AddWithValue("@title", product.Title);
                cmd.Parameters.AddWithValue("@description", product.Description);
                cmd.Parameters.AddWithValue("@color", product.Color);
                cmd.Parameters.AddWithValue("@size", product.Size);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@stock", product.Stock);
                cmd.ExecuteNonQuery();



            }
        }

        public Product GetById(int id)
        {
            Product product = new Product();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM product WHERE Id = @Id";

                MySqlCommand cmd = new MySqlCommand(statement, conn);

                cmd.Parameters.AddWithValue("@Id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        product.ID = reader.GetInt32("ID");
                        product.Title = reader.GetString("Title");
                        product.Description = reader.GetString("Description");
                        product.Color = reader.GetString("Color");
                        product.Size = reader.GetString("Size");
                        product.Price = reader.GetInt32("Price");
                        product.Stock = reader.GetInt32("Stock");
                    }
                }
            }

            return product;
        }
    }
}
