using System.Reflection;
using Plugin.Interfaces;
namespace Plugin.Interfaces.ConsoleApp
{
    class Program
    {
        private static List<IOperasyon> operasyonlar;

        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Title = "Plugin Altyapılı Hesap Makinası";

            Console.WriteLine("----- *** Hesap Makinasına Hoşgeldiniz *** -----");
            operasyonlar = OperasyonlarıYükle();
            if (operasyonlar.Count == 0)
            {
                Console.WriteLine("Hiçbir Operasyon Bulunamadı..." +
                                  "Program Sonlandırılıyor \nÇıkmak İçin Herhangi Bir Tuşa Basınız...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Hesap Makinası Eklentileri Başarı İle Eklendi");
            while (true)
            {
                ShowMenu();
                string choose = Console.ReadLine();
                var chooseOperation = operasyonlar.FirstOrDefault(o => o.symbol == choose);
                if (chooseOperation == null)
                {
                    if (choose.ToLower() == "c")
                    {
                        break;
                    }
                    Console.WriteLine("Geçersiz Seçim");
                    continue;
                }

                Console.Write("Lütfen Birinci Sayıyı Giriniz:");
                double number1 = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("\nLütfen İkinci Sayıyı Giriniz:");
                double number2 = Convert.ToDouble(Console.ReadLine());

                double resoult = chooseOperation.calculate(number1, number2);

                if (!double.IsNaN(resoult))
                {
                    Console.WriteLine($"Sonuç: {resoult}");
                }
                
            }
        }

        static List<IOperasyon> OperasyonlarıYükle()
        {
            var foundoperasyonlar = new List<IOperasyon>();
            string extansionFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "operasyonlar");
            if (!Directory.Exists(extansionFolder))
            {
                Directory.CreateDirectory(extansionFolder);
                return foundoperasyonlar;
            }

            string[] dllFiles = Directory.GetFiles(extansionFolder, "*.dll");

            foreach (var file in dllFiles)
            {
                try
                {
                    Assembly assembly = Assembly.LoadFile(file);
                    var types = assembly.GetExportedTypes()
                        .Where(t => typeof(IOperasyon).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);
                    foreach (var type in types)
                    {
                        IOperasyon operasyon = (IOperasyon)Activator.CreateInstance(type);
                        foundoperasyonlar.Add(operasyon);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Dll Yüklenirken Bir Hata Oluştu{Path.GetFileName(file)} - {ex.Message}");
                }
            }
            return foundoperasyonlar;
        }

        static void ShowMenu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin:");
            foreach (var op in operasyonlar)
            {
                Console.WriteLine($"[{op.symbol}] {op.Explanation}");
            }
            Console.WriteLine("[c] Çıkış");
            Console.Write("Seçiminiz: ");
        }
    }
}