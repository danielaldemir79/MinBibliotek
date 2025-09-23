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
        }
    }
}
