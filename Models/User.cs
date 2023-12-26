using CsharpPro.Contracts;
using CsharpPro.Enums;
using System.DirectoryServices;

namespace CsharpPro.Models;

public class User : BaseEntity
{
    public User(string firstName, string lastName, DateTime? birthDate, string mobileNumber, Gender gender)

    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        MobileNumber = mobileNumber;
        Gender = gender;
    }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MobileNumber { get; set; }
    public DateTime? BirthDate { get; set; }
    public Gender Gender { get; set; }

    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";

        }
    }

    public override bool IsActiveItem()
    {
        if (BirthDate is not null)
        {
            if (BirthDate < DateTime.Now)
                return true;
            else

                return false;
        }
        else
        {
            return false;
        }
    
    }

}

