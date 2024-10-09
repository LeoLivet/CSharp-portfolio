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






#region Exercise - Build and test a loop for entering new pet data.


// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
	switch (i)
	{
		case 0:
			animalSpecies = "dog";
			animalID = "d1";
			animalAge = "2";
			animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
			animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
			animalNickname = "lola";
			break;

		case 1:
			animalSpecies = "dog";
			animalID = "d2";
			animalAge = "9";
			animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
			animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
			animalNickname = "loki";
			break;

		case 2:
			animalSpecies = "cat";
			animalID = "c3";
			animalAge = "1";
			animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
			animalPersonalityDescription = "friendly";
			animalNickname = "Puss";
			break;

		case 3:
			animalSpecies = "cat";
			animalID = "c4";
			animalAge = "?";
			animalPhysicalDescription = "";
			animalPersonalityDescription = "";
			animalNickname = "";
			break;

		default:
			animalSpecies = "";
			animalID = "";
			animalAge = "";
			animalPhysicalDescription = "";
			animalPersonalityDescription = "";
			animalNickname = "";
			break;

	}

	ourAnimals[i, 0] = "ID #: " + animalID;
	ourAnimals[i, 1] = "Species: " + animalSpecies;
	ourAnimals[i, 2] = "Age: " + animalAge;
	ourAnimals[i, 3] = "Nickname: " + animalNickname;
	ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
	ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}


// display the top-level menu options
do
{
	// Console.Clear();

	Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
	Console.WriteLine(" 1. List all of our current pet information");
	Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
	Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
	Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
	Console.WriteLine(" 5. Edit an animal’s age");
	Console.WriteLine(" 6. Edit an animal’s personality description");
	Console.WriteLine(" 7. Display all cats with a specified characteristic");
	Console.WriteLine(" 8. Display all dogs with a specified characteristic");
	Console.WriteLine();
	Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

	readResult = Console.ReadLine();
	if (readResult != null)
	{
		menuSelection = readResult.ToLower();
	}

	// Console.WriteLine($"You selected menu option {menuSelection}.");
	// Console.WriteLine("Press the Enter key to continue");

	// pause code execution
	// readResult = Console.ReadLine();
	switch (menuSelection)
	{
		case "1":
			// List all of our current pet information
			for (int i = 0; i < maxPets; i++)
			{
				if (ourAnimals[i, 0] != "ID #: ")

				{
					Console.WriteLine();
					for (int j = 0; j < 6; j++)

					{
						Console.WriteLine(ourAnimals[i, j]);
					}
				}
			}
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;

		case "2":
			// Add a new animal friend to the ourAnimals array
			string anotherPet = "y";
			int petCount = 0;
			for (int i = 0; i < maxPets; i++)
			{
				if (ourAnimals[i, 0] != "ID #: ")
				{
					petCount += 1;
				}

			}

			if (petCount < maxPets)
			{
				Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
			}
			while (anotherPet == "y" && petCount < maxPets)
			{
				bool validEntry = false;
				// get species (cat or dog) - string animalSpecies is a required field
				do
				{
					Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
					readResult = Console.ReadLine();
					if (readResult != null)
					{
						animalSpecies = readResult.ToLower();
						if (animalSpecies != "dog" && animalSpecies != "cat")
						{
							validEntry = false;
						}
						else
						{
							validEntry = true;
						}
					}
				} while (validEntry == false);

				//build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
				animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

				//get the pets's age. can be ? at initial entry.
				do
				{
					int petAge;
					Console.WriteLine("Enter the pet's age or enter ? if unknown");
					readResult = Console.ReadLine();
					if (readResult != null)
					{
						animalAge = readResult;
						if (animalAge != "?")
						{
							validEntry = int.TryParse(animalAge, out petAge);
						}
						else
						{
							validEntry = true;
						}
					}
				} while (validEntry == false);

				// get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
				do
				{
					Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
					readResult = Console.ReadLine();
					if (readResult != null)
					{
						animalPhysicalDescription = readResult.ToLower();

						if (animalPhysicalDescription == "")
						{
							animalPhysicalDescription = "tbd";

						}
					}
				} while (animalPhysicalDescription == "");

				// get a description of the pet's personality - animalPersonalityDescription can be blank.
				do
				{
					Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
					readResult = Console.ReadLine();

					if (readResult != null)
					{
						animalPersonalityDescription = readResult.ToLower();
						if (animalPersonalityDescription == "")
						{
							animalPersonalityDescription = "tbd";
						}
					}
				} while (animalPersonalityDescription == "");

				// get the pet's nicname. animalNickname can be blank.
				do
				{
					Console.WriteLine("Enter a nickname for the pet");
					readResult = Console.ReadLine();
					if (readResult != null)
					{
						animalNickname = readResult.ToLower();
						if (animalNickname == "")
						{
							animalNickname = "tbd";
						}
					}
				} while (animalNickname == "");
				
				//store the pet information in the ourAnimals array (zero based)
				ourAnimals[petCount, 0] = "ID#: " + animalID;
				ourAnimals[petCount, 1] = "Species: " + animalSpecies;
				ourAnimals[petCount, 2] = "Age: " + animalAge;
				ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
				ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
				ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;



				// increment petCount (the array is zero-based, so we increment the counter after adding to the array)
				petCount = petCount + 1;

				//check maxPet limit
				if (petCount < maxPets)
				{
					//another pet?
					Console.WriteLine("Do you want to enter info for another pet (y/n)?");
					do
					{
						readResult = Console.ReadLine();
						if (readResult != null)
						{
							anotherPet = readResult.ToLower();
						}
					} while (anotherPet != "y" && anotherPet != "n");
				}
			}
			if (petCount >= maxPets)
			{
				Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
				Console.WriteLine("Press the Enter key to continue.");
				readResult = Console.ReadLine();
			}

			break;

		case "3":
			// Ensure animal ages and physical descriptions are complete
			
				
				int currentPets = 0;
			for (int i = 0; i < maxPets; i++)
			{
				if (ourAnimals[i, 0] != "ID #: ")
				{
					currentPets += 1;
				}

			}
			Console.WriteLine("There is currently: "+ currentPets + " pets at the moment");
			Console.WriteLine("Checking if all animals have valid descriptions...");






			for (int i = 0; i < currentPets; i++)
			{
				bool validEntry = false;
				bool validNumeric = false;
				do
				{

					//Checks if animal has a valid numeric Age
					if (ourAnimals[i, 2].Contains("?"))
					{
						int petAge;



						Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}");
						readResult = Console.ReadLine();

						if (readResult != null)
						{
							if (int.TryParse(readResult, out petAge))
							{
								ourAnimals[i, 2] = "Age: " + readResult;
								validNumeric = true;
							}
							else
							{
								validNumeric = false;
							}
						}
					}
					else
					
					{
						validNumeric = true;
					}
				} while (validNumeric == false);

				//Checks if Animal has valid Physical description
				do
				{
					if (ourAnimals[i, 4] == "Physical description: ")
					{
						Console.WriteLine($"Enter a valid physical description for {ourAnimals[i, 0]} (size, Color, breed, gender, weight, housebroken)");
						readResult = Console.ReadLine();
						if (readResult != null)

						{
							ourAnimals[i, 4] = "Physical description: " + readResult;
							Console.WriteLine(ourAnimals[i, 4]);
						}
					}
					else
					{
						validEntry = true;
					}
				} while (validEntry == false);
			}


			Console.WriteLine("All Animals Have Valid Information.");
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;


		case "4":
		
			// Ensure animal nicknames and personality descriptions are complete

			Console.WriteLine("Checking if all Animals have valid nickname and personality descriptions...");

			for (int i = 0; i < petCount; i++)
			{
				bool validEntry = false;

				do//Check if animal has valid Nickname
				{

					if (ourAnimals[i, 3] == "Nickname: ")
					{
						Console.WriteLine($"Enter a nickname for {ourAnimals[i, 0]}");
						readResult = Console.ReadLine();

						if (readResult != null)

						{
							ourAnimals[i, 3] = "Nickname: " + readResult;

						}

					}
					else
					{
						validEntry = true;
					}


				} while (validEntry == false);


				do //Check if animal has valid personality description
				{
					validEntry = false;

					if (ourAnimals[i, 5] == "Personality: ")
					{
						Console.WriteLine($"Enter a Personality description for: {ourAnimals[i, 0]})");
						readResult = Console.ReadLine();

						if (readResult != null)
						{
							ourAnimals[i, 5] = "Personality: " + readResult;

						}



					}
					else
					{
						validEntry = true;
					}
				} while (validEntry == false);
			}



			Console.WriteLine("Nickname and personality description fields are complete for all of our friends. ");
			Console.WriteLine("Press the enter key to continue");
			Console.ReadLine();
			break;


		case "5":
			//Edit an animals age
			Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress");
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;

		case "6":
			//Edit an animals Personalitys description
			Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress");
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;

		case "7":
			//Display all cats with a specified description
			Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress");
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;

		case "8":
			//Display all dogs with a specified description
			Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress");
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;

		default:
			break;
	}

} while (menuSelection != "exit");

#endregion






#region A selection of data types

Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("floating point types:");
Console.WriteLine($"float   : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double  : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision");
Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

#endregion







#region combining string array values as strings and as integers challenge

// My Solution

using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");



string[] values = {"12.3", "45", "ABC", "11", "DEF"};
decimal numbers = 0;
string itsText = "";
decimal itsNumeric = 0;
for (int i = 0; i < values.Length; i++)
{
	if (decimal.TryParse(values[i], out numbers))
	{
		itsNumeric += numbers;
	}
	
	else
	{
		itsText += values[i];
	}
}



Console.WriteLine(itsNumeric);
Console.WriteLine(itsText);


// Microsoft solution


string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
	decimal number; // stores the TryParse "out" value
	if (decimal.TryParse(value, out number))
	{
		total += number;
	} else
	{
		message += value;
	}
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");






#endregion






#region Exercise - Complete a challenge to reverse words in a sentence

// My solution
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;


decimal result11 = 0;


result11 = value1 / value2;

int result1 = Convert.ToInt32(result11);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");


decimal result2 = result11;
Console.WriteLine($"Divide value1 by value2, display the result as a decimal: {result2}");



float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


// oops i mixed the numbers lmao
// result2 is divided wrongly fixed version below


//fixed version
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;


decimal result11 = 0;


result11 = value2 / (decimal)value3;

int result1 = Convert.ToInt32(result11);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");


decimal result2 = result11;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");



float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");







//Microsoft solution

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// Convert.ToInt32() rounds up the way you would expect.
int result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


#endregion





#region Perform operations on arrays using helper methods in C#



// my solution:
//thoughts: i ended up peeking at the solution after i had managed to reverse
//each word but couldn't get further when trying to put them back in an array, i was trying/practicing 
//foreach loops but couldnt get my reversedword put back into a new string array because i had a better understanding of the loop while using for instead.

using System.Runtime.InteropServices;

string pangram = "The quick brown fox jumps over the lazy dog";


string[] pangramWordArray = pangram.Split(" ");

string[] resultMessage = new string[pangramWordArray.Length];

Console.WriteLine(pangramWordArray[0]);
// string[] solutionArray = new string(resultWordString)

for(int i = 0; i < pangramWordArray.Length; i++)
{
	char[] reverseword = pangramWordArray[i].ToCharArray();
	Array.Reverse(reverseword);
	resultMessage[i] = new string(reverseword);
	// Console.WriteLine(resultMessage[i]);
	// Console.WriteLine(reverseword);
}
string reversedWordsNotAll = String.Join(" ", resultMessage);
Console.WriteLine(reversedWordsNotAll);






//microsofts solution:


string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
	char[] letters = message[i].ToCharArray();
	Array.Reverse(letters);
	newMessage[i] = new string(letters);
}

//Step 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result);

#endregion





#region Exercise - Complete a challenge to parse a string of orders, sort the orders and tag possible errors
// my solution

//promise i didnt peak at the solution
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] items = orderStream.Split(",");
Array.Sort(items);

foreach (var item in items)
{
	if(item.Length != 4)
	{
		Console.WriteLine($"{item}\t\t- Error");
	}
	
	else
	Console.WriteLine(item);
}

//microsoft solution

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (var item in items)
{
	if (item.Length == 4)
	{
		Console.WriteLine(item);
	}
	else
	{
		Console.WriteLine(item + "\t- Error");
	}
}


#endregion





#region Exercise - Complete a challenge to apply string interpolation to a form letter

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";

int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:C} shares at a return of {currentReturn:P}\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}");

Console.WriteLine("Here's a quick comparison: \n");
Console.WriteLine($"{currentProduct}\t\t {currentReturn:P2}\t{currentProfit:C}");
Console.WriteLine($"{newProduct}\t\t {newReturn:P2}\t{newProfit:C}");
string comparisonMessage = "";

// my logic here

Console.WriteLine(comparisonMessage);


//microsoft solution

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);



#endregion





#region Exercise - Complete a challenge to extract, replace, and remove data from an input string

//Mine:

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";


string quantity = "";
string output = input;


// quantity counter section

int openingPosition = input.IndexOf("<span>");
openingPosition += 6;

int closingPosition = input.IndexOf("</span>");

int messageLength = closingPosition - openingPosition;
quantity = input.Substring(openingPosition, messageLength);


//Output section
output = input.Replace("&trade;", "&reg;");

int divOne = output.IndexOf("<div>");
int divTwo = output.IndexOf("</div>");
Console.WriteLine(divOne);
Console.WriteLine(divTwo);

output = output.Remove(divTwo, 6);
output = output.Remove(divOne, 5);

for (int i = 0; i < 100; i++)
{
	Console.Write("-");
}
Console.WriteLine("");
Console.WriteLine("Quantity: " + quantity);
Console.WriteLine($"Output: {output}");


//Microsoft solution:

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

// Extract the "quantity"
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
int quantityEnd= input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);

//I spent too long trying to input the length of the <div>'s in  
// somethin like =   output.remove(output.indexof("<div>"),"<div>".length) (not what i actually wrote)
// which may or may not have worked but i ended up going the ease way and doing it the magic way :)))))


#endregion





#region Exercise - Complete the challenge to create a reusable method (fortune teller)

//my solution
// who knew it was this simple. I read this one before going to bed to let it simmer, thinking it would be a sort of big overtaking but no. Sometimes it really is just that simple. :)

Random random = new Random();
int luck = random.Next(100);

string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature" };

FortuneTeller();

void FortuneTeller()
{
	Console.WriteLine("A fortune teller whispers the following words:");
	string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
	for (int i = 0; i < 4; i++)
	{
		Console.Write($"{text[i]} {fortune[i]} ");
	}
}

//Microsofts solution
Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

TellFortune();

void TellFortune() 
{
	Console.WriteLine("A fortune teller whispers the following words:");
	string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
	for (int i = 0; i < 4; i++) 
	{
		Console.Write($"{text[i]} {fortune[i]} ");
	}
}

#endregion





#region Exercise - Complete the challenge to display email addresses

// this is my solution. For once i felt that i have managed to make something that seems to make somewhat sense without
// being a total hackjob. I think this might be my first feeling of solving a problem and damn it feels good!

// here is my solution:

string[,] corporate = 
{
	{"Robert", "Bavin"},
	{"Simon", "Bright"},
	{"Kim", "Sinclair"}, 
	{"Aashrita", "Kamath"},
	{"Sarah", "Delucchi"}, 
	{"Sinan", "Ali"}
};

string[,] external = 
{
	{"Vinnie", "Ashton"}, 
	{"Cody", "Dysart"},
	{"Shay", "Lawrence"}, 
	{"Daren", "Valdes"}
};

/*
TODO Your challenge is to create a method that displays the correct email address for both internal and external employees
*/

string corporateDomain = "contoso.com";
string externalDomain = "hayworth.com";


for (int i = 0; i < corporate.GetLength(0); i++) 
{
	DisplayMail(firstName: corporate[i,0], lastName:corporate[i,1], location: "corporate" );
}

Console.WriteLine();

for (int i = 0; i < external.GetLength(0); i++) 
{
	DisplayMail(external[i,0], external[i,1], "external");
}


void DisplayMail(string firstName, string lastName, string location)
{
	firstName = firstName.Substring(0,2).ToLower();
	lastName = lastName.ToLower();
	string userName = firstName + lastName;
	string domain = (location == "corporate" ) ? corporateDomain : externalDomain;
	string newEmail = userName + "@" + domain;


	
	
	
	Console.WriteLine(newEmail);
	
}


//And heres the Proposed microsoft solution:

string[,] corporate = 
	{
		{"Robert", "Bavin"}, {"Simon", "Bright"},
		{"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
		{"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

	string[,] external = 
	{
		{"Vinnie", "Ashton"}, {"Cody", "Dysart"},
		{"Shay", "Lawrence"}, {"Daren", "Valdes"}
	};

	string externalDomain = "hayworth.com";

	for (int i = 0; i < corporate.GetLength(0); i++) 
	{
		DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
	}

	for (int i = 0; i < external.GetLength(0); i++) 
	{
		DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
	}

	void DisplayEmail(string first, string last, string domain = "contoso.com") 
	{
		string email = first.Substring(0, 2) + last;
		email = email.ToLower();
		Console.WriteLine($"{email}@{domain}");
	}
	
	//I had trouble somewhere midway because of not fully understanding the text, think i also had to add the emails as an array. But that comes later! :)) :celebrateemoji:


#endregion




#region Exercise - Complete the challenge to add methods to make the game playable

// had some trouble with the console output writing some lines twice. Found out that i had put two messages in two methods. Whoopsie, that took a while for nothing lmao.
//Anyways heres my solution
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
	PlayGame();
}

void PlayGame()
{
	var play = true;

	while (play)
	{
		int target = random.Next(1,6);
		int roll = random.Next(1,7);

		Console.WriteLine(WinOrLose(target, roll));
		Console.WriteLine("\nPlay again? (Y/N)");
		play = ShouldPlay();
	}
}

bool ShouldPlay()
{
	while(true)
	{
		string? choice = Console.ReadLine().ToLower();
		if (choice == "y")
		{
			return true;
		}
		else if (choice == "n")
		{
			return false;
		}
		else
		{
			Console.WriteLine("Invalid input please enter Y or N");
		}
	}
}

string WinOrLose(int targetNumber, int rollThrow)
{
	Console.WriteLine($"Roll a number greater than {targetNumber} to win!");
	Console.WriteLine($"You rolled a {rollThrow}");

	return (rollThrow > targetNumber) ? "you win!" : "You Lose!";
	
}

//and heres the one from microsoft:

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
	PlayGame();
}

bool ShouldPlay() 
{
	string response = Console.ReadLine();
	return response.ToLower().Equals("y");
}

void PlayGame() 
{
	var play = true;

	while (play) {
		var target = GetTarget();
		var roll = RollDice();

		Console.WriteLine($"Roll a number greater than {target} to win!");
		Console.WriteLine($"You rolled a {roll}");
		Console.WriteLine(WinOrLose(roll, target));
		Console.WriteLine("\nPlay again? (Y/N)");

		play = ShouldPlay();
	}
}

int GetTarget() 
{
	return random.Next(1, 6);
}

int RollDice() 
{
	return random.Next(1, 7);
}

string WinOrLose(int roll, int target) 
{
	if (roll > target) 
	{
		return "You win!";
	}
	return "You lose!";
}

#endregion




