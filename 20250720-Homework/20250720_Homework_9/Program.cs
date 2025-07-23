using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250720_Homework_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black; Console.Title = "Dizideki Sayıların Sırası";
            Console.WriteLine("-----*** Dizideki En Büyük & En Küçük Sayıların Sırasını Bulma Uygulaması ***-----");
            Console.WriteLine("\n|    Program Sizden 10 Tane Sayı Alıcak Ve Girdiğiniz En Buyuk & En Küçük \n     Sayıları Kaçıncı Sırada Oldugunu & Dizideki İndex İni Söylüycek    |");
            Console.Write("\n-_-_-_*Devam Etmek İçin Enter a Basınız*-_-_-"); Console.ReadLine(); Console.Clear();
            int[] numbers = new int[10]; int linenumbermin =0;int linenumbermax=0; string word_suffixmin = "", word_suffixmax = "";
            //Birinci Sayı Manuel Alınıp Maks Ve Min E Atadım
            Console.Write("1. Sayıyı Giriniz:");
            numbers[0]= Convert.ToInt32(Console.ReadLine());
            int maxnumber = numbers[0]; int minnumber = numbers[0]; 
            //
            for (int i = 1; i < numbers.Length; i++)
            {
                Console.WriteLine();
                Console.Write($"{i + 1}. Sayıyı Giriniz:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxnumber)
                {
                    maxnumber = numbers[i];
                    linenumbermax = i;
                }
                else if (numbers[i] < minnumber)
                {
                    minnumber = numbers[i];
                    linenumbermin = i;
                }
            }
            #region word_suffix
            switch (linenumbermin)
            {
                case 0:
                    word_suffixmin = "dır";
                    break;
                case 1:
                    word_suffixmin = "dir";
                        break;
                case 2:
                    word_suffixmin = "dir";
                    break;
                case 3:
                    word_suffixmin = "tür";
                    break;
                case 4:
                    word_suffixmin = "tür";
                    break;
                case 5:
                    word_suffixmin = "tir";
                    break;
                case 6:
                    word_suffixmin = "dır";
                    break;
                case 7:
                    word_suffixmin = "dir";
                    break;
                case 8:
                    word_suffixmin = "dir";
                    break;
                case 9:
                    word_suffixmin = "dur";
                    break;
                case 10:
                    word_suffixmin = "dur";
                    break;
            }
            switch (linenumbermax)
            {
                case 0:
                    word_suffixmax = "dır";
                    break;
                case 1:
                    word_suffixmax = "dir";
                    break;
                case 2:
                    word_suffixmax = "dir";
                    break;
                case 3:
                    word_suffixmax = "tür";
                    break;
                case 4:
                    word_suffixmax = "tür";
                    break;
                case 5:
                    word_suffixmax = "tir";
                    break;
                case 6:
                    word_suffixmax = "dır";
                    break;
                case 7:
                    word_suffixmax = "dir";
                    break;
                case 8:
                    word_suffixmax = "dir";
                    break;
                case 9:
                    word_suffixmax = "dur";
                    break;
                case 10:
                    word_suffixmax = "dur";
                    break;
            }
            #endregion
            int difference = maxnumber - minnumber; Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Girdiğiniz En Büyük Sayı {maxnumber} dır Girdiğiniz {linenumbermax +1}. Sayıdır Ve Dizideki İndex i {linenumbermax} {word_suffixmax}.");
            Console.WriteLine($"Girdiğiniz En Küçük Sayı {minnumber} dır Girdiğiniz {linenumbermin +1}. Sayıdır Ve Dizideki İndex i {linenumbermin} {word_suffixmin}.");
            Console.WriteLine($"Girgiğiniz En Büyük Sayı İle En Küçük Sayı Arasındaki Fark => {difference}");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.Write("\nProgramı Kapatmak İçin Enter a Bas..."); Console.ReadLine(); Console.Beep();
        }
    }
}
