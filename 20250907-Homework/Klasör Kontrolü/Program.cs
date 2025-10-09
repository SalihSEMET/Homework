namespace Homework
{
    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.Title = "Klasör Kontrolü";
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Olan Klasör İçin Enter,Olmayan İçin ESC ye Basınız...");
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.Enter:
                    string folderPath = @"C:\Users\semet\OneDrive\Masaüstü\Yazılım\PushGithubHomework\Homework\Homework\20250907-Homework\Dosyaya Yaz  Dosyadan Oku";

                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                        Console.WriteLine("Dosya Oluşturuldu:" + folderPath);
                    }
                    else
                    {
                        Console.WriteLine("Dosya Zaten Var:" + folderPath);
                    }

                    string filePath = Path.Combine(folderPath, "SA.txt");
                    string textToWrite;

                    if (!File.Exists(filePath))
                    {
                        Console.Write("Dosyaya Yazılcak Mesajı Yaz:");
                        textToWrite = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Dosya Zaten Var Üzerine Yazar");
                        Console.Write("Üzerine Yazılıcak Metin:");
                        textToWrite = Console.ReadLine();
                    }

                    File.WriteAllText(filePath, textToWrite);
                    Console.WriteLine("Metin Buraya Yazıldı:" + filePath);
                    break;
                case ConsoleKey.Escape:
                    string folderPathh = @"C:\Users\semet\OneDrive\Masaüstü\Yazılım\PushGithubHomework\Homework\Homework\20250907-Homework\VarOlmayanDosya";

                    if (!Directory.Exists(folderPathh))
                    {
                        Directory.CreateDirectory(folderPathh);
                        Console.WriteLine("Dosya Oluşturuldu:" + folderPathh);
                    }
                    else
                    {
                        Console.WriteLine("Dosya Zaten Var:" + folderPathh);
                    }

                    string filePathh = Path.Combine(folderPathh, "SA.txt");
                    string textToWritee;

                    if (!File.Exists(filePathh))
                    {
                        Console.Write("Dosyaya Yazılcak Mesajı Yaz:");
                        textToWritee = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Dosyada Mesaj Zaten Var Üzerine Yazar");
                        Console.Write("Üzerine Yazılıcak Metin:");
                        textToWritee = Console.ReadLine();
                    }

                    File.WriteAllText(filePathh, textToWritee);
                    Console.WriteLine("Metin Buraya Yazıldı" + filePathh);
                    break;
            }
        }
    }
}