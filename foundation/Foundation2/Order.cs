using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double totalProductCost = 0;
        foreach (var product in _products)
        {
            totalProductCost += product.GetTotalCost();
        }

        double shippingCost = _customer.IsInUSA() ? 5.0 : 35.0;
        return totalProductCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}\n";
        return label;
    }
}
