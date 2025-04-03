namespace SolidCafe.Models;

public class Beverage
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Beverage(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}