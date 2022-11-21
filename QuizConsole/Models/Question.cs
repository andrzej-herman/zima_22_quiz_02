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
        public string Author { get; set; }

        public int Display(bool isWheelAvailable)
        {
            Console.Clear();
            while(true)
            {
                QuestionText(isWheelAvailable);
                var answer = Console.ReadLine();
                if (IsCorrectKey(answer))
                {
                    if (answer.ToLower() == "k") return 5;
                    return int.Parse(answer);
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wcisnałaś/eś nieprawidłowy klawisz ...");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private void QuestionText(bool isWheelAvailable)
        {
            Console.WriteLine($"Pytanie za {Category} pkt");
            Console.WriteLine($"Autor: {Author}");
            Console.WriteLine();
            Console.WriteLine(Content);
            Console.WriteLine();

            foreach (var answer in Answers)
                Console.WriteLine($"{answer.DisplayOrder}. {answer.Content}");

            Console.WriteLine();
            var message = isWheelAvailable
                ? "Naciśnij 1, 2, 3, 4 lub K aby użyć koła  => "
                : "Naciśnij 1, 2, 3 lub 4 => ";

            Console.Write(message);

        }


        private bool IsCorrectKey(string key)
        {
            if (key.ToLower() == "k") return true;
            if (int.TryParse(Console.ReadLine(), out int x) && x > 0 && x < 5)
                return true;

            return false;   
        }

    }
}
