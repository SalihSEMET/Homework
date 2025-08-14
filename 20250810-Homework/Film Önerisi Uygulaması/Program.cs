using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Film_Önerisi_Uygulaması
{
    internal class Program
    {
        class Filmler
        {
            public string[] korkuFilmleri = { "Dabbe", "Siccin", "Testere" };
            public string[] aksiyonFilmleri = { "Görevimiz Tehlike", "İnception(Başlangıç)", "Avatar" };
            public string[] dramFilmerli = { "Esaretin Bedeli", "Prestij", "Dövüş Kulubü" };
            public string[] komediFilmleri = { "Recep İvedik", "Kolpaçino", "The Hangover" };
            public string[] izlenicekfilmtürü = new string[3];
            public string[] izlenecekfilmruhhalinegöre = new string[2];
            public string[] izlenecekfilm = new string[1];

        }
        static string TürSeçici(Filmler filmler)
        {
            string tür = null;
            while (true)
            {
                Console.Write("Hangi Türde Film İzlemek İstersiniz(Korku,Aksiyon,Dram,Komedi):");
                tür = Console.ReadLine().ToLower();
                if (tür == "korku" || tür == "aksiyon" || tür == "dram" || tür == "komedi")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Yanluş Tür Girdiniz Tekrar Deneyin...");
                }
            }
            switch (tür)
            {
                case "korku":
                    for (int i = 0; i < 3; i++)
                    {
                        filmler.izlenicekfilmtürü[i] = filmler.korkuFilmleri[i];
                    }

                    break;
                case "aksiyon":
                    for (int i = 0; i < 3; i++)
                    {
                        filmler.izlenicekfilmtürü[i] = filmler.aksiyonFilmleri[i];
                    }

                    break;
                case "dram":
                    for (int i = 0; i < 3; i++)
                    {
                        filmler.izlenicekfilmtürü[i] = filmler.dramFilmerli[i];
                    }

                    break;
                case "komedi":
                    for (int i = 0; i < 3; i++)
                    {
                        filmler.izlenicekfilmtürü[i] = filmler.komediFilmleri[i];
                    }

                    break;
            }
            return tür;
        }
        static string RuhhalineGöreEşleştirme(Filmler filmler,string tür)
        {
            Console.Write("Ruh Haliniz Nasıl(Mutlu,Heyecanlı,Üzgün):");
            string ruhhali = Console.ReadLine().ToLower();
            switch (ruhhali)
            {
                case "mutlu":
                    if (tür == "korku")
                    {
                        filmler.izlenecekfilmruhhalinegöre = new string[] { "Testere", "Siccin" };
                    }
                    else if (tür == "aksiyon")
                    {
                        filmler.izlenecekfilmruhhalinegöre = new string[] { "İnception(Başlangıç)", "Avatar" };
                    }
                    else if (tür == "dram")
                    {
                        filmler.izlenecekfilmruhhalinegöre = new string[] { "Prestij", "Dövüş Kulubü" };
                    }
                    else if (tür == "komedi")
                    {
                        filmler.izlenecekfilmruhhalinegöre = new string[] { "Recep İvedik", "Kolpaçino" };
                    }
                    break;
                case "heycanlı":
                    if (tür == "korku")
                    {
                        filmler.izlenecekfilmruhhalinegöre = new string[] { "Testere", "Dabbe" };
                    }
                    else if (tür == "aksiyon")
                    {
                        filmler.izlenecekfilmruhhalinegöre = new string[] { "İnception(Başlangıç)", "Görevimiz Tehlike" };
                    }
                    else if (tür == "dram")
                    {
                        filmler.izlenecekfilmruhhalinegöre = new string[] { "Prestij", "Esaretin Bedeli" };
                    }
                    else if (tür == "komedi")
                    {
                        filmler.izlenecekfilmruhhalinegöre = new string[] { "Kolpaçino", "The Hangover" };
                    }
                    break;
                case "üzgün":
                    if (tür == "korku")
                    {
                        filmler.izlenecekfilmruhhalinegöre = new string[] { "Siccin", "Dabbe" };
                    }
                    else if (tür == "aksiyon")
                    {
                        filmler.izlenecekfilmruhhalinegöre = new string[] { "Avatar", " Görevimiz Tehlike" };
                    }
                    else if (tür == "dram")
                    {
                        filmler.izlenecekfilmruhhalinegöre = new string[] { "Dövüş Kulubü", "Esaretin Bedeli" };
                    }
                    else if (tür == "komedi")
                    {
                        filmler.izlenecekfilmruhhalinegöre = new string[] { "Recep İvedik", "The Hangover" };
                    }
                    break;
            }
            return ruhhali;
        }
        static void YaşaGöreEşleştime(Filmler filmler , string tür, string ruhhali)
        {
            Console.Clear();
            Console.Write("Lütfen Yaşınızı Giriniz:");
            int yaş = Convert.ToInt32(Console.ReadLine());
            if(yaş < 18)
            {
                switch (ruhhali)
                {
                    case "mutlu":
                        switch (tür)
                        {
                            case "korku":
                                Console.WriteLine("18 Yaşından Altında Olanlar İçin Korku Filmi Önerilmez.");
                                Console.WriteLine("Uygulama Kapatılıyor..."); Thread.Sleep(2000); Environment.Exit(0);
                                break;
                            case "aksiyon":
                                filmler.izlenecekfilm = new string[] { "Avatar" };
                                break;
                            case "dram":
                                filmler.izlenecekfilm = new string[] { "Prestij" };
                                break;
                            case "komedi":
                                filmler.izlenecekfilm = new string[] { "Recep İvedik" };
                                break;
                        }
                        break;
                    case "heyecanlı":
                        switch (tür)
                        {
                            case "korku":
                                Console.WriteLine("18 Yaşından Altında Olanlar İçin Korku Filmi Önerilmez.");
                                Console.WriteLine("Uygulama Kapatılıyor..."); Thread.Sleep(2000); Environment.Exit(0);
                                break;
                            case "aksiyon":
                                filmler.izlenecekfilm = new string[] { "Görevimiz Tehlike" };
                                break;
                            case "dram":
                                filmler.izlenecekfilm = new string[] { "Prestij" };
                                break;
                            case "komedi":
                                filmler.izlenecekfilm = new string[] { "The Hangover" };
                                break;
                        }
                        break;
                    case "üzgün":
                        switch (tür)
                        {
                            case "korku":
                                Console.WriteLine("18 Yaşından Altında Olanlar İçin Korku Filmi Önerilmez.");
                                Console.WriteLine("Uygulama Kapatılıyor..."); Thread.Sleep(2000); Environment.Exit(0);
                                break;
                            case "aksiyon":
                                filmler.izlenecekfilm = new string[] { "Görevimiz Tehlike" };
                                break;
                            case "dram":
                                filmler.izlenecekfilm = new string[] { "Esaretin Bedeli" };
                                break;
                            case "komedi":
                                filmler.izlenecekfilm = new string[] { "Recep İvedik" };
                                break;
                        }
                        break;


                }
            }
            else
            {
                switch (ruhhali)
                {
                    case "mutlu":
                        switch (tür)
                        {
                            case "korku":
                                filmler.izlenecekfilm = new string[] { "Siccin" };
                                break;
                            case "aksiyon":
                                filmler.izlenecekfilm = new string[] { "İnception(Başlangıç)" };
                                break;
                            case "dram":
                                filmler.izlenecekfilm = new string[] { "Dövüş Kulubü" };
                                break;
                            case "komedi":
                                filmler.izlenecekfilm = new string[] { "Kolpaçino" };
                                break;
                        }
                        break;
                    case "heyecanlı":
                        switch (tür)
                        {
                            case "korku":
                                filmler.izlenecekfilm = new string[] { "Testere" };
                                break;
                            case "aksiyon":
                                filmler.izlenecekfilm = new string[] { "Görevimiz Tehlike" };
                                break;
                            case "dram":
                                filmler.izlenecekfilm = new string[] { "Prestij" };
                                break;
                            case "komedi":
                                filmler.izlenecekfilm = new string[] { "The Hangover" };
                                break;
                        }
                        break;
                    case "üzgün":
                        switch (tür)
                        {
                            case "korku":
                                filmler.izlenecekfilm = new string[] { "Dabbe" };
                                break;
                            case "aksiyon":
                                filmler.izlenecekfilm = new string[] { "Avatar" };
                                break;
                            case "dram":
                                filmler.izlenecekfilm = new string[] { "Esaretin Bedeli" };
                                break;
                            case "komedi":
                                filmler.izlenecekfilm = new string[] { "Recep İvedik" };
                                break;
                        }
                        break;
                }
            } 
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black; Console.Title = "Film Öneri Motoru";
            Filmler filmler = new Filmler();
            string tür = TürSeçici(filmler);
            string ruhhali = RuhhalineGöreEşleştirme(filmler,tür);
            YaşaGöreEşleştime(filmler,tür,ruhhali);
            string film = filmler.izlenecekfilm[0];
            Console.WriteLine($"Sizin İçin Seçtiğimiz Film:{film}"); Console.WriteLine("Kapatmak İçin Herhanggi Bir Tuşa Basınız..."); Console.Read();
            Console.ReadLine();
        }
    }
}
