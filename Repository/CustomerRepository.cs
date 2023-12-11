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
       public Customer GetById(object id)
    {
        throw new NotImplementedException();
    }

    public List<Customer> GetIAll()
    {
        throw new NotImplementedException();
    }

    bool IGenericRepository<Customer>.AddItem(Customer item)
    {
        throw new NotImplementedException();
    }

    bool IGenericRepository<Customer>.DeleteItem(int id)
    {
        throw new NotImplementedException();
    }

    Customer IGenericRepository<Customer>.GetById(object id)
    {
        throw new NotImplementedException();
    }

    List<Customer> IGenericRepository<Customer>.GetIAll()
    {
        throw new NotImplementedException();
    }

    bool IGenericRepository<Customer>.UpdateItem(Customer item)
    {
        throw new NotImplementedException();
    }
}
