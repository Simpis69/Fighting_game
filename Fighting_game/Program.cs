Console.WriteLine("Welcome to fight simulator!");
Console.WriteLine("Choose your fighters name");
String name = Console.ReadLine();



int HeroHp = 100;
int VillainHp = 100;


string HeroName = $"{name}";
string VillainName = "Villain";

Random generator = new Random();

int dmg = generator.Next(10, 20);

while (HeroHp> 0 && VillainHp>0)
{
    Console.WriteLine("\n----New round----");
    Console.WriteLine($"{HeroName}: {HeroHp} {VillainName}: {VillainHp}\n");


int herodamage = generator.Next(1, 20);
VillainHp -= herodamage;
Console.WriteLine($"{HeroName} does {herodamage} to {VillainName}");

int villaindamage = generator.Next(1, 20);
HeroHp -= villaindamage;
Console.WriteLine($"{VillainName} does {villaindamage} to {HeroName}");

Console.WriteLine("Press any button to continue");
Console.ReadKey();
}

Console.WriteLine("\n----Battle ended----");

if (HeroHp == 0 && VillainHp == 0){
    Console.WriteLine("It's a draw!");
}
else if (HeroHp == 0){
    Console.WriteLine($"{VillainName} won!");
}
else{
    Console.WriteLine($"{HeroName} Won!");
}

Console.WriteLine("press any button to quit");
Console.ReadKey();