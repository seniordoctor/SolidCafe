using SolidCafe.Models;
using SolidCafe.Utils;

namespace SolidCafe.Services;

// Bu sınıf sadece ödeme işlemleri ile ilgilidir. (SRP)
public class PaymentService
{
    private readonly ILogger _logger;

    public PaymentService(ILogger logger)
    {
        _logger = logger;
    }

    public void ProcessPayment(List<Beverage> basket)
    {
        decimal total = 0;

        foreach (var item in basket)
        {
            Console.WriteLine($"💳 {item.Name} için {item.Price} TL ödeme alındı.");
            _logger.Log($"{item.Name} için {item.Price} TL ödeme alındı.");
            
            total += item.Price;
        }
        
        Console.WriteLine($"\n🧾 Toplam Tutar: {total} TL");
        _logger.Log($"Toplam ödeme alındı: {total} TL");
    }
}