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
    public static List<Product> products = new List<Product>();
    public ProductRepository()
    {
        
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

    bool IGenericRepository<Product>.AddItem(Product item)
    {
        throw new NotImplementedException();
    }

    bool IGenericRepository<Product>.DeleteItem(int id)
    {
        throw new NotImplementedException();
    }

    Product IGenericRepository<Product>.GetById(object id)
    {
        throw new NotImplementedException();
    }

    List<Product> IGenericRepository<Product>.GetIAll()
    {
        throw new NotImplementedException();
    }

    bool IGenericRepository<Product>.UpdateItem(Product item)
    {
        throw new NotImplementedException();
    }
}
