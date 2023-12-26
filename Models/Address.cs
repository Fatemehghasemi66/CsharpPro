﻿using CsharpPro.Contracts;


namespace CsharpPro.Models;

public class Address :BaseEntity

{
    public Address()
    {
    }
    public int CustomerId { get; set; }
    public string PostalCode {  get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string Pelak { get; set; }

    public  override bool IsActiveItem()
    {
        throw new NotImplementedException();
    }
}
