using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250720_Homework_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear(); Console.Title = "Sayı Dizide Mevcut Mu";
            Console.ForegroundColor = ConsoleColor.Green;
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("|-----***Sayı DizideMiBil Uygulamasına Hoşgeldiniz***-----|");
            Console.WriteLine("\n|Uygulama Sizden Bir Sayı Alıcak Bu Sayı Dizide Mevcut Olup  Olmadıgını Yazdırıcak|");
            Console.Write("\n|-_-_-_-_ Devam Etmek İçin Enter a Bas -_-_-_-_|"); Console.ReadLine(); Console.Clear();
            Console.Write("Lütfen Bir Sayı Giriniz:"); int _number = Convert.ToInt32(Console.ReadLine()); bool have =false;
            Console.Clear();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == _number)
                {
                    have = true;
                    break;
                }
                else
                {
                    have = false;
                }
            }
            if (have == true)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"| Sayı: {_number} Dizide Mevcuttur. |");
                Console.WriteLine("------------------------------------");
            }
            else
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Sayı: {_number} Dizide Mevcut Değildir.");
                Console.WriteLine("------------------------------------");
            }
            Console.Write("\nProgramı Kapatmak İçin Enter a Basınız..."); Console.ReadLine(); Console.Beep();
        }
    }
}
