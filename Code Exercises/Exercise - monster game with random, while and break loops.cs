// monster game with random, while and break loops

// my version
Random random = new Random();

int monsterHP = 10;
int heroHP = 10;

int attack = 0;

while (true)
{
	Console.WriteLine("monster:"+monsterHP+"hero:"+heroHP+"\n");
	attack = random.Next(1,11);
	
	Console.WriteLine($"Monster was hit for: -|{attack}| HP and now has {monsterHP -= attack}HP\n");
	
	if (monsterHP <=0)
	{
		Console.WriteLine("The hero has defeated the monster hooray!\n A ray of light sparks on the horizon...");
		break;
	}

	attack = random.Next(1,11);
	Console.WriteLine($"Hero was hit for: -|{attack}| HP and now has {heroHP -= attack}HP\n");
	
	if (heroHP <= 0)
	{
		Console.WriteLine("The monster has defeated the villain, the whole town screams in despair!\n Darkness surrounds the town...\n\n__________");
		break;
	}
} 

//Proposed microsoft version
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
	int roll = dice.Next(1, 11);
	monster -= roll;
	Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

	if (monster <= 0) continue;

	roll = dice.Next(1, 11);
	hero -= roll;
	Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
