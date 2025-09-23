using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinBibliotek
{
    abstract class User
    {

        public string Name { get; set; }       
        public string Password { get; set; }
        public abstract void Menu();
        
       
    }
}
