using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinBibliotek
{
    internal class Clear
    {
        public static void ClearConsole()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
