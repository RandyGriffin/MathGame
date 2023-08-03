using System.Threading.Tasks.Sources;

var date = DateTime.Now;
Console.WriteLine("Hello, What is your name?");
var name = Console.ReadLine();
Console.WriteLine("Hello {0}!, Today is {1} and welcome to a very simple math game!", name, date);
Console.WriteLine(@$"Please choose an option from the menu!
A -  Addition 
S -  Subtraction 
M -  Multiplication 
D -  Division 
Q -  To quit");


var gameSelected = Console.ReadLine();

switch (gameSelected.Trim().ToLower())
{
    case "a":
        AddictionGame("Addiction game selected");
        break;
    case "s":
        SubtractionGame("Subtraction game selected");
        break;
    case "m":
        MultiplicationGame("Multiplication game selected");
        break;
    case "d":
        DivisionGame("Division game selected");
        break;
    case "q":
        Console.WriteLine("Thank you for playing!");
        Environment.Exit(1);
        break;
    default:
        Console.WriteLine("Invalid Input");
        break;
}

//if (gameSelected == "a")
//{
//AddictionGame("Addiction game selected");

//}
//else if (gameSelected == "s")
//{
//SubtractionGame("Subtraction game selected");

//}
//else if (gameSelected == "m")
//{
//MultiplicationGame("Multiplication game selected");

//}
//else if (gameSelected == "d")
//{
//DivisionGame("Division game selected");

//}
//else if (gameSelected == "q")
//{
//    Console.WriteLine("Thank you for playing!");
//    Environment.Exit(1);
//}
//else
//{
//    Console.WriteLine("Invalid input!");

//}

void DivisionGame(string message)
{
    GetDivisionNumbers();
}



void MultiplicationGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();

    var score = 0;
    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == (firstNumber + secondNumber))
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect");
        }

        if (i == 4)
            Console.WriteLine($"Game over. Your final score is {score}");
    }
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();

    var score = 0;
    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == (firstNumber + secondNumber))
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect");
        }

        if (i == 4)
            Console.WriteLine($"Game over. Your final score is {score}");
    }
}

void AddictionGame(string message) //Methods
{
    Console.WriteLine(message);

    var random = new Random();

    var score = 0;
    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == (firstNumber + secondNumber))
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect");
        }

        if(i == 4)
            Console.WriteLine($"Game over. Your final score is {score}");
    }


}

int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(0, 99);
    var secondNumber = random.Next(0, 99);

    var result = new int[2];

    result[0] = firstNumber;
    result[1] = secondNumber;

    Console.WriteLine(result);

    return result;
}

