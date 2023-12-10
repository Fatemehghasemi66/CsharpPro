using CsharpPro.Contracts;
using CsharpPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPro.Repository;

internal class CustomerRepository : IGenericRepository<Customer>
{
    public bool AddItem(Customer item)
    {
        throw new NotImplementedException();
    }

    public bool DeleteItem(Customer item)
    {
        throw new NotImplementedException();
    }

    public Customer GetById(object id)
    {
        throw new NotImplementedException();
    }

    public List<Customer> GetIAll()
    {
        throw new NotImplementedException();
    }

}
