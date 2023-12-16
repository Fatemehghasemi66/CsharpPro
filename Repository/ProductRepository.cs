using CsharpPro.Contracts;
using CsharpPro.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPro.Repository;

public class ProductRepository : IGenericRepository<Product>
{
    public readonly string jsonPData = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"FileData", "Pro.json")); 
    public static List<Product> products = new List<Product>();
    public ProductRepository()
    {
        products = JsonConvert.DeserializeObject<List<Product>>(jsonPData);
        
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
