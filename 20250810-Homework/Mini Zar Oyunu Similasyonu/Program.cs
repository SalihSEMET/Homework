using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mini_Zar_Oyunu_Similasyonu
{
    internal class Program
    {
        static void ZarOyunu(Random random,int hedefsayı,int toplam,int denemesayısı)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Tekli Zar Atılıyor..."); Thread.Sleep(1000); Console.Clear();
                int zardegeri = random.Next(1, 6);
                toplam += zardegeri;
                if (toplam >= hedefsayı)
                {
                    Sonuçbelirleyici(hedefsayı, denemesayısı);
                }
                denemesayısı++;
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"{zardegeri} Çıktı Hedefe Kalan {hedefsayı - toplam} Toplam Deneme:{denemesayısı}");
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                Console.Write("|Tekrar Tekli Zar Atmak İçin Enter a|\n|Zar Menüsüne Dönmek İçin ESC ye Basınız...|");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if(keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    continue;
                }
                else if(keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    break;
                }
            }
            int zarsayısı = ZarSeçici(hedefsayı,toplam,denemesayısı);
            YöneticiMenü(random, hedefsayı, denemesayısı, zarsayısı, toplam, 0, 0);
        }
        static void ZarOyunu(Random random, int hedefsayı, int toplam, int denemesayısı,int ikilizartoplamı)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("İkili Zar Atılıyor..."); Thread.Sleep(1000); Console.Clear();
                int zardegeri1 = random.Next(1, 6);
                int zardegeri2 = random.Next(1, 6);
                toplam += zardegeri1 + zardegeri2;
                if (toplam >= hedefsayı)
                {
                    Sonuçbelirleyici(hedefsayı, denemesayısı);
                }
                denemesayısı++;
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"1.Zar:{zardegeri1}, 2.Zar:{zardegeri2} Çıktı İkili Zar Toplamı:{zardegeri1 + zardegeri2}\nHedefe Kalan {hedefsayı - toplam} Toplam Deneme:{denemesayısı}");
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                Console.Write("|Tekrar İkili Zar Atmak İçin Enter a|\n|Zar Menüsüne Dönmek İçin ESC ye Basınız...|");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    continue;
                }
                else if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    break;
                }
            }
            int zarsayısı = ZarSeçici(hedefsayı, toplam, denemesayısı);
            YöneticiMenü(random, hedefsayı, denemesayısı, zarsayısı, toplam, ikilizartoplamı, 0);
        }
        static void ZarOyunu(Random random, int hedefsayı, int toplam, int denemesayısı,int ikilizartoplamı,int üçlüzartoplamı)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Üçlü Zar Atılıyor..."); Thread.Sleep(1000); Console.Clear();
                int zardegeri1 = random.Next(1, 6);
                int zardegeri2 = random.Next(1, 6);
                int zardegeri3 = random.Next(1, 6);
                toplam += zardegeri1 + zardegeri2 + zardegeri3;
                if(toplam >= hedefsayı)
                {
                    Sonuçbelirleyici(hedefsayı, denemesayısı);
                }
                denemesayısı++;
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"1.Zar:{zardegeri1}, 2.Zar:{zardegeri2}, 3.Zar:{zardegeri3} Çıktı Üçlü Zar Toplamı:{zardegeri1 + zardegeri2 + zardegeri3}\nHedefe Kalan {hedefsayı - toplam} Toplam Deneme:{denemesayısı}");
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                Console.Write("|Tekrar Üçlü Zar Atmak İçin Enter a|\n|Zar Menüsüne Dönmek İçin ESC ye Basınız...|");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    continue;
                }
                else if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    break;
                }
            }
            int zarsayısı = ZarSeçici(hedefsayı, toplam, denemesayısı);
            YöneticiMenü(random, hedefsayı, denemesayısı, zarsayısı, toplam, ikilizartoplamı, üçlüzartoplamı);
        }
        static void WelcomeSeen(int hedefsayı,int toplam,int denemesayısı)
        {
            Console.WriteLine("                   ----- *** Zar Oyununa Hoşgeldiniz *** -----                          ");
            Console.WriteLine("---------------------------------------------------------------------------------------\n                      Kaç zar Atmak İstediğinizi Seçiceksiniz          \nÇıkan Zar ların toplamı Hesaplanıcak Ve En Kısa Atış İle Hedefe Ulaşmaya Çalışıcaksınız\n---------------------------------------------------------------------------------------");
            Console.Write("\n\n|Oyunu Başlatmak İçin Enter a Çıkmak İçin İse ESC ye Basınız...|");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.Enter:
                    Console.Clear();
                    Console.WriteLine("Oyuna Aktarılıyorsunuz..."); Thread.Sleep(2000); 
                    int zarsayısı = ZarSeçici(hedefsayı, toplam, denemesayısı);
                    YöneticiMenü(new Random(), hedefsayı, denemesayısı, zarsayısı, toplam, 0, 0);
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    Console.WriteLine("Uygulamadan Çıkış Yapılıyor..."); Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;
            }
        }
        static int ZarSeçici(int hedefsayı,int toplam,int denemesayısı)
        {
            Console.Clear();
            int zarsayısı = 0;
            while (true)
            {
                Console.WriteLine($"Hedef:{hedefsayı} Hedefe Kalan:{hedefsayı - toplam} Toplam Deneme Sayısı:{denemesayısı}");
                Console.Write("Kaç Zar Atmak İstersiniz(1, 2, 3):");
                
                bool dogruyazıldımı = int.TryParse(Console.ReadLine(),out int _zarsayısı);
                if (!dogruyazıldımı)
                {
                    Console.WriteLine("Yanlış Yazdınız Lütfen Tekrar Deneyin..."); Thread.Sleep(1000);
                    continue;
                }
                else if(_zarsayısı ==1 || _zarsayısı == 2 || _zarsayısı == 3)
                {
                    zarsayısı = _zarsayısı;
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış Yazdınız Lütfen Tekrar Deneyin..."); Thread.Sleep(1000);
                    continue;
                }
            }
            return zarsayısı;
        }
        static void YöneticiMenü(Random random,int hedefsayı,int denemesayısı,int zarsayısı,int toplam,int ikilizardegeritoplamı,int üçlüzardegeritoplamı)
        {

            switch (zarsayısı)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine($"Hedefiniz:{hedefsayı} Hedefe Kalan{hedefsayı - toplam} Toplam Deneme:{denemesayısı}");
                    ZarOyunu(random, hedefsayı, toplam, denemesayısı);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine($"Hedefiniz:{hedefsayı} Hedefe Kalan{hedefsayı - toplam} Toplam Deneme:{denemesayısı}");
                    ZarOyunu(random, hedefsayı, toplam, denemesayısı,ikilizardegeritoplamı);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine($"Hedefiniz:{hedefsayı} Hedefe Kalan{hedefsayı - toplam} Toplam Deneme:{denemesayısı}");
                    ZarOyunu(random, hedefsayı, toplam, denemesayısı, ikilizardegeritoplamı,üçlüzardegeritoplamı);
                    break;
            }
        }
        static void Sonuçbelirleyici(int hedefsayı,int denemesayısı)
        {
            string sonuç;
            if(hedefsayı <=150 && hedefsayı >= 130)
            {
                if(denemesayısı <= 25)
                {
                    sonuç = "Başarılısın :)";
                }
                else if(denemesayısı <=30 && denemesayısı > 25)
                {
                    sonuç = "Ortalamasın";
                }
                else
                {
                    sonuç = "Başarısızsın";
                }
                Console.WriteLine("----- *** Bu Hedef Sayısı İçin Başarı Tablosu *** -----");
                Console.WriteLine("|Başarılı:(25 Eşit Veya den Daha Az) Ortalama(30 ile 26 Arası) Başarısız(30 Dan Fazla)");
                Console.WriteLine($"|               Deneme Sayın:{denemesayısı} Buna Göre:{sonuç}              ");
                Console.WriteLine("|           Uygulamadan Çıkmak İçin Herhangi Bir Tuşa Basınız...            |");
                Console.ReadLine(); Console.Clear();  Console.WriteLine("Uygulamadan Çıkılıyor..."); Thread.Sleep(2000); Environment.Exit(0);
            }
            else if(hedefsayı <130 && hedefsayı >= 110)
            {
                if (denemesayısı <= 22)
                {
                    sonuç = "Başarılısın :)";
                }
                else if (denemesayısı <= 27 && denemesayısı > 22)
                {
                    sonuç = "Ortalama";
                }
                else
                {
                    sonuç = "Başarısız";
                }
                Console.WriteLine("----- *** Bu Hedef Sayısı İçin Başarı Tablosu *** -----");
                Console.WriteLine("|Başarılı:(22 Eşit Veya den Daha Az) Ortalama(27 ile 23 Arası) Başarısız(27 Dan Fazla)");
                Console.WriteLine($"|               Deneme Sayın:{denemesayısı} Buna Göre:{sonuç}              ");
                Console.WriteLine("|           Uygulamadan Çıkmak İçin Herhangi Bir Tuşa Basınız...            |");
                Console.ReadLine(); Console.Clear(); Console.WriteLine("Uygulamadan Çıkılıyor..."); Thread.Sleep(2000); Environment.Exit(0);
            }
            else if(hedefsayı <110 && hedefsayı >= 90)
            {
                if (denemesayısı <= 18)
                {
                    sonuç = "Başarılısın :)";
                }
                else if (denemesayısı <= 23 && denemesayısı > 18)
                {
                    sonuç = "Ortalama";
                }
                else
                {
                    sonuç = "Başarısız";
                }
                Console.WriteLine("----- *** Bu Hedef Sayısı İçin Başarı Tablosu *** -----");
                Console.WriteLine("|Başarılı:(18 Eşit Veya den Daha Az) Ortalama(23 ile 19 Arası) Başarısız(23 Dan Fazla)");
                Console.WriteLine($"|               Deneme Sayın:{denemesayısı} Buna Göre:{sonuç}              ");
                Console.WriteLine("|           Uygulamadan Çıkmak İçin Herhangi Bir Tuşa Basınız...            |");
                Console.ReadLine(); Console.Clear(); Console.WriteLine("Uygulamadan Çıkılıyor..."); Thread.Sleep(2000); Environment.Exit(0);
            }
            else if(hedefsayı <90 && hedefsayı >= 70)
            {
                if (denemesayısı <= 14)
                {
                    sonuç = "Başarılısın :)";
                }
                else if (denemesayısı <= 19 && denemesayısı > 14)
                {
                    sonuç  = "Ortalama";
                }
                else
                {
                    sonuç = "Başarısız";
                }
                Console.WriteLine("----- *** Bu Hedef Sayısı İçin Başarı Tablosu *** -----");
                Console.WriteLine("|Başarılı:(14 Eşit Veya den Daha Az) Ortalama(19 ile 15 Arası) Başarısız(19 Dan Fazla)");
                Console.WriteLine($"|               Deneme Sayın:{denemesayısı} Buna Göre:{sonuç}              ");
                Console.WriteLine("|           Uygulamadan Çıkmak İçin Herhangi Bir Tuşa Basınız...            |");
                Console.ReadLine(); Console.Clear(); Console.WriteLine("Uygulamadan Çıkılıyor..."); Thread.Sleep(2000); Environment.Exit(0);
            }
            else if(hedefsayı <70 && hedefsayı >= 50)
            {
                if (denemesayısı <= 10)
                {
                    sonuç = "Başarılısın :)";
                }
                else if (denemesayısı <= 15 && denemesayısı > 10)
                {
                    sonuç = "Ortalama";
                }
                else
                {
                    sonuç = "Başarısız";
                }
                Console.WriteLine("----- *** Bu Hedef Sayısı İçin Başarı Tablosu *** -----");
                Console.WriteLine("|Başarılı:(10 Eşit Veya den Daha Az) Ortalama(15 ile 11 Arası) Başarısız(15 Dan Fazla)");
                Console.WriteLine($"|               Deneme Sayın:{denemesayısı} Buna Göre:{sonuç}              ");
                Console.WriteLine("|           Uygulamadan Çıkmak İçin Herhangi Bir Tuşa Basınız...            |");
                Console.ReadLine(); Console.Clear(); Console.WriteLine("Uygulamadan Çıkılıyor..."); Thread.Sleep(2000); Environment.Exit(0);
            }
            else
            {
                sonuç = "";
            }
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black; Console.Title = "Zar Oyun Similasyonu";
            Random random = new Random();
            int hedefsayı = random.Next(50, 150);
            int denemesayısı = 0;
            int toplam = 0; 
            int ikilizardegeritoplamı = 0;
            int üçlüzardegeritoplamı = 0;
            WelcomeSeen(hedefsayı,toplam,denemesayısı);
            int zarsayısı = ZarSeçici(hedefsayı, toplam, denemesayısı);
            YöneticiMenü(random, hedefsayı, denemesayısı, zarsayısı,toplam,ikilizardegeritoplamı,üçlüzardegeritoplamı);
        }
    }
}
