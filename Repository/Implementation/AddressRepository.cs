using SharpPro.Contracts;
using SharpPro.Models;
using SharpPro.Repository.InterFace;
using System.Configuration;

namespace SharpPro.Repository.Implementation;

public class AddressRepository : IAddressRepository
{
    private readonly string connectionString = ConfigurationManager.ConnectionStrings["FirstDB"].ToString();
    public AddressRepository()
    {
    }

    public bool AddItem(Address item, out int id)
    {
        throw new NotImplementedException();
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
