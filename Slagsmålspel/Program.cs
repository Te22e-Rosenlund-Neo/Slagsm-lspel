using System.Collections;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
//lägg till så att man kan skapa nya karaktärer
Console.WriteLine(@"


                                        ▄▄▄█████▓ ██░ ██ ▓█████                         
                                        ▓  ██▒ ▓▒▓██░ ██▒▓█   ▀                         
                                        ▒ ▓██░ ▒░▒██▀▀██░▒███                           
                                        ░ ▓██▓ ░ ░▓█ ░██ ▒▓█  ▄                         
                                        ▒██▒ ░ ░▓█▒░██▓░▒████▒                        
                                        ▒ ░░    ▒ ░░▒░▒░░ ▒░ ░                        
                                            ░     ▒ ░▒░ ░ ░ ░  ░                        
                                        ░       ░  ░░ ░   ░                           
                                                ░  ░  ░   ░  ░                        
                                                                                        
                                        ▓█████▄ ▓█████ ▄▄▄      ▓█████▄  ██▓   ▓██   ██▓
                                        ▒██▀ ██▌▓█   ▀▒████▄    ▒██▀ ██▌▓██▒    ▒██  ██▒
                                        ░██   █▌▒███  ▒██  ▀█▄  ░██   █▌▒██░     ▒██ ██░
                                        ░▓█▄   ▌▒▓█  ▄░██▄▄▄▄██ ░▓█▄   ▌▒██░     ░ ▐██▓░
                                        ░▒████▓ ░▒████▒▓█   ▓██▒░▒████▓ ░██████▒ ░ ██▒▓░
                                        ▒▒▓  ▒ ░░ ▒░ ░▒▒   ▓▒█░ ▒▒▓  ▒ ░ ▒░▓  ░  ██▒▒▒ 
                                        ░ ▒  ▒  ░ ░  ░ ▒   ▒▒ ░ ░ ▒  ▒ ░ ░ ▒  ░▓██ ░▒░ 
                                        ░ ░  ░    ░    ░   ▒    ░ ░  ░   ░ ░   ▒ ▒ ░░  
                                        ░       ░  ░     ░  ░   ░        ░  ░░ ░     
                                        ░                       ░              ░ ░     
                                        ▓█████▄  █    ██ ▓█████  ██▓      ██████        
                                        ▒██▀ ██▌ ██  ▓██▒▓█   ▀ ▓██▒    ▒██    ▒        
                                        ░██   █▌▓██  ▒██░▒███   ▒██░    ░ ▓██▄          
                                        ░▓█▄   ▌▓▓█  ░██░▒▓█  ▄ ▒██░      ▒   ██▒       
                                        ░▒████▓ ▒▒█████▓ ░▒████▒░██████▒▒██████▒▒       
                                        ▒▒▓  ▒ ░▒▓▒ ▒ ▒ ░░ ▒░ ░░ ▒░▓  ░▒ ▒▓▒ ▒ ░       
                                        ░ ▒  ▒ ░░▒░ ░ ░  ░ ░  ░░ ░ ▒  ░░ ░▒  ░ ░       
                                        ░ ░  ░  ░░░ ░ ░    ░     ░ ░   ░  ░  ░         
                                        ░       ░        ░  ░    ░  ░      ░         
                                        ░                                              
");
Thread.Sleep(5000);

string[] ABCList = { "A", "B", "C" };
string Answer = "";
Random Generator1 = new Random();
// character x = new character(name,damage,health,armor,speed,move1,move1damage,move1hitchance,move2,move2damage,move2hitchance,id)
Character Player1 = new Character("Micke", 60, 100, 40, 50, "Skjut lasrar ur dina röda ögon", 1, 0.9, "Ta hjälp av japanare", 3, 0.4, 1);
Character Player2 = new Character("Martin", 80, 110, 30, 30, "använd TOUCHPADEN!", 2, 0.7, "använd din mus, primitivt!", 0.9, 0.9, 2);
Character Player3 = new Character("Huglin", 70, 60, 20, 100, "Goblin GANG", 1.5, 0.8, "Dissa skolmaten", 1, 0.95, 3);
Character Player4 = new Character("Finsk Fisk", 30, 50, 100, 70, "DU har redovisnig imorgon", 2, 0.7, "Prata finska", 4, 0.5, 4);
Character Player5 = new Character("Einstein", 20, 120, 100, 10, "ANVÄND NEWTONS 0'TE LAG", 10, 0.3, "Mät motståndaren med KrukVäxten i sal A6!", 1.2, 0.9, 5);
Character Player6 = new Character("Rådet", 100, 50, 10, 90, "Bryt era egna regler, genom korrupta handlingar", 1, 0.9, "laga en 3d-printer", 2, 0.7, 6);
Character Player7 = new Character("Atom-bomb", 201, 49, 0, 0, "Explose on the opponent", 10, 0.3, "Launch a fake bomb", 0.1, 1, 7);
List<Character>PlayerList = new List<Character>{Player1,Player2,Player3,Player4,Player5,Player6,Player7}; 
 // players is a flexilble list which enables player to make new characters infinitely, which an array cannot do. 

int IdCount = 7;        //id count is used to create new characters later on

//p1,p2 is the variable that saves the players character
Character P1;
Character P2;
bool IsAiChosen;
string Value;
GameOpeningChoice();
//----------------------------------------------------------------------------------------
void GameOpeningChoice()
{
    //launches at game start, sime menu
    while (true)
    {
        Console.Clear();
        Console.WriteLine("\n\nWhat would you like to do?");
        Console.WriteLine("A: Play game");
        Console.WriteLine("B: Character menu");
        Console.WriteLine("C: Quit the game");
        CheckAnswerABC();
        GameMenu();
        break;
    }
}
//----------------------------------------------------------------------------------------
void GameMenu() //Handles the options that can be written in gameopeningchoice, could be written in that functon as well
{              
    while (true)
    {
        if (Answer == "A")
        {
            Console.WriteLine("you started the game!");
            Thread.Sleep(1000);
            Console.Clear();
            GameMode();
            break;
        }
        else if (Answer == "B")
        {
            Console.Clear();
            CharacterMenu();
        }
        else
        {
            //quits the game.
            Environment.Exit(0);
        }
    }
}
//----------------------------------------------------------------------------------------
void CharacterMenu()
{
    //if you chose to enter charactermenu above
    Console.WriteLine("Choose an option");
    Console.WriteLine("A: Create a new Character");
    Console.WriteLine("B: View current characters");
    Console.WriteLine("C: Go back");
    CheckAnswerABC();
    if (Answer == "A")
    {
        MakeCustomCharacter();
    }
    else if (Answer == "B")
    {
        Console.Clear();
        foreach (Character Character in PlayerList)
        {
            Character.Displaystats();           //shows the statistics/information of every character
        }
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        GameOpeningChoice();
    }
    else if(Answer == "C")
    {
        GameOpeningChoice();
    }



}
//----------------------------------------------------------------------------------------
void MakeCustomCharacter() //to make a custom character that can be used, but is only stored for the duration of runtime
{
    //points = total amount of points to spend on stats
    int Points = 250;
    IdCount++;


    Console.Clear();
    Console.WriteLine("Write a name");          //make a name
    string name = Console.ReadLine() ?? "";
;    Console.Clear();

    ColorSwap("you have 250 points to use on 4 stats", "Green");    
    Console.WriteLine("choose strength");                       //choose strength stat
    Points -= CheckLogicForCC(Points);
    int Strength = Convert.ToInt32(Value);
    Console.Clear();

    ColorSwap($"you have {Points} points left", "Green");
    Console.WriteLine("choose health");                     //choose health
    Points -= CheckLogicForCC(Points);
    int Health = Convert.ToInt32(Value);
    Console.Clear();

    ColorSwap($"you have {Points} points left", "Green");
    Console.WriteLine("choose Armour (reduces opponents damage will be reduced)");
    Points -= CheckLogicForCC(Points);                                              //choose armor amount
    int Armor = Convert.ToInt32(Value);
    Console.Clear();

    ColorSwap($"you have {Points} points left", "Green");
    Console.WriteLine("Choose speed");
    Points -= CheckLogicForCC(Points);                      //choose speed amount
    int Speed = Convert.ToInt32(Value);
    Console.Clear();

    Character Name = new Character(name,Strength,Health,Armor,Speed,"move1",1,0.9,"move2",3,0.7,IdCount);
    PlayerList.Add(Name);          // ^ creates a new character based on input, however the moves and its damage is already set
    CharacterMenu();
}
//----------------------------------------------------------------------------------------
int CheckLogicForCC(int Points){  //checks if the users input is a int, and if the value is possible in this context. used in function above
    int Trying;
    while(true){
         Value = Console.ReadLine() ?? "";
            if(int.TryParse(Value, out Trying) && Convert.ToInt32(Value) <= Points && Convert.ToInt32(Value) >= 0){
                break;
            }else{
                Console.WriteLine("Not possible!");
        }
}
return Convert.ToInt32(Value);



}
//----------------------------------------------------------------------------------------
void GameMode() //self explanatory
{ 
    Console.WriteLine("A: Player vs Player");
    Console.WriteLine("B: Player vs bot");
    Console.WriteLine("C: Go back");
    CheckAnswerABC();
    if (Answer == "A")
    {
        IsAiChosen = false;
        GameStarted();
    }
    else if (Answer == "B")
    {
        IsAiChosen = true;  //IsAiChosen makes the seconds player become an automatic robot.
        GameStarted();
    }
    else
    {
        GameOpeningChoice();
    }
}
//----------------------------------------------------------------------------------------
void GameStarted() //runtime, prompts the player/s to choose a character
{
    Console.WriteLine("\nPlayer 1 choose your character");
    Thread.Sleep(1000);
    foreach (Character Character in PlayerList)
    {
        Character.Displaystats();  //displays all characters
    }

    CheckForCharacterPossibilities("characterdecision");
    P1 = PlayerList[Convert.ToInt32(Answer) - 1]; //sets that player 1 = given answer
    Console.Clear();
    Console.WriteLine("\nPlayer 2 choose your character");  //only happens if a player vs player mode is chosen.
    Thread.Sleep(1000);
    foreach (Character Character in PlayerList)
    {
        Character.Displaystats();
    }
    if (IsAiChosen == false)
    {
        CheckForCharacterPossibilities("characterdecision");  //fucntion that choses which character the Bot choses
        P2 = PlayerList[Convert.ToInt32(Answer) - 1];
    }
    else
    {
        P2 = PlayerList[Generator1.Next(1, PlayerList.Count())];
    }

    Console.WriteLine($"Player1 is {P1.Name}");
    Console.WriteLine($"Player2 is {P2.Name}");
    Thread.Sleep(1000);
    Rounds();
}
//----------------------------------------------------------------------------------------
void Rounds()  //starts the run phase, which only ends when one or both players have died
{
    int Round = 0;
    while (true)
    {
        Round++;
        Console.Clear();
        ColorSwap($"Round: {Round}", "Green"); //colorswap adds a color to the given text
        Console.WriteLine($"player1's {P1.Name} has {P1.Hp} health.         Player2's {P2.Name} has {P2.Hp} health.");
        //the different types of possibilities depending on who is quicker
        if (P1.Speed > P2.Speed)
        {
            AttackPhase("player1");
            if (IsAiChosen == false)
            {
                AttackPhase("player2");
            }
            else
            {
                BotOpponent();
            }
            Thread.Sleep(3000);
        }
        else if (P1.Speed < P2.Speed)
        {
            if (IsAiChosen == false)
            {
                AttackPhase("player2");
            }
            else
            {
                BotOpponent();
            }
            AttackPhase("player1");
            Thread.Sleep(3000);
        }
        else if (P1.Speed == P2.Speed) //if their speed is equal, we randomize who attacks first each round
        {
            int randomorder = Generator1.Next(1, 2);
            if (randomorder == 1)
            {
                AttackPhase("player1");
                if (IsAiChosen == false)
                {
                    AttackPhase("player2");
                }
                else
                {
                    BotOpponent();
                }
                Thread.Sleep(3000);
            }
            else if (randomorder == 2)
            {
                if (IsAiChosen == false)
                {
                    AttackPhase("player2");
                }
                else
                {
                    BotOpponent();
                }
                AttackPhase("player1");
                Thread.Sleep(3000);
            }
        }
        //checks which player won
        if (P1.Hp <= 0)
        {
            ColorSwap($"Player2's {P2.Name} won!!", "Green");
            break;
        }
        else if (P2.Hp <= 0)
        {
            ColorSwap($"Player1's {P1.Name} won!!", "Green");
            break;
        }
        else if (P1.Hp <= 0 && P2.Hp <= 0)
        {
            ColorSwap($"The game ended in a stalemate!!", "Green");
            break;
        }

    }
    Console.WriteLine("\npress any button to continue");
    Console.ReadKey();
    GameOpeningChoice();
}
//----------------------------------------------------------------------------------------
void CheckAnswerABC()
{
    //checks if the given answer is either A, B, or C. used in menus
    while (true)
    {
        Answer = (Console.ReadLine() ?? "").ToUpper();    // question marks with "" at the end, makes that if the players answer = null, it becomes an empty string
        if (ABCList.Contains(Answer) == true)   //ABC list contains {"A", "B", "C"}
        {
            break;
        }
        else
        {
            Console.WriteLine("please write a possible answer!");
        }
    }

}
//----------------------------------------------------------------------------------------
void CheckForCharacterPossibilities(string phase)
{
    //CheckForCharacterPossibilities
    //checks depending on which phase of the game about if the given answer is possible.
    while (true)
    {
        int Trying;
        Answer = Console.ReadLine() ?? "";
        if (phase == "characterdecision")   //if a characters should be chosen
        {
            if (!int.TryParse(Answer, out Trying) || Convert.ToInt32(Answer) > PlayerList.Count() || Convert.ToInt32(Answer) < 0)
            {
                Console.WriteLine("please type a possible character!");
            }
            else
            {
                break;
            }
        }
        else if (phase == "attackdecision")  //if the attacks should be displayed and chosen
        {
            if (!int.TryParse(Answer, out Trying) || Convert.ToInt32(Answer) < 0 || Convert.ToInt32(Answer) > 2) 
            { 
                Console.WriteLine("write a possible move!!!! (1-2)");  //either move 1 or two
            }
            else
            {
                break;
            }
        }
    }
}
//----------------------------------------------------------------------------------------
void ColorSwap(string Text, string color)  //chagnes the color of the given text, depending on which color has been chosen
{
    if (color == "Red")  //only red and green color is a part of the game
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Text);
        Console.ResetColor();
    }
    else if (color == "Green")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{Text}");
        Console.ResetColor();
    }

}
//----------------------------------------------------------------------------------------
void AttackPhase(string Attacker)
{
    // Decides which of the attacks the player has chosen, calculates damage, removes it from opponent hp
    if (Attacker == "player1")
    {
        Console.WriteLine($"\nWhat should player1's {P1.Name} do");  
        Thread.Sleep(2000);
        Console.WriteLine($"1: {P1.attack1}         2: {P1.attack2}");  //displays the attacks, besides each other.
        CheckForCharacterPossibilities("attackdecision");

        if (Convert.ToInt32(Answer) == 1)
        {
            P2.Hp -= P1.Attack1DamageCalculator(P2.Armour); //removes hp from opponent
        }
        else if (Convert.ToInt32(Answer) == 2)
        {
            P2.Hp -= P1.Attack2DamageCalculator(P2.Armour);
        }
        ColorSwap($"Player 2 has {P2.Hp} hitpoints left", "Red");
        //----
        //same as above, but if the attacker is player2
    }
    else if (Attacker == "player2")
    {
        Console.WriteLine($"\nWhat should player2's {P2.Name} do");
        Console.WriteLine($"1: {P2.attack1}         2: {P2.attack2}");
        CheckForCharacterPossibilities("attackdecision");

        if (Convert.ToInt32(Answer) == 1)
        {
            P1.Hp -= P2.Attack1DamageCalculator(P1.Armour);
        }
        else if (Convert.ToInt32(Answer) == 2)
        {
            P1.Hp -= P2.Attack2DamageCalculator(P1.Armour);
        }
        ColorSwap($"Player 1 has {P1.Hp} hitpoints left", "Red");

    }
}
//----------------------------------------------------------------------------------------
void BotOpponent() //generates a random attack for the AI/bot opponent. Either attack 1 or 2.
{

    int AiAnswer = Generator1.Next(1, 2);
    if (AiAnswer == 1)
    {
        P1.Hp -= P2.Attack1DamageCalculator(P1.Armour);
    }
    else if (AiAnswer == 2)
    {
        P1.Hp -= P2.Attack2DamageCalculator(P1.Armour);
    }
    ColorSwap($"Player 1 has {P1.Hp} hitpoints left", "Red");
}

