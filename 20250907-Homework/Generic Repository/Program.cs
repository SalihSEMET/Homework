namespace Homework
{
    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.Title = "Generic Repository";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------ STUDENT REPOSITORY KULLANIMI ------");

            IRepository<Student> studentRepository = new Repository<Student>();

            var student1 = new Student { Id = 1, FirstName = "Ali", LastName = "Veli" };
            var student2 = new Student { Id = 2, FirstName = "Ayşe", LastName = "Yılmaz" };
            studentRepository.Add(student1);
            studentRepository.Add(student2);
            Console.WriteLine("İki öğrenci eklendi.");

            Console.WriteLine("\nTüm Öğrenciler:");
            var allStudents = studentRepository.GetAll();
            foreach (var student in allStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nAli Veli siliniyor...");
            studentRepository.Remove(student1);

            Console.WriteLine("\nKalan Öğrenciler:");
            foreach (var student in studentRepository.GetAll())
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n\n------ BOOK REPOSITORY KULLANIMI ------");

            IRepository<Book> bookRepository = new Repository<Book>();

            var book1 = new Book { Id = 101, Title = "Sefiller", Author = "Victor Hugo" };
            var book2 = new Book { Id = 102, Title = "Suç ve Ceza", Author = "Dostoyevski" };
            bookRepository.Add(book1);
            bookRepository.Add(book2);
            Console.WriteLine("İki kitap eklendi.");
        
            Console.WriteLine("\nTüm Kitaplar:");
            foreach (var book in bookRepository.GetAll())
            {
                Console.WriteLine(book);
            }

            Console.ReadLine();
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Ad: {FirstName}, Soyad: {LastName}";
        }
    }
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Başlık: {Title}, Yazar: {Author}";
        }
    }
}

