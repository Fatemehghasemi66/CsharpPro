using SharpPro.Contracts;


namespace SharpPro.Models;

public class Address : BaseEntity<int>

{
    public Address()
    {
    }
    public Address(string postalcode, string city, string street, string houseNumber, string consideration)
    {
        PostalCode = postalcode;
        City = city;
        Street = street;
        HouseNumber = houseNumber;
        Consideration = consideration;

    }
    public int CustomerId { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string HouseNumber { get; set; }
    public string Consideration { get; set; }

    

    public  override bool IsActiveItem()
    {
        throw new NotImplementedException();
    }
}
