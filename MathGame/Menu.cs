 
namespace MathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new(); 
        internal void ShowMenu(string name, DateTime date)
        {
            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine("Hello {0}!, Today is {1} and welcome to a very simple math game!", name, date);
                Console.WriteLine(@$"Please choose an option from the menu!
V - View Previous Games
A -  Addition 
S -  Subtraction 
M -  Multiplication 
D -  Division 
Q -  To quit");


                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetGames();
                        break;
                    case "a":
                        gameEngine.AddictionGame("Addiction game selected");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction game selected");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game selected");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division game selected");
                        break;
                    case "q":
                        Console.WriteLine("Thank you for playing!");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (isGameOn);
        }
    }
}
