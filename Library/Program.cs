using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author1 = new Author("Ion Creanga","ion.creanga@gmail.com");
            Book book1 = new Book("Amintiri din copilarie", 1892, 65, author1);

            Console.WriteLine("Book {0} ({1} RON), by {2}, published in {3} ", book1.getName(),book1.getPrice(), author1.getName(), book1.getYear() );
        }
    }
}
