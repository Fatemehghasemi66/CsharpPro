using SharpPro.Contracts;
using SharpPro.Models;
using SharpPro.Repository.InterFace;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SharpPro.Repository.Implementation;

public class CustomerRepository : ICustomerRepository
{
    private readonly string connectionString = ConfigurationManager.ConnectionStrings["FirstDB"].ToString();

    public CustomerRepository()
    {
    }
    //public readonly string jsonData = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FileData", "Customer.json"));
    //public static List<Customer> people = new List<Customer>();
    //public CustomerRepository()
    //{
    //    //people = JsonConvert.DeserializeObject<List<Customer>>(jsonData);
    //}

    public bool AddItem(Customer item, out int id)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("InsertCustomer", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserName", item.UserName);
                cmd.Parameters.AddWithValue("@Password", item.Password);
                cmd.Parameters.AddWithValue("@FirstName", item.FirstName);
                cmd.Parameters.AddWithValue("@LastName", item.LastName);
                cmd.Parameters.AddWithValue("@Email", item.Email);
                cmd.Parameters.AddWithValue("@HomeAddress", item.HomeAddress);
                cmd.Parameters.AddWithValue("@MobileNumber", item.MobileNumber);
                cmd.Parameters.AddWithValue("BirthDate", item.BirthDate);
                cmd.Parameters.AddWithValue("@GenderId", (short)item.Gender);

                SqlParameter outputParameter = new SqlParameter("@CustomerId", SqlDbType.Int);
                outputParameter.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);
          
                int rowsAffected = cmd.ExecuteNonQuery();

                int customerId = Convert.ToInt32(outputParameter.Value);
                id = customerId;
                return rowsAffected>0;

            }
            catch (Exception ex)
            {
                id = 0;
                MessageBox.Show($"Error {ex.Message}");
                return false;
            }
            finally { connection.Close(); }

        }
    }
    public bool DeleteItem(int id)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            try
            {
                conn.Open();

                string query = $"delete dbo.Customer where Id = @Id";
                SqlCommand command = new SqlCommand(query, connection: conn);
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
                conn.Close();
            }
        }
    }
    public Customer GetById(object id)
    {
        Customer customer = null;
        string tableName = "dbo.Customer";
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
                    customer = new Customer
                    {
                        Id = (int)reader["Id"],
                        UserName = reader["UserName"].ToString(),
                        Password = reader["Password"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        BirthDate = reader["BirthDate"] != DBNull.Value ? (DateTime)reader["BirthDate"] : null,
                        Email = reader["Email"].ToString(),
                        MobileNumber = reader["MobileNumber"].ToString(),
                        IsValidEmail = (bool)reader["IsValidEmail"],
                        IsValidMobileNumber = (bool)reader["IsValidMobileNumber"],
                        IsActive = (bool)reader["IsActive"],
                        CreationDate = (DateTime)reader["CreationDate"],
                        //Gender = (Enums.Gender)reader["GenderId"],
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
            return customer;
        }
    }

    public List<Customer> GetIAll()
    {
        List<Customer> customers = new List<Customer>();
        string tableName = "dbo.Customer";
        using (SqlConnection conn = new SqlConnection(connectionString))
            try
            {
                conn.Open();
                string query = $"SELECT * FROM {tableName}";
                SqlCommand cmd = new SqlCommand(query, connection: conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Customer customer = new Customer
                    {
                        Id = (int)reader["Id"],
                        UserName = reader["UserName"].ToString(),
                        Password = reader["Password"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        BirthDate = reader["BirthDate"] != DBNull.Value ? (DateTime)reader["BirthDate"] : null,
                        Email = reader["Email"].ToString(),
                        MobileNumber = reader["MobileNumber"].ToString(),
                        HomeAddress = reader["HomeAddress"].ToString(),
                        IsValidEmail = (bool)reader["IsValidEmail"],
                        IsValidMobileNumber = (bool)reader["IsValidMobileNumber"],
                        IsActive = (bool)reader["IsActive"],
                        CreationDate = (DateTime)reader["CreationDate"],
                    };
                    customers.Add(customer);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        return customers;

    }

    public bool UpdateItem(Customer item)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string query = $"UPDATE dbo.Customer " +
                    $"SET FirstName = @FirstName," +
                    $"LastName = @LastName," +
                    $"UserName = @UserName," +
                    $"Password = @Password," +
                    $"Email = @Email," +
                    $"HomeAddress = @HomeAddress," +
                    $"MobileNumber = @MobileNumber," +
                    $"BirthDate = @BirthDate," +
                    $"GenderId = @GenderId" +
                    $" WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", item.Id);
                command.Parameters.AddWithValue("@UserName", item.UserName);
                command.Parameters.AddWithValue("@Password", item.Password);
                command.Parameters.AddWithValue("@FirstName", item.FirstName);
                command.Parameters.AddWithValue("@LastName", item.LastName);
                command.Parameters.AddWithValue("@Email", item.Email);
                command.Parameters.AddWithValue("@HomeAddress", item.HomeAddress);
                command.Parameters.AddWithValue("@MobileNumber", item.MobileNumber);
                command.Parameters.AddWithValue("@BirthDate", item.BirthDate);
                command.Parameters.AddWithValue("@GenderId", (short)item.Gender);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
                return false;
            }
            finally
            { 
                connection.Close(); 
            }
        }
    }
}
