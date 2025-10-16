using System.Text.RegularExpressions;

class Program
{
    static List<string> Posts = new List<string>();

    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Title = "Mini Sosyal Medya Trend Analizi"; Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("----- *** Mini Sosyal Medyaya Hoşgeldiniz *** -----");
        Console.WriteLine("|Postları Görebilmek Ve Post Atabilmek İçin Lütfen Kayıt Olunuz|");
        Console.Write("Adınız:");
        string name = Console.ReadLine();
        Console.Write("Soyadınız:");
        string surname = Console.ReadLine();
        Console.WriteLine($"Başarı İle Kayıt Oldunuz:{name} {surname}");
        Console.WriteLine("\n-------------------------------\nİlk Postu Görmek İçin Herhangi Bir Tuşa Basınız...\n-------------------------------");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("----- *** Salih Kullanıcısının Dedikleri *** -----");
        Console.WriteLine("--------------------------------------------------");
        Posts.Add("Enes Batur İyicene Kafayı Yedi");
        Console.WriteLine(Posts[0] + "--- (17K Like)");
        Console.WriteLine("--------------------------------------------------\n\n");

        Console.WriteLine("İkinci Postu Görmek İçin Herhangi Bir Tuşa Basınız...");
        Console.ReadLine(); Console.Clear();

        Console.WriteLine("----- *** Yusuf Kullanıcısının Dedikleri *** -----");
        Console.WriteLine("--------------------------------------------------");
        Posts.Add("Enes Batur Kanalını Silmiş");
        Console.WriteLine(Posts[1] + "--- (18K Like)");
        Console.WriteLine("--------------------------------------------------\n\n");

        Console.WriteLine("Üçüncü Postu Görmek İçin Herhangi Bir Tuşa Basınız...");
        Console.ReadLine(); Console.Clear();

        Console.WriteLine("----- *** Kerem Kullanıcısının Dedikleri *** -----");
        Console.WriteLine("--------------------------------------------------");
        Posts.Add("Enes Batur Düzgün Bir Kariyer Planlaması Yapsa İdi\n MrBeast e Bile Rakip Olurdu");
        Console.WriteLine(Posts[2] + "--- (25K Like)");
        Console.WriteLine("--------------------------------------------------\n\n");

        Console.WriteLine("Kendi Postunuzu Yazmak İçin Herhangi Bir Tuşa Basınız...");
        Console.ReadLine(); Console.Clear();

        Console.WriteLine($"{name + surname} (Geliştiriciden Not:(Eger En Çok Tekrar Eden Kelimeye Sizin Olsun İstiyorsanız Bol Bol Yazınız:))");
        Console.Write("Postunuzu Yazınız(Bitince Enter a Basınız):");
        string _post = Console.ReadLine();
        Posts.Add(_post);
        Console.Clear();

        Console.WriteLine($"----- *** {name + surname} Kullanıcısının Dedikleri *** -----");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine(_post + "--- (0K Like-Şimdilik)");
        Console.WriteLine("--------------------------------------------------\n\n");

        Console.Write("En Çok Kullanılan Kelimeyi Görmek İçin Herhangi Bir Tuşa Bas...");
        Console.Read(); Console.Clear();

        var wordCounts = new Dictionary<string, int>();

        foreach (var post in Posts)
        {
            string[] words = Regex.Split(post.ToLower(), @"\W+"); //Regex Metin İçindeki Karakterlerle Aradıgımız Seyi Bulmaya Yarar Buradaki \W+ İle Bir Veya Daha Fazla Sayıda Olan Ve Kelimeleri Bulmak İçin Kullanılır Regex.Split ise Bulunan Yerlerden Böler Ve Bu Şekilde Kelimeleri Buluruz.

            foreach (var word in words)
            {
                if (string.IsNullOrEmpty(word))
                    continue;

                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts[word] = 1;
                }
            }
        }

        var mostFrequentWord = wordCounts
            .OrderByDescending(kvp => kvp.Value)
            .FirstOrDefault();
        // Çoktan Az Sıralayıp En Üste Olan Kelimeyi Alıcak

        if (mostFrequentWord.Key != null)
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine($"En Çok Kullanılan Kelime: '{mostFrequentWord.Key}' ({mostFrequentWord.Value} Kez Kullanıldı)");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
        }
        else
        {
            Console.WriteLine("En Çok Kullanılan Kelime Bulunmadı");
        }
    }

}