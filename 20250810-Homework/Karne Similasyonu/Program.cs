using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Karne_Similasyonu
{
    internal class Program
    {
        static void KarşılamaEkranı()
        {
            Console.WriteLine("----- *** Karne Hesaplama Uygulamsı *** -----");
            Console.WriteLine("|Bu Uygulama Sizden 6 Not Alıp Degerlendiricek ve Genel Durumunuzu Söyliycek|");
            Console.WriteLine("Devam Etmek İçin Herhangi Bir Tuşa Basınız..."); Console.Read();
            Console.Clear(); Console.WriteLine("Aktarılıyorsunuz..."); Thread.Sleep(2000);
            Console.Clear();
        }
        static int[] NotAlıcıVeHesaplayıcı()
        {
            int[] notlar = new int[6];
            for (int i = 0; i < notlar.Length; i++)
            {
                int miktar;
                while (true)
                {
                    Console.Write($"{i + 1}. Notunuzu Giriniz:");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out miktar) && miktar >= 0 && miktar <= 100)
                    {
                        notlar[i] = miktar;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen 0 ile 100 arasında geçerli bir sayı giriniz.");
                    }
                    Console.Clear();
                }
            }
            Console.Clear();
            Console.WriteLine("Notlar Alındı Hesaplama İçin Herhangi Bir Tuşa Basınız..."); Console.Read(); Console.Clear();
            Console.WriteLine("Hesaplanıyor..."); Thread.Sleep(2000); Console.Clear();
            string[] harfdegerler = new string[6];
            for (int i = 0; i < harfdegerler.Length; i++)
            {
                if (notlar[i] >= 90 && notlar[i] <= 100)
                {
                    harfdegerler[i] = "AA";
                }
                else if (notlar[i] >= 85 && notlar[i] < 90)
                {
                    harfdegerler[i] = "BA";
                }
                else if (notlar[i] >= 80 && notlar[i] < 85)
                {
                    harfdegerler[i] = "BB";
                }
                else if (notlar[i] >= 70 && notlar[i] < 80)
                {
                    harfdegerler[i] = "CB";
                }
                else if (notlar[i] >= 60 && notlar[i] < 70)
                {
                    harfdegerler[i] = "CC";
                }
                else if (notlar[i] >= 55 && notlar[i] < 60)
                {
                    harfdegerler[i] = "DC";
                }
                else if (notlar[i] >= 50 && notlar[i] < 55)
                {
                    harfdegerler[i] = "DD";
                }
                else if (notlar[i] >= 40 && notlar[i] < 50)
                {
                    harfdegerler[i] = "FD";
                }
                else if (notlar[i] >= 0 && notlar[i] < 40)
                {
                    harfdegerler[i] = "FF";
                }
            }
            Console.WriteLine(new string ('-', 50));
            for (int i = 0; i < notlar.Length; i++)
            {
                Console.WriteLine($"{i + 1}. Sınav Notunuz:{notlar[i]} Buna Göre:{harfdegerler[i]} Aldınız");
            }
            int endüşüknot = notlar.Min();
            int enyükseknot = notlar.Max();
            Console.WriteLine($" *** En Yüksek Notunuz:{enyükseknot} En Düşük Notunuz:{endüşüknot} *** ");
            return notlar;
        }
        static (string,double) AnaDurumesaplayıcı(int[] notlar)
        {
            int totalnot = 0;
            for (int i = 0; i < notlar.Length; i++)
            {
                totalnot += notlar[i];
            }
            double sonuç = totalnot / 6;
            string genelsonuç = "";
            double sonuçtemizhali = Math.Round(sonuç, 2);
                if (sonuçtemizhali >= 90 && sonuçtemizhali <= 100)
                {
                    genelsonuç = "AA";
                }
                else if (sonuçtemizhali >= 85 && sonuçtemizhali < 90)
                {
                    genelsonuç = "BA";
                }
                else if (sonuçtemizhali >= 80 && sonuçtemizhali < 85)
                {
                    genelsonuç = "BB";
                }
                else if (sonuçtemizhali >= 70 && sonuçtemizhali < 80)
                {
                    genelsonuç = "CB";
                }
                else if (sonuçtemizhali >= 60 && sonuçtemizhali < 70)
                {
                    genelsonuç = "CC";
                }
                else if (sonuçtemizhali >= 55 && sonuçtemizhali < 60)
                {
                    genelsonuç = "DC";
                }
                else if (sonuçtemizhali >= 50 && sonuçtemizhali < 55)
                {
                    genelsonuç = "DD";
                }
                else if (sonuçtemizhali >= 40 && sonuçtemizhali < 50)
                {
                    genelsonuç = "FD";
                }
                else if (sonuçtemizhali >= 0 && sonuçtemizhali < 40)
                {
                    genelsonuç = "FF";
                }
            return (genelsonuç, sonuçtemizhali);
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear(); Console.ForegroundColor = ConsoleColor.Black; Console.Title = "Karne Hesaplama Uygulaması";
            KarşılamaEkranı();
            (string genelsonuç, double sonuçtemizhali) = AnaDurumesaplayıcı(NotAlıcıVeHesaplayıcı());

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Genel Durumunuzu Görmek İçin Herhangi Bir Tuşa Basınız...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Hesaplanıyor...");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("Hesaplandı, Sonuçlarınız Aktarılıyor...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Ortalamanız: {sonuçtemizhali}  Genel Harf Notunuz: {genelsonuç}");
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("\n\n|Kapatmak İçin Herhangi Bir Tuşa Basınız...|");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Program Kapatılıyor...");
            Thread.Sleep(2000);
            Console.Clear();
            Environment.Exit(0);
        }
    }
}
