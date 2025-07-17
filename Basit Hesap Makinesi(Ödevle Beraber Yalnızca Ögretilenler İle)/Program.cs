using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basit_Hesap_Makinesi_Ödevle_Beraber_Yalnızca_Ögretilenler_İle_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Title = "Hesap Makinesi-ÖDEV-";
            Console.WriteLine(" -----***Hesap Makinesine Hoşgeldiniz***----- ");
            Console.WriteLine("|             *****İşlemler*****             |");
            Console.WriteLine("||| Toplama İçin=> (+) | Çıkarma İçin=> (-) | Çarpma İçin=> (*) | Bölme İçin=> (/) |||");
            Console.Write("Lütfen Yapmak İstediğiniz İşlemi Seçiniz:");
            string işlemtürü = Console.ReadLine();
            Console.Clear();
            double sayı1, sayı2;
            Console.Write("Lütfen Birinci Sayıyı Giriniz:");
            sayı1 = double.Parse(Console.ReadLine());
            Console.Write("Lütfen İkinci Sayıyı Giriniz:");
            sayı2 = double.Parse(Console.ReadLine());
            
            switch (işlemtürü)
            {
                case "+":
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine($"Sonuç:{sayı1 + sayı2} ");
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.Write("Kapatmak İçin Enter a Basın...");
                        break;
                case "-":
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine($"Sonuç:{sayı1 - sayı2} ");
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.Write("Kapatmak İçin Enter a Basın...");
                    break;
                case "*":
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine($"Sonuç:{sayı1 * sayı2} ");
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.Write("Kapatmak İçin Enter a Basın...");
                    break;
                case "/":
                    Console.Clear();
                    if (sayı2 != 0)
                    {
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine($"Sonuç:{sayı1 * sayı2} ");
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.Write("Kapatmak İçin Enter a Basın...");
                    }
                    else
                    {
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine("Sıfıra Bölünmez");
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.Write("Kapatmak İçin Enter a Basın...");
                    }
                        break;
            }
        
            Console.ReadLine();
        }
    }
}
