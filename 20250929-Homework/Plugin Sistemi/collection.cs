using Plugin.Interfaces;

namespace CollectionExtansion
{
    public class collection : IOperasyon
    {
        public string symbol => "+";
        public string Explanation => "Toplama"; 
        public double calculate(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}
