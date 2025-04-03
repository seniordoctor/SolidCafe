using SolidCafe.Models;
using SolidCafe.Utils;

namespace SolidCafe.Services;

// Single Responsibility Principle (SRP) - OrderService
// Logger'ı dışarıdan alıyoruz, böylece test edilebilir ve değiştirilebilir oluyor (DIP)
public class OrderService
{
    private readonly ILogger _logger;

    public OrderService(ILogger logger)
    {
        _logger = logger;
    }

    public List<Beverage> TakeOrder(List<Beverage> menu)
    {
        var basket = new List<Beverage>();

        while (true)
        {
            Console.Write("\nSipariş vermek istediğiniz içeceğin numarasını girin, çıkmak için q: ");
            var input = Console.ReadLine();

            if (input?.ToLower() == "q")
            {
                _logger.Log("Sipariş verme işlemi sonlandırıldı.");
                break;
            }
        
            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= menu.Count)
            {
                var selected = menu[choice - 1];
                basket.Add(selected);
                
                Console.WriteLine($"🛒 Sepete eklendi: {selected.Name} - {selected.Price} TL");
                _logger.Log($"Sepete eklendi: {selected.Name}");
            }
            else
            {
                Console.WriteLine("Geçersiz seçim.");
            
                _logger.Log("Geçersiz seçim yapıldı.");
            }
        }

        return basket;
    }
}