using System;
using System.Collections.Generic;

public class Depo<T>
{
    private List<T> items;

    public Depo()
    {
        items = new List<T>();
    }

    public void Add(T item)
    {
        items.Add(item);
        Console.WriteLine($"'{item}' depoya eklendi.");
    }

    public void Remove(T item)
    {
        bool isSuccess = items.Remove(item);
        if (isSuccess)
        {
            Console.WriteLine($"'{item}' depodan başarıyla silindi.");
        }
        else
        {
            Console.WriteLine($"HATA: '{item}' depoda bulunamadı.");
        }
    }

    public void ListItems()
    {
        Console.WriteLine("\n--- Depo İçeriği ---");
        if (items.Count == 0)
        {
            Console.WriteLine("Depo şu an boş.");
        }
        else
        {
            int counter = 1;
            foreach (T item in items)
            {
                Console.WriteLine($"{counter}. {item}");
                counter++;
            }
        }
        Console.WriteLine("--------------------\n");
    }
}