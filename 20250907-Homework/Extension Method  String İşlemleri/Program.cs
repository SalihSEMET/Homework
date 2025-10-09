namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.Title = "Extension Method String İşlemleri";
            Console.ForegroundColor = ConsoleColor.White;
            string text1 = "merhaba dünya";
            string text2 = "c# programlama DİLİ";
            string text3 = "BU BİR TEST CÜMLESİDİR";
            string text4 = "Zaten Doğru Olan Başlık";

            Console.WriteLine("--- ToTitleCase() Extension Metot Testi ---\n");

            Console.WriteLine($"Orijinal: '{text1}'");
            Console.WriteLine($"Sonuç:    '{text1.ToTitleCase()}'\n");

            Console.WriteLine($"Orijinal: '{text2}'");
            Console.WriteLine($"Sonuç:    '{text2.ToTitleCase()}'\n");

            Console.WriteLine($"Orijinal: '{text3}'");
            Console.WriteLine($"Sonuç:    '{text3.ToTitleCase()}'\n");

            Console.WriteLine($"Orijinal: '{text4}'");
            Console.WriteLine($"Sonuç:    '{text4.ToTitleCase()}'\n");
        }
    }
}