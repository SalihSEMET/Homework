using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
        Console.Title = "Tuple ile Ögrenci Notları";
        Console.ForegroundColor = ConsoleColor.White;
        
        var studentGrades = new List<(string FirstName, string LastName, int Grade)>();

        studentGrades.Add(("Ahmet", "Yılmaz", 85));
        studentGrades.Add(("Ayşe", "Kaya", 92));
        studentGrades.Add(("Mehmet", "Demir", 78));
        studentGrades.Add(("Fatma", "Çelik", 92));
        studentGrades.Add(("Mustafa", "Aydın", 65));

        Console.WriteLine("--- Öğrenci Not Listesi ---");
        foreach (var student in studentGrades)
        {
            Console.WriteLine($"Öğrenci: {student.FirstName} {student.LastName}, Notu: {student.Grade}");
        }
        Console.WriteLine("--------------------------\n");
        
        if (studentGrades.Count == 0)
        {
            Console.WriteLine("Listede hiç öğrenci yok.");
            return;
        }

        var topStudent = studentGrades[0];

        foreach (var student in studentGrades)
        {
            if (student.Grade > topStudent.Grade)
            {
                topStudent = student;
            }
        }

        Console.WriteLine(">>> En Yüksek Notu Alan Öğrenci <<<");
        Console.WriteLine($"Adı: {topStudent.FirstName}");
        Console.WriteLine($"Soyadı: {topStudent.LastName}");
        Console.WriteLine($"Notu: {topStudent.Grade}");
    }
}