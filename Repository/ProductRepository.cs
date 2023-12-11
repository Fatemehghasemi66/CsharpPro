using CsharpPro.Contracts;
using CsharpPro.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPro.Repository;

public class ProductRepository : IGenericRepository<Product>
{
    List<Product> products = null;
    public ProductRepository()
    {
        products = new List<Product>();
        for (int i = 0; i < 4; i++)
        {
            products.Add(new Product()
            {
                Name = $"Test {i}",
                Price = i * 1500,
                Count = i * 5,
                BrandName = "testbrandName",
            });
        }
    }
    public bool AddItem(Product item)
    
    {
       products.Add(item);
        return true;
    }

    public bool DeleteItem(int id)
    {
        throw new NotImplementedException();
    }

    public Product GetById(object id)
    {
        return products.Where(x => x.Id == (int)id).FirstOrDefault();
    }

    public List<Product> GetIAll()
    {
       return products;
    }

    public bool UpdateItem(Product item)
    {
        throw new NotImplementedException();
    }
}
