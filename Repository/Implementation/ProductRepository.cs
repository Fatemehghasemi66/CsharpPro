using CsharpPro.Contracts;
using CsharpPro.Models;
using CsharpPro.Repository.InterFace;
using System.Configuration;
using System.Data.SqlClient;

namespace CsharpPro.Repository.Implementation;

public class ProductRepository : IProductRepository
{
    private readonly string connectionString = ConfigurationManager.ConnectionStrings["FirstDB"].ToString();
    //public static List<Product> products = new List<Product>()
    //{

    //};
    // Read From JSONFILE:
    //public readonly string jsonPData = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"FileData", "Pro.json")); 
    //public static List<Product> products = new List<Product>();
    //public ProductRepository()
    //{
    //    //products = JsonConvert.DeserializeObject<List<Product>>(jsonPData);

    //}
    public bool AddItem(Product item)

    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string tableName = "dbo.Product";
                string query = $"INSERT INTO {tableName}([Name],[Price],[Count],[BrandName])" +
                    "VALUES (@Name, @Price, @Count, @BrandName)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@Price", item.Price);
                command.Parameters.AddWithValue("@Count", item.Count);
                command.Parameters.AddWithValue("@BrandName", item.BrandName);



                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
                return false;
            }
            finally { connection.Close(); }

        }

    }
    public bool DeleteItem(int id)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                string query = $"delete dbo.Product where Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }

    public Product GetById(object id)
    {
        Product product = null;
        string tableName = "dbo.Product";
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                string query = $"SELECT * FROM {tableName} where Id = @Id";
                SqlCommand command = new SqlCommand(query, connection: conn);
                command.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    product = new Product
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        Price = (int)reader["Price"],
                        Count = (int)reader["Count"],
                        BrandName = reader["BrandName"].ToString(),
                        IsActive = (bool)reader["IsActive"],
                        CreationDate = (DateTime)reader["CreationDate"],
                    };

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
            return product;
        }
    }

    public List<Product> GetIAll()
    {
        List<Product> products = new List<Product>();
        string tableName = "dbo.Product";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string query = $"SELECT * FROM {tableName}";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Product product = new Product
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        BrandName = reader["BrandName"].ToString(),
                        Count = (int)reader["Count"],
                        IsActive = (bool)reader["IsActive"],
                        Price = (decimal)reader["Price"],
                        CreationDate = (DateTime)reader["CreatinDate"],
                    };
                    products.Add(product);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return products;

        }
    }

    public bool UpdateItem(Product item)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string query = $"UPDATE dbo.Product" +
                    $"SET Name = @Name," +
                    $"SET Price = @Price," +
                    $"SET Count = @Count," +
                    $"SET BrandName = @BrandName," +
                    $"WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", item.Id);
                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@Price", item.Price);
                command.Parameters.AddWithValue("@Count", item.Count);
                command.Parameters.AddWithValue("@BrandName", item.BrandName);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
                return false;
            }
            finally
            { connection.Close(); }
        }
    }
}

