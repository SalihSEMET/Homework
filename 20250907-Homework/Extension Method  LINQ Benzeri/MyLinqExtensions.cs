namespace Homework;

public static class MyLinqExtensions
{
    public static double AverageSquared(this IEnumerable<int> source)
    {
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        return source.Select(x => (double)x * x).Average();
    }
}