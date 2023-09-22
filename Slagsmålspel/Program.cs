string[] ABCList = {"A","B","C"};
string Answer="";

void GameOpeningChoice(){
    //launches at game start
while(true){   
Console.WriteLine("Welcome to a fighting game");
Console.WriteLine("What would you like to do?");
Console.WriteLine("A: Play game");
Console.WriteLine("B: Customize characters");
Console.WriteLine("C: Quit the game");
CFAABC();
break;
}
}
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
Thread.Sleep(5000);









// Characters characters = new Characters();
// characters.character1();