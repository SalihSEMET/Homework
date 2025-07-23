using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250720_Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] exams = new double[5];
            double resoult = 0;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black; Console.Title = "Not Degerlendirici";
            Console.WriteLine("-----*** Sınav Durumu Hesaplama Uygulaması ***-----");
            Console.WriteLine("\n| Uygulama Not Ortalamanıza Göre Geçip/Kaldınızı Söylüycek |"); 
            for (int i = 0; i < exams.Length; i++)
            {
                Console.WriteLine();
                Console.Write($"{i + 1}.Sınav Notunuzu Giriniz(0-100):");
                exams[i] = Convert.ToDouble(Console.ReadLine());
                resoult += exams[i];
            }
            Console.Write("\nDevam Etmek İçin Enter a Basınız..."); Console.ReadLine();
            if(resoult / 5 > 50)
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"Ortalamanız:{resoult / 5} Buna Göre Geçtiniz");
                Console.WriteLine("---------------------------------------------");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"Ortalamanız:{resoult / 5} Buna Göre Kaldınız");
                Console.WriteLine("---------------------------------------------");
            }
            Console.Write("\nProgramı Kapatmak İçin Enter a Basınız..."); Console.ReadLine(); Console.Beep();
        }
    }
}
