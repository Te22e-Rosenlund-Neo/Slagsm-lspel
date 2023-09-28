using System.Reflection.Metadata.Ecma335;
//makes characters based on a specific manual, makes it easier to manage individual characters.
public class Character{
    
public string Name;
public double Damage,Hp,Armour, Speed,ID,Attack1Damage,Attack2Damage,Attack1HitChance,Attack2HitChance;
double crit = 1;
public string Attack1;
public string Attack2;
Random Generator = new Random();
//contstructor to turn all the given information about the character when created
public Character(string Aname, int Adamage, int Ahp, int Aarmour, int Aspeed, string Move1, double Move1Damage, double Move1HitChance, string Move2, double Move2Damage, double Move2HitChance, double ID){
    Name = Aname;
    Damage = Adamage;
    Hp = Ahp;
    Armour = Aarmour;
    Speed = Aspeed;
    this.ID = ID;
    Attack1 = Move1;
    Attack1Damage = Move1Damage;
    Attack1HitChance = Move1HitChance;
    Attack2 = Move2;
    Attack2Damage = Move2Damage;
    Attack2HitChance = Move2HitChance;
}
//calculates the damage depending on hitchance, opponents armour, move damage and crit chance.
//for attack1, (could've done both in the same method similar to other parts of the code)
public double Attack1DamageCalculator(double OpponentArmour){
    //1/10 chance of a crit, crit = 3x damage
    if(Generator.Next(1,10) == 7){
        crit = 3;
        Console.WriteLine("CRIT!");
    }else{
        crit = 1;
    }
//makes it random if the character will hit the opponent or not, based on the specific attacks hitchance
if(Generator.Next(1,100)<=(Attack1HitChance*100)){
Console.WriteLine($"{Name} used {Attack1}");
Console.WriteLine($"{Attack1Damage*crit*(Damage*0.4)*(1-(OpponentArmour/2*0.01))} damage");
return Math.Round(Attack1Damage*crit*(Damage*0.4)*(1-(OpponentArmour/2*0.01)));
}else{
    Console.WriteLine("Miss!");
    return 0;
}
}

//calculates the damage depending on hitchance, opponents armour, move damage and crit chance.
//for move 2, rest is same as above
public double Attack2DamageCalculator(Double OpponentArmour){
    if(Generator.Next(1,10) == 7){
        crit = 3;
        Console.WriteLine("CRIT!");
    }else{
        crit = 1;
    }
if(Generator.Next(1,100)<=(Attack2HitChance*100)){
Console.WriteLine($"{Name} used {Attack2}");
Console.WriteLine($"{Attack2Damage*crit*(Damage*0.4)*(1-(OpponentArmour/2*0.01))} damage");
return Math.Round(Attack2Damage*crit*(Damage*0.4)*(1-(OpponentArmour/2*0.01)));
}else{
    Console.WriteLine("Miss!");
    return 0;
}
}
//displays all the stats for the player to see
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


