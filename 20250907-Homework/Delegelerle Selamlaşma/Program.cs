namespace Homework
{
    delegate string Print(string name);
    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.Title = "Delegelerle Selemlaşma";
            Console.ForegroundColor = ConsoleColor.White;
            Print printDelegate = print;
            while (true)
            {
                Console.WriteLine("* 1. Ödev *");
                Console.WriteLine(printDelegate(get()));
                break;
            }
        }
        private static string get()
        {
            string name;
            while (true)
            {
                Console.Write("İsminizi Giriniz:");
                name= Console.ReadLine();
                if (!string.IsNullOrEmpty(name))
                {
                    return name;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("*                       İsim Boş Olamaz                    *"); 
                    Console.WriteLine("------------------------------------------------------------");
                    Thread.Sleep(2000); Console.Clear();
                }
            }
        }
        private static string print(string name)
        {
            Console.Clear();
            string message = $"İsminiz:{name}";
            return message;
        }
    }
}