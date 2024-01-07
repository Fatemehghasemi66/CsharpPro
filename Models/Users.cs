using SharpPro.Contracts;
using SharpPro.Enums;
using System.DirectoryServices;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.Mail;

namespace SharpPro.Models;

public class Users : BaseEntity<int>
{
    public Users()
    {
    }

    public Users(string username, string password, string firstName, string lastName, DateTime? birthDate, string mobileNumber, Gender gender)
    {
        UserName = username;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
        MobileNumber = mobileNumber;
        Gender = gender;
        IsValidMobileNumber = true;
        BirthDate = birthDate;
    }

    public string UserName { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MobileNumber { get; set; }
    public DateTime? BirthDate { get; set; }
    public Gender Gender { get; set; }
    public bool IsValidMobileNumber { get; set; }



    public override bool IsActiveItem()
    {
        throw new NotImplementedException();
    }




}

