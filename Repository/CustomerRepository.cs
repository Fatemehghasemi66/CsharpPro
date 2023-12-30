using CsharpPro.Contracts;
using CsharpPro.Models;
using System.Data.SqlClient;

namespace CsharpPro.Repository;

public class CustomerRepository : IGenericRepository<Customer>
{

    const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Documents\\Db-1.mdf;Integrated Security=True;Connect Timeout=30";
    //public readonly string jsonData = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FileData", "Customer.json"));
    //public static List<Customer> people = new List<Customer>();
    //public CustomerRepository()
    //{
    //    //people = JsonConvert.DeserializeObject<List<Customer>>(jsonData);
    //}

    public bool AddItem(Customer item)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                string tableName = "dbo.Customer";
                string query = $"INSERT INTO {tableName}([UserName],[Password],[FirstName],[LastName],[Email],[MobileNumber],[BirthDate],[HomeAddress],[GenderId])" +
                    "VALUES (@UserName, @Password, @FirstName, @LastName, @Email, @MobileNumber,@BirthDate,@GenderId, @HomeAddress)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@UserName", item.UserName);
                cmd.Parameters.AddWithValue("@Password", item.Password);
                cmd.Parameters.AddWithValue("@FirstName", item.FirstName);
                cmd.Parameters.AddWithValue("@LastName", item.LastName);
                cmd.Parameters.AddWithValue("@Email", item.Email);
                cmd.Parameters.AddWithValue("@HomeAddress", item.HomeAddress);
                cmd.Parameters.AddWithValue("@MobileNumber", item.MobileNumber);
                cmd.Parameters.AddWithValue("BirthDate", item.BirthDate);
                cmd.Parameters.AddWithValue("@GenderId", (short)item.Gender);


                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
                return false;
            }
            finally { conn.Close(); }

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
                string query = $"UPDATE dbo.Customer" +
                    $"SET FirstName = @FirstName," +
                    $"SET LastName = @LastName," +
                    $"SET UserName = @UserName," +
                    $"SET Password = @Password," +
                    $"SET Email = @Email," +
                    $"SET HomeAddress = @HomeAddress," +
                    $"SET MobileNumber = @MobileNumber," +
                    $"SET BirthDate = @BirthDate," +
                    $"SET GenderId = @GenderId" +
                    $"WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", item.Id);
                command.Parameters.AddWithValue("@UserName", item.UserName);
                command.Parameters.AddWithValue("@Password", item.Password);
                command.Parameters.AddWithValue("@FirstName", item.FirstName);
                command.Parameters.AddWithValue("@LastName", item.LastName);
                command.Parameters.AddWithValue("@Email", item.Email);
                command.Parameters.AddWithValue("@HomeAddress", item.HomeAddress);
                command.Parameters.AddWithValue("@MobileNumber", item.MobileNumber);
                command.Parameters.AddWithValue("BirthDate", item.BirthDate);
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
            { connection.Close(); }
        }
    }
}
