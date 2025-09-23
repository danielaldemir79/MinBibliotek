namespace MinBibliotek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Välkommen till din bibliotek!");
            Console.WriteLine();
            Console.WriteLine("Logga in här nedan");
            Console.WriteLine();
            
            User loggedInUser = LoggaIn.Login();
            
            if (loggedInUser != null)
            {
                loggedInUser.Menu();
            }

           
        }
    }
}
