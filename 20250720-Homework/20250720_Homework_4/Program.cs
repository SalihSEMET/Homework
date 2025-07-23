using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250720_Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black; Console.Title = "Pozitif ve Negatif Sayı Adedi Hesaplama";
            Console.WriteLine("-----*** Diziden Pozitif ve Negatif Sayı Adedi Bulma ***-----");
            Console.WriteLine("\n|Program Dizideki Sayıların Pozitif Yada Negatif Oldugunu Anlar Ve Adetlerini Yazdırır|");
            int positivenumber= 0, negativenumber = 0;
            int[] numbers = { -1, 2, -3, 4, -5, 6, -7, 8, -9, 10 ,11};
            Console.Write("\nDiziyi Yazdırmak İçin Enter a Basınız..."); Console.ReadLine(); Console.Clear();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"{i + 1}.Sayı:{numbers[i]}");
            }
            Console.WriteLine();
            Console.Write("Pozitif Ve Negatif Adedini Görmek İçin Enter a Basınız..."); Console.ReadLine(); Console.Clear();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    positivenumber++;
                }
                else
                {
                    negativenumber++;
                }
            } 
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($" |Pozitif Sayı Adedi:{positivenumber} & Negatif Sayı Adedi:{negativenumber} |");
            Console.WriteLine("----------------------------------------------------------");
            Console.Write("\nProgramı Kapatmak İçin Enter a Basınız..."); Console.Read(); Console.Beep();
            Console.ReadLine();
        }
    }
}
