using CsharpPro.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPro.Models
{
    internal class Order : BaseEntity
    {
        public string code { get; set; }
        public DateTime Orderdate { get; set; }
        public int AddresId { get; set; }
        public int CustomerId { get; set; }
        public List<OrderItem> OrderItems { get; set; } 
        public override bool IsActiveItem()
        {
            throw new NotImplementedException();
        }
    }
}
