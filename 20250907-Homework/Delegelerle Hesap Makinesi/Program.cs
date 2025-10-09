namespace Homework
{
    public delegate long MathDelegate();

    public static class Math
    {
        public static long collection()
        {
            Console.Write("Kaç Sayı Topluycaksın:");
            int count = int.Parse(Console.ReadLine());
            long[] numbers = new long[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{i + 1}. Sayıyı Giriniz:");
                numbers[i] = long.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("----- SAYILAR -----");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. Sayı {numbers[i]}");
            }

            long total = 0;
            
            for (int i = 0; i < count; i++)
            {
                total += numbers[i];
            }

            return total;
        }
        public static long subtraction()
        {
            Console.Write("Eksilen Sayıyı Giriniz:");
            long number = long.Parse(Console.ReadLine());
            Console.Write("Çıkan Sayıyı Giriniz:");
            long number2 = long.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"*** Eksilen Sayı:{number} ***");
            Console.WriteLine($"*** Çıkan Sayı:{number2} ***");
            return number - number2;
        }
        public static long multiplication()
        {
            Console.Write("Kaç Sayı Çarpıcaksın:");
            int count = int.Parse(Console.ReadLine());
            long[] numbers = new long[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{i + 1}. Sayıyı Giriniz:");
                numbers[i] = long.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("----- SAYILAR -----");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. Sayı {numbers[i]}");
            }

            long total = 1;
            
            for (int i = 0; i < count; i++)
            {
                total *= numbers[i];
            }

            return total;
        }
        public static long division()
        {
            Console.Write("Bölünecek Sayıyı Giriniz:");
            long dividend = long.Parse(Console.ReadLine());
            Console.Write("Bölen Sayıyı Giriniz:");
            long divisor = long.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"*** Bölünecek Sayı:{dividend} ***");
            Console.WriteLine($"***   Bölen Sayı:{divisor}    ***");
            return dividend / divisor;
        }
    }
    class Program
    {
        static void Main()
        {
            MathDelegate mathDelegate = Math.collection;
            Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.Title = "Delegelerle Hesap Makinası";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----- *** Hesap Makinasına Hoşgeldiniz *** -----");
            Console.WriteLine("----- --- ******** 1) Toplama ******** --- -----");
            Console.WriteLine("----- --- ******** 2) Çıkarma ******** --- -----");
            Console.WriteLine("----- --- ******** 3) Çarpma  ******** --- -----");
            Console.WriteLine("----- --- ******** 4) Bölme   ******** --- -----");
            Console.Write("|Hangi İşlemi Yapmak İstersiniz|:");
            string choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    long resoult = mathDelegate();
                    Console.WriteLine($"|   Toplama Sonucunuz:{resoult}   |");
                    break;
                case "2":
                    mathDelegate += Math.subtraction;
                    mathDelegate -= Math.collection;
                    resoult = mathDelegate();
                    Console.WriteLine($"|   Çıkarma Sonucunuz:{resoult}   |");
                    break;
                case "3":
                    mathDelegate += Math.multiplication;
                    mathDelegate -= Math.collection;
                    resoult = mathDelegate();
                    Console.WriteLine($"|   Çarpma Sonucunuz:{resoult}   |");
                    break;
                case "4":
                    mathDelegate += Math.division;
                    mathDelegate -= Math.collection;
                    resoult = mathDelegate();
                    Console.WriteLine($"|   Bölme Sonucunuz:{resoult}   |");
                    break;
            }
        }
    }
}