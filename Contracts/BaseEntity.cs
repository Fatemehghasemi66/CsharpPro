using System;
using System.Collections.Generic;
using System.Globalization;


namespace CsharpPro.Contracts;

public abstract class BaseEntity<TId>
{
    public BaseEntity()
    {
        IsActive = true;
        CreationDate = DateTime.Now;
    }
    public BaseEntity(bool isActive)
    {
        IsActive = isActive;
        CreationDate = DateTime.Now;
        
    }
    public string creationhDate
    {
        get
        {
            string persianCreationD = CreationDate.ToString("yyy/MM/dd", new CultureInfo("fa-IR"));
            return persianCreationD;
        }
    }
    public TId Id { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreationDate { get; set; }
    public abstract bool IsActiveItem();

}
