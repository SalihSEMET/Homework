using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250720_Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Sayı Uygulaması";
            double[] numbers = new double[1];
            double[] konteyner = new double[1];
            double evennumbers = 0, oddnumbers = 0;
            Console.WriteLine("-----***Sayı Uygulamasına Hoşgeldiniz***-----");
            Console.WriteLine("\n| Yazdıgınız Sayıların Çift Olanları Toplanıp Tek olanların İse Adet Sayısı Yazdırılıcaktır |");
            Console.Write("\nDevam Etmek İçin Enter a Basınız..."); Console.ReadLine(); Console.Clear();
            while (true)
            {
                Console.Write("Sayıları Gir(Görüntülemek İçin (0)):");
                double login = Convert.ToDouble(Console.ReadLine());
                if(login == 0)
                {
                   Console.Clear();
                   Console.WriteLine("----------------------------------------------------");
                   Console.WriteLine($"Çift Sayıların Toplamı:{evennumbers}");
                   Console.WriteLine($"Tek Sayıların Adedi:{oddnumbers}");
                   Console.WriteLine("----------------------------------------------------");
                   Console.Write("\nÇıkmak İçin Enter a Basınız...");
                   Console.ReadLine();
                    Console.Beep();
                        break;
                }
                else
                {
                    numbers[numbers.Length - 1] = login;
                    if(login % 2 == 0)
                    {
                        evennumbers += login;
                    }
                    else
                    {
                        oddnumbers++;
                    }
                     for (int i = 0; i < numbers.Length; i++)
                     {
                        konteyner[i] = numbers[i];
                     }
                    numbers = new double[numbers.Length + 1];

                    for (int i = 0; i < konteyner.Length; i++)
                    {
                        numbers[i] = konteyner[i];
                    }
                    konteyner = new double[konteyner.Length + 1];
                    Console.WriteLine();
                }
                
            }

        }
    }
}
