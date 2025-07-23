using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giriş_Kontrol_Sistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black; string username, password;
            Console.WriteLine("-----***Giriş Kontrol Sistemi***-----");
            Console.Write("Lütfen Giriş Yapın| Kullanıcı Adı:"); username = Console.ReadLine();
            if(username == "admin")
            {
                Console.Clear();
                Console.Write("Lütfen Şifrenizi Giriniz:"); password = Console.ReadLine();
                if (password == "1234")
                {
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Giriş Başarılı");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Programı Kapatmak İçin Enter a Basınız...");
                }
                else
                {
                    Console.WriteLine("\aYanlış Şifre");
                    Console.WriteLine("Programı Kapatmak İçin Enter a Basınız...");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Yanlış Kullanıcı Adı");
                Console.WriteLine("Programı Kapatmak İçin Enter a Basınız...");
            }
            Console.Read();
        }
    }
}
