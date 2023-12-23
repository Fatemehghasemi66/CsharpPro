using CsharpPro.Contracts;
using CsharpPro.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPro.Models;

public class Product:BaseEntity
{
    public Product()
    {
    }

    public Product(string name, decimal price, int count, string brandName)
    {
        Name = name;
        Price = price;
        Count = count;
        BrandName = brandName;
    }
   
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Count { get; set; }
    public string BrandName { get; set; }

    public override bool IsActiveItem()
    {
        throw new NotImplementedException();
    }
    
}
