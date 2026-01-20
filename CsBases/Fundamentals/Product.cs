using System;
using System.Data;

namespace CsBases.Fundamentals;

public class Product : IProduct
{
    // propiedades
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public bool IsAvaible { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid UniqueCode { get; set; }

    // Constructor
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
        CreatedAt = DateTime.Now;
        UniqueCode = Guid.NewGuid();
    }

    // Metodos
    public void ApplyDiscount(decimal percentage)
    {
        var discountAmount = Price * (percentage / 100);
        Price -= discountAmount; // es igual a Price = Price - discountAmount;
    }

    public string GetDescription()
    {
        return $"{Name} - {Price:C}";
    }
}
