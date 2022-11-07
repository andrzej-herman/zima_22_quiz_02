using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsole.Models
{
    // klasa ospowiadająca za wyświetlanie komunikatów graczowi
    internal class Message
    {
        // wyświetlanie powitania
        internal void DisplayWelcome()
        {
            Console.WriteLine();
            Console.WriteLine("**************************");
            Console.WriteLine("* WITAMY W NASZYM QUIZIE *");
            Console.WriteLine("**************************");
            Console.WriteLine("** Odpowiedz na 7 pytań **");
            Console.WriteLine("**************************");
            Console.WriteLine("***** POWODZENIA !!! *****");
            Console.WriteLine();
        }
    }
}
