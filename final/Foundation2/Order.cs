using System;
using System.Collections.Generic;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalCost = 0.0;
        foreach (Product product in _products)
        {
            totalCost += product.GetPrice();
        }

        totalCost += _customer.IsInUSA() ? 5.0 : 35.0;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} - {product.GetProductId()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"{_customer.GetName()}\n{_customer.GetAddress().GetFormattedAddress()}";
        return shippingLabel;
    }
}
