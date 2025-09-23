using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinBibliotek
{
    internal class Book
    {

        int ISBN;
        string Title;
        string Author;
        bool IsAvailable;

        public static List<Book> Books = new List<Book>();

        public static void AddBook()
        {
            Book newBook = new Book();

            Console.WriteLine();

            Console.WriteLine("Lägga till Bok");
            Console.Write("Ange bokens ISBN: ");
            newBook.ISBN = Validering.GetInt();
            if (Books.Any(thisBook => thisBook.ISBN == newBook.ISBN))
            {
                Console.WriteLine($"Boken med ISBN {newBook.ISBN} finns redan i systemet.");
                return;
            }

            Console.Write("Ange boktitel: ");
            newBook.Title = Console.ReadLine();
            Console.Write("Ange författare: ");
            newBook.Author = Console.ReadLine();
            newBook.IsAvailable = true;
            Books.Add(newBook);

            Console.Clear();
            Console.WriteLine($"Boken '{newBook.Title}' av {newBook.Author} med ISBN {newBook.ISBN} har lagts till i biblioteket.");

        }
        
        
        public static void RemoveBook()
        { }
        
        public static void ReturnBook()
        { }

        public static void BorrowBook()
        { }

        public static void ShowAllBooks()
        {
            foreach (var item in Books)
            {
                Console.WriteLine();
                Console.WriteLine("Lista på alla tillgängliga böcker");
                Console.WriteLine($"Titel: {item.Title}, Författare: {item.Author}");
                Console.WriteLine($"ISBN: {item.ISBN}, Tillgänglig: {item.IsAvailable}");
            }
        
        }

    }

    
    
}
