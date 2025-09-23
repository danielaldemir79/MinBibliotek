namespace MinBibliotek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vill du logga in som...");
            Console.WriteLine("1. Bibliotekarie");
            Console.WriteLine("2. Lånare");
            Console.WriteLine("3. Admin");
            Console.Write("Ange ditt val: ");
            int choice = Validering.GetInt();

            switch (choice)
            {
                case 1:
                    Librarian librarian = new Librarian();
                    librarian.Menu();
                    break;
                case 2:
                    Borrower borrower = new Borrower();
                    borrower.Menu();
                    break;
                case 3:
                    Admin admin = new Admin();
                    admin.Menu();
                    break;
                default:
                    Console.WriteLine("Ogiltigt val. Vänligen försök igen.");
                    break;
            }
        }
    }
}
