using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not_Durumu_Değerlendirici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Not Değerlendiricisi";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|       -----***NOT DEGERLENDİRİCİ***-----       |");
            Console.WriteLine("---Not a Göre Sınıflandırma İşlemi Yapılıcaktır---");
            Console.Write("|   -------- Lütfen Notunuzu Giriniz --------    |:");
            double exam = double.Parse(Console.ReadLine());
            string resoult = exam <= 59 ? "Kaldınız" : exam >= 60 && exam <= 74 ? "Geçtiniz Ama Biraz Daha Çalışırsanız İyi Olur" : exam >= 75 && exam <= 89 ? "Notunuz Gayet İyi" : exam >= 90 ? "Mükemmel Bir Not" : "Yanlış Veri Girdiniz";
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($"Notunuz :{exam} Buna Göre {resoult}");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Kapatmak İçin Enter a Basınız...");
            Console.Read();
        }
    }
}
