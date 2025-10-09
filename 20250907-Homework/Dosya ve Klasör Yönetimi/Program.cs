using System.IO;
using System.Text;
namespace Homework
{
    class Program
{
    static void Main()
    {
            Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.Title = "Dosya Ve Klasör Yönetimi";
            Console.ForegroundColor = ConsoleColor.White;
            string targetDirectory = Path.Combine(Directory.GetCurrentDirectory(), "TestKlasoru");

        if (!Directory.Exists(targetDirectory))
        {
            Directory.CreateDirectory(targetDirectory);
        }

        File.WriteAllText(Path.Combine(targetDirectory, "dosya1.txt"), "Bu birinci metin dosyasının içeriğidir.\n");
        File.WriteAllText(Path.Combine(targetDirectory, "dosya2.txt"), "Bu da ikinci dosyanın metnidir.\n");
        File.WriteAllText(Path.Combine(targetDirectory, "notlar.txt"), "Bunlar da önemli notlar.\n");
        File.WriteAllText(Path.Combine(targetDirectory, "veriler.csv"), "1,2,3,4,5");
        
        Console.WriteLine($"Test ortamı '{targetDirectory}' klasöründe hazırlandı.");
        Console.WriteLine("-------------------------------------------------");

        MergeTxtFiles(targetDirectory);

        Console.WriteLine("\nİşlem tamamlandı. Sonucu kontrol etmek için Enter'a basın ve dosyayı açın.");
        Console.ReadLine();

        System.Diagnostics.Process.Start("notepad.exe", Path.Combine(targetDirectory, "Hepsi.txt"));
    }

    public static void MergeTxtFiles(string directoryPath)
    {
        try
        {
            string[] txtFilePaths = Directory.GetFiles(directoryPath, "*.txt");

            if (txtFilePaths.Length == 0)
            {
                Console.WriteLine("Belirtilen klasörde birleştirilecek .txt dosyası bulunamadı.");
                return;
            }

            string combinedFilePath = Path.Combine(directoryPath, "Hepsi.txt");
            
            Console.WriteLine($"{txtFilePaths.Length} adet .txt dosyası bulundu. İçerikler '{combinedFilePath}' dosyasına yazılıyor...");

            using (StreamWriter writer = new StreamWriter(combinedFilePath, false, Encoding.UTF8))
            {
                foreach (string filePath in txtFilePaths)
                {
                    if (Path.GetFileName(filePath).Equals("Hepsi.txt", StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }
                    
                    Console.WriteLine($"-> Okunuyor: {Path.GetFileName(filePath)}");

                    string content = File.ReadAllText(filePath, Encoding.UTF8);
                    
                    writer.Write(content);
                }
            }
            Console.WriteLine("\nBirleştirme işlemi başarıyla tamamlandı.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Bir hata oluştu: {ex.Message}");
        }
    }
}
}