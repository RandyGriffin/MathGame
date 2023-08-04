using MathGame;
using System.ComponentModel.Design;
using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;

var menu = new Menu();
 
var date = DateTime.Now;

var games = new List<string>();
string name = GetName();

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Hello, What is your name?");
    var name = Console.ReadLine();
    var date = DateTime.Now;
    return name;

}

 


