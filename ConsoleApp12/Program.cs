public class Book
{
    public string NameBook { get; set; }
    public string Autor { get; set; }
    public int Year { get; set; }
}

public class Library
{
    public string Name { get; set; }
    public string Adress { get; set; }
    public List<Book> LibraryBooks { get; set; }

    public Library()
    {
        LibraryBooks = new List<Book>();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем книги
        Book book1 = new Book
        {
            NameBook = "I`m Dan",
            Autor = "Daniel",
            Year = 1866,
        };

        Book book2 = new Book
        {
            NameBook = "I`m dog",
            Autor = "Dogov",   
            Year = 1967,
        };

        // Создаем библиотеку и добавляем книги
        Library библиотека = new Library
        {
            Name = "Library",
            Adress = "Dollar street"
        };

        библиотека.LibraryBooks.Add(book1);
        библиотека.LibraryBooks.Add(book2);

        // Выводим информацию о книгах в библиотеке
        Console.WriteLine($"Name of Library: {библиотека.Name}");
        Console.WriteLine($"Adress of Library: {библиотека.Adress}");
        Console.WriteLine("Books in Library:");
        foreach (var books in библиотека.LibraryBooks)
        {
            Console.WriteLine($"- {books.NameBook} ({books.Autor}, {books.Year})");
        }
    }
}
