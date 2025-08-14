using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Şifre_Güçlendirme_Aracı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black; Console.Title = "Şifre Güçlendirme Ve Denetleme Aracı";
            Console.WriteLine("---- *** Şifre Kontrol Ve Yapılandırma Aracına Hoşgeldiniz *** -----");
            Console.WriteLine("--- Program Sizden Şifrenizi Alıp 5 üzerinden Puanlıycak \nEger 2 Den Az Gelirse Size Daha Güçlü Şifre Önerileri Yapacak ---");
            Console.Write("\n\nDevam Etmek İçin Herhangi Bir Tuşa Basınız..."); Console.ReadLine(); Console.Clear(); Console.WriteLine("Programa Aktarılıyorsunuz..."); Thread.Sleep(2000); Console.Clear();
            Console.Write("Lütfen Şifrenizi Girin:");
            string şifre = Console.ReadLine();
            int puan = ŞifreKontrolEdici(şifre, out bool kuçükkaraktervarmı, out bool büyükkaraktervarmı, out bool sayıvarmı, out bool özelkaraktervarmı);
            Console.WriteLine($"Şifrenizin Gücü:{puan} Buna Göre Şifreniz:{PuanaGöreGüç(puan)}");

            if(puan <= 2)
            {
                Console.WriteLine("Zayıf Şifre Daha Güçlü Altarnatifler İstiyorsanız Enter a Çıkmak İstiyorsanız ESC Basın...");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Console.Write("Kaç Tane Önermesini İstersiniz:"); int sayı = int.Parse(Console.ReadLine()); Console.Clear();
                        Console.WriteLine($"----- *** {sayı} Adet Güçlü Şifre Örneği *** -----");
                        for (int i = 0; i < sayı; i++)
                        {
                            Console.WriteLine($"{GüçlüŞifreÜreticisi(şifre, kuçükkaraktervarmı, büyükkaraktervarmı, sayıvarmı, özelkaraktervarmı)}");
                        }
                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.WriteLine("Uygulamadan Çıkılıyor..."); Thread.Sleep(2000); Environment.Exit(0);
                        break;
                }
                
            }
            Console.WriteLine("\n\n|Uygulamayı Kapatmak İçin Herhangi Bir Tuşa Basınız...|"); Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Uygulama Kapatılıyor..."); Thread.Sleep(2000);
            Environment.Exit(0);


        }
        static int ŞifreKontrolEdici(string şifre,out bool kuçükkaraktervarmı,out bool büyükkaraktervarmı,out bool sayıvarmı,out bool özelkaraktervarmı)
        {
            kuçükkaraktervarmı = büyükkaraktervarmı = sayıvarmı = özelkaraktervarmı = false; int puan = 0;
            foreach (char c in şifre)
            {
                if (char.IsLower(c))
                {
                    kuçükkaraktervarmı = true;
                }
                else if (char.IsUpper(c))
                {
                    büyükkaraktervarmı = true;
                }
                else if (char.IsDigit(c))
                {
                    sayıvarmı = true;
                }
                else if(ÖzelKarakterDenetleyicisi(c))
                {
                    özelkaraktervarmı = true;
                }
            }
            if(şifre.Length >= 8)
            {
                puan++;
            }
            if (kuçükkaraktervarmı) puan++;
            if (büyükkaraktervarmı) puan++;
            if (sayıvarmı) puan++;
            if (özelkaraktervarmı) puan++;
            return puan;
        }
        static bool ÖzelKarakterDenetleyicisi(char c)
        {
            string özelkarakterler = "!@#$%^&*()-_=+[]{}|;:'\",.<>?/\\`~";
            return özelkarakterler.Contains(c);
        }
        static string PuanaGöreGüç(int puan)
        {
            if(puan <= 2)
            {
                return "Zayıf";
            }
            else if(puan <=4 && puan > 2)
            {
                return "Ortalama";
            }
            else if(puan >= 5)
            {
                return "Güçlü";
            }
            else
            {
                return "";
            }
        }
        static string GüçlüŞifreÜreticisi(string normalşifre,bool küçükharfvarmı,bool büyükharfvarmı,bool sayıvarmı,bool özelkaraktervarmı)
        {
            //StringBuilder => Yeni Birleştirmeler İle Yeni Bir String Oluşturur.
            StringBuilder builder = new StringBuilder(normalşifre);
            if (!büyükharfvarmı) builder.Append('A');
            if (!küçükharfvarmı) builder.Append('a');
            if (!sayıvarmı) builder.Append('5');
            if (!özelkaraktervarmı) builder.Append('%');
            while(builder.Length <= 10)
            {
                builder.Append(RastgeleKarakterOluşturucu());
            }
            return builder.ToString();
        }
        static Random r = new Random();
        static char RastgeleKarakterOluşturucu()
        {
            string karakterler = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@#$%&*!";
            return karakterler[r.Next(karakterler.Length)];
        }
    }
}
