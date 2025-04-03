using SolidCafe.Models;

namespace SolidCafe.Services;

// Bu sınıf sadece analiz/raporlama işlemleri ile ilgilidir. (SRP)
public class ReportService
{
    public void PrintSummary(List<Beverage> basket)
    {
        Console.WriteLine($"\n🧾 Gün Sonu Raporu");
        
        int totalItems = basket.Count;
        decimal totalRevenue = basket.Sum(b => b.Price);
        var mostExpensiveItem = basket.OrderByDescending(b => b.Price).FirstOrDefault();
        
        Console.WriteLine($"\nToplam Sipariş Sayısı: {totalItems}");
        Console.WriteLine($"\nToplam Ciro: {totalRevenue} TL");

        if (mostExpensiveItem != null)
        {
            Console.WriteLine($"En Pahalı Sipariş: {mostExpensiveItem.Name} - {mostExpensiveItem.Price} TL");
        }
    }
}