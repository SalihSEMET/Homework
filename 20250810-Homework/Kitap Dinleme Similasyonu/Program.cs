using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kitap_Dinleme_Similasyonu
{
    class kitaplar
    {
        //Hikaye
        public string[] EjderhaGeçidi = new string[]
{
    "Güneş", ",", "dağların", "ardında", "kaybolurken", "Kafran", "Vadisi", "sessizliğe", "bürünmüştü", ".",
    "Yirmi", "yaşındaki", "Kael", ",", "köyün", "demircisinin", "çırağıydı", "ama", "bu", "gece", "bambaşka", "bir", "görevi", "vardı", ":",
    "Yasaklı", "Orman’ın", "derinliklerindeki", "Ejderha", "Geçidi’ni", "bulmak", ".",
    "Rivayete", "göre", "geçidi", "geçen", ",", "kaybolmuş", "kralların", "hazinesine", "ulaşırdı", ".",

    "Karanlıkta", "ilerlerken", "ağaçların", "arasından", "gelen", "fısıltılar", "Kael’in", "cesaretini", "sınadı", ".",
    "Derken", ",", "kırmızı", "gözlü", "bir", "kurt", "önüne", "çıktı", ".",
    "Kael", ",", "kılıcını", "çekti", "ancak", "kurt", "saldırmadı", ",", "yalnızca", "başını", "ormanın", "derinliklerine", "doğru", "salladı", ".",
    "Bu", ",", "gizemli", "bir", "davetti", "." ,

    "Bir", "saat", "sonra", "Kael", ",", "kayalara", "oyulmuş", "devasa", "bir", "kapıya", "ulaştı", ".",
    "Kapının", "ortasında", "altın", "pullarla", "bezeli", ",", "uyuyan", "bir", "ejderha", "vardı", ".",
    "Ejderha", "gözlerini", "açtı", "ve", "konuştu", ":",
    "“Geçmek", "isteyen", ",", "cesaretini", "kanıtlamalı", ".”",

    "Kael", ",", "cebinden", "annesinin", "verdiği", "gümüş", "madalyonu", "çıkardı", ".",
    "Madalyon", ",", "ejderhanın", "göğsünde", "parladı", ".",
    "Ejderha", ",", "başını", "eğdi", "ve", "kapı", "açıldı", ".",
    "Kael", "adım", "attığında", "göz", "kamaştırıcı", "hazine", "önünde", "serildi", ".",
    "Ama", "en", "değerli", "şey", "altın", "değil", ",", "Ejderha", "Geçidi’nin", "artık", "köyünü", "koruyacağına", "dair", "verilen", "söz", "oldu", "."
};
        //Macera
        public string[] ZamanınÖtesindekiAda = new string[]
{
    "Rüzgâr", ",", "geminin", "yırtık", "yelkenlerini", "acımasızca", "savuruyordu", ".",
    "Kaptan", "Mira", ",", "pusulasının", "dönüp", "durduğunu", "fark", "etti", ".",
    "Birden", ",", "sislerin", "arasından", "görünmeyen", "bir", "ada", "belirdi", ".",
    "Mürettebat", "korku", "içinde", "geri", "çekilse", "de", "Mira", "karaya", "çıktı", ".",

    "Ada", ",", "altın", "yapraklı", "ağaçlar", "ve", "gökyüzünde", "süzülen", "balinalarla", "doluydu", ".",
    "Bir", "mağaranın", "içinde", ",", "taş", "bir", "masa", "üzerinde", "duran", "kum", "saati", "dikkatini", "çekti", ".",
    "Kumlar", "yukarıdan", "aşağıya", "değil", ",", "aşağıdan", "yukarıya", "akıyordu", "." ,

    "Tam", "kum", "saatine", "dokunacakken", "arkasında", "yaşlı", "bir", "ses", "duyuldu", ":",
    "“Zamanın", "efendisi", "olabilirsin", "…", "ama", "bedeli", "sonsuz", "yalnızlıktır", ".”",

    "Mira", "tereddüt", "etti", ".",
    "Denizdeki", "hayatı", "zorluydu", "ama", "bu", "güçle", "tüm", "fırtınaları", "durdurabilir", ",", "krallıklar", "kurabilirdi", ".",
    "Yine", "de", "yalnızlık", "fikri", "yüreğini", "sıktı", ".",
    "Kum", "saatini", "yerine", "bıraktı", "." ,

    "Tam", "adadan", "ayrılırken", "kum", "saati", "kendi", "kendine", "çatladı", ".",
    "Zamanda", "bir", "dalgalanma", "oldu", "ve", "Mira", "kendini", "tekrar", "gemisinde", "buldu", ".",
    "Ada", "ortadan", "kaybolmuştu", "…", "ama", "cebinde", ",", "hâlâ", "sıcak", "olan", "bir", "altın", "yaprak", "vardı", "."
};
        //Fantastik
        public string[] GökyüzüŞehriAuralis = new string[]
{
    "Yerden", "binlerce", "metre", "yüksekte", ",", "bulutların", "üzerinde", "Auralis", "adında", "bir", "şehir", "vardı", ".",
    "Yalnızca", "gökkuşağı", "köprüleriyle", "ulaşılan", "bu", "şehir", ",", "rüzgâr", "ustalarının", "yurduydu", ".",
    "Genç", "çırak", "Elara", ",", "ustası", "tarafından", "ilk", "kez", "şehrin", "dışına", ",", "Fırtına", "Vadisi’ne", "gönderildi", ".",

    "Vadide", ",", "gökyüzünü", "delen", "siyah", "bir", "sütun", "yükseliyordu", ".",
    "Elara", "yaklaşınca", "sütunun", "içinde", "hapsolmuş", ",", "kanatları", "zincirlenmiş", "bir", "fırtına", "ejderi", "gördü", ".",
    "Efsaneler", ",", "bu", "ejderin", "özgür", "kaldığında", "şehre", "sonsuz", "enerji", "sağlayacağını", "anlatırdı", "." ,

    "Elara", ",", "zincirleri", "kırmak", "için", "rüzgâr", "büyülerini", "kullandı", ".",
    "Zincirler", "çatırdadı", "ama", "aynı", "anda", "gökyüzü", "karardı", ".",
    "Ustası", "aniden", "yanında", "belirdi", ":",
    "“Bunu", "yaparsan", ",", "Auralis", "ya", "kurtulur", "…", "ya", "da", "sonsuza", "dek", "yok", "olur", "!”",

    "Elara", "tereddüt", "etmedi", ".",
    "Zincirler", "koptu", ",", "ejder", "özgür", "kaldı", ".",
    "Bir", "çığlık", "attı", "ve", "göğe", "yükseldi", ".",
    "Ardından", "şehre", "doğru", "dev", "bir", "ışık", "seli", "indi", ".",
    "Auralis", "artık", "sonsuz", "rüzgârla", "dönen", "bir", "şehir", "olmuştu", ".",
    "Elara", "ise", "“Rüzgârların", "Kızı”", "unvanıyla", "efsanelere", "geçti", "."
};
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black; Console.Title = "Sesli Kitap Dinleme Uygulaması";
            kitaplar kitaplar = new kitaplar();
            Console.WriteLine("----- *** Kitap Okuma Uygulamasına Hoşgeldiniz *** -----");
            Console.WriteLine("| Uygulama Size Seçtiğiniz Kitabı Seçtiğiniz Hızda Okuyacaktır |");
            Console.Write("| Devam Etmek İçin Enter a Çıkmak İçin ESC ye Basınız |");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.Enter:
                    Console.Clear();
                    Console.WriteLine("----- ***     Kitap Türleri     *** -----");
                    Console.WriteLine("----- ***        1-Hikaye       *** -----");
                    Console.WriteLine("----- ***        2-Macera       *** -----");
                    Console.WriteLine("----- ***       3-Fantastik     *** -----");
                    Console.Write("\nHangi Türden Kitap Okumak İstersiniz(Hikaye İçin(1), Macera İçin(2), Fantastic İçin(3)):");
                    int kitaptürü = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("--- Okuma Hızları(dk Başına Kelime Cinsinden) ---\n----- Hızlı Okuma:350 -----\n----- Ortalama:250 -----\n----- Yavaş:150 -----");
                    Console.Write("\n|Hangi Hızda Okumak İstersiniz(Hızlı İçin:1, Ortalama İçin(2),Yavaş İçin(3))|:");
                    int okumahızı = int.Parse(Console.ReadLine());
                    Console.Clear();
                    KitapOkuyucu(kitaplar.EjderhaGeçidi, kitaplar.ZamanınÖtesindekiAda, kitaplar.GökyüzüŞehriAuralis, kitaptürü, okumahızı);
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    Console.WriteLine("Uygulamadan Çıkılıyor..."); Thread.Sleep(2000); Environment.Exit(0);
                    break;
            } 
        }
        static void KitapOkuyucu(string[] kitap1, string[] kitap2, string[] kitap3,int kitaptürü,int okumahızı)
        {
            int beklemesüresi = 0;
            switch (okumahızı)
            {
                case 1:
                    beklemesüresi = 167;
                    break;
                case 2:
                    beklemesüresi = 250;
                    break;
                case 3:
                    beklemesüresi = 400;
                    break;
            }
            switch (kitaptürü)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear(); Console.ForegroundColor = ConsoleColor.Green;
                    for (int i = 0; i < kitap1.Length; i++)
                    {
                        Console.Write(kitap1[i] + "  "); Thread.Sleep(beklemesüresi);
                        if(i % 10 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                    Console.Write("\n\n| Programdan Çıkmak İçin Herhangi Bir Tuşa Basınız... |"); Console.ReadLine();
                    Console.Clear(); Console.Write("Program Kapatılıyor..."); Thread.Sleep(2000); Environment.Exit(0);
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear(); Console.ForegroundColor = ConsoleColor.Blue;
                    for (int i = 0; i < kitap2.Length; i++)
                    {
                        Console.Write(kitap2[i] + "  "); Thread.Sleep(beklemesüresi);
                        if (i % 10 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                    Console.Write("\n\n| Programdan Çıkmak İçin Herhangi Bir Tuşa Basınız... |"); Console.ReadLine();
                    Console.Clear(); Console.Write("Program Kapatılıyor..."); Thread.Sleep(2000); Environment.Exit(0);
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear(); Console.ForegroundColor = ConsoleColor.Red;
                    for (int i = 0; i < kitap3.Length; i++)
                    {
                        Console.Write(kitap3[i] + "  "); Thread.Sleep(beklemesüresi);
                        if (i % 10 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                    Console.Write("\n\n| Programdan Çıkmak İçin Herhangi Bir Tuşa Basınız... |"); Console.ReadLine();
                    Console.Clear(); Console.Write("Program Kapatılıyor..."); Thread.Sleep(2000); Environment.Exit(0);
                    break;

            }
            Console.Clear();

        }
    }
}
