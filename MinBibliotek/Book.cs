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
                
            foreach(Book b in Books)
            {
                if (b.ISBN == newBook.ISBN)
                {
                    Console.WriteLine($"Boken med ISBN {newBook.ISBN} finns redan i systemet.");
                    return;
                }
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
        { 
            Book removeBook = new Book();

            Console.WriteLine();
            Console.WriteLine("Ta bort Bok");
            Console.Write("Ange bokens ISBN som du vill ta bort: ");    
            int bookToremove = Validering.GetInt();

            foreach (Book b in Books)
            {
                if (bookToremove == b.ISBN)
                {

                    removeBook = b;

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine($"Boken {removeBook.Title} med ISBN {removeBook.ISBN} är nu raderad.");
                    Console.ResetColor();
                    break;
   
                   
                }
                else
                {
                    Console.WriteLine($"Boken med ISBN {bookToremove} finns inte i systemet.");
                    return;
                }

            }

            if (removeBook != null)
            {
                Books.Remove(removeBook);
            }

        }
        
        public static void ReturnBook()
        { }

        public static void BorrowBook()
        { }

        public static void ShowAllBooks()
        {
            Console.WriteLine();
            Console.WriteLine("Lista på alla tillgängliga böcker");

            foreach (var item in Books)
            {
                
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
            Clear.ClearConsole();
        }

    }

    
    
}
