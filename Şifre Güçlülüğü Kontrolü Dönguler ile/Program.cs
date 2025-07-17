using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şifre_Güçlülüğü_Kontrolü_Dönguler_ile
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
            bool hasMinumumLenght = password.Length >= 8, hasUppercase = false, hasDigit = false;
            foreach(char character in password)
            {
                if (char.IsUpper(character))
                    hasUppercase = true;
                if (char.IsDigit(character))
                    hasDigit = true;
            }
            string resoult = hasMinumumLenght && hasUppercase && hasDigit == true ? "Güçlü Şifre" : "Zayıf Şifre";
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine(resoult);
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Kapatmak İçin Enter a Basınız...");
            Console.Read();


        }
    }
}
