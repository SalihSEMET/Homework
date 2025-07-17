using System;
using System.Collections.Generic;

class MyCalculatorProgram //Eskiden Kendi Yaptıgım Proje
{
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Title = "Hesap Makinesi";
        Console.WriteLine(" -----***Hesap Makinesine Hoşgeldiniz***----- ");
        Console.WriteLine("|             *****İşlemler*****             |");
        Console.WriteLine("||| Toplama İçin=> (+) | Çıkarma İçin=> (-) | Çarpma İçin=> (*) | Bölme İçin=> (/) |||");
        Console.Write("Lütfen Yapmak İstediğiniz İşlemi Seçiniz:");
        string operation = Console.ReadLine();

        List<double> numbers = new List<double>();
        string input;
        int count = 1;
        Console.Clear();
        Console.WriteLine("| Sayıları Giriniz Bitirmek İstediğinizde 'Bitti' Yazın |");

        while (true)
        {
            Console.Write($"{count}.Sayıyı Giriniz veya Bitirmek İçin 'Bitti' Yazınız:");
            input = Console.ReadLine();

            if (input.ToLower() == "bitti")
            {
                break;
            }
            if (double.TryParse(input, out double number))
            {
                numbers.Add(number);
                count++;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş.|Lütfen Geçerli Bir Sayı Giriniz.");
            }
        }
        if (numbers.Count == 0)
        {
            Console.WriteLine("Sayı Girişi Yok");
        }
        else
        {
            double result = numbers[0];

            switch (operation)
            {
                case "+":
                    for (int i = 1; i < numbers.Count; i++)
                        result += numbers[i];
                    break;
                case "-":
                    for (int i = 1; i < numbers.Count; i++)
                        result -= numbers[i];
                    break;
                case "*":
                    for (int i = 1; i < numbers.Count; i++)
                        result *= numbers[i];
                    break;
                case "/":
                    for (int i = 1; i < numbers.Count; i++)
                        result /= numbers[i];
                    break;

                default:
                    Console.WriteLine("Geçersiz İşlem Girildi.");
                    return;
            }
            Console.Clear();
            Console.WriteLine($"Sonuç: {result}");
        }
        Console.WriteLine("Programı Kapatmak için Enter Tuşuna basınız...");
        Console.ReadLine();
    }
}
