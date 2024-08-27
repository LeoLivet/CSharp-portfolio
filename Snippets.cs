#region User permission (self guided)



string permission = "Manager";
int level = 20;

string userPermission = permission;

int userLevel = level;


if (userPermission.Contains("Admin"))
{
    if (userLevel > 55)
        Console.WriteLine("Welcome, Super Admin user.");
    
    else 
        Console.WriteLine("Welcome, Admin user.");
}

else if (userPermission.Contains("Manager"))
{
    if (userLevel < 20)
        Console.WriteLine("You do not have sufficient privileges.");
    else
        Console.WriteLine("Contact an Admin for access.");

}
else
{
    Console.WriteLine("You do not have sufficient priviliges, noob.");
}

#endregion







#region switch states example

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
    color = "Black";
    break;
    
    case "MN":
    color = "Maroon";
    break;

    default:
    color = "White";
    break;

}

switch (product[2])
{
    case "S":
    size = "Small";
    break;

    case "M":
    size = "Medium";
    break;

    case "L":
    size = "Large";
    break;

    default:
    size = "One size fits all!";
    break; 
}


Console.WriteLine($"Product: {size} {color} {type}");

#endregion







#region Fizzbuzz challenge 

//  Iterate through 100 numbers
// if its divisible by 3 print "fizz"
// if its dividible by 5 print "buzz"
// if its both print fizzbuzz

// my solution:

//Fizzbuzz challenge yeehaw

for (int i = 1; i < 101; i++)
{
    int j = i % 3;
    int k = i % 5;

    if (j == 0)
    {
        if (k == 0)

            Console.WriteLine(i + " - FizzBuzz");

        else
        Console.WriteLine(i + " - Fizz");
    }
    else if (k == 0)
        Console.WriteLine(i + " - Buzz");
    
    else
        Console.WriteLine(i);
}

//Microsofts solution:
// I too tried to use the and operator but cannot yet wrap my head around it. (26/08-2024)
// i did originally go with testing i using == but found it easier to use the variable i had set myself.
// Still my version would of course also work 
//although i do see that the example given is more succcint.


for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}

#endregion






#region monster game with random, while and break loops

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

#endregion





#region User permission (self guided)



string permission = "Manager";
int level = 20;

string userPermission = permission;

int userLevel = level;


if (userPermission.Contains("Admin"))
{
    if (userLevel > 55)
        Console.WriteLine("Welcome, Super Admin user.");
    
    else 
        Console.WriteLine("Welcome, Admin user.");
}

else if (userPermission.Contains("Manager"))
{
    if (userLevel < 20)
        Console.WriteLine("You do not have sufficient privileges.");
    else
        Console.WriteLine("Contact an Admin for access.");

}
else
{
    Console.WriteLine("You do not have sufficient priviliges, noob.");
}

#endregion






#region switch states example

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
    color = "Black";
    break;
    
    case "MN":
    color = "Maroon";
    break;

    default:
    color = "White";
    break;

}

switch (product[2])
{
    case "S":
    size = "Small";
    break;

    case "M":
    size = "Medium";
    break;

    case "L":
    size = "Large";
    break;

    default:
    size = "One size fits all!";
    break; 
}


Console.WriteLine($"Product: {size} {color} {type}");

#endregion
