using System;
using System.Reflection;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public bool IsGraduate { get; set; }
}

public class Product
{
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int StockQuantity { get; set; }
}

public static class AutoFormGenerator
{
    public static void Fill<T>(T entity) where T : class
    {
        Type entityType = typeof(T);
        Console.WriteLine($"--- {entityType.Name} Formu ---");

        PropertyInfo[] properties = entityType.GetProperties();

        foreach (var property in properties)
        {
            while (true)
            {
                Console.Write($"{property.Name} ({property.PropertyType.Name}): ");
                string userInput = Console.ReadLine();

                try
                {
                    object convertedValue = Convert.ChangeType(userInput, property.PropertyType);
                    property.SetValue(entity, convertedValue);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine($"Hatalı giriş! Lütfen '{property.PropertyType.Name}' tipinde geçerli bir değer girin.");
                }
            }
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var student = new Student();
        AutoFormGenerator.Fill(student);

        Console.WriteLine("\n--- Doldurulan Öğrenci Bilgileri ---");
        Console.WriteLine($"İsim: {student.FirstName}");
        Console.WriteLine($"Soyisim: {student.LastName}");
        Console.WriteLine($"Yaş: {student.Age}");
        Console.WriteLine($"Mezun Mu: {student.IsGraduate}");

        Console.WriteLine("\n--------------------------------------\n");

        var product = new Product();
        AutoFormGenerator.Fill(product);

        Console.WriteLine("\n--- Doldurulan Ürün Bilgileri ---");
        Console.WriteLine($"Ürün Adı: {product.ProductName}");
        Console.WriteLine($"Fiyat: {product.Price}");
        Console.WriteLine($"Stok Adedi: {product.StockQuantity}");

        Console.ReadKey();
    }
}