using Plugin.Interfaces;
namespace MultiplicationExtansion
{
    public class multiplication : IOperasyon
    {
        public string symbol => "*";
        public string Explanation => "Çarpma";
        public double calculate(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}

