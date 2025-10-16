using Plugin.Interfaces;
namespace SubstractionExtansion 
{
    public class subtraction : IOperasyon
    {
        public string symbol => "-";
        public string Explanation => "Çıkarma";
        public double calculate(double number1, double number2)
        {
            return number1 - number2;
        }
    }
}

