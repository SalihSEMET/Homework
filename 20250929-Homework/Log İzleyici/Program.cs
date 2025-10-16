using System;
using System.IO;
using System.Threading;

namespace LoggerApp
{
    public static class LogManager
    {
        private static readonly string logFolderPath;
        private static readonly string logFilePath;

        static LogManager()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            logFolderPath = Path.Combine(baseDirectory, "logs");
            Directory.CreateDirectory(logFolderPath);

            string logFileName = $"{DateTime.Now:yyyy-MM-dd}.log";
            logFilePath = Path.Combine(logFolderPath, logFileName);
        }

        public static void Log(string message)
        {
            try
            {
                string timestamp = DateTime.Now.ToString("HH:mm:ss");
                string logLine = $"[{timestamp}] - {message}{Environment.NewLine}";

                File.AppendAllText(logFilePath, logLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Log Hata Verdi: {ex.Message}");
            }
        }
        
        public static string GetLogFilePath()
        {
            return logFilePath;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loglama Programı Çalışıyor...");

            LogManager.Log("Uygulama Başladı");

            Console.WriteLine("Kullanıcı Bilgileri İşleniyor...");
            LogManager.Log("Kullanıcı 'Admin' Sisteme Giriş Yaptı.");

            Console.WriteLine("Veritabanı İşlemi Simüle Ediliyor...");
            Thread.Sleep(1500);
            LogManager.Log("Veritabanından müşteri Verileri Başarıyla Çekildi.");
            
            LogManager.Log("Uygulama Sonlandırıldı.");

            Console.WriteLine("\nTüm İşlemler Loglandı.");
            Console.WriteLine($"Log Dosyası Konumu: {LogManager.GetLogFilePath()}");
            Console.WriteLine("Programı Kapatmak İçin Herhangi Bir Tuşa Basın.");
            Console.ReadKey();
        }
    }
}