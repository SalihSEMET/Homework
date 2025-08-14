using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Yemek_Sipariş_Uygulaması_
{
    class Menü
    {
        public string[,,] Yemekler = {
        {
            { "Hamburger", "1200kcal", "370TL", "15dk" },
            { "Pizza", "1000kcal", "250TL", "20dk" }
        },
        {
            { "Zurna Dürüm", "1300kcal", "250TL", "10dk" },
            { "Beyti", "800kcal", "500TL", "25dk" }
        }
    };
    }
    internal class Program
    {
        static ConsoleKey KarşılamaEkranı()
        {
            while (true)
            {
                Console.WriteLine("----- *** Yemek-Kapında Uygulamasına Hoşğeldiniz *** -----");
                Console.WriteLine("|Ürünlerle İlğili Kalori,Fiyat,Hazırlanma Süresi İçin BackSpace e|");
                Console.WriteLine("|                Satın Alma Ekranı İçin Enter a                  |");
                Console.WriteLine("|                Uygulamadan Çıkmak İçin ESC ye                  |");
                Console.Write("|Basınız...|"); 
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        return ConsoleKey.Enter;
                    case ConsoleKey.Backspace:
                        Console.Clear();
                        return ConsoleKey.Backspace;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.WriteLine("Uygulamadan Çıkılıyor..."); Thread.Sleep(2000); Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Yanlış Girdiniz Lütfen Tekrar Deneyin..."); Thread.Sleep(1000);
                        Console.Clear();
                        break;
                }
                continue;
            }
        }
        static void Yönlendirici(ConsoleKey key, string[,,] strings)
        {
            switch (key)
            {
                case ConsoleKey.Enter:
                    HazırlamaEkranı(SatınAlmaEkranı());
                    break;
                case ConsoleKey.Backspace:
                    ÜrünleriYazdır(strings);
                    break;
            }
        }
        static void ÜrünleriYazdır(string[,,] strings)
        {
                Console.WriteLine(new string('-', 75));

                int x = strings.GetLength(0);
                int y = strings.GetLength(1);
                int z = strings.GetLength(2);

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write($"{i * y + j + 1}. Yemek: ");
                        for (int k = 0; k < z; k++)
                        {
                            Console.Write($"{strings[i, j, k]} ");
                        }
                        Console.WriteLine();
                    }
                }
            Console.Write("|Geri Dönmek İçin Herhangi Bir Tuşa Basınız...|"); Console.ReadLine(); Console.Clear();
            Console.WriteLine("Geri Dönülüyor..."); Thread.Sleep(2000); Console.Clear(); KarşılamaEkranı();
        }
        static int SatınAlmaEkranı()
        {
            while (true)
            {
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("---------      Ne Sipariş Etmek İstersiniz       ---------");
                Console.WriteLine("---------              1-Hamburger               ---------");
                Console.WriteLine("---------                2-Pizza                 ---------");
                Console.WriteLine("---------             3-Zurna Dürüm              ---------");
                Console.WriteLine("---------                4-Beyti                 ---------");
                Console.WriteLine(new string('-', 50));
                Console.Write("|--------          Ne Almak İstersiniz           --------|");
                int.TryParse(Console.ReadLine(), out int input);
                if (input == 1 | input == 2 | input == 3 | input == 4)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Yanlış Girdiniz Lütfen Tekrar Deneyin..."); Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }
            }
        }
        static void HazırlamaEkranı(int number)
        {
            switch (number)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Hamburger Hazırlanıyor...");
                    for (int i = 15; i >= 0; i--) // düzeltme: i-- olmalı
                    {
                        Console.WriteLine($"Kalan Süre: {i}"); Thread.Sleep(1000);
                    }
                    Console.Clear();
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine("Hamburger Hazırlandı. 370TL Ödeme Alındı.");
                    Console.WriteLine("Teşekkür Ederiz!");
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine("Ana menüye dönmek için bir tuşa basınız...");
                    Console.ReadKey(); Console.Clear();
                    ConsoleKey key = KarşılamaEkranı();
                    Menü menü = new Menü();
                    Yönlendirici(key, menü.Yemekler);
                                break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Pizza Hazırlanıyor...");
                    for (int i = 20; i >= 0; i--)
                    {
                        Console.WriteLine($"Kalan Süre:{i}"); Thread.Sleep(1000);
                    }
                    Console.Clear();
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine("Pizza Hazırlandı 250Tl Ödeme Alındı");
                    Console.WriteLine("Teşekkür Ederiz");
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine("Ana menüye dönmek için bir tuşa basınız...");
                    Console.ReadKey(); Console.Clear();
                    ConsoleKey key1 = KarşılamaEkranı();
                    Menü menü1 = new Menü();
                    Yönlendirici(key1, menü1.Yemekler);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Zurna Dürüm Hazırlanıyor...");
                    for (int i = 10; i >= 0; i--)
                    {
                        Console.WriteLine($"Kalan Süre:{i}"); Thread.Sleep(1000);
                    }
                    Console.Clear();
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine("Zurna Dürüm Hazırlandı 250 Ödeme Alındı");
                    Console.WriteLine("Teşekkür Ederiz");
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine("Ana menüye dönmek için bir tuşa basınız...");
                    Console.ReadKey(); Console.Clear();
                    ConsoleKey key2 = KarşılamaEkranı();
                    Menü menü2 = new Menü();
                    Yönlendirici(key2, menü2.Yemekler);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Beyti Hazırlanıyor...");
                    for (int i = 25; i >= 0; i--)
                    {
                        Console.WriteLine($"Kalan Süre:{i}"); Thread.Sleep(1000);
                    }
                    Console.Clear();
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine("Beyti Hazırlandı 500Tl Ödeme Alındı");
                    Console.WriteLine("Teşekkür Ederiz");
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine("Ana menüye dönmek için bir tuşa basınız...");
                    Console.ReadKey(); Console.Clear();
                    ConsoleKey key3 = KarşılamaEkranı();
                    Menü menü3 = new Menü();
                    Yönlendirici(key3, menü3.Yemekler);
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black; Console.Title = "Online Yemek Sipariş";
            Menü menü = new Menü();
            ConsoleKey key = KarşılamaEkranı();
            Yönlendirici(key, menü.Yemekler);
        }
    }
}
