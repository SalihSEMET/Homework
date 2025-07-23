using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250720_Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Sayının Karesinin Tablosu";
            Console.WriteLine("-----*** Sayının Karesinin Tablosu Uygulaması ***-----");
            Console.WriteLine("\n| Program Yazdıgınız Altı Tane Sayının Hepsinin Karesini Alarak Ekrana Yazdırır |");
            int[] numbers = new int[6];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine();
                Console.Write($"{i + 1 }. Sayı Gir:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nOnaylamak İçin Enter a Basınız..."); Console.ReadLine(); Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} x {numbers[i]} = {numbers[i] * numbers[i]}");
            }
            Console.WriteLine("------------------------------------------------------------------------");
            Console.Write("\nProgramı Kapatmak İçin Enter a Basınız..."); Console.ReadLine(); Console.Beep();
        }
    }
}
