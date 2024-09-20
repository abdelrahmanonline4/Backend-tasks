using static System.Reflection.Metadata.BlobBuilder;

namespace oop_project
{
    internal class Book
    {
        public string Title { get; }
        public string Author { get; }
        public bool IsBorrowed { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            IsBorrowed = false;
        }
    }

    internal class Library
    {
        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Added: {book.Title} by {book.Author}");
        }

        public void DisplayAvailableBooks()
        {
            Console.WriteLine("Available books:");
            foreach (var book in books)
            {
                if (!book.IsBorrowed)
                {
                    Console.WriteLine($"- {book.Title} by {book.Author}");
                }
            }
        }

        public void BorrowBook(string title)
        {
            bool bookFound = false;

            foreach (var book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    bookFound = true;

                    switch (book.IsBorrowed)
                    {
                        case false:
                            book.IsBorrowed = true;
                            Console.WriteLine($"You borrowed: {book.Title}");
                            break;
                        case true:
                            Console.WriteLine($"The book '{book.Title}' is already borrowed.");
                            break;
                    }
                    break;
                }
            }

            if (!bookFound)
            {
                Console.WriteLine($"The book '{title}' is not in the library.");
            }
        }

        public void ReturnBook(string title)
        {
            bool bookFound = false;

            foreach (var book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    bookFound = true;

                    switch (book.IsBorrowed)
                    {
                        case true:
                            book.IsBorrowed = false;
                            Console.WriteLine($"You returned: {book.Title}");
                            break;
                        case false:
                            Console.WriteLine($"The book '{book.Title}' was not borrowed.");
                            break;
                    }
                    break;
                }
            }

            if (!bookFound)
            {
                Console.WriteLine($"The book '{title}' is not in the library.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee"));
            library.AddBook(new Book("1984", "George Orwell"));

            library.DisplayAvailableBooks();

            library.BorrowBook("1984");
            library.BorrowBook("Harry Potter");

            library.ReturnBook("1984");
            library.ReturnBook("Harry Potter");

            Console.ReadLine();
        }
    }
}


// task 2 serch

- // When should I use a struct instead of a class?

  struct  بيخزن في ال stack   ف هيبقى الادء كويس في بعض الحالات
    class :  في ال heap  والبيانات الاكبر 
    من الاخر 

    Struct : استخدمه للبيانات الصغيرة، غير القابلة للتغيير 
    class : ستخدمه للأنواع الأكبر، القابلة للتغيير 

    مثال
    public struct Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}


Class

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsBorrowed { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        IsBorrowed = false;
    }
}

  

  

