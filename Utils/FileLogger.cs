namespace SolidCafe.Utils;

// Bu sınıf, ILogger Interface'ini implement eder ve mesajları bir dosyaya yazar.
public class FileLogger : ILogger
{
    private readonly string _logFilePath = "log.txt";

    public void Log(string message)
    {
        var logEntry = $"[FILE-LOG] {DateTime.Now}: {message}";
        File.AppendAllText(_logFilePath, logEntry + Environment.NewLine);
    }
}