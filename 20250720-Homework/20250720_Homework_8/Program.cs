using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250720_Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black; Console.Title = "Gün Numaralandırma Ve Yazdırma";
            Console.WriteLine("-----*** Gün Numarasına Göre Gün Adını Yazdırma Uygulaması ***-----");
            Console.WriteLine("\n| Günün Numarasını Kullanıcıdan Alır Ve o Numaraya Göre Günün Adını Söyler |");
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.Write("\nDevam Etmek İçin Enter a Basınız..."); Console.ReadLine(); Console.Clear();
            Console.Write("Pazartesi=>1 Den Pazar=>7 Olmak Üzere Bulundugunuz Günün Numarasını Girin:"); 
                switch(numbers[(Convert.ToInt16(Console.ReadLine())) - 1])
                {
                    case 1:
                    Console.Clear();
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("|            Bugun Günlerden Pazartesi            |");
                    Console.WriteLine("---------------------------------------------------");
                        break;
                    case 2:
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("|              Bugun Günlerden Salı              |");
                    Console.WriteLine("--------------------------------------------------");
                    break;
                    case 3:
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("|             Bugün Günlerden Çarşamba           |");
                    Console.WriteLine("--------------------------------------------------");
                    break;
                    case 4:
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("|            Bugün Günlerden Perşembe            |");
                    Console.WriteLine("--------------------------------------------------");
                    break;
                    case 5:
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("|              Bugün Günlerden Cuma              |");
                    Console.WriteLine("--------------------------------------------------");
                    break;
                    case 6:
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("|            Bugün Günlerden Cumartesi           |");
                    Console.WriteLine("--------------------------------------------------");
                    break;

                    case 7:
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("|              Bugün Günlerden Pazar             |");
                    Console.WriteLine("--------------------------------------------------");
                    break;
            }
            Console.Write("\nProgramı Kapatmak İçin Enter a Basınız..."); Console.ReadLine(); Console.Beep();






        }
    }
}
