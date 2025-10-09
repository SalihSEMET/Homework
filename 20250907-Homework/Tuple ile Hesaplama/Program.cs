namespace Homework
{
    class Program
    {
        public static Tuple<long, bool> Calculate(int number)
        {
            long factorial = 1;
            bool isPrime = true;

            if (number < 2)
            {
                isPrime = false;
                if (number < 0)
                {
                    factorial = 0;
                }
                else
                {
                    factorial = 1;
                }
            }
            else
            {
                for (int i = 2; i <= number; i++)
                {
                    factorial *= i;

                    if (isPrime && i < number && number % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }

            return new Tuple<long, bool>(factorial, isPrime);
        }

        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.Title = "Tuple İle Hesaplama";
            Console.ForegroundColor = ConsoleColor.White;
            int[] numbersToTest = { 5, 10, 7, 2, 1, 0, 13, -3 };

            Console.WriteLine("Sayıların faktöriyel ve asallık durumları:");
            Console.WriteLine("------------------------------------------");

            foreach (var number in numbersToTest)
            {
                Tuple<long, bool> result = Calculate(number);

                long factorialResult = result.Item1;
                bool primalityStatus = result.Item2;

                Console.WriteLine(
                    $"Sayı: {number,-3} -> Faktöriyel: {factorialResult,-15} | Asal mı?: {primalityStatus}");
            }
        }
    }
}