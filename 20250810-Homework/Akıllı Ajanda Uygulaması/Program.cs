using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Akıllı_Ajanda_Uygulaması
{
    internal class GünlerveGörevler
    {
        public string[] günler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
        public string[,] görevler = new string[7, 5];
    }
    internal class Methodlar
    {
        public void GörevleriYazdır(GünlerveGörevler günlerveGörevler)
        {
            Console.Clear();
            for (int i = 0; i < günlerveGörevler.günler.Length; i++)
            {
                Console.WriteLine($"----- *** {günlerveGörevler.günler[i]} Günü Görevleri *** -----");
                bool görevVar = false;

                for (int j = 0; j < 5; j++)
                {
                    string görev = günlerveGörevler.görevler[i, j];
                    if (!string.IsNullOrWhiteSpace(görev))
                    {
                        Console.WriteLine($"   - Görev {j + 1}: {görev}");
                        görevVar = true;
                    }
                }

                if (!görevVar)
                {
                    Console.WriteLine("   - Görev yok.");
                }
            }
            Console.Write("Ana Menüye Geri Dönmek İçin Herhangi Bir Tuşa Basınız..."); Console.ReadLine(); Console.Clear();
        }
        public void GörevEkleme(GünlerveGörevler günlerveGörevler)
        {
            Console.Clear();
            int sonuç;
            while (true)
            {
                Console.Write("|Hangi Güne Görev Eklemek İstersiniz(Pazartesi(1)-Pazar(7)) Gibi Günün Numarasını Girin|:");
                string girdi = Console.ReadLine();
                if (int.TryParse(girdi, out sonuç) && sonuç >= 1 && sonuç <= 7)
                    break;
                else
                    Console.Write("Yanlış Giriş Yaptınız Lütfen Tekrar Deneyiniz...");
            }
            switch (sonuç)
            {
                case 1:
                    GörevEkle(günlerveGörevler, 0);
                    break;
                case 2:
                    GörevEkle(günlerveGörevler, 1);
                    break;
                case 3:
                    GörevEkle(günlerveGörevler, 2);
                    break;
                case 4:
                    GörevEkle(günlerveGörevler, 3);
                    break;
                case 5:
                    GörevEkle(günlerveGörevler, 4);
                    break;
                case 6:
                    GörevEkle(günlerveGörevler, 5);
                    break;
                case 7:
                    GörevEkle(günlerveGörevler, 6);
                    break;
            }

        }
        private void GörevEkle(GünlerveGörevler günlerveGörevler, int günIndex)
        {
            Console.Clear();
            Console.WriteLine($"----- *** {günlerveGörevler.günler[günIndex]} Olan Görevler *** -----");
            for (int j = 0; j < 5; j++)
            {
                string görev = günlerveGörevler.görevler[günIndex, j];
                if (!string.IsNullOrWhiteSpace(görev))
                    Console.WriteLine($"   - Görev {j + 1}: {görev}");
                else
                    Console.WriteLine($"   - Görev {j + 1}: Boş");
            }
            while (true)
            {
                Console.Write("\n|Boş Görevlere Yeni Ekleme Yada Var Olan Görevi Değiştirmek İçin|\n|İşlem Yapmak İstediğiniz Görev Sırasını Girin|:");
                if (int.TryParse(Console.ReadLine(), out int seçim) && seçim >= 1 && seçim <= 5)
                {
                    Console.Write("Ne Eklemek İstersiniz:");
                    günlerveGörevler.görevler[günIndex, seçim - 1] = Console.ReadLine();
                    Console.Write("Ekleme Başarılı Devam Etmek İçin Herhangi Bir Tuşa Basınız...");
                    Console.Read(); Console.Clear();
                    break;
                }
                else
                    Console.WriteLine("Lütfen 1 ile 5 arasında bir sayı giriniz.");
            }
            Console.Write("Görev ekleme işlemi tamamlandı. Ana menüye dönmek için bir tuşa basınız...");
            Console.ReadLine();
            Console.Clear();
        }
        public void GörevSilme(GünlerveGörevler günlerveGörevler)
        {
            Console.Clear();
            int sonuç;
            while (true)
            {
                Console.Write("|Hangi Günden Görev Silmek İstersiniz \n(Pazartesi(1)-Pazar(7)) Gibi Günün Numarasını Girin|:");
                string girdi = Console.ReadLine();
                if (int.TryParse(girdi, out sonuç) && sonuç >= 1 && sonuç <= 7)
                    break;
                else
                    Console.Write("Yanlış Giriş Yaptınız Lütfen Tekrar Deneyiniz...");
            }

            int günIndex = sonuç - 1;
            Console.Clear();
            Console.WriteLine($"----- *** {günlerveGörevler.günler[günIndex]} Olan Görevler *** -----");

            bool tümGörevlerBoş = true;
            for (int j = 0; j < 5; j++)
            {
                string görev = günlerveGörevler.görevler[günIndex, j];
                if (!string.IsNullOrWhiteSpace(görev))
                {
                    tümGörevlerBoş = false;
                    Console.WriteLine($"   - Görev {j + 1}: {görev}");
                }
                else
                {
                    Console.WriteLine($"   - Görev {j + 1}: Boş");
                }
            }

            if (tümGörevlerBoş)
            {
                Console.WriteLine("Bu gün için zaten hiçbir görev bulunmamaktadır. Ana menüye dönmek için bir tuşa basınız...");
                Console.ReadLine();
                Console.Clear();
                return;
            }

            while (true)
            {
                Console.Write("\n|Silmek İstediğiniz Görev Sırasını Girin|:");
                if (int.TryParse(Console.ReadLine(), out int seçim) && seçim >= 1 && seçim <= 5)
                {
                    if (!string.IsNullOrWhiteSpace(günlerveGörevler.görevler[günIndex, seçim - 1]))
                    {
                        günlerveGörevler.görevler[günIndex, seçim - 1] = null;
                        Console.WriteLine("Görev silme işlemi başarılı. Ana menüye dönmek için bir tuşa basınız...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Seçtiğiniz görev zaten boş. Lütfen başka bir görev seçiniz.");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen 1 ile 5 arasında bir sayı giriniz.");
                }
            }
        }
        internal class Program
        {
            static void MenüAtayıcı(GünlerveGörevler günlerveGörevler, Methodlar methodlar)
            {
                Console.Clear();
                while (true)
                {
                    int seçim;
                    while (true)
                    {
                        Console.WriteLine("----- *** Akıllı Ajandaya Hoşgeldiniz *** -----\n|             1- Görevleri Göster             |\n|                 2- Görev Ekle               |\n|                 3- Görev Sil                |\n|             4- Uygulamadan Çık              |");
                        Console.Write("Seçiminiz Nedir:");
                        string girdi = Console.ReadLine();
                        if (int.TryParse(girdi, out seçim) && seçim >= 1 && seçim <= 4)
                            break;
                        else
                            Console.Write("Yanlış Giriş Yaptınız Lütfen Tekrar Deneyiniz..."); Thread.Sleep(1000); Console.Clear();
                    }
                    switch (seçim)
                    {
                        case 1:
                            methodlar.GörevleriYazdır(günlerveGörevler);
                            break;
                        case 2:
                            methodlar.GörevEkleme(günlerveGörevler);
                            break;
                        case 3:
                            methodlar.GörevSilme(günlerveGörevler);
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Uygulamadan Çıkılıyor..."); Thread.Sleep(2000); Console.Clear();
                            Environment.Exit(0);
                            break;
                    }
                }
            } 
            static void Main(string[] args)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black; Console.Title = "Akıllı Ajanda Uygulaması";
                GünlerveGörevler günlervegörevler = new GünlerveGörevler();
                Methodlar methodlar = new Methodlar();
                MenüAtayıcı(günlervegörevler, methodlar);
            }
        }
    }
}
