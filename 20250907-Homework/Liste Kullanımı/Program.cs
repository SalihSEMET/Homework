namespace Homework
{
    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.Title = "Liste Kullanımı";
            Console.ForegroundColor = ConsoleColor.White;
           List<string> citys = new List<string>();
           citys.Add("Ankara");
           citys.Add("İstanbul");
           citys.Add("Giresun");
           citys.Add("Samsun");
           citys.Add("Kastamonu");
           Console.WriteLine("* 2. Ödev *");
           while (true)
           {
               Console.WriteLine("Şehir Eklemek İçin 1 e| Şehirleri Listelemek İçin 2  | Uygulamadan Çıkmak İçin 3 Yazınız");
               Console.Write("Seçiminiz:");
               string choose = Console.ReadLine();
               if (choose == "1")
               {
                   Console.Clear();
                   Console.Write("Kaç Adet Şehir Eklemek İstersiniz:");
                   int number = int.Parse(Console.ReadLine());
                   for (int i = 0;i < number; i++)
                   {
                       Console.Write($"{i + 1}. Şehrinizi Ekleyiniz:");
                       citys.Add(Console.ReadLine());
                   }

                   Console.Write("Ekleme Başarılı Ana Menüye Dönüyorsunuz..."); Thread.Sleep(2000);
                   Console.Clear();
               }
               else if (choose == "2")
               {
                   Console.Clear();
                   for (int i = 0; i < citys.Count; i++)
                   {
                       Console.WriteLine($"{i + 1}. Şehir:{citys[i]}");
                   }

                   Console.Write("Ana Menüye Dönmek İçin Herhangi Bir Tuşa Basınız...");
                   Console.ReadLine();
                   Console.Clear();
               }
               else if (choose == "3")
               {
                   Console.Clear();
                   Console.Write("Çıkış Yapılıyor..."); Thread.Sleep(2000);
                   Environment.Exit(0);
               }
               else
               {
                   Console.WriteLine("Yanlış Seçim Tekrar Deneyiniz Yönlendirliyorsunuz...");
                   Thread.Sleep(2000);
                   Console.Clear();
               }
           }
        }
    }
}