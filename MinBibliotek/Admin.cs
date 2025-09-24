using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinBibliotek
{
    internal class Admin : User
    {

        public override void Menu() 
        {
           
            int choice = 0;

            while (choice != 5)
            {

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("----------------");
                Console.WriteLine("***Admin Menu***");
                Console.WriteLine("----------------");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("1. Lägg till bok.");
                Console.WriteLine("2. Ta bort bok..");
                Console.WriteLine("3. Visa alla böcker");
                Console.WriteLine("4. Sök efter en bok");
                Console.WriteLine("5. Avsluta");
                Console.Write("Ange ditt val: ");

                choice = Validering.GetInt();
                switch (choice)
                {
                    case 1:
                        Book.AddBook();
                        break;
                    case 2:
                        Book.RemoveBook();
                        break;
                    case 3:
                        Book.ShowAllBooks();
                        break;
                    case 4:
                        
                         SearchBook.SearchBooks();
                        
                        break;
                    case 5:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Admin menyn avslutas");
                        Console.ResetColor();
                        Clear.ClearConsole();
                        Program.Begin();
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val. Vänligen försök igen.");
                        break;
                }
            }

        }

    }
}
