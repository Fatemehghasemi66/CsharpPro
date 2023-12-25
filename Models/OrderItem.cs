using CsharpPro.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPro.Models;

public class OrderItem:BaseEntity
{
    public decimal CurrentPrice { get; set; }
    public Product Product { get; set; }
    public override bool IsActiveItem()
    {
        throw new NotImplementedException();
    }
}
