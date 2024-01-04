using SharpPro.Contracts;
using SharpPro.Enums;
using System.DirectoryServices;

namespace SharpPro.Models;

public class UserLogin : BaseEntity<int>
{
    public UserLogin(string username, string password)
    {
       UserName = username;
        Password = password;
    }


    public string UserName { get; set; }
    public string Password { get; set; }

    public override bool IsActiveItem()
    {
        throw new NotImplementedException();
    }




}

