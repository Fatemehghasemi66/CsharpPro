using CsharpPro.Contracts;
using CsharpPro.Models;
using System.Data.SqlClient;

namespace CsharpPro.Repository;

public class ProductRepository : IGenericRepository<Product>
{
    const string connectionString = "Data Source=Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\Db-1.mdf;Integrated Security=True;Connect Timeout=30";
    public static List<Product> products = new List<Product>()
    {

    };
    //public readonly string jsonPData = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"FileData", "Pro.json")); 
    //public static List<Product> products = new List<Product>();
    //public ProductRepository()
    //{
    //    //products = JsonConvert.DeserializeObject<List<Product>>(jsonPData);
        
    //}
    public bool AddItem(Product item)
    
    {
       products.Add(item);
        return true;
    }

    public bool DeleteItem(int id)
    {
        throw new NotImplementedException();
    }

    public Product GetById(object id)
    {
        return products.Where(x => x.Id == (int)id).FirstOrDefault();
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

    bool IGenericRepository<Product>.AddItem(Product item)
    {
        throw new NotImplementedException();
    }

    bool IGenericRepository<Product>.DeleteItem(int id)
    {
        throw new NotImplementedException();
    }

    Product IGenericRepository<Product>.GetById(object id)
    {
        throw new NotImplementedException();
    }

    List<Product> IGenericRepository<Product>.GetIAll()
    {
        throw new NotImplementedException();
    }

    bool IGenericRepository<Product>.UpdateItem(Product item)
    {
        throw new NotImplementedException();
    }
}
