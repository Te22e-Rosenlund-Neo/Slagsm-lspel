using System.Reflection.PortableExecutable;

string[] ABCList = {"A","B","C"};
string Answer="";
//Karaktärernas stats återspeglar inte åsikter, karaktärsdrag eller liknande om personen/na!
// character x = new character(name,damage,health,armor,speed,move1,move1damage,move1hitchance,move2,move2damage,move2hitchance)
Character Player1 = new Character("Micke", 60,100,40,50,"Skjut lasrar ur dina röda ögon",1,0.9,"Ta hjälp av japanare",3,0.4);
Character Player2 = new Character("Martin",80, 110, 30,30,"använd TOUCHPADEN!",2,0.7,"använd din mus",0.9,1);
Character Player3 = new Character("Huglin",70, 60, 20,100,"Goblin GANG", 1.5,0.8,"Dissa skolmaten",1,1);
Character Player4 = new Character("Vera",30, 50, 100,70,"DU har redovisnig imorgon", 2,0.7,"Fäll ner din skärm",1,0.9);
Character Player5 = new Character("Nicholas",20, 120, 100,10,"ANVÄND NEWTONS 0'TE LAG",10,0.9,"Merge with einstein",0,0.5);
Character Player6 = new Character("Rådet",100, 50, 10,90,"Bryt era egna regler, genom korrupta handlingar",1,1,"laga en 3d-printer",2,0.7);
Character[] players;


//game start
while(true){

GameOpeningChoice();
if(Answer == "A"){
    Console.WriteLine("you started the game!");
    break;
}else if(Answer == "B"){
    Console.WriteLine("this function is not yet made, come back another time!");
    break;
}else{
    Console.WriteLine("else (Quit)");
    break;
}


}
Console.ReadKey();

//----------------------------------------------------------------------------------------
void CFAABC(){
    //CheckForAnswerABC
    Answer = (Console.ReadLine() ?? "").ToUpper();
while(true){
    
 if(ABCList.Contains(Answer) == true){
        break;
}else{
        Console.WriteLine("please write a possible answer!");
}
}

}

//----------------------------------------------------------------------------------------
void GameOpeningChoice(){
    //launches at game start
while(true){   
    Console.WriteLine("Welcome to a fighting game");
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("A: Play game");
    Console.WriteLine("B: View Characters");
    Console.WriteLine("C: Quit the game");
    CFAABC();
break;
}
}
//----------------------------------------------------------------------------------------
void DisplayHealth(){
    Console.Write($"Player1 has {Player1.Hp}hp        Player2 has {Player2.Hp}hp");
}
//----------------------------------------------------------------------------------------


