using System.Reflection.Emit;
using PlayerInfo;
using PlayerModule;
using System.Text.RegularExpressions;  

/* 
String? name = null;
Console.WriteLine("¿Cual es tu nombre?");

name = Console.ReadLine();

Console.WriteLine($"Tu nombre es: {name}.");
 */

List<float> healthList = new List<float>();
List<Player> playerList = new List<Player>();
string? answer;
string? name;
int lvl;
float health;
bool isEnough = true;
float average = 0f;

while (isEnough){

    Console.Write($"\nIngrese le nombre del jugador: ");
    answer = Console.ReadLine();
    name = string.IsNullOrWhiteSpace(answer) ? "NPC" : answer;

    Console.Write("\nIngrese el nivel del jugador: ");
    answer = Console.ReadLine();
    lvl = int.Parse(string.IsNullOrWhiteSpace(answer) || Regex.IsMatch(answer, @"^\d+$") ? "1" : answer);

    Console.Write("\nIngrese la salud del jugador: ");
    answer = Console.ReadLine();
    health = float.Parse(string.IsNullOrWhiteSpace(answer) || !Regex.IsMatch(answer, @"^\d+(.\d+)?$") ? "0.0" : answer);
    playerList.Add(new Player(name, lvl, health));

    Console.Write("\n¿Quieres crear otro jugador? Y/N: ");
    answer = Console.ReadLine();
    isEnough = (answer == "Y") ? true : false;

}

foreach (Player player in playerList){
    average += player.Salud;
    Console.Write($"\n Nombre: {player.Name}, la salud es: {player.Salud} y el acomulado es : {average}");
}

Console.Write($"\n El promedio de salud de todos los jugadores es de: {average / playerList.Count}");


namespace PlayerInfo
{
    class Player : PlayerNames{
        private float salud;
        
        public Player(string name, int level, float salud) : base(name, level){
            this.salud = salud;
        }

        public float Salud{
            get{return this.salud;}
            set{this.salud = value;}
        }

    }
}