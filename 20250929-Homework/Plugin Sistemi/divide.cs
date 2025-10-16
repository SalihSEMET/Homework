using Plugin.Interfaces;
namespace DivideExtansion
{
    public class divide : IOperasyon
    {
        public string symbol => "/";
        public string Explanation => "Bölme";
        public double calculate(double number1, double number2)
        {
            if (number2 == 0)
            {
                Console.WriteLine("Hata Sıfıra Bölünemez!");
                return double.NaN;//Nan = Not a Number 
            }
            return number1 / number2;
        }
        
    }
}

