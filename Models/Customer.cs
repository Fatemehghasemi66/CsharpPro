using SharpPro.Contracts;
using SharpPro.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;


namespace SharpPro.Models;
[DebuggerDisplay("Customer {Id}: {FirstName} {LastName} whith {MobileNumber} Mobile")]
public class Customer : Users 
{

    public Customer()
    {

    }

    public Customer(string username, string password, string firstName, string lastName, DateTime? birthDate, string mobileNumber, Gender gender, string homeAddress,
        string emailAddress):base()

    {

        UserName = username;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
        MobileNumber = mobileNumber;
        Gender = gender;
        IsValidMobileNumber = true;
        BirthDate = birthDate;
        Email = emailAddress;
        HomeAddress = homeAddress;
        IsValidMobileNumber = true;
        IsValidEmail = true;
     
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

    public int UserId { get; set; }
    public string Email { get; set; }
    public string HomeAddress { get; set; }
    public bool IsValidEmail { get; set; }
   

    public override bool IsActiveItem()
    {
        throw new NotImplementedException();
    }
}

