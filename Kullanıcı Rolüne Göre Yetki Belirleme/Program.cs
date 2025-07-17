using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kullanıcı_Rolüne_Göre_Yetki_Belirleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green; Console.Title = "Kullanıcı Rolüne Göre Yetki Belirleme";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-----*** Yetki Belirlemeye Hoşgeldiniz ***-----");
            Console.Write("Lütfen Rolünüzü Giriniz(admin,editor,user) :"); string role = Console.ReadLine();
            string resoult = role == "admin" ? "Tüm Yetkilere Sahipsiniz." : role == "editor" ? "İçerik Düzenliyebilirsiniz." : role == "user" ? "İçerik Görüntüleyebilirsiniz." : "Tanımsız Rol";
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine(resoult);
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Kapatmak İçin Enter a Basınız...");
            Console.Read();
        }
    }
}
