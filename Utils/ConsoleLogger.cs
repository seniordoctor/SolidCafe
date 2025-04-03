namespace SolidCafe.Utils;

// bu sınıf, ILogger Interface'ini implement eder ve mesajları konsola yazar.
public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
    }
}