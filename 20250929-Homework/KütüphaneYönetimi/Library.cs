using System.Globalization;

namespace _29_09_2025_Homework;

public class Library
{
    private Dictionary<int, string> _books;

    public Library()
    {
        _books = new Dictionary<int, string>();
        AddExampleBooks();
    }

    public void AddBook(int bookId, string bookName)
    {
        if (!_books.ContainsKey(bookId))
        {
            Console.Clear();
            Console.WriteLine("\nKitap Ekleme İşlemi Başarılı");
            _books.Add(bookId,bookName);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("\nHata: Bu Id ye Sahip Bir Kitap Zaten Mevcut.");
        }
    }

    private void AddExampleBooks()
    {
        AddBook(101, "Sefiller");
        AddBook(102, "Suç Ve Ceza");
        AddBook(103, "Satranç");
        AddBook(201, "Simyacı");
        AddBook(202, "Hayvan Çiftliği");
        AddBook(501, "İnsan Ne İle Yaşar");
    }

    public Dictionary<int, string> FindBooksByLetter(char FirstLetter)
    {
        return _books
            .Where(book =>
                !string.IsNullOrEmpty(book.Value) && book.Value.StartsWith(FirstLetter.ToString(),
                    StringComparison.CurrentCultureIgnoreCase)).ToDictionary(book => book.Key, book => book.Value);
    }

    public bool DeleteBook(int bookId)
    {
        return _books.Remove(bookId);
    }

    public KeyValuePair<int, string> Recommend_A_RandomBook()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _books.Count);
        return _books.ElementAt(randomIndex);
    }

    public void ListBooks()
    {
        foreach (var VARIABLE in _books)
        {
            Console.WriteLine($"Kitap Id Si:{VARIABLE.Key} Kitap Adı:{VARIABLE.Value}");
        }
    }
}