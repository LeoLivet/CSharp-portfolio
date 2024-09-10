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
