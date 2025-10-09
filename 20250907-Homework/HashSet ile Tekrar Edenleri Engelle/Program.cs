namespace Homework
{
    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.Title = "HashSet İle Tekrar Edenleri Engelle";
            Console.ForegroundColor = ConsoleColor.White;
            HashSet<int> uniqueNumbers = new HashSet<int>();

            Console.WriteLine("Lütfen sayılar giriniz (Çıkmak için 'q' tuşuna basın):");

            while (true)
            {
                Console.Write("Sayı girin: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    break;
                }

                if (int.TryParse(input, out int number))
                {
                    if (uniqueNumbers.Add(number))
                    {
                        Console.WriteLine($"-> {number} eklendi.");
                    }
                    else
                    {
                        Console.WriteLine($"-> {number} zaten mevcut, eklenmedi.");
                    }
                }
                else
                {
                    Console.WriteLine("-> Geçersiz giriş. Lütfen bir tamsayı girin.");
                }
            }

            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("Girdiğiniz benzersiz sayılar:");

            if (uniqueNumbers.Count == 0)
            {
                Console.WriteLine("Hiç sayı girmediniz.");
            }
            else
            {
                foreach (int uniqueNumber in uniqueNumbers)
                {
                    Console.WriteLine(uniqueNumber);
                }
            }

            Console.WriteLine("------------------------------------");
        }
    }
}