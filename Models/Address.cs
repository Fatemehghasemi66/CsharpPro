using CsharpPro.Contracts;


namespace CsharpPro.Models;

public class Address :Customer

{
    public Address()
    {
    }

    public Address(string firstname,string lastname, string mobile, string homeAddress)
    {
        FirstName = firstname;
        LastName = lastname;
        MobileNumber = mobile;
        HomeAddress = homeAddress;
       
    }


}
