using SharpPro.Contracts;
using SharpPro.Models;
using SharpPro.Repository.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPro.Repository.Implementation;

public class OrderRepository : IOrderRepository
{
    public bool AddItem(Order item, out int id)
    {
        throw new NotImplementedException();
    }

    public bool AddSubItem(OrderItem item)
    {
        throw new NotImplementedException();
    }

    public bool DeleteItem(int id)
    {
        throw new NotImplementedException();
    }

    public Order GetById(object id)
    {
        throw new NotImplementedException();
    }

    public List<Order> GetIAll()
    {
        throw new NotImplementedException();
    }

    public bool UpdateItem(Order item)
    {
        throw new NotImplementedException();
    }
}
