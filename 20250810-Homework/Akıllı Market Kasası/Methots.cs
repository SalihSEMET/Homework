using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Akıllı_Market_Kasası
{
    public  class Methots
    {
        public void WelcomeSeen()
        {
            products products = new products();
            string seen = "";
            Console.WriteLine("-----*** Süper Markete Hoşgeldiniz ***-----");
            Console.WriteLine("---- Yapmak İstediginiz İşlemi Seçiniz ----");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("----  1-Maket Ürünlerini Görüntülemek  ----");
            Console.WriteLine("----           2-Satın Almak           ----");
            Console.WriteLine("----  3-İndirim Ve Kampanyalara Bakmak ----");
            Console.WriteLine("-------------------------------------------");
            bool loops = true;
            while (loops)
            {
                Console.Write(" Lütfen Yapmak İstediginiz İşlemi Giriniz :");
                string input = Console.ReadLine();
                char.TryParse(input, out char operation);
                if (operation != '1' && operation != '2' && operation != '3')
                {
                    Console.Clear();
                    Console.Write("Hatalı Giriş Tekrar Denemek İçin Enter a Uygulamadan Çıkmak İçin ESC ye Basın");
                    ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
                    if(keyInfo.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        WelcomeSeen();
                        continue;
                    }
                    else if(keyInfo.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Console.WriteLine("Program Kapatılıyor...");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                    }

                }
                else
                {
                    Console.Clear();
                    loops = false;
                    Console.WriteLine("Başarılı Yönlendriliyorsunuz...");
                    seen = input.ToString();
                    Thread.Sleep(2000);
                    break;
                }
            }
            switch (seen)
            {
                case "1":
                    Console.Clear();
                    products.Showproductsandcost();
                    Console.Write("--------------------------------------\nGeri Dönmek İçin Enter Tuşuna Basınız \nUygulamadan Çıkmak İçin ESC Tuşuna Basınız\n--------------------------------------\n\n");
                    ConsoleKeyInfo keyInfo = Console.ReadKey(intercept:true);
                    if(keyInfo.Key == ConsoleKey.Enter)
                    {
                        Console.Write("Geri Dönülüyor..."); Thread.Sleep(2000);
                        Console.Clear();
                        WelcomeSeen();
                        break;
                    }
                    else if(keyInfo.Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine("Uygulamadan Çıkılıyor..."); Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;
                    }
                    else
                    {
                        return;
                    }
                case "2":
                            Console.Clear();
                            Purchase();
                            break;
                        case "3":
                            Console.Clear();
                    Console.WriteLine("-------------------- *** İndirimler *** --------------------");
                    Console.WriteLine("1- 1,3,5 Barkod Nolu Ürüneler Alınırsa Yüzde 30 İndirim");
                    Console.WriteLine("2- 9,10,4 Barkod Nolu Ürünler Alınırsa Yüzde 25 İndirim");
                    Console.WriteLine("3- 1,3,4,5,9,10 Barkod Nolu Ürünler Alınırsa Yüzde 50 İndirim");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.Write("\n\n\nGeri Dönmek İçin Enter a Uygulamadan Çıkmak İçin ESC Ye Basınız...");
                    ConsoleKeyInfo consoleKey = Console.ReadKey(intercept: true);
                    if(consoleKey.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("\nAna Menüye Dönülüyor..."); Thread.Sleep(2000);
                        Console.Clear();
                        WelcomeSeen();
                    }
                    else if(consoleKey.Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine("\nUygulamadan Çıkılıyor..."); Thread.Sleep(2000);
                        Environment.Exit(0);
                    }

                        break;
                        default:
                            Console.WriteLine("Hatalı Giriş");
                            break;
                        }
        }
        double totalprice = 0;
        public void Purchase()
        {
            products products = new products();
            Dictionary<int, int> barcodepricemape = products.GetBarcodePriceMap();
            products.Showproductsandcost();
            int count;
            Console.Write("\nKaç Ürün Almak İstiyorsunuz:");
            string inputt = Console.ReadLine();
            Console.WriteLine();
            while(!int.TryParse(inputt, out count))
            {
                Console.Clear();
                products.Showproductsandcost();
                Console.WriteLine("Geçerli Bir Sayı Giriniz:");
                Console.Write("\nKaç Ürün Almak İstiyorsunuz:");
                inputt = Console.ReadLine();
            }
            int[] wanttobuy = new int[count];
            for (int i = 0; i < count; i++)
            {
                int barcode;
                while (true)
                {
                    Console.Write($"Almak İstediğiniz {i + 1}. Ürünün Barkod Numarası Nedir:");
                    string input = Console.ReadLine();
                    if(int.TryParse(input, out barcode))
                    {
                        wanttobuy[i] = barcode;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz Barkod Numarası Girdiniz. Lütfen Tekrar Deneyin...");
                    }
                }
                

            }
            Console.Clear();
            Console.WriteLine("Ürünlerin Barkod Numaraları Alındı Okutuluyor..."); Thread.Sleep(2000); Console.Clear(); products.Showproductsandcost(); Console.WriteLine("---------------------------------------------------");
            foreach (int barcode in wanttobuy)
            {
                if (barcodepricemape.ContainsKey(barcode))
                {
                    Console.WriteLine($"Aldığınız Ürünün Barkod Numarası:{barcode} , Fiyatı:{barcodepricemape[barcode]}");
                    totalprice += barcodepricemape[barcode];
                }
                else
                {
                    Console.WriteLine($"{barcode} için eşleşen bir ürün bulunamadı.");
                }
            }
            DiscountCalculator(wanttobuy);
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"Toplam Tutar:{totalprice}"); Console.Write("Ödeme Ekranı İçin Enter a Bas");
            Console.WriteLine("Satın Alma Memüsüne Dönmek İçin BackSpace e Bas");
            Console.WriteLine("Ana Menü İçin Delete e Bas");
            Console.WriteLine("Uygulamayı Kapatmak İçin ESC ye Basınız Bas");
            Console.WriteLine("-------------------------------------------------------------------");
            ConsoleKeyInfo KeyInfo = Console.ReadKey();
            switch (KeyInfo.Key)
            {
                case ConsoleKey.Enter:
                    Console.WriteLine("Özet Ekranına Yönlendiriliyorsunuz..."); Thread.Sleep(2000);
                    break;
                case ConsoleKey.Backspace:
                    Console.Write("Satın Alma Menüsüne Dönüyorsunuz..."); Thread.Sleep(2000);
                    Console.Clear();
                    Purchase();
                    break;
                case ConsoleKey.Delete:
                    Console.Write("Ana Menüye Dönüyorsunuz..."); Thread.Sleep(2000);
                    Console.Clear();
                    WelcomeSeen();
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    Console.Write("Uygulamadan Çıkış Yapılıyor..."); Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;
            }
        }
        double oldprice = 0;
        public void DiscountCalculator(int[] series)
        {
            int[] items = { 1, 3, 5 };
            bool allısthere = items.All(x => series.Contains(x));
            int[] items2 = { 9, 10, 4 };
            bool allısthere2 = items2.All(x => series.Contains(x));
            oldprice = totalprice;
            Console.WriteLine();
            
            if (allısthere && allısthere2 == false)
            {
                Console.WriteLine("--------------------------------------------------------");
                totalprice = (totalprice / 100) * 70;
                Console.WriteLine("Yüzde 30 İndirim Uygulandı");
                Console.WriteLine($"{oldprice} >> {totalprice}");
                Console.WriteLine("--------------------------------------------------------");
            }
            else if (allısthere2 && allısthere ==false)
            {
                Console.WriteLine("--------------------------------------------------------");
                totalprice = (totalprice / 100) * 75;
                Console.WriteLine("Yüzde 25 İndirim Uygulandı");
                Console.WriteLine($"{oldprice} >> {totalprice}");
                Console.WriteLine("--------------------------------------------------------");
            } 
            else if(allısthere && allısthere2)
            {
                Console.WriteLine("--------------------------------------------------------");
                totalprice = totalprice / 2;
                Console.WriteLine("Yüzde 50 İndirim Uygulandı");
                Console.WriteLine($"{oldprice} >> {totalprice}");
                Console.WriteLine("--------------------------------------------------------");
            }
            Console.WriteLine("|              Devam Etmek İçin Enter a                |");
            Console.WriteLine("|  Satın Alma EKranına Geri Dönmek İçin BackSpace e    |");
            Console.WriteLine("|          Uygulamayı Kapatmak İçin ESC Basınız        |");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("Ödeme Ekranına Aktarılıyorsunuz...");
                Thread.Sleep(2000);
                Console.Clear();
                payment();
            }
            else if(keyInfo.Key == ConsoleKey.Backspace)
            {
                Console.WriteLine("Ödeme Ekranına Dönüyorsunuz..."); 
                Thread.Sleep(2000);
                Console.Clear();
                Purchase();
            }
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Uygulama Kaptılıyor..."); Thread.Sleep(2000);
                Environment.Exit(0);
            }

        }
        public void payment()
        {
            Console.WriteLine("----- *** Hangi Yöntem İle Ödeme Yapıcaksınız *** -----");
            Console.WriteLine("-----           1- Nakit İle Ödeme            *** -----");
            Console.WriteLine("-----         2- Kredi Kartı İle Ödeme        *** -----");
            Console.WriteLine("Kredi Kartı İle Ödemelerde % 2 İşlem Ücreti Alınıcaktır");
            Console.Write("\nLütfen Seçtiğiniz Ödeme Yöntemini Girin:");
            int count;
            string input = Console.ReadLine();
            while (!int.TryParse(input, out count))
            {
                Console.WriteLine("Geçerli Bir Sayı Giriniz:");
                input = Console.ReadLine();
            }
            switch (count)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine($"|{totalprice} TL Lik Ödemeyi Onaylamak İçin Enter a Basınız|");
                    Console.WriteLine("|      Satın Alma Menüsü İçin Backspace e  Basınız        |");
                    Console.WriteLine("|                 Çıkmak İçin ESC ye Basınız              |");
                    Console.WriteLine("-----------------------------------------------------------");
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.Enter:
                            Console.Clear();
                            Console.WriteLine("----- *** Teşekkür Ederiz *** -----");
                            Console.WriteLine("Ödeme Tamamlandı Ana Menüye Dönüyorsunuz..."); totalprice = 0;
                            Thread.Sleep(2000);
                            Console.Clear();
                            WelcomeSeen();
                            break;
                        case ConsoleKey.Backspace:
                            Console.Clear();
                            Console.WriteLine("Satın Alma Menüsüne Dönülüyor..."); totalprice = 0;
                            Thread.Sleep(2000);
                            Console.Clear();
                            Purchase();
                            break;
                        case ConsoleKey.Escape:
                            Console.Clear();
                            Console.WriteLine("Uygulamadan Çıkılıyor..."); Thread.Sleep(2000);
                            Environment.Exit(0);
                            break;
                    }
                    break;
                case 2:
                    Console.Clear();
                    double newprice = totalprice + (totalprice / 100 * 2);
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine($"|{newprice} TL Lik Ödemeyi Onaylamak İçin Enter a Basınız|");
                    Console.WriteLine("|      Satın Alma Menüsü İçin Backspace e  Basınız        |");
                    Console.WriteLine("|                 Çıkmak İçin ESC ye Basınız              |");
                    Console.WriteLine("-----------------------------------------------------------");
                    ConsoleKeyInfo _keyInfo = Console.ReadKey(); Console.Clear();
                    switch (_keyInfo.Key)
                    {
                        case ConsoleKey.Enter:
                            Console.Clear();
                            Console.WriteLine("----- *** Teşekkür Ederiz *** -----");
                            Console.WriteLine("Ödeme Tamamlandı Ana Menüye Dönüyorsunuz..."); totalprice = 0;
                            Thread.Sleep(2000);
                            Console.Clear();
                            WelcomeSeen();
                            break;
                        case ConsoleKey.Backspace:
                            Console.Clear();
                            Console.WriteLine("Satın Alma Menüsüne Dönülüyor..."); totalprice = 0;
                            Thread.Sleep(2000);
                            Console.Clear();
                            Purchase();
                            break;
                        case ConsoleKey.Escape:
                            Console.Clear();
                            Console.WriteLine("Uygulamadan Çıkılıyor..."); Thread.Sleep(2000);
                            Environment.Exit(0);
                            break;
                    }
                    break;
            }
        }


    }
}
