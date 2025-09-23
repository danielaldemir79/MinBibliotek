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
       string available => IsAvailable ? "Ja" : "Utlånad";

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
            newBook.Title = Validering.GetString();
            Console.Write("Ange författare: ");
            newBook.Author = Validering.GetString();
            newBook.IsAvailable = true;
            Books.Add(newBook);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Boken '{newBook.Title}' av {newBook.Author} med ISBN {newBook.ISBN} har lagts till i biblioteket.");
            Console.ResetColor();

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
                Console.WriteLine();
                Console.WriteLine($"ISBN: {item.ISBN}. Titel: {item.Title}, Författare: {item.Author}");
                if (item.IsAvailable)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Tillgänglig: {item.available}");
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Tillgänglig: {item.available}");
                    Console.ResetColor();
                    Console.WriteLine();
                }

            }
            Console.WriteLine("Klicka på valfri tangent för att gå tillbaka till menyn");
            Console.ReadKey();
        }

    }

    
    
}
