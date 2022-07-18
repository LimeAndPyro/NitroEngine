using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NitroEngine.Core
{
    internal class NitroConsole
    {
        public static void Msg(string message, bool consoletime = false)
        {
            if (consoletime)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(DateTime.Now.ToString("HH:mm:ss.fff"));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] ");
            }
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("NITRO");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" => ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(message + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Space(bool spacer)
        {
            if(spacer == true)
            {
                Console.WriteLine("");
            }
            else { }
        }

        public static void PrintArt()
        {
            //To be finished lol
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
