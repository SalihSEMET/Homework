using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giyinme_Tavsiyesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "***GİYİNME TAVSİYE***";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("|     ***Giyinme Tavsiyesine Hoşgeldiniz***         |");
            Console.WriteLine("-----Sıcaklıga Göre Kıyafet Önerisi Yapılıcaktır-----");
            Console.Write("|  Lütfen Hava Sıcaklıgını Girin(Celcius Cinsinden)| :");
            double temperature = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            string resoult = temperature <= 4 ? "Kalın Mont" : temperature >= 5 && temperature <= 14 ? "Sweatshirt" : temperature >= 15 && temperature <= 24 ? "Tişört" : temperature >= 25 ? "Şort" : "Geçersiz Sıcaklık Degeri";
            Console.WriteLine($"{temperature} Santigrat Dereceye Göre {resoult} Giymeni Tavsiye Ederiz.");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.Write("Kapatmak İçin Enter a Basınız...");
            Console.Read();
        }
    }
}
