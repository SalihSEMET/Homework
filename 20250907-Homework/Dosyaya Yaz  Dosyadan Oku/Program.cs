namespace Homework
{
    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.Title = "Dosyaya Yaz Dosyadan Oku";
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Mesajınızı Yazınız:");
            string text = Console.ReadLine();
            string fileName = "example.txt";
            File.WriteAllText(fileName,text);
            Console.WriteLine("Mesajınız Kayıt Edildi");
            string readedText = File.ReadAllText(fileName);
            Console.WriteLine("Mesajınız:" + readedText);
        }
    }
}

