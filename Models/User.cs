using CsharpPro.Contracts;
using CsharpPro.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPro.Models;

public class User : BaseEntity
{
    public Gender Gender { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string MobileNumber { get; set; }
    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";

        }
    }


    public override bool IsActiveItem()
    {
        if (BirthDate > DateTime.Now)
            return true;
        else

            return false;
    }
}

