using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinBibliotek
{
    internal class LoggaIn
    {
        private static List<User> users = new List<User>
        {
            new Librarian { Name = "librarian", Password = "librarian123" },
            new Borrower { Name = "borrower", Password = "borrower123" },
            new Admin { Name = "admin", Password = "admin123" }
        };

        public static User Login()
        {
            Console.Write("Ange användarnamn: ");
            string name = Validering.GetString().ToLower();
            Console.Write("Ange lösenord: ");
            string password = Validering.GetString();


            User foundUser = null;

            foreach (User u in users)
            {
                if (u.Name == name && u.Password == password)
                {
                    foundUser = u;
                    break;
                }
            }

            if (foundUser != null)
            {
                Console.WriteLine($"Välkommen {foundUser.Name}!");
                return foundUser;
            }
            else
            {
                Console.WriteLine("Fel användarnamn eller lösenord.");
                return null;
            }
        }

    }
}
