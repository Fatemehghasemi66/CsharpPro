using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPro.Models;

internal class Customer:User
{
    public Customer(string firstName, string lastName, DateTime birthDate, string phonNumber, string mobileNumber, string emailAddress)

    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        PhonNumber = phonNumber;
        MobileNumber = mobileNumber;
        EmailAddress = emailAddress;
        IsValidMobileNumber = true;
        IsValidEmail = true;
    }
    public string PhonNumber { get; set; }
    public string MobileNumber { get; set; }
    public string EmailAddress { get; set; }
    public string HomeAddress { get; set; }
    public bool IsValidMobileNumber { get; set; }
    public bool IsValidEmail { get; set; }
}
