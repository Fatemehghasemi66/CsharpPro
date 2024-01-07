using SharpPro.Contracts;
using SharpPro.Models;
using SharpPro.Repository.InterFace;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace SharpPro.Repository.Implementation;

public class AddressRepository : IAddressRepository
{
    private readonly string connectionString = ConfigurationManager.ConnectionStrings["FirstDB"].ToString();
    public AddressRepository()
    {
    }

    public bool AddItem(Address item, out int id)
    {
        using(SqlConnection connection = new SqlConnection(connectionString)) 
      {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("InsertAddress", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PostalCode", item.PostalCode);
                cmd.Parameters.AddWithValue("@City", item.City);
                cmd.Parameters.AddWithValue("@Street", item.Street);
                cmd.Parameters.AddWithValue("@HouseNumber", item.HouseNumber);
                cmd.Parameters.AddWithValue("@Consideration", item.Consideration);
                

                SqlParameter outputParameter = new SqlParameter("@CustomerId", SqlDbType.Int);
                outputParameter.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);

                int rowsAffected = cmd.ExecuteNonQuery();

                int customerId = Convert.ToInt32(outputParameter.Value);
                id = customerId;
                return rowsAffected > 0;

            }
            catch (Exception ex)
            {
                id = 0;
                MessageBox.Show($"Error {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
   }

    public bool DeleteItem(int id)
    {
        throw new NotImplementedException();
    }

    public Address GetById(object id)
    {
        throw new NotImplementedException();
    }

    public List<Address> GetIAll()
    {
        throw new NotImplementedException();
    }

    public bool UpdateItem(Address item)
    {
        throw new NotImplementedException();
    }
}
