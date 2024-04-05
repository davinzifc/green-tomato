// See https://aka.ms/new-console-template for more information
using System.Reflection;
using System.Text.RegularExpressions;
using PlayerModule;
/*Console.WriteLine("Cual es tu nombre?");
string? playerName;
playerName = Console.ReadLine();
playerName =  string.IsNullOrWhiteSpace(playerName)? "Desconocido" : playerName;
Console.WriteLine($"Hola, {playerName}!");*/

namespace PlayerModule
{
    public class PlayerNames{
    private string name;
    private int level;

    public PlayerNames(string name, int level){
        this.name = name;
        this.level = level;
    }

    public string Name{
        get{return this.name;}
        set{this.name = value;}
    }

    public int Level{
        get{return this.level;}
        set{this.level = value;}
    }
    
    }

}
