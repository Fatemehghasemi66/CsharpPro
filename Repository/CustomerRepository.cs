using CsharpPro.Contracts;
using CsharpPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPro.Repository;

public class CustomerRepository : IGenericRepository<Customer>
{
    public static List<Customer> people = new List<Customer>();

    public CustomerRepository()
        {
        }

    public bool AddItem(Customer item)
    {
        people.Add(item);
        return true;
    }
    public bool DeleteItem(int id)
    {
        throw new NotImplementedException();
    }
    public Customer GetById(object id)
    {
        throw new NotImplementedException();
    }

    public List<Customer> GetIAll()
    {
        return people;
    }

    public bool UpdateItem(Customer item)
    {
        throw new NotImplementedException();
    }
}
