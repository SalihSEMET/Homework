namespace Homework
{
    using System;
    using System.IO;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.Title = "Dosya İşlemleri Günlük";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--- Günlük Yazma Programı ---");
            Console.WriteLine("Lütfen günlüğünüzü yazın. Kaydetmek için boş bir satırda Enter'a basın:");

            StringBuilder contentBuilder = new StringBuilder();
            string line;
            while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
            {
                contentBuilder.AppendLine(line);
            }

            string diaryContent = contentBuilder.ToString();

            if (string.IsNullOrWhiteSpace(diaryContent))
            {
                Console.WriteLine("\nHiçbir şey yazmadığınız için dosya oluşturulmadı.");
                Console.ReadKey();
                return;
            }

            try
            {
                DateTime currentDate = DateTime.Now;
                string fileName = $"{currentDate:yyyy-MM-dd}.txt";

                File.WriteAllText(fileName, diaryContent);

                string fullPath = Path.GetFullPath(fileName);
                Console.WriteLine("\n------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Günlük başarıyla kaydedildi!");
                Console.WriteLine($"Dosya Adı: {fileName}");
                Console.WriteLine($"Kaydedildiği Konum: {fullPath}");
                Console.ResetColor();
                Console.WriteLine("------------------------------------------------");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nHATA: Günlük kaydedilirken bir sorun oluştu.");
                Console.WriteLine($"Detay: {ex.Message}");
                Console.ResetColor();
            }

            Console.WriteLine("\nProgramı kapatmak için bir tuşa basın.");
            Console.ReadKey();
        }
    }
}