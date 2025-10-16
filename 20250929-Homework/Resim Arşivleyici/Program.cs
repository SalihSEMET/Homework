using System;
using System.IO;
using System.Linq;

namespace ImageArchiver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- C# Resim Arşivleyici ---");
            Console.Write("Lütfen Resimlerin Bulunduğu Klasörün Tam Yolunu Girin: ");
            string sourceFolderPath = Console.ReadLine();

            if (!Directory.Exists(sourceFolderPath))
            {
                Console.WriteLine("Hata: Belirtilen klasör bulunamadı!");
                Console.WriteLine("Programı Sonlandırmak İçin Herhangi Bir Tuşa Basın...");
                Console.ReadKey();
                return;
            }

            var jpgFiles = Directory.GetFiles(sourceFolderPath, "*.jpg", SearchOption.TopDirectoryOnly);
            var pngFiles = Directory.GetFiles(sourceFolderPath, "*.png", SearchOption.TopDirectoryOnly);

            var allImages = jpgFiles.Concat(pngFiles).ToList();

            if (allImages.Count == 0)
            {
                Console.WriteLine("Bu Klasörde Arşivlenecek .jpg veya .png Uzantılı Dosya bulunamadı.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"{allImages.Count} Adet Resim Dosyası Bulundu. Arşivleme Başlıyor...");
            int movedFileCount = 0;

            foreach (string currentFilePath in allImages)
            {
                try
                {
                    DateTime creationDate = File.GetCreationTime(currentFilePath);
                    
                    string targetFolderName = creationDate.ToString("yyyy-MM");
                    
                    string targetFolderPath = Path.Combine(sourceFolderPath, targetFolderName);

                    if (!Directory.Exists(targetFolderPath))
                    {
                        Directory.CreateDirectory(targetFolderPath);
                        Console.WriteLine($"-> Yeni klasör Oluşturuldu: {targetFolderName}");
                    }
                    
                    string fileName = Path.GetFileName(currentFilePath);
                    string destinationFilePath = Path.Combine(targetFolderPath, fileName);

                    File.Move(currentFilePath, destinationFilePath);
                    Console.WriteLine($"Taşındı: {fileName}  ->  {targetFolderName}");
                    movedFileCount++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata! {Path.GetFileName(currentFilePath)} Taşınamadı. Sebep: {ex.Message}");
                }
            }

            Console.WriteLine("\n-------------------------------------------------");
            Console.WriteLine($"İşlem Tamamlandı. Toplam {movedFileCount} Dosya Arşivlendi.");
            Console.WriteLine("Programı Sonlandırmak İçin Bir Tuşa Basın...");
            Console.ReadKey();
        }
    }
}