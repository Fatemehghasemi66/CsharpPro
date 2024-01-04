using SharpPro.Contracts;
using SharpPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPro.Repository.InterFace;

public interface IOrderRepository : IGenericRepository<Order>
{
    public bool AddSubItem(OrderItem item);
}
