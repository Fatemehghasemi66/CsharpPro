using SharpPro.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPro.Models;

public class OrderItem:BaseEntity<int>
{
    public int OrderId { get; set; }
    public decimal CurrentPrice { get; set; }
    public int ProductId { get; set; }
    public int Count { get; set; }
    public override bool IsActiveItem()
    {
        throw new NotImplementedException();
    }
}
