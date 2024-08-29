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






#region Code project 1 Console readline project. Pick an int between 5-10

string? thenumberAsAString;
int theNumber = 0;
bool validNumber = false;


Console.WriteLine("pick a number between '5' or '10' Do not write it using letters.");

do
{
	thenumberAsAString = Console.ReadLine();

	if (int.TryParse(thenumberAsAString, out theNumber))
	{

		if (theNumber >=5 && theNumber <= 10)
		{
			Console.WriteLine($"Yes you have picked number: {theNumber} it is between 5 and 10 good job reading!");
			validNumber = true;

		}
		else
			Console.WriteLine(theNumber > 10 ? "Too High!" : "Too low!");
			
	}
	else
	Console.WriteLine(thenumberAsAString == "" ? "you must input a number!" : "not a number! You must not use letters to type your numbers!"); 


}while(validNumber == false);

//microsoft solution:
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
	readResult = Console.ReadLine();
	if (readResult != null) 
	{
		valueEntered = readResult;
	}

	validNumber = int.TryParse(valueEntered, out numValue);

	if (validNumber == true)
	{
		if (numValue <= 5 || numValue >= 10)
		{
			validNumber = false;
			Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
		}
	}
	else 
	{
		Console.WriteLine("Sorry, you entered an invalid number, please try again");
	}
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();



#endregion






#region Code project 2 - Check user credentials
/* Need to redo this i think theres a way to simply check if  
the userInput matches something in the array and then do
 a switch case instead */

string? userInput;
string? trimmedString;
bool userHasValidCredentials = false;
string[] levelCredentials = {"administrator", "manager", "user"};



Console.WriteLine("Enter your role name (Administrator, Manager or User)");


do {
userInput = Console.ReadLine();
trimmedString = userInput.Trim().ToLower();

if(trimmedString == levelCredentials[0])
 {
	Console.WriteLine("You are an Administrator");
	userHasValidCredentials = true;
 }

else if(trimmedString == levelCredentials[1])
{
	Console.WriteLine("You are a Manager");
	userHasValidCredentials = true;
}

else if(trimmedString == levelCredentials[2])
{
	Console.WriteLine("You are a user");
	userHasValidCredentials = true;
}

else
{
	Console.WriteLine($"The credential you have entered:{userInput} is not valid");
}

}while(userHasValidCredentials != true);

// microsoft solution:
string? readResult;
string roleName = "";
bool validEntry = false;

do
{                
	Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
	readResult = Console.ReadLine();
	if (readResult != null) 
	{
		roleName = readResult.Trim();
	}

	if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
	{
		validEntry = true;
	}
	else
	{
		Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
	}

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();

#endregion






#region Code Project 3 - Write code that processes the contents of a string array

//My first Attempt that i tried before peeking at the solution=


				/*
				string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I. like all three of the menu choices" };


				// int periodLocation = 0;


				for (int i = 0; i < myStrings.Length; i++) //Kører hver string i myStrings arrayen
				{
					string currentString = myStrings[i];
					int hasPeriod = currentString.IndexOf(".");
					
					Console.WriteLine(hasPeriod);

					while(hasPeriod != -1)
					{
						int stringStart = 0;
						int stringEnd = currentString.IndexOf(".") + 1;
						string printThisString = currentString.Substring(stringStart, stringEnd);
						Console.WriteLine(printThisString+ "pee");

						// stringStart += stringEnd;
						// stringEnd ++;

						hasPeriod = currentString.IndexOf(".", stringEnd);
						
						
					}

				}



				// my pseudo code for the logic 

					// for hver array i mystrings(i++)

					// punktumLokation = indexof(".") 

					//     imens (PunktumLokation =! -1)

					//         jegKanLide = trim(arraystring frem til punktumLokation)
					//         punktumLokation ++;
					//         Console.WriteLine(JegKanLide);
					
					//     ellers
					//         Console.WriteLine(myStrings[i]);

				*/        


// the end result after i peaked at the solution:
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;



for (int i = 0; i < stringsCount; i++) //Kører hver string i myStrings arrayen
{
	myString = myStrings[i];
	periodLocation = myString.IndexOf(".");
	
	string mySentence;


	while(periodLocation != -1)
	{
		mySentence = myString.Remove(periodLocation);
		
		myString = myString.Substring(periodLocation + 1);
		
		myString = myString.TrimStart();
		
		periodLocation = myString.IndexOf(".");
		
		Console.WriteLine(mySentence);
	
	}
	mySentence = myString.Trim();
	Console.WriteLine(mySentence);

}

// and the microsoft solution:
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
	myString = myStrings[i];
	periodLocation = myString.IndexOf(".");

	string mySentence;

	// extract sentences from each string and display them one at a time
	while (periodLocation != -1)
	{

		// first sentence is the string value to the left of the period location
		mySentence = myString.Remove(periodLocation);

		// the remainder of myString is the string value to the right of the location
		myString = myString.Substring(periodLocation + 1);

		// remove any leading white-space from myString
		myString = myString.TrimStart();

		// update the comma location and increment the counter
		periodLocation = myString.IndexOf(".");

		Console.WriteLine(mySentence);
	}
 
	mySentence = myString.Trim();
	Console.WriteLine(mySentence);
}
#endregion