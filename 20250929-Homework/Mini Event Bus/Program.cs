using System;
using System.IO;
using System.Threading;

namespace EventBusDemo
{
    public class NewsAgency
    {
        public event Action<string> NewNewsPublished;

        public void PublishNews(string news)
        {
            Console.WriteLine($"\n--- HABER AJANSI YENİ BİR HABER YAYINLIYOR: '{news}' ---");
            Thread.Sleep(1000);
            NewNewsPublished?.Invoke(news);
        }
    }

    public class ScreenSubscriber
    {
        public void WriteNewsToScreen(string newsText)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"[EKRAN BİLDİRİMİ]: {newsText}");
            Console.ResetColor();
        }
    }

    public class FileSubscriber
    {
        private readonly string _filePath = "news_archive.log";

        public void SaveNewsToFile(string newsText)
        {
            string logEntry = $"[{DateTime.Now:G}] - {newsText}{Environment.NewLine}";
            File.AppendAllText(_filePath, logEntry);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[DOSYA KAYDI]: Haber '{_filePath}' Dosyasına Kaydedildi.");
            Console.ResetColor();
        }
    }

    public class EmailSubscriber
    {
        public void SendEmail(string newsText)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[E-MAIL GÖNDERİMİ]: '{newsText}' Haberi Tüm Abonelere E-mail Olarak Gönderiliyor...");
            Console.ResetColor();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var newsAgency = new NewsAgency();
            var screenSubscriber = new ScreenSubscriber();
            var fileSubscriber = new FileSubscriber();
            var emailSubscriber = new EmailSubscriber();

            Console.WriteLine("Aboneler Haber Ajansına Kaydoluyor...");
            newsAgency.NewNewsPublished += screenSubscriber.WriteNewsToScreen;
            newsAgency.NewNewsPublished += fileSubscriber.SaveNewsToFile;
            newsAgency.NewNewsPublished += emailSubscriber.SendEmail;
            Console.WriteLine("Kayıt Tamamlandı.\n");
            
            newsAgency.PublishNews("Giresun'da Fındık Rekoltesi Beklentileri Aştı.");
            newsAgency.PublishNews("Türkiye, Teknoloji İhracatında Yeni Bir Rekora İmza Attı.");

            Console.WriteLine("\n--- Dosya Abonesi abonelikten ayrılıyor... ---\n");
            newsAgency.NewNewsPublished -= fileSubscriber.SaveNewsToFile;

            newsAgency.PublishNews("Ay'da Yeni Bir Mineral Keşfedildi.");

            Console.WriteLine("\nProgram bitti.");
            Console.ReadKey();
        }
    }
}