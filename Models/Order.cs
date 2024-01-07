using SharpPro.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPro.Models
{
    public class Order : BaseEntity<int>
    {
        public string? Code { get; set; }
        public DateTime OrderDate { get; set; }
        public int AddressId { get; set; }
        public int CustomerId { get; set; }
        //public List<OrderItem> OrderItems { get; set; } 
        public override bool IsActiveItem()
        {
            throw new NotImplementedException();
        }
    }
}
