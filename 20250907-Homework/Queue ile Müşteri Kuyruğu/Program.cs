using System;
using System.Collections.Generic;
using System.Threading;

namespace Homework
{
 class Program
{
    static Queue<string> customerQueue = new Queue<string>();
    static Random randomizer = new Random();

    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
        Console.Title = "Queue ile Müşteri Kuyruğu";
        Console.ForegroundColor = ConsoleColor.White;
        customerQueue.Enqueue("Recep Tayip Erdogan");
        customerQueue.Enqueue("Kemal Kılıçdaroğlu");
        customerQueue.Enqueue("Mansur Yavaş");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Banka Simülasyonuna Hoş Geldiniz!");
            Console.WriteLine("=================================");
            DisplayQueue();
            Console.WriteLine("\nLütfen bir işlem seçin:");
            Console.WriteLine("1. Sıra Al");
            Console.WriteLine("2. Sıraya Müşteri Ekle");
            Console.WriteLine("3. Çıkış");
            Console.Write("Seçiminiz: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    TakeNumberAndWait();
                    return;
                case "2":
                    AddCustomerToQueue();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }

    static void TakeNumberAndWait()
    {
        Console.Clear();
        Console.Write("Sıraya girmek için lütfen adınızı ve soyadınızı yazın: ");
        string userName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(userName))
        {
            userName = "İsimsiz Müşteri";
        }

        customerQueue.Enqueue(userName);
        Console.Clear();
        Console.WriteLine($"Sıraya eklendiniz. Önünüzde {customerQueue.Count - 1} kişi var.");
        Console.WriteLine("İşlemler başlıyor...");
        Thread.Sleep(3000);

        while (customerQueue.Peek() != userName)
        {
            string currentCustomer = customerQueue.Dequeue();
            int processingTime = randomizer.Next(20, 50);

            for (int i = processingTime; i > 0; i--)
            {
                bool isDisplayTime = (i <= 10) || (i % 10 == 0);

                if (isDisplayTime)
                {
                    Console.Clear();
                    Console.WriteLine($"ŞU ANKİ MÜŞTERİ: {currentCustomer}");
                    Console.WriteLine($"Sırada Bekleyen Toplam Kişi: {customerQueue.Count}");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine($"\n>> İşlemin bitmesine kalan süre: {i} saniye <<");
                    Console.WriteLine("\n--- KUYRUKTAKİLER ---");
                    DisplayQueue(userName, false);
                }
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine($"{currentCustomer} adlı müşterinin işlemi tamamlandı!");
            Thread.Sleep(2500);
        }

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("********************");
        Console.WriteLine($"* {userName},");
        Console.WriteLine("* Sıra size geldi! *");
        Console.WriteLine("********************");
        Console.ResetColor();
        Thread.Sleep(4000);
    }

    static void AddCustomerToQueue()
    {
        Console.Clear();
        Console.Write("Eklenecek müşterinin adını ve soyadını girin: ");
        string newCustomerName = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(newCustomerName))
        {
            customerQueue.Enqueue(newCustomerName);
            Console.WriteLine($"\n'{newCustomerName}' başarıyla sıraya eklendi.");
        }
        else
        {
            Console.WriteLine("\nGeçersiz isim girdiniz.");
        }
        Console.WriteLine("\nAna menüye dönmek için bir tuşa basın...");
        Console.ReadKey();
    }

    static void DisplayQueue(string highlightName = "", bool showHeader = true)
    {
        if (showHeader)
        {
            Console.WriteLine($"\nGüncel Kuyruk (Toplam {customerQueue.Count} kişi):");
        }

        if (customerQueue.Count == 0)
        {
            Console.WriteLine("Kuyrukta kimse yok.");
        }
        else
        {
            int queueNumber = 1;
            foreach (var customer in customerQueue)
            {
                if (!string.IsNullOrWhiteSpace(highlightName) && customer == highlightName)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{queueNumber}. -> {customer}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"{queueNumber}. {customer}");
                }
                queueNumber++;
            }
        }
    }
}   
}