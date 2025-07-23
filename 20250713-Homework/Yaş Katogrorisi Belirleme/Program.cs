using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaş_Katogrorisi_Belirleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black; Console.Title = "Yaş Kategorisi";
            Console.WriteLine("-----***Yaş Katogarisi Belirleme Uygulamasına Hoşgeldiniz***-----"); int age;
            Console.Write("Lütfen Yaşınızı Giriniz:"); age = int.Parse(Console.ReadLine());
            string resoult = age>=0 && age<=3 ? "Bebeksiniz":age >= 4 && age <= 12 ? "Çocuksunuz" : age >= 13 && age <= 17 ? "Gençsiniz" : age >= 18 && age <= 59 ? "Yetişkinsiniz" : age >= 60 ? "Yaşlısınız" : "Yanlış Yaş Bilğisi";
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine($"|                  Yaşınız:{age} Buna Göre :{resoult}                  |");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Kapatmak İçin Enter a Basınız..."); Console.Read();
            

        }
    }
}
