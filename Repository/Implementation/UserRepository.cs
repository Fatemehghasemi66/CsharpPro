using SharpPro.Contracts;
using SharpPro.Models;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users = SharpPro.Models.Users;
using CsharpPro.Repository.InterFace;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace SharpPro.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["FirstDB"].ToString();

        public bool AddItem(Users item, out int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("InsertUsers", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserName", item.UserName);
                    cmd.Parameters.AddWithValue("@Password", item.Password);
                    cmd.Parameters.AddWithValue("@FirstName", item.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", item.LastName);
                    cmd.Parameters.AddWithValue("@MobileNumber", item.MobileNumber);
                    cmd.Parameters.AddWithValue("BirthDate", item.BirthDate);
                    cmd.Parameters.AddWithValue("@GenderId", (short)item.Gender);

                    SqlParameter outputParameter = new SqlParameter("@userId", SqlDbType.Int);
                    outputParameter.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputParameter);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    int userId = Convert.ToInt32(outputParameter.Value);
                    id = userId;
                    return rowsAffected > 0;

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
            throw new NotImplementedException();
        }

        public Users GetById(object id)
        {
            throw new NotImplementedException();
        }

        public List<Users> GetIAll()
        {
            List<Users> users = new List<Users>();
            string tableName = "dbo.Users";
            using (SqlConnection conn = new SqlConnection(connectionString))
                try
                {
                    conn.Open();
                    string query = $"SELECT * FROM {tableName}";
                    SqlCommand cmd = new SqlCommand(query, connection: conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Users user = new Users
                        {
                            Id = (int)reader["Id"],
                            UserName = reader["UserName"].ToString(),
                            Password = reader["Password"].ToString(),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            BirthDate = reader["BirthDate"] != DBNull.Value ? (DateTime)reader["BirthDate"] : null,
                            MobileNumber = reader["MobileNumber"].ToString(),
                            IsValidMobileNumber = (bool)reader["IsValidMobileNumber"],
                            IsActive = (bool)reader["IsActive"],
                            CreationDate = (DateTime)reader["CreationDate"],
                        };
                        users.Add(user);
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
            return users;
        }

        public bool UpdateItem(Users item)
        {
            throw new NotImplementedException();
        }
    }
}
