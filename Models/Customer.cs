using CsharpPro.Contracts;
using CsharpPro.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPro.Models;
[DebuggerDisplay("Customer {Id}: {FirstName} {LastName} whith {MobileNumber} Mobile")]
public class Customer : BaseEntity<int>
{
    public Customer()
        {
        }
   

    public Customer( string username, string firstName, string lastName, DateTime? birthDate, string mobileNumber, Gender gender, string homeAddress,
        string emailAddress,string password):base(false)
    {
        UserName = username;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
        MobileNumber = mobileNumber;
        Email = emailAddress;
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

    public string UserName { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MobileNumber { get; set; }
    public string Email { get; set; }
    public string HomeAddress { get; set; }
    public bool IsValidMobileNumber { get; set; }
    public bool IsValidEmail { get; set; }
    public DateTime? BirthDate { get; set; }
    public Gender Gender { get; set; }
    public object Value { get; }

    public override bool IsActiveItem()
    {
        throw new NotImplementedException();
    }
}
