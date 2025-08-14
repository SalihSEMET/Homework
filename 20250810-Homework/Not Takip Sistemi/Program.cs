using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not_Takip_Sistemi
{
    internal class Program
    {

        static (int[][], string[])  NotHesaplayıcı()
        {
            Console.Write("Kaç Öğrencinin Notunu Giriceksiniz:");
            int kaçögrenci = Convert.ToInt32(Console.ReadLine());
            string[] ögrenciAdları = new string[kaçögrenci];
            int[][] ögrencinotları = new int[kaçögrenci][];
            for (int i = 0; i < kaçögrenci; i++)
            {
                Console.Write($"{i + 1}. Ögrencinin Adı Nedir:");
                ögrenciAdları[i] = Console.ReadLine();
                Console.Write($"{ögrenciAdları[i]} İçin Kaç Tane Not Girmek İstersin:");
                int notsayısı = Convert.ToInt32(Console.ReadLine());
                ögrencinotları[i] = new int[notsayısı];
                for (int j = 0; j < notsayısı; j++)
                {
                    Console.Write($"{ögrenciAdları[i]} {j +1}. Notunu Giriniz:");
                    ögrencinotları[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return (ögrencinotları, ögrenciAdları);
        }
        static (string[], double[],double) NotHesaplayıcı(int[][] array)
        {
            double[] sonuç = new double[array.Length];
            string[] harfkarşılığı = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int totalnot = 0;
                for (int j = 0; j < array[i].Length; j++)
                {
                    totalnot += array[i][j];
                }
                sonuç[i] = (double)totalnot / array[i].Length;
                string harfsonucu;
                if (sonuç[i] >= 90)
                {
                    harfsonucu = "AA";
                    harfkarşılığı[i] = harfsonucu;
                }
                else if (sonuç[i] >= 85 && sonuç[i] <= 89)
                {
                    harfsonucu = "BA";
                    harfkarşılığı[i] = harfsonucu;
                }
                else if (sonuç[i] >= 80 && sonuç[i] <= 84)
                {
                    harfsonucu = "BB";
                    harfkarşılığı[i] = harfsonucu;
                }
                else if (sonuç[i] >= 70 && sonuç[i] <= 79)
                {
                    harfsonucu = "CB";
                    harfkarşılığı[i] = harfsonucu;
                }
                else if (sonuç[i] >= 60 && sonuç[i] <= 69)
                {
                    harfsonucu = "CC";
                    harfkarşılığı[i] = harfsonucu;
                }
                else if (sonuç[i] >= 50 && sonuç[i] <= 59)
                {
                    harfsonucu = "DC";
                    harfkarşılığı[i] = harfsonucu;
                }
                else if (sonuç[i] >= 45 && sonuç[i] <= 49)
                {
                    harfsonucu = "DD";
                    harfkarşılığı[i] = harfsonucu;
                }
                else if (sonuç[i] >= 0 && sonuç[i] <= 44)
                {
                    harfsonucu = "FF";
                    harfkarşılığı[i] = harfsonucu;
                }
            }
            double sınıftoplamı = 0;
            for (int i = 0; i < sonuç.Length; i++)
            {
                sınıftoplamı += sonuç[i];
            }
            double sınıfortalaması = sınıftoplamı / sonuç.Length;
            return (harfkarşılığı, sonuç,sınıfortalaması);
            }
        static string[] NotHesaplayıcı(double sınıfortalaması, double[] sonuçlar)
        {
            string[] Başarısonuçları = new string[sonuçlar.Length];
            for (int i = 0; i < Başarısonuçları.Length; i++)
            {
                if (sonuçlar[i] > sınıfortalaması + 10)
                {
                    Başarısonuçları[i] = "Başarılı";
                }
                else if (sonuçlar[i] >= sınıfortalaması - 10 && sonuçlar[i] <= sınıfortalaması + 10)
                {
                    Başarısonuçları[i] = "Ortalama";
                }
                else if (sonuçlar[i] < sınıfortalaması - 10)
                {
                    Başarısonuçları[i] = "Başarısız";
                }
            }
            return Başarısonuçları;
        }
        static void Yazdırıcı(int[][] ints, string[] strings, string[] strings1, double[] doubles, string[] strings2,double doubles1)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine($"{strings[i]} Adlı Ögrencinin Notları");
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                for (int j = 0; j < ints[i].Length; j++)
                {
                    Console.WriteLine($"{j + 1}. Notu:{ints[i][j]}");
                }
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                Console.WriteLine($"***************************************Sınıf Ortalaması:{doubles1}*********************************");
                Console.WriteLine($"{strings[i]} Adlı Ögrencinin Ortalaması:{doubles[i]} Ve Buna Karşılık Gelen Harf Notu:{strings1[i]} Buna Göre Ögrenci:{strings2[i]} Sayılır");
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
            }
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black; Console.Title = "Not Hesaplayıcı";
            Console.WriteLine("----- *** Not Hesaplayıcıya Hoş Geldiniz *** -----");
            Console.WriteLine("Uygulama Sizden Aldıgı Degerlere Göre Bütün Gerekli Degerleri ve Degerlendirmeleri Göstericektir");
            Console.WriteLine("Devam Etmek İçin Herhangi Bir Tuşa Basınız..."); Console.ReadLine(); Console.Clear();
            var (ögrencinotları, ögrenciadları) = NotHesaplayıcı();
            NotHesaplayıcı(ögrencinotları);
            Console.WriteLine("Onaylamak İçin Herhangi Bir Tuşa Basınız..."); Console.ReadLine(); Console.Clear();
            var (harfkarşılıgı, sonuç,sınıfortalaması) = NotHesaplayıcı(ögrencinotları);
            var BaşarıSonuçları = NotHesaplayıcı(sınıfortalaması, sonuç);
            for (int i = 0; i < sonuç.Length; i++)
            {
                sonuç[i] = Math.Round(sonuç[i], 2);
            }
            sınıfortalaması = Math.Truncate(sınıfortalaması * 100) / 100;
            Yazdırıcı(ögrencinotları, ögrenciadları, harfkarşılıgı, sonuç,BaşarıSonuçları,sınıfortalaması);
            Console.WriteLine("\n\nUygulamayı Kapatmak İçin Herhangi Bir Tuşa a Basınız..."); Console.ReadLine();
        }
    }
}
