using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Günlere_Özel_Mesaj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Günlere Özel Mesaj";
            Console.WriteLine("-----***Günlere Özel Mesaj Uygyulamamıza Hoşgeldiniz***-----");
            Console.Write("Lütfe Bulundugunuz Haftanın Gününü (Pazartesi-1 Salı-2 Cuma-5 vb) girin:");
            int daynumber = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (daynumber)
            {
                case 1:
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("Buğün Pazartesi");
                    Console.WriteLine("---------------------------------------------------------------------");
                    break;
                case 2:
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("Bugun Salı");
                    Console.WriteLine("---------------------------------------------------------------------");
                    break;
                case 3:
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("Bugun Çarşamba");
                    Console.WriteLine("---------------------------------------------------------------------");
                    break;
                case 4:
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("Bugun Perşembe");
                    Console.WriteLine("---------------------------------------------------------------------");
                    break;
                case 5:
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("Bugun Cuma");
                    Console.WriteLine("---------------------------------------------------------------------");
                    break;
                case 6:
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("Bugun Haftasonu Ve Günlerden Cumartesi");
                    Console.WriteLine("---------------------------------------------------------------------");
                    break;
                case 7:
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("Bugun Haftasonu ve Günlerden Pazar");
                    Console.WriteLine("---------------------------------------------------------------------");
                    break;
                default:
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("Yanlış Gün Sayısı Girişi");
                    Console.WriteLine("---------------------------------------------------------------------");
                    break;
            }
            Console.Write("Kapatmak İçin Enter a Basınız...");
            Console.Read();




        }
    }
}
