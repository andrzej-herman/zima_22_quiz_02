using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsole.Models
{
    public class Game
    {
        public Game()
        {
            CurrentCategory = 100;
            DisplayWelcomeScreen();
            GetQuestions();
        }


        // właściwości
        public List<Question> Questions { get; set; }
        public int CurrentCategory { get; set; }
        public Question CurrentQuestion { get; set; }

        // metoda wyświetlająca ekran powitalny
        void DisplayWelcomeScreen()
        {
            Console.WriteLine();
            Console.WriteLine("**************************");
            Console.WriteLine("* WITAMY W NASZYM QUIZIE *");
            Console.WriteLine("**************************");
            Console.WriteLine("** Odpowiedz na 5 pytań **");
            Console.WriteLine("**************************");
            Console.WriteLine("***** POWODZENIA !!! *****");
            Console.WriteLine();
        }

        // metoda tworzaca bazę pytań
        void GetQuestions()
        {
            Questions = new List<Question>();
            Question p1 = new Question
            {
                Id = 1,
                Category = 100,
                Content = "Jak miał na imię Einstein?",
            };

            p1.Answers.Add(new Answer()
            {
                Id = 1,
                Content = "Albert",
                IsCorrect = true
            });

            p1.Answers.Add(new Answer()
            {
                Id = 2,
                Content = "Aaron",
                IsCorrect = false
            });

            p1.Answers.Add(new Answer()
            {
                Id = 3,
                Content = "Andrew",
                IsCorrect = false
            });

            p1.Answers.Add(new Answer()
            {
                Id = 4,
                Content = "Anthony",
                IsCorrect = false
            });


            Question p2 = new Question
            {
                Id = 2,
                Category = 200,
                Content = "W którym roku obalono komunizm w Polsce?",
            };

            p2.Answers.Add(new Answer()
            {
                Id = 1,
                Content = "1989",
                IsCorrect = true
            });

            p2.Answers.Add(new Answer()
            {
                Id = 2,
                Content = "2000",
                IsCorrect = false
            });

            p2.Answers.Add(new Answer()
            {
                Id = 3,
                Content = "1960",
                IsCorrect = false
            });

            p2.Answers.Add(new Answer()
            {
                Id = 4,
                Content = "2012",
                IsCorrect = false
            });

            Questions.Add(p1);  
            Questions.Add(p2);
        }

        // metoda losująca jedno pytanie z wszystkich pytan aktualnej kategorii
        public void DrawQuestion()
        {
            foreach (var question in Questions)
            {
                if (question.Category == CurrentCategory)
                {
                    CurrentQuestion = question;
                    break;
                }
                    
            }
        }
    }
}

// 100, 200, 500, 1000, 5000