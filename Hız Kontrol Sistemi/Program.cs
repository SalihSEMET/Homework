using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hız_Kontrol_Sistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black; Console.Title = "Hız Kontrol Sistemi";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----*** Hız Kontrol Sistemi ***-----");
            Console.WriteLine("|Program Hızınızı Degerlendiricektir|");
            Console.Write("Lütfen Hızınızı Girin:"); int speed = int.Parse(Console.ReadLine());
            string resoult = speed <= 90 ? "Hızınız Güvenli." : speed >= 91 & speed <= 110 ? "Uyarı: Hız Limitine Yaklaştınız." : speed >= 111 ? "Ceza Kesildi! Aşırı hız yaptınız." : "Yanlış Hız Bilğisi";
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine(resoult);
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Kapatmak İçin Enter a Basınız...");
            Console.Read();


        }
    }
}
