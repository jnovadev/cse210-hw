using System;

class Address
{
    private readonly string _street;
    private readonly string _city;
    private readonly string _stateOrProvince;
    private readonly string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool IsInUSA()
    {
        string country = _country.Trim();
        return country.Equals("USA", StringComparison.OrdinalIgnoreCase) ||
               country.Equals("US", StringComparison.OrdinalIgnoreCase) ||
               country.Equals("United States", StringComparison.OrdinalIgnoreCase) ||
               country.Equals("United States of America", StringComparison.OrdinalIgnoreCase);
    }

    public string GetFullAddress()
    {
        return $"{_street}{Environment.NewLine}{_city}, {_stateOrProvince}{Environment.NewLine}{_country}";
    }
}
