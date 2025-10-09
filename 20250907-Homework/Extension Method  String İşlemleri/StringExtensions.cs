using System.Globalization;

namespace Homework
{
    public static class StringExtension
    {
        public static string ToTitleCase(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo; // Klavye hangi dil ve Modeline baglı ise tr-TR gibi ona göre davranıcak

            return textInfo.ToTitleCase(input.ToLower());
        }
    }
}