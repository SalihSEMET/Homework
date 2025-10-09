using System.Globalization;

namespace Homework
{
    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.Title = "Dictionary ile Telefon Rehberi";
            Console.ForegroundColor = ConsoleColor.White;
            Dictionary<string, string> nameAndPhoneNumber = new Dictionary<string, string>();
            nameAndPhoneNumber.Add("salih","+90 5305296745");
            nameAndPhoneNumber.Add("yusuf","+90 5361389583");
            nameAndPhoneNumber.Add("kerem","+90 5242824693");
            while (true)
            {
                Console.Clear();
                Console.WriteLine("* 3. Ödev *");
                Console.Write("| Ad İle Arama İçin 1 i |\n| Liste ile Beraber Ad Araması İçin 2 yi |\n| Numara Eklemek İçin 3 ü |\n| Uygulamadan Çıkmak İçin 4 Yazınız |");
                Console.Write("Seçiminiz:");
                string choose = Console.ReadLine();
                if (choose == "1")
                {
                    Console.Clear();
                    
                    bool tryAgain = true;

                    while (tryAgain)
                    {
                        Console.Write("Ad Giriniz: ");
                        string name = Console.ReadLine();

                        if (nameAndPhoneNumber.TryGetValue(name.ToLower(), out string number))
                        {
                            Console.WriteLine($"İsim:{name} Numara: {number}");
                            Console.Write("Devam Etmek İçin Herhangi Bir Tuşa Basınız...");
                            Console.Read();
                            tryAgain = false;
                        }
                        else
                        {
                            Console.WriteLine("İsim eşleşmedi.");
                            Console.Write("Tekrar denemek için Enter'a, ana menüye dönmek için ESC'ye basınız...");

                            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                Console.Clear();
                                continue;
                            }
                            else if (keyInfo.Key == ConsoleKey.Escape)
                            {
                                Console.Clear();
                                tryAgain = false; 
                            }
                        }
                    }
                }

                if (choose == "2")
                {
                    Console.Clear();
                    foreach (var item in nameAndPhoneNumber)
                    {
                        Console.WriteLine($"İsmi:{item.Key} Numarası:{item.Value}");
                    }
                    bool tryAgain = true;

                    while (tryAgain)
                    {
                        Console.Write("Ad Giriniz: ");
                        string name = Console.ReadLine();

                        if (nameAndPhoneNumber.TryGetValue(name.ToLower(), out string number))
                        {
                            Console.WriteLine($"İsim:{name} Numara: {number}");
                            Console.Write("Devam Etmek İçin Herhangi Bir Tuşa Basınız...");
                            Console.Read();
                            tryAgain = false;
                        }
                        else
                        {
                            Console.WriteLine("İsim eşleşmedi.");
                            Console.Write("Tekrar denemek için Enter'a, ana menüye dönmek için ESC'ye basınız...");

                            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

                            if (keyInfo.Key == ConsoleKey.Enter)
                            {
                                Console.Clear();
                                continue;
                            }
                            else if (keyInfo.Key == ConsoleKey.Escape)
                            {
                                Console.Clear();
                                tryAgain = false; 
                            }
                        }
                    }
                }
                if (choose == "3")
                {
                    Console.Clear();
                    Console.Write("Adı:");
                    string name = Console.ReadLine();
                    Console.Write("Numara:");
                    string phoneNumber = Console.ReadLine();
                    nameAndPhoneNumber.Add(name,phoneNumber);
                    Console.Write("Ana Menüye Dönüyorsunuz..."); Thread.Sleep(2000);
                }

                if (choose == "4")
                {
                    Console.Clear();
                    Console.Write("Çıkılıyor..."); Thread.Sleep(2000);
                    Environment.Exit(0);
                }
            }
        }
    }
}