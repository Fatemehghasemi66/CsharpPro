using CsharpPro.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPro.Models;

public class Customer : User
{
    public Customer() 
    { 
    }

    public Customer(string firstName, string lastName, DateTime birthDate, string mobileNumber, string emailAddress,string homeAddress)

    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        MobileNumber = mobileNumber;
        EmailAddress = emailAddress;
        HomeAddress = homeAddress;
        IsValidMobileNumber = true;
        IsValidEmail = true;
    }
   
    
    public string EmailAddress { get; set; }
    public string HomeAddress { get; set; }
    public bool IsValidMobileNumber { get; set; }
    public bool IsValidEmail { get; set; }

    }
