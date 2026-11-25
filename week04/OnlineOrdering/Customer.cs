class Customer
{
    private readonly string _name;
    private readonly Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddressText()
    {
        return _address.GetFullAddress();
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}
