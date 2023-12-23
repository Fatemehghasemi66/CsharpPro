using CsharpPro.Contracts;
using CsharpPro.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPro.Models;

public class Customer:BaseEntity
{
    public Customer() 
    { 
    }

    public Customer(string firstName, string lastName, string mobileNumber, string emailAddress,string homeAddress,Gender gender, DateTime birthDate)

    {
        FirstName = firstName;
        LastName = lastName;
        MobileNumber = mobileNumber;
        EmailAddress = emailAddress;
        HomeAddress = homeAddress;
        Gender = gender;
        IsValidMobileNumber = true;
        IsValidEmail = true;
        BirthDate = birthDate;

    }
    public string PersianBirthDate
    {
        get
        {
            if (BirthDate is not null)
            {
                string persianD = BirthDate?.ToString("yyy/MM/dd", new CultureInfo("fa-IR"));
                return persianD;
            }
            else
            {
                return null;
            }
        }
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MobileNumber { get; set; }
    public DateTime? BirthDate { get; set; }
    public Gender Gender { get; set; }
    public string EmailAddress { get; set; }
    public string HomeAddress { get; set; }
    public bool IsValidMobileNumber { get; set; }
    public bool IsValidEmail { get; set; }

    public override bool IsActiveItem()
    {
        throw new NotImplementedException();
    }
}
