// See https://aka.ms/new-console-template for more information
using System.Reflection;
using System.Text.RegularExpressions;
using PlayerModule;
/*Console.WriteLine("Cual es tu nombre?");
string? playerName;
playerName = Console.ReadLine();
playerName =  string.IsNullOrWhiteSpace(playerName)? "Desconocido" : playerName;
Console.WriteLine($"Hola, {playerName}!");*/


Console.WriteLine("Cual es tu nombre?");
string? playerName01 = Console.ReadLine();
playerName01 =  string.IsNullOrWhiteSpace(playerName01)? "<Not Provided>" : playerName01;
Console.WriteLine("Cual es tu nivel?");
string? tempPlayerLevel = Console.ReadLine();
string notNullLevel = string.IsNullOrWhiteSpace(tempPlayerLevel)? "1" : tempPlayerLevel;
int playerLevel01 = int.Parse(Regex.IsMatch(notNullLevel, @"^\d+$")? notNullLevel: "1");


PlayerNames player01 = new PlayerNames(playerName01, playerLevel01);
Console.WriteLine($"Hola, {player01.Name}! Tu nivel es {player01.Level}");

namespace PlayerModule
{
    class PlayerNames{
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
