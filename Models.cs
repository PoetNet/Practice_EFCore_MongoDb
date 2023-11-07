using Docker.DotNet.Models;

public class Customer
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required Species Species { get; set; }
    public required ContactInfo ContactInfo { get; set; }
}

public class ContactInfo
{
    public required Address ShippingAddress { get; set; }
    public Address? BillingAddress { get; set; }
    public required PhoneNumbers Phone { get; set; }
}

public class PhoneNumbers
{
    public PhoneNumber? HomePhone { get; set; }
    public PhoneNumber? WorkPhone { get; set; }
    public PhoneNumber? MobilePhone { get; set; }
}

public class PhoneNumber
{
    public required int CountryCode { get; set; }
    public required string Number { get; set; }
}

public class Address
{
    public required string Line1 { get; set; }
    public string? Line2 { get; set; }
    public string? Line3 { get; set; }
    public required string City { get; set; }
    public required string Country { get; set; }
    public required string PostalCode { get; set; }
}

public enum Species
{
    Human,
    Dog,
    Cat
}
