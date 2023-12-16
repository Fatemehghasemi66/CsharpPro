using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPro.Contracts;

public abstract class BaseEntity
{
    public BaseEntity()
    {
        IsActive = true;
        CreationDate = DateTime.Now;
        Random random = new Random();
        Id = random.Next(minValue: 1, maxValue: 1000);
    }
    public BaseEntity(bool isActive)
    {
        IsActive = isActive;
        CreationDate = DateTime.Now;
        Random random = new Random();
        Id = random.Next(minValue: 100, maxValue: 10000);
    }
    public BaseEntity(bool isActive, int minvalue, int maxvalue)
    {
        IsActive = isActive;
        CreationDate = DateTime.Now;
        Random random = new Random();
        Id = random.Next(minValue: minvalue, maxValue: maxvalue);
    }


    public int Id { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreationDate { get; set; }
    public abstract bool IsActiveItem();

}
