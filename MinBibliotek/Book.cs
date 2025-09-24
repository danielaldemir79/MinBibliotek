using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinBibliotek
{
    public class Book
    {

        public int ISBN {get; set;}
        public string Title {get; set;}
        public string Author {get; set;}
        public bool IsAvailable {get; set;}
        public string available => IsAvailable ? "Tillgänglig" : "Utlånad";

        public static List<Book> Books = new List<Book>();

        public static void AddBook()
        {
            Book newBook = new Book();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Lägga till Bok"); 
            Console.ResetColor();
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
            FileManager.SaveToFile();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Boken '{newBook.Title}' av {newBook.Author} med ISBN {newBook.ISBN} har lagts till i biblioteket.");
            Console.ResetColor();

        }
        
        
        public static void RemoveBook()
        { 
            Book removeBook = new Book();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ta bort Bok");
            Console.ResetColor();
            Console.Write("Ange bokens ISBN som du vill ta bort: ");    
            int bookToremove = Validering.GetInt();

            foreach (Book b in Books)
            {
                if (bookToremove == b.ISBN)
                {
                    removeBook = b;               
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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine($"Boken {removeBook.Title} med ISBN {removeBook.ISBN} är nu raderad.");
                Console.ResetColor();
                FileManager.SaveToFile();
            }

        }
        
        public static void ReturnBook()
        { 
            Book returnBook = new Book();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Lämna tillbaka Bok");
            Console.ResetColor();
            Console.Write("Ange bokens ISBN som du vill lämna tillbaka: ");
            
            int bookToReturn = Validering.GetInt();

            foreach (Book b in Books)
            {
                if (bookToReturn == b.ISBN)
                {
                    returnBook = b;

                    if (!returnBook.IsAvailable)
                    {
                        returnBook.IsAvailable = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine($"Du har lämnat tillbaka boken {returnBook.Title} med ISBN {returnBook.ISBN}.");
                        Console.ResetColor();
                        FileManager.SaveToFile();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine($"Boken {returnBook.Title} med ISBN {returnBook.ISBN} är inte utlånad.");
                        Console.ResetColor();
                        return;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Boken med ISBN {bookToReturn} finns inte i systemet.");
                    Console.ResetColor();
                    return;
                }
            }
        }



        public static void BorrowBook()
        {
            Book borrowBook = new Book();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Låna Bok");
            Console.ResetColor();

            Console.Write("Ange bokens ISBN som du vill låna: ");
            int bookToBorrow = Validering.GetInt();


            foreach (Book b in Books)
            {
                if (bookToBorrow == b.ISBN)
                {
                    borrowBook = b;
                    if (borrowBook.IsAvailable)
                    {
                        borrowBook.IsAvailable = false;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine($"Du har lånat boken {borrowBook.Title} med ISBN {borrowBook.ISBN}.");
                        Console.ResetColor();
                        FileManager.SaveToFile();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine($"Boken {borrowBook.Title} med ISBN {borrowBook.ISBN} är redan utlånad.");
                        Console.ResetColor();
                        return;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Boken med ISBN {bookToBorrow} finns inte i systemet.");
                    Console.ResetColor();
                    return;
                }


            }
        }

        public static void ShowAllBooks()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("_______________________________________");
            Console.WriteLine("Lista på alla tillgängliga böcker");
            Console.ResetColor();

            if (Book.Books.Count == 0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Det finns inga böcker i systemet.");
                Console.WriteLine();
                Console.ResetColor();
                Clear.ClearConsole();
                return;
            }

            foreach (var item in Books)
            {
                
                Console.WriteLine();
                Console.WriteLine($"ISBN: {item.ISBN}. Titel: {item.Title}, Författare: {item.Author}");
                if (item.IsAvailable)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Status: {item.available}");
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Status: {item.available}");
                    Console.ResetColor();
                    Console.WriteLine();
                }

            }
            Console.WriteLine("________________________________________");
            Clear.ClearConsole();
        }

    }

    
    
}
