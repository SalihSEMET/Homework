using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Günlük
{
    public class GunlukEntry
    {
        public DateTime Date { get; set; }
        public string Content { get; set; }
    }

    class Program
    {
        static List<GunlukEntry> diaries = new List<GunlukEntry>();
        static string UserName = "";

        static void Main()
        {
            ShowSignUpScreen();

            while (true)
            {
                MainMenu();
            }
        }

        static void ShowSignUpScreen()
        {
            Console.WriteLine("*** Uygulamaya Lütfen Kayıt Olunuz ***");
            
            string name = "";
            while (string.IsNullOrEmpty(name))
            {
                Console.Write("Lütfen Adınızı Giriniz: ");
                name = Console.ReadLine();
            }

            string surname = "";
            while (string.IsNullOrEmpty(surname))
            {
                 Console.Write("Lütfen Soyadınızı Giriniz: ");
                 surname = Console.ReadLine();
            }

            UserName = $"{name} {surname}";
            
            Console.Clear();
            Console.WriteLine($"Hoş geldin {UserName}!");
            Console.Write("Lütfen bugün için olan ilk günlüğünüzü yazınız (Bittiğinde Enter'a basınız): ");
            string The_Firstparagraph = Console.ReadLine();

            var newEntry = new GunlukEntry
            {
                Date = DateTime.Now,
                Content = The_Firstparagraph
            };
            diaries.Add(newEntry);

            Console.Clear();
            Console.WriteLine("----- *** İlk Günlüğünüz Başarıyla Oluşturuldu *** -----");
            Console.WriteLine($"Tarih: {newEntry.Date:D}");
            Console.WriteLine($"İçerik: {newEntry.Content}");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.Write("\n\nOnaylamak ve Ana Menüye gitmek için herhangi bir tuşa basınız...");
            Console.ReadKey();
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine($"--- GÜNLÜK UYGULAMASI | {UserName} ---");
            Console.WriteLine("1. Yeni Günlük Ekle");
            Console.WriteLine("2. Tüm Günlükleri Görüntüle");
            Console.WriteLine("3. Çıkış");
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");

            string choose = Console.ReadLine();

            switch (choose)
            {
                case "1":
                    AddNewEntry();
                    break;
                case "2":
                    ViewAllEntries();
                    break;
                case "3":
                    Console.WriteLine("Uygulamadan çıkılıyor...");
                    Thread.Sleep(1000);
                    Environment.Exit(0);

                    break;
                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    Thread.Sleep(1500);
                    break;
            }
        }

        static void AddNewEntry()
        {
            Console.Clear();
            Console.WriteLine("--- YENİ GÜNLÜK EKLEME ---");
            Console.Write("Bugünkü günlüğünüzü yazın: ");
            string paragraph = Console.ReadLine();

            var newEntry = new GunlukEntry
            {
                Date = DateTime.Now,
                Content = paragraph
            };
            diaries.Add(newEntry);

            Console.WriteLine("\nGünlüğünüz başarıyla eklendi!");
            Console.Write("Ana menüye dönmek için bir tuşa basın...");
            Console.ReadKey();
        }

        static void ViewAllEntries()
        {
            Console.Clear();
            Console.WriteLine("--- TÜM GÜNLÜKLERİNİZ ---");

            if (diaries.Count == 0)
            {
                Console.WriteLine("Henüz hiç günlük yazmamışsınız.");
            }
            else
            {
                var sequentialDays = diaries.OrderByDescending(entry => entry.Date);

                foreach (var entry in sequentialDays)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine($"Tarih: {entry.Date:dd.MM.yyyy HH:mm}");
                    Console.WriteLine($"İçerik: {entry.Content}");
                }
                 Console.WriteLine("------------------------------------------");
            }

            Console.Write("\nAna menüye dönmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}