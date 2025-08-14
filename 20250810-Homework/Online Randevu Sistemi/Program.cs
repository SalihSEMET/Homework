using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Online_Randevu_Sistemi
{
    class RandevuSaatleri
    {
        public string[] saatler = { "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "12:30 - 14:00(Ögle Arası)", "14:00", "14:30", "15:00" };

    }
    internal class Program
    {
        static void RandevuAl(string[] strings)
        {
            
            while (true)
            {
                RandevuSaatleri(strings);
                Console.Write("Kaçıncı Randevuyu Almak İstiyorsunuz:");
                bool dogrumu = int.TryParse(Console.ReadLine(),out int number);
                if (!dogrumu)
                {
                    break;
                }
                string input = strings[number - 1];
                int index = Array.IndexOf(strings, input);
                if(index != -1 && index !=9)
                {
                    Console.WriteLine("\n--------------------------------------------------");
                    Console.WriteLine($"Saat:{strings[index]} a Randevunuz Alındı");
                    Console.WriteLine("--------------------------------------------------");
                    Console.Write("|Ana Menüye Dönmek İçin Herhangi Bir Tuşa Basın...|");
                    Console.ReadKey(); Console.Clear();
                    Console.WriteLine("Ana Menüye Dönülüyor...");
                    Thread.Sleep(2000); Console.Clear();
                    break;
                }
                else if(index == 9)
                {
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("Ögle Arasına Randevu Alınamaz...");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("Geri Dönülüyor...");  Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }
                else
                {
                    continue;
                }
            }
        }
        static void MenüYazısı()
        {
            Console.WriteLine("---------  *** Online Randevu Sistemine Hoşgeldiniz *** ---------");
            Console.WriteLine("|              Randevu Almak İçin Enter a Basınız               |");
            Console.WriteLine("|  Saatleri Görüntülemek İçin BackSpace(Geri Tuşuna) a Basınız  |");
            Console.Write("|           Uygulamayı Kapatmak İçin ESC ye Basınız             |");
        }
        static void RandevuSaatleri(string[] strings)
        {

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("***** ---                 Randevu Saatleri                  --- *****");
            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine($"{i + 1}.Randevu :{strings[i]}");
            }
            Console.WriteLine("---------------------------------------------------------------------");
        }
        static ConsoleKey KeyAlma()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            return keyInfo.Key;
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear(); Console.ForegroundColor = ConsoleColor.Black; Console.Title = "Randevu Alıcı";
            RandevuSaatleri randevuSaatleri = new RandevuSaatleri();
            while (true)
            {
                MenüYazısı();
                ConsoleKey keyInfo = KeyAlma();
                switch (keyInfo)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        RandevuAl(randevuSaatleri.saatler);
                        break;
                    case ConsoleKey.Backspace:
                        Console.Clear();
                        RandevuSaatleri(randevuSaatleri.saatler);
                        while (true)
                        {
                            Console.Write("\n\n|Geri Dönmek İçin ESC Tuşuna Basınız...|");
                            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                            Console.Clear();
                            if (consoleKeyInfo.Key == ConsoleKey.Escape)
                            {
                                Console.WriteLine("Geri Dönülüyor..."); Thread.Sleep(2000); Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Giriş Tekrar Deneyin...");
                                continue;
                            }
                        }
                        break;
                    case ConsoleKey.Escape:
                                Console.Clear();
                                Console.WriteLine("Uygulama Kapatılıyor..."); Thread.Sleep(2000); Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Geçersiz tuş. Lütfen tekrar deneyin.");
                                Thread.Sleep(1500);
                                Console.Clear();
                                break;

                            }
                continue;
            }
            
        }
    }
}
