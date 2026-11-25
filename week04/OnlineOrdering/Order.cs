using System;
using System.Collections.Generic;

class Order
{
    private readonly List<Product> _products = new List<Product>();
    private readonly Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal total = 0m;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        decimal shippingCost = _customer.LivesInUSA() ? 5m : 35m;
        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        List<string> lines = new List<string>();

        foreach (Product product in _products)
        {
            lines.Add($"{product.GetName()} (Product ID: {product.GetProductId()})");
        }

        return string.Join(Environment.NewLine, lines);
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}{Environment.NewLine}{_customer.GetAddressText()}";
    }
}
