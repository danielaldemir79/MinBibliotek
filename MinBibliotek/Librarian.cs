using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinBibliotek
{
    internal class Librarian : User
    {
        private int pinCode = 1111;

        public int PinCode
        {
            get { return pinCode; }
            set { pinCode = value; }
        }
        public override void Menu()
        {
            int choice = 0;

            while (choice != 3)
            {

                Console.WriteLine();
                Console.WriteLine("Librarian Menu");
                Console.WriteLine("1. Lägg till bok.");
                Console.WriteLine("2. Visa alla böcker.");
                Console.WriteLine("3. Avsluta");

                Console.Write("Ange ditt val: ");
                choice = Validering.GetInt();

                switch (choice)
                {
                    case 1:
                        Book.AddBook();
                        break;
                    case 2:
                        Book.ShowAllBooks();
                        break;
                   
                     case 3:
                        Console.WriteLine("Librarian menyn avslutas");
                        break;
                        
                    default:
                        Console.WriteLine("Ogiltigt val. Vänligen försök igen.");
                        break;
                }
            }
        }
    }
}
