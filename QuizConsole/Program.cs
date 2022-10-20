using QuizConsole.Obiekty;




// Utworzyliśmy pytanie p1
Pytanie p1 = new Pytanie
{
    Id = 1,
    Kategoria = 100,
    Tresc = "Jak miał na imię Einstein?",
};

p1.Odpowiedzi.Add(new Odpowiedz()
{
    Id = 1,
    Tresc = "Albert",
    CzyPrawidlowa = true
});

p1.Odpowiedzi.Add(new Odpowiedz()
{
    Id = 2,
    Tresc = "Aaron",
    CzyPrawidlowa = false
});

p1.Odpowiedzi.Add(new Odpowiedz()
{
    Id = 3,
    Tresc = "Andrew",
    CzyPrawidlowa = false
});

p1.Odpowiedzi.Add(new Odpowiedz()
{
    Id = 4,
    Tresc = "Anthony",
    CzyPrawidlowa = false
});

// Wywietlamy
Console.WriteLine("WITAJ W QUIZIE");
Console.WriteLine();
p1.PokazPytanie();








Console.WriteLine();


