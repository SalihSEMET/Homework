namespace Homework
{
    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.Title = "Tuple İle Kordinatlar";
            Console.ForegroundColor = ConsoleColor.White;
             Tuple<int, int>[] coordinates = new Tuple<int, int>[3];

             for (int i = 0; i < 3; i++)
             {
                 Console.Write($"Nokta {i + 1} için x değerini girin: ");
                 int x = int.Parse(Console.ReadLine());

                 Console.Write($"Nokta {i + 1} için y değerini girin: ");
                 int y = int.Parse(Console.ReadLine());

                 coordinates[i] = new Tuple<int, int>(x, y);
             }

             Console.WriteLine("\nGirilen Noktalar:");
             for (int i = 0; i < 3; i++)
             {
                 Console.WriteLine($"Nokta {i + 1}: ({coordinates[i].Item1}, {coordinates[i].Item2})");
             }
        }
    }
}

