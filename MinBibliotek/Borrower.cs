using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MinBibliotek
{
    internal class Borrower : User
    {

        public override void Menu()
        {
            int choice = 0;

            while (choice != 4)
            {

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-------------------");
                Console.WriteLine("***Borrower Menu***");
                Console.WriteLine("-------------------");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("1. Låna en bok.");
                Console.WriteLine("2. Lämna tillbaka en bok.");
                Console.WriteLine("3. Visa alla böcker.");
                Console.WriteLine("4. Avsluta.");
                Console.Write("Ange ditt val: ");

                choice = Validering.GetInt();
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Book.BorrowBook();
                        break;
                    case 2:
                        Book.ReturnBook();
                        break;
                    case 3:
                        Book.ShowAllBooks();
                        break;
                    case 4:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Borrower menyn avslutas");
                        Console.ResetColor();
                        Clear.ClearConsole();
                        Program.Begin();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine("Du har angett felaktigt val");
                        Console.ResetColor();
                        break;
                }
            }

        }
    }
}
