using SolidCafe.Models;

namespace SolidCafe.Services;

public class MenuService
{
    public List<Beverage> GetMenu()
    {
        return new List<Beverage>
        {
            new Beverage("Türk Kahvesi", 25),
            new Beverage("Latte", 30),
            new Beverage("Çay", 10),
            new Beverage("Espresso", 28),
        };
    }

    public void PrintMenu(List<Beverage> menu)
    {
        Console.WriteLine("\n📋 Menü:");
        for (int i = 0; i < menu.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {menu[i].Name} - {menu[i].Price} TL");
        }
    }
}