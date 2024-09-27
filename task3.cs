using static System.Reflection.Metadata.BlobBuilder;

namespace task3
{
    class Book
    {
        public Book(string title, string author, string iSBN)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;

        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool Avaiability { get; set; }

    }
    class Library
    {
        public List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book {book.Title}  added to the library");
        }
        public bool SearchBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title)
                {
                    return true;
                }

            }
            return false;
        }
        public void BorrowBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (title == books[i].Title) {
                    books[i].Avaiability = false;
                    Console.WriteLine("you have borrowed");
                }
                else
                {
                    Console.WriteLine("Book not found in library");
                }
            }  
            
        }
        public void ReturnBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (title == books[i].Title)
                {
                    books[i].Avaiability = true;
                    Console.WriteLine("Book Successfully returned");
                }
            }
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            library.AddBook(new Book("1984", "George Orwell", "9780451524935"));
            Console.WriteLine("Searching and borrowing books...");
            library.BorrowBook("Gatsby");
            library.BorrowBook("1984");
            library.BorrowBook("Harry Potter");
            Console.WriteLine("\nReturning books...");
            library.ReturnBook("Gatsby");
            library.ReturnBook("Harry Potter"); 


        }
    }
}

