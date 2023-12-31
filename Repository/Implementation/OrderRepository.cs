using CsharpPro.Contracts;
using CsharpPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPro.Repository.Implementation;

public class OrderRepository : IGenericRepository<Order>
{
    public bool DeleteItem(int id)
    {
        throw new NotImplementedException();
    }

    bool IGenericRepository<Order>.AddItem(Order item)
    {
        throw new NotImplementedException();
    }

    Order IGenericRepository<Order>.GetById(object id)
    {
        throw new NotImplementedException();
    }

    List<Order> IGenericRepository<Order>.GetIAll()
    {
        throw new NotImplementedException();
    }

    bool IGenericRepository<Order>.UpdateItem(Order item)
    {
        throw new NotImplementedException();
    }
}
