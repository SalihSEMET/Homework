namespace Homework;

internal static class ExtantionMethods
{
    public static int squareIt(this int number)
    {
        return number * number;
    }
}
class Program
{
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
        Console.Title = "Extension Method Kare Alma";
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
        Console.Title = "Extension Method İle Kare Alma";
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Sayı Giriniz:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"Karesi:{number.squareIt()}");
    }
}
