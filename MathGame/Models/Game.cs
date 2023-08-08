 
namespace MathGame.Models;

internal class Game
{
    //private int _score; 

    //public int Score 
    //{
    //    get { return _score; }
    //    set { _score = value; }
    //}

    public DateTime Date { get; set; }

    public int Score { get; set; } // a shorter way to do what I did above th at commented out
    public GameType Type { get; set; }  
}

internal enum GameType //enumeration
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}
