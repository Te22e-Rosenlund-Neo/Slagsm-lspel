using System.Reflection.Metadata.Ecma335;

public class Character{
    
string Name;
public double Damage,Hp,Armour, Speed;
double crit = 1;
Random Generator = new Random();
public Character(string Aname, int Adamage, int Ahp, int Aarmour, int Aspeed, string Move1, double Move1Damage, double Move1HitChance, string Move2, double Move2damage, double Move2hitchance){
    Name = Aname;
    Damage = Adamage;
    Hp = Ahp;
    Armour = Aarmour;
    Speed = Aspeed;
}



public double Damagecalculator(){
if(Generator.Next(1,10) == 7){
    crit = 3;
}else{
    crit=1;
}
return Math.Round(crit*(Damage*0.25*Generator.Next(1,3))*((Armour/2)*0.01));
}

public void Displaystats(){
Console.WriteLine($"\n\n{Name} has {Hp} hitpoints");
Console.WriteLine($"{Name} has {Damage} Damage");
Console.WriteLine($"{Name} has {Speed} Speed");
Console.WriteLine($"{Name} has {Armour} Armour");
}
}


