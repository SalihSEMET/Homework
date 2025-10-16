namespace Plugin.Interfaces
{
    public interface IOperasyon
    {
        string symbol { get; }
        string Explanation { get; }
        double calculate(double number1, double number2);
    }
}

