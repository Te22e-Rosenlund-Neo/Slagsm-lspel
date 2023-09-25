using System.Reflection.Metadata.Ecma335;

public class Character{
    
public string Name;
public double Damage,Hp,Armour, Speed,ID,attack1damage,attack2damage,attack1hitchance,attack2hitchance;
double crit = 1;
public string attack1;
public string attack2;
Random Generator = new Random();
public Character(string Aname, int Adamage, int Ahp, int Aarmour, int Aspeed, string Move1, double Move1Damage, double Move1HitChance, string Move2, double Move2damage, double Move2hitchance, double ID){
    Name = Aname;
    Damage = Adamage;
    Hp = Ahp;
    Armour = Aarmour;
    Speed = Aspeed;
    this.ID = ID;
    attack1 = Move1;
    attack1damage = Move1Damage;
    attack1hitchance = Move1HitChance;
    attack2 = Move2;
    attack2damage = Move2damage;
    attack2hitchance = Move2hitchance;
}

public double Attack1DamageCalculator(double OpponentArmour){
    if(Generator.Next(1,10) == 7){
        crit = 3;
        Console.WriteLine("CRIT!");
    }else{
        crit = 1;
    }
if(Generator.Next(1,100)<=(attack1hitchance*100)){
Console.WriteLine($"{attack1damage*crit*(Damage*0.4)*(1-((OpponentArmour/2)*0.01))} damage");
return Math.Round(attack1damage*crit*(Damage*0.4)*(1-((OpponentArmour/2)*0.01)));
}else{
    Console.WriteLine("you missed!");
    return 0;
}
}

public double Attack2DamageCalculator(Double OpponentArmour){
    if(Generator.Next(1,10) == 7){
        crit = 3;
        Console.WriteLine("CRIT!");
    }else{
        crit = 1;
    }
if(Generator.Next(1,100)<=(attack2hitchance*100)){
Console.WriteLine($"{attack2damage*crit*(Damage*0.4)*(1-((OpponentArmour/2)*0.01))} damage");
return Math.Round(attack2damage*crit*(Damage*0.4)*(1-((OpponentArmour/2)*0.01)));
}else{
    Console.WriteLine("you missed!");
    return 0;
}
}

public void Displaystats(){
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(ID+":");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"\n{Name}");
Console.ResetColor();
Console.WriteLine($"{Hp} hitpoints");
Console.WriteLine($"{Damage} Damage");
Console.WriteLine($"{Speed} Speed");
Console.WriteLine($"{Armour} Armour");
}






}


