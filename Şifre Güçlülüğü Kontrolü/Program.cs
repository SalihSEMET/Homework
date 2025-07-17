using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şifre_Güçlülüğü_Kontrolü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green; Console.Title = "Şifre Güçlülüğü Kontrolü";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-----*** Şifre Kontrol Mekanizması ***-----");
            Console.WriteLine("Bu Uygulama Sizin Şifrenizin Güçlü Olup Olmadıgını Ölçücek");
            Console.Write("Lütfen Şifrenizi Giriniz:"); string password = Console.ReadLine();
            bool hasMinumumLenght = password.Length >= 8;
            bool hasUppercase = password.Any(char.IsUpper);//Any koleksiyondaki bir öge bıle kosulu saglarsa true yapar. //IsUpper ise Karakterin Buyuk Harf Olup Olmadıgını Kontrol eder.
            bool hasDigit = password.Any(char.IsDigit); //Amaç Şifrede en az bir rakam Olup Olmadıgını Kontrol Etmek char.IsDigit ise karakterın rakam olup olmadıgını Kontrol eder.
            string resoult = hasMinumumLenght && hasUppercase && hasDigit == true ? "Güçlü Şifre" : "Zayıf Şifre";
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine(resoult);
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Kapatmak İçin Enter a Basınız..."); Console.Read();
        }
    }
}
