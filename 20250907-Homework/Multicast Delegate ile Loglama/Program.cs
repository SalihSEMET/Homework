namespace Homework
{
public delegate void LogHandler(string message);

public static class Logger
{
    private static readonly string logFileName = "gunluk.log";

    public static void LogToConsole(string message)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"[EKRAN LOG]: {message}");
        Console.ResetColor();
    }

    public static void LogToFile(string message)
    {
        try
        {
            string formattedMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}{Environment.NewLine}";
            File.AppendAllText(logFileName, formattedMessage);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Dosyaya log yazma hatası: {ex.Message}");
            Console.ResetColor();
        }
    }
}

public class ProcessSimulator
{
    public void StartProcess(LogHandler logger)
    {
        logger?.Invoke("İşlem başlıyor...");
        Thread.Sleep(1000);

        logger?.Invoke("Veritabanı bağlantısı kuruluyor...");
        Thread.Sleep(1500);

        logger?.Invoke("Veriler işleniyor...");
        Thread.Sleep(2000);

        logger?.Invoke("İşlem başarıyla tamamlandı.");
    }
}

class Program
{
    static void Main(string[] args)
    {
            Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.Title = "Multicast Delegate İle Loglama";
            Console.ForegroundColor = ConsoleColor.White;
            LogHandler mainLogger = Logger.LogToConsole;
        mainLogger += Logger.LogToFile;

        ProcessSimulator simulator = new ProcessSimulator();

        Console.WriteLine("İşlem simülasyonu başlatılıyor. Ekrana ve 'gunluk.log' dosyasına log atılacak.");
        Console.WriteLine("--------------------------------------------------------------------------");

        simulator.StartProcess(mainLogger);

        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("Simülasyon tamamlandı. 'gunluk.log' dosyasının içeriğini kontrol edebilirsiniz.");
        
        string fullPath = Path.GetFullPath("gunluk.log");
        Console.WriteLine($"Dosya Yolu: {fullPath}");
    }
}
}