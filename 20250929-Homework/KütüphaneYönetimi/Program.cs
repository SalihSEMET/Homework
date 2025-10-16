using System.Globalization;
using _29_09_2025_Homework;

class Program
{
    static void Main()
    {

        var library = new Library();

        Console.BackgroundColor = ConsoleColor.Black;
        Console.Title = "Kütüphane Yönetimi"; Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("----- *** Kitaplık Similasyonuna Hoşgeldiniz *** -----|");
            Console.WriteLine("|                1) Kitap Ekleme                      |");
            Console.WriteLine("|                2) Kitap Silme                       |");
            Console.WriteLine("|           3) Rastgele Kitap Önerisi                 |");
            Console.WriteLine("|       4) Baş Harfe Göre Kitap Listeleme             |");
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("|               Seçiminizi Giriniz                   |:");
            bool chooseCorrect = int.TryParse(Console.ReadLine(), out var choose);
            while (!chooseCorrect)
            {
                Console.Clear();
                Console.WriteLine("Yanlış Giriş Yaptınız Tekrar Deneyiniz...");
                Console.Write("Başlangıça Yönlendiriliyorsunuz Lütfen Bekleyiniz...");
                Thread.Sleep(2000);
                break;
            }
            Console.Clear();
            string input;
            int input2;
            switch (choose)
            {
                case 1:
                    while (true)
                    {
                        Console.WriteLine(" *** Eklemek İstediğiniz Kitapla İlğili Verileri Giriniz *** ");
                        while (true)
                        {
                            Console.Write("|Kitabın Adını Giriniz|:");
                            input = Console.ReadLine();
                            Console.Clear();
                            if (string.IsNullOrEmpty(input))
                            {
                                Console.WriteLine("Ad Boş Olamaz !!!");
                                Console.WriteLine("Tekrar Deneyin");
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.Write("|Kitabınız İçin Id Giriniz|:");
                        chooseCorrect = int.TryParse(Console.ReadLine(), out input2);
                        if(!chooseCorrect)
                        {
                            Console.WriteLine("Yanlış Giriş Yaptınız Tekrar Deneyiniz...");
                            Console.Write("Kitap Ekleme Sayfasına Yönlendiriliyorsunuz Lütfen Bekleyiniz...");
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        if (!string.IsNullOrEmpty(input) && chooseCorrect)
                        {
                            Console.Write("Kontroller Yapılıyor Lütfen Bekleyiniz...");
                            Thread.Sleep(2000);
                            library.AddBook(input2,input);
                            break;
                        }
                    }
                    Console.Write("\n--- 3 Saniye İçerisinde Ana Menüye Dönüceksiniz ---");
                    Thread.Sleep(3000);
                    break;
                case 2:
                    while (true)
                    {
                        Console.WriteLine(" *** Silmek İstediğiniz Kitapla İlğili Verileri Giriniz *** ");
                        library.ListBooks();
                        Console.Write("|Kitabın Id Sini Giriniz|:");
                        chooseCorrect = int.TryParse(Console.ReadLine(), out input2);
                        if(!chooseCorrect)
                        {
                            Console.WriteLine("Yanlış Giriş Yaptınız Tekrar Deneyiniz...");
                            Console.Write("Kitap Silme Sayfasına Yönlendiriliyorsunuz Lütfen Bekleyiniz...");
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        if (chooseCorrect && library.DeleteBook(input2))
                        {
                            Console.WriteLine("Kitap Silme İşlemi Başarılı");
                            Console.Write("\n--- 3 Saniye İçerisinde Ana Menüye Dönüceksiniz ---");
                            Thread.Sleep(3000);
                            break;
                        }
                    }
                    break;
                case 3:
                    while (true)
                    {
                        Console.WriteLine("--- Rastgele Kitap Önerisi Testi ---");
                        try
                        {
                            Console.WriteLine("Önerilen Birinci Kitabın:");
                            var recommentbook1 = library.Recommend_A_RandomBook();
                            Console.WriteLine($"ID si: {recommentbook1.Key}, Adı: {recommentbook1.Value}");

                            Console.WriteLine("\nÖnerilen İkinci Kitabın:");
                            var recommendbook2 = library.Recommend_A_RandomBook();
                            Console.WriteLine($"ID si: {recommendbook2.Key}, Adı: {recommendbook2.Value}");
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine($"Bir hata oluştu: {ex.Message}");
                        }

                        Console.Write("\nDevam Etmek İçin Herhangi Bir Tuşa Basınız...");
                        Console.ReadLine();
                        break;
                    }
                    break;
                case 4:
                    while (true)
                    {
                        Console.WriteLine("--- Harfe Göre Arama Testi ---");
                        Console.Write("Lütfen bir harf giriniz: ");
                        input = Console.ReadLine();
                        Console.WriteLine("\n======================================\n");
                        if (!string.IsNullOrEmpty(input))
                        {
                            var sonuclar = library.FindBooksByLetter(input[0]);
                            if (sonuclar.Any())
                            {
                                foreach (var kitap in sonuclar) Console.WriteLine($"Bulunan: ID: {kitap.Key}, Adı: {kitap.Value}");
                            }
                            else
                                Console.WriteLine("Kitap bulunamadı.");
                        }
                        Console.WriteLine("\n======================================\n");
                        Console.Write("\nAna Menüye Dönmek İçin Herhangi Bir Tuşa Basınız...");
                        Console.ReadLine();
                        break;
                    }
                    break;
            }
        }
    }
}