using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202507_Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black; Console.Title = "Sayı Karşılaştırma";
            double[] numbers = new double[5];
            Console.WriteLine("-----***Sayı Karşılaştırma Uygulaması***-----");
            Console.WriteLine("\n--------5 Sayı Alınıcak Ve Bu Sayılar Arasında En Buyuk Ve Kucuk olanları Ekrana Yazırıcak--------");
            Console.Write("\nDevam Etmek İçin Enter a Bas..."); Console.ReadLine(); Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i+1}. Sayıyı Giriniz:");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
            }
            Console.Clear();
            double maxnumber = numbers[0], minnumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxnumber)
                {
                    maxnumber = numbers[i];
                }
                if (numbers[i] < minnumber)
                {
                    minnumber = numbers[i];
                }
            }
            double difference = maxnumber - minnumber;
            Console.WriteLine($"------------------------------------------------------------------");
            Console.WriteLine($"|En Büyük Sayı:{maxnumber} => En Küçük Sayı:{minnumber} => Aradaki Fark:{difference}|");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.Write("\nProgramı Kapatmak İçin Enter a Basınız...");
            Console.ReadLine();
            Console.Beep();
        }
    }
}
