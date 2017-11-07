using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StringOverloadMulti_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string mehrText = new string('-', 3);
            // string mehrText = 3 * "Kaffee";     // soll KaffeeKaffeeKaffee ausgeben     // geht wohl nicht
            WriteLine(mehrText);                    // aber hey, string hat da was eigenes
        }
    }
}
