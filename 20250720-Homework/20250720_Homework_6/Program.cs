using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250720_Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black; Console.Title = "Şehir Baş Harfi";
            Console.WriteLine("-----*** Şehir Baş Harfi Uygulaması ***-----");
            Console.WriteLine("\n| *** Yazdıgınız Şehir Adının Baş Hafi Alınıp Yazdırılır *** |");
            string[] citys = new string[4];
            char[] firstLetters = new char[citys.Length];
            Console.Write("\nDevam Etmek İçin Enter a Basınız..."); Console.ReadLine(); Console.Clear();
            for (int i = 0; i < citys.Length; i++)
            {
                Console.Write($"{i + 1}. Şehri Girin:");
                citys[i] = Console.ReadLine();

                if (!string.IsNullOrEmpty(citys[i])) //Boş Olup Olmadıgı Kontrol Edilir Eger Boş Değilse(!) Kod Blogu Çalışır
                {
                    firstLetters[i] = citys[i][0];
                }
                else
                    firstLetters[i] = '-'; // Boş Giriş İçin Varsayılan Karakter
            }
            Console.Clear();
            Console.Write("Baş Harfleri Görmek İçin Enter a Bas..."); Console.ReadLine(); Console.Clear();
            for (int i = 0; i < firstLetters.Length; i++)
            {
                Console.WriteLine($"{i + 1}. Şehrin Baş Harfi:{firstLetters[i]}");
                Console.WriteLine();
            }
            Console.Write("Kapatmak İçin Enter a Bas...");
            Console.ReadLine(); Console.Beep();
            

        }
    }
}
