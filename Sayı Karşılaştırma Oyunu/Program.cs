using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayı_Karşılaştırma_Oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue; Console.Title = "Sayı Karşılaştırma Oyunu";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("----------*** Sayı Karşılaştırma Oyununa Hoşgeldiniz ***----------");
            Console.WriteLine("İki Sayı Alınıcalktır Ve Bu Sayılar Karşılaştırılıcaktır");
            Console.Write("Lütfen İlk Sayıyı Girin:"); double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lütfen İkinci Sayıyı Girin:"); double number2 = Convert.ToDouble(Console.ReadLine());
            string resoult = number1 > number2 ? $"{number1} > {number2} Birinci Sayı Daha Büyüktür" : number2 > number1 ? $"{number2} > {number1} İkinci Sayı Daha Büyüktür" : number1 == number2 ? $"{number1}={number2} Sayılar Eşittir" : "Yanlış Sayı Girişi";
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine(resoult);
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Kapatmak İçin Enter a Basınız..."); Console.Read();
        }
    }
}
