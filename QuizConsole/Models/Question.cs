using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsole.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Category { get; set; }
        public List<Answer> Answers { get; set; } = new List<Answer>();

        public void Display()
        {
            //Console.WriteLine("Pytanie za " + Category + " pkt");
            Console.WriteLine($"Pytanie za {Category} pkt");
            Console.WriteLine();
            Console.WriteLine(Content);
            Console.WriteLine();

            foreach (var answer in Answers)
                Console.WriteLine($"{answer.Id}. {answer.Content}");

            Console.WriteLine();
            Console.Write("Naciśnij 1, 2, 3 lub 4 => ");
        }
    }
}
