using CsharpPro.Contracts;
using CsharpPro.Models;


namespace CsharpPro.Repository.Implementation;

public class AddressRepository : IGenericRepository<Address>
{
    public static List<Address> Address = new List<Address>();
    public AddressRepository()
    {
    }

    public bool AddItem(Address item)
    {
        Address.Add(item);
        return true;
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
        return Address;
    }

    public bool UpdateItem(Address item)
    {
        throw new NotImplementedException();
    }
}
