using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.CompilerServices;
namespace MinBibliotek
{
    internal class FileManager
    {
        public static string filePath = "books.json";
        public static void SaveToFile()
        {
            string jsonString = JsonSerializer.Serialize(Book.Books);
            System.IO.File.WriteAllText(filePath, jsonString);
        }
        public static void LoadFromFile() 
        { 
            
            if (System.IO.File.Exists(filePath))
            {
                string jsonString = System.IO.File.ReadAllText(filePath);
                Book.Books = JsonSerializer.Deserialize<List<Book>>(jsonString);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Data har laddats upp från fil");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Det finns ingen sparad data.");
                Console.ResetColor();
                Book.Books = new List<Book>();
            }


        }

    }
}
