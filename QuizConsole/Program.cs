using QuizConsole.Models;

var game = new Game();
var message = new Message();
message.DisplayWelcome();
game.DrawQuestion();
var playerAnswer = game.CurrentQuestion.Display();
if (game.CheckIfAnswerCorrect(playerAnswer))
{
    if (game.CheckIdLastQuestion)
}
else
{
    message.DisplayGameOver();
}


