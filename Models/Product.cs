using CsharpPro.Contracts;


namespace CsharpPro.Models;

public class Product:BaseEntity<int>
{
    public Product()
    {
    }

    public Product(string name, decimal price, int count, string brandName):base(false)
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
