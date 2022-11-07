using Newtonsoft.Json;
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
            GetQuestions();
            Random = new Random();
        }


        // właściwości
        public List<Question> AllQuestions { get; set; }
        public int CurrentCategory { get; set; }
        public Question CurrentQuestion { get; set; }
        public Random Random { get; set; }


        // metoda tworzaca bazę pytań
        void GetQuestions()
        {
            var path = $"{Directory.GetCurrentDirectory()}\\questions.json";
            var json = File.ReadAllText(path);
            AllQuestions = JsonConvert.DeserializeObject<List<Question>>(json);
        }

        // metoda losująca jedno pytanie z wszystkich pytan aktualnej kategorii
        public void DrawQuestion()
        {
            var questionsCat = AllQuestions.Where(q => q.Category == CurrentCategory).ToList();
            var number = Random.Next(0, questionsCat.Count);
            var selectedQuestion = questionsCat[number];
            selectedQuestion.Answers = selectedQuestion.Answers.OrderBy(a => Random.Next()).ToList();
            int index = 1;
            foreach (var a in selectedQuestion.Answers)
            {
                a.DisplayOrder = index;
                index++;
            }
            
            CurrentQuestion = selectedQuestion;
        }
    }
}

// 100, 200, 300, 400, 500, 750, 1000