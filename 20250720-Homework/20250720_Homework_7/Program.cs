using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250720_Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black; Console.Title = "Dizideki Sayıların Pozitif Negatif Yada Sıfır Olma Durumu";
            Console.WriteLine("-----*** Sayı Durmu Gösterme Uygulaması ***-----");
            Console.WriteLine("\n| Program Sayıları Pozitif-Negatif-Sıfır Oldugunu Anlar ve Yadırır |");
            double[] numbers = new double[] { 1, 2, 3, 4, 5, 0, -1, -2, -3, -4, -5 };
            Console.Write("\nDizideki Sayıları Görmek İçin Enter a Basınız..."); Console.ReadLine(); Console.Clear();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Sayılar {numbers[i]}");
                if (numbers[i] == -5)
                {
                    Console.Write("\nDevam Etmek İçin Enter a Basınız..."); Console.ReadLine();
                }
            }
            Console.Clear();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine();
                if (numbers[i] > 0)
                {
                    Console.WriteLine($"| {numbers[i]} Sayısı Sıfırdan Buyuk Ve Pozitiftir |");
                }
                else if (numbers[i] < 0)
                {
                    Console.WriteLine($"| {numbers[i]} Sayısı Sıfırdan Küçük Ve Negatftir |");
                }
                else
                {
                    Console.WriteLine($"| {numbers[i]} Sayısı Sıfıra Eşittir |");
                }
            }
            Console.Write("\nKapatmak İçin Enter a Basınız..."); Console.ReadLine(); Console.Beep();
        }
    }
}
