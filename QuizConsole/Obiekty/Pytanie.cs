using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsole.Obiekty
{
    public class Pytanie
    {
        public int Id { get; set; }
        public string Tresc { get; set; }
        public int Kategoria { get; set; }
        public List<Odpowiedz> Odpowiedzi { get; set; } = new List<Odpowiedz>();

        public void PokazPytanie()
        {
            Console.WriteLine($"Pytanie za {Kategoria} pkt");
            Console.WriteLine();
            Console.WriteLine(Tresc);
            Console.WriteLine();
            foreach (var odp in Odpowiedzi)
            {
                Console.WriteLine($"{odp.Id}. {odp.Tresc}");
            }

            Console.WriteLine();
            Console.Write("Naciśnij 1, 2, 3 lub 4 => ");
        }
    }
}
