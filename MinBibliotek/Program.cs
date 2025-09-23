namespace MinBibliotek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Begin();

           
        }

        public static void Begin()
        {
            Console.WriteLine();
            Console.WriteLine("LINKÖPINGS BIBLIOTEK");
            Console.WriteLine("VÄLKOMMEN!");
            Console.WriteLine();
            Console.WriteLine("Logga in här nedan");

            User loggedInUser = LoggaIn.Login();

            if (loggedInUser != null)
            {
                loggedInUser.Menu();
            }
            else
            {
                Begin();
            }
        }
    }
}
