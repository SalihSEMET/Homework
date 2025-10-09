namespace Homework
{
    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.Title = "Generic Sınıf Depo";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("### Kitap Deposu (string) Testi ###");
            Depo<string> bookDepo = new Depo<string>();
            bookDepo.Add("1984 - George Orwell");
            bookDepo.Add("Sefiller - Victor Hugo");
            bookDepo.Add("Fahrenheit 451 - Ray Bradbury");
            bookDepo.ListItems();

            bookDepo.Remove("Sefiller - Victor Hugo");
            bookDepo.Remove("Suç ve Ceza - Dostoyevski");
            bookDepo.ListItems();

            Console.WriteLine("\n### Sipariş Numarası Deposu (int) Testi ###");
            Depo<int> orderNumberDepo = new Depo<int>();
            orderNumberDepo.Add(101);
            orderNumberDepo.Add(102);
            orderNumberDepo.Add(205);
            orderNumberDepo.ListItems();

            orderNumberDepo.Remove(102);
            orderNumberDepo.ListItems();

            Console.WriteLine("\n### Elektronik Eşya Deposu (Product Sınıfı) Testi ###");
            Depo<Product> productDepo = new Depo<Product>();

            Product laptop = new Product { Id = 1, Name = "Dizüstü Bilgisayar" };
            Product phone = new Product { Id = 2, Name = "Akıllı Telefon" };

            productDepo.Add(laptop);
            productDepo.Add(phone);
            productDepo.ListItems();

            productDepo.Remove(laptop);
            productDepo.ListItems();
        }
    }
}