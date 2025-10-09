namespace Homework
{
    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.Title = "Extantion Method LINQ Benzeri";
            Console.ForegroundColor = ConsoleColor.White;
            List<int> numbersList = new List<int> { 1, 2, 3, 4, 5 };
        
            double resultFromList = numbersList.AverageSquared();

            Console.WriteLine("Liste: { 1, 2, 3, 4, 5 }");
            Console.WriteLine("Beklenen Hesaplama: (1*1 + 2*2 + 3*3 + 4*4 + 5*5) / 5 = (1 + 4 + 9 + 16 + 25) / 5 = 55 / 5 = 11");
            Console.WriteLine($"Hesaplanan Sonuç: {resultFromList}");
        
            Console.WriteLine("\n-----------------------------------\n");
        
            int[] numbersArray = { 10, 20, 30 };
        
            double resultFromArray = numbersArray.AverageSquared();
        
            Console.WriteLine("Dizi: { 10, 20, 30 }");
            Console.WriteLine("Beklenen Hesaplama: (10*10 + 20*20 + 30*30) / 3 = (100 + 400 + 900) / 3 = 1400 / 3 = 466.66...");
            Console.WriteLine($"Hesaplanan Sonuç: {resultFromArray}");
        }
    }
}