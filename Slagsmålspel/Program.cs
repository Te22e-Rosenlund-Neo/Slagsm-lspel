using System.Reflection.PortableExecutable;
using System.Security.Cryptography;

//lägg till så att man kan skapa nya karaktärer




string[] ABCList = {"A","B","C"};
string Answer="";
Random Generator1 = new Random();
//Karaktärernas stats återspeglar inte åsikter, karaktärsdrag eller liknande om personen/na!
// character x = new character(name,damage,health,armor,speed,move1,move1damage,move1hitchance,move2,move2damage,move2hitchance,id)
Character Player1 = new Character("Micke", 60,100,40,50,"Skjut lasrar ur dina röda ögon",1,0.9,"Ta hjälp av japanare",3,0.4,1);
Character Player2 = new Character("Martin",80, 110, 30,30,"använd TOUCHPADEN!",2,0.7,"använd din mus",0.9,1,2);
Character Player3 = new Character("Huglin",70, 60, 20,100,"Goblin GANG", 1.5,0.8,"Dissa skolmaten",1,1,3);
Character Player4 = new Character("Vera",30, 50, 100,70,"DU har redovisnig imorgon", 2,0.7,"Fäll ner din skärm",1,0.9,4);
Character Player5 = new Character("Nicholas",20, 120, 100,10,"ANVÄND NEWTONS 0'TE LAG",10,0.2,"Mät motståndaren med plantan!",1.2,0.9,5);
Character Player6 = new Character("Rådet",100, 50, 10,90,"Bryt era egna regler, genom korrupta handlingar",1,1,"laga en 3d-printer",2,0.7,6);
Character[] Players = {Player1,Player2,Player3,Player4,Player5,Player6};
Character p1;
Character p2;
//----------------------------------------------------------------------------------------
//game start
gamemenu();
void gamemenu(){
while(true){
Console.Clear();
GameOpeningChoice();
if(Answer == "A"){
    Console.WriteLine("you started the game!");
    Thread.Sleep(1000);
    Console.Clear();
    GameStarted();
    break;
}else if(Answer == "B"){

Console.Clear();
foreach(Character Character in Players){
Character.Displaystats();
}
Console.WriteLine("\nPress any key to continue");
Console.ReadKey();
Console.Clear();

}else{
    Environment.Exit(0);
    }
}
}
//----------------------------------------------------------------------------------------
void CFAABC(){
//checks if the given answer is either A, B, or C
while(true){
Answer = (Console.ReadLine() ?? "").ToUpper();   
 if(ABCList.Contains(Answer) == true){
        break;
}else{
        Console.WriteLine("please write a possible answer!");
}
}

}
//----------------------------------------------------------------------------------------
void CFCHARACTERPOSSIBILITIES(string phase){
    //CheckForCharacterPossibilities
//checks depending on which phase of the game about if the given answer is possible.
while(true){
int Trying;
Answer = Console.ReadLine() ?? "";
if(phase == "characterdecision"){
    if(!int.TryParse(Answer, out Trying) || Convert.ToInt32(Answer) > Players.Length || Convert.ToInt32(Answer)<0){
                 Console.WriteLine("please type a possible character!");
        }else{
            break;
        }
}else if(phase == "attackdecision"){
    if(!int.TryParse(Answer, out Trying) || Convert.ToInt32(Answer)< 0 || Convert.ToInt32(Answer)>2){
                Console.WriteLine("write a possible move!!!! (1-2)");
    }else{
            break;
    }
}
}
}

//----------------------------------------------------------------------------------------
void GameOpeningChoice(){
    //launches at game start
while(true){   
    Console.WriteLine("\n\nWelcome to a fighting game");
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("A: Play game");
    Console.WriteLine("B: View Characters");
    Console.WriteLine("C: Quit the game");
    CFAABC();
break;
}
}
//----------------------------------------------------------------------------------------
void GameStarted(){
Console.WriteLine("\nPlayer 1 choose your character");
Thread.Sleep(1000);
foreach(Character Character in Players){
    Character.Displaystats();
}

CFCHARACTERPOSSIBILITIES("characterdecision");
p1 = Players[Convert.ToInt32(Answer)-1]; //sets that player 1 = given answer
Console.Clear();
Console.WriteLine("\nPlayer 2 choose your character");
Thread.Sleep(1000);
foreach(Character Character in Players){
    Character.Displaystats();
}

CFCHARACTERPOSSIBILITIES("characterdecision");
p2 = Players[Convert.ToInt32(Answer)-1];
Console.WriteLine($"Player1 is {p1.Name}");
Console.WriteLine($"Player2 is {p2.Name}");
Thread.Sleep(1000);
rounds();
}
//----------------------------------------------------------------------------------------
void attackphase(string attacker){
// Decides which of the attacks the player has chosen, calculates damage, removes it from opponent hp
if(attacker == "player1"){
    Console.WriteLine($"\nWhat should player1's {p1.Name} do");
    Console.WriteLine($"1: {p1.attack1}         2: {p1.attack2}");
    CFCHARACTERPOSSIBILITIES("attackdecision");

if(Convert.ToInt32(Answer) == 1){
        p2.Hp-=p1.Attack1DamageCalculator(p2.Armour);
    }
else if(Convert.ToInt32(Answer) == 2){
        p2.Hp -= p1.Attack2DamageCalculator(p2.Armour);
    }
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Player 2 has {p2.Hp}hitpoints left");
    Console.ResetColor();

//----
//same as above, but if the attacker is player2
}else if(attacker == "player2"){
    Console.WriteLine($"\nWhat should player2's {p2.Name} do");
    Console.WriteLine($"1: {p2.attack1}         2: {p2.attack2}");
    CFCHARACTERPOSSIBILITIES("attackdecision");

if(Convert.ToInt32(Answer) == 1){
        p1.Hp -= p2.Attack1DamageCalculator(p1.Armour);
    }
else if(Convert.ToInt32(Answer) == 2){
        p1.Hp -= p2.Attack2DamageCalculator(p1.Armour);
    }
        Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Player 1 has {p1.Hp}hitpoints left");
        Console.ResetColor();
        
}
}
//----------------------------------------------------------------------------------------
void rounds(){
int round = 0;
while(true){
    round++;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Round: {round}");
    Console.ResetColor();
    Console.WriteLine($"player1's {p1.Name} has {p1.Hp} health.         Player2's {p2.Name} has {p2.Hp} health.");
//the different types of possibilities depending on who is quicker
if(p1.Speed > p2.Speed){
    attackphase("player1");
    attackphase("player2");
    Thread.Sleep(4000);
}else if(p1.Speed < p2.Speed){
    attackphase("player2");
    attackphase("player1");
    Thread.Sleep(4000);
}else if(p1.Speed == p2.Speed){
    int randomorder = Generator1.Next(1,2);
        if(randomorder == 1){
            attackphase("player1");
            attackphase("player2");
            Thread.Sleep(4000);
    }else if(randomorder == 2){
            attackphase("player2");
            attackphase("player1");
            Thread.Sleep(4000);
    }
}
//checks which player won
if(p1.Hp <= 0){
    Console.WriteLine($"Player2's {p2.Name} won!!");
    break;
}else if(p2.Hp <= 0){
    Console.WriteLine($"Player1's {p1.Name} won!!");
    break;
}else if(p1.Hp <=0 && p2.Hp <= 0){
    Console.WriteLine($"The game ended in a stalemate!!");
    break;
}

}
Console.WriteLine("press any button to continue");
Console.ReadKey();
gamemenu();
}
