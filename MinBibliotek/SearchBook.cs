using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinBibliotek
{
    public class SearchBook
    {

        public static void SearchBooks()
        {
            Console.Write("Ange sökord (titel eller författare): ");
            string searchTerm = Validering.GetString().ToLower();

            List<Book> matchedBooks = Book.Books.Where(b => b.Title.ToLower().Contains(searchTerm) || b.Author.ToLower().Contains(searchTerm)).ToList();
            
            if (matchedBooks.Count > 0)
            {
                Console.WriteLine("\nHittade böcker:");
                foreach (var book in matchedBooks)
                {
                    Console.WriteLine();
                    Console.Write("Titel: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(book.Title);
                    Console.ResetColor();
                    Console.Write(" Författare: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(book.Author);
                    Console.ResetColor();
                    Console.Write(" ISBN: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(book.ISBN);
                    Console.ResetColor();

                    if (book.IsAvailable)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Status: {book.available}");
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Status: {book.available}");
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                   
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Inga böcker matchade din sökning.");
                Console.ResetColor();
            }
        }


    }
}
