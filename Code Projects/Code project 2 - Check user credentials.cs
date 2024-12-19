//                                                          Code project 2 - Check user credentials
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
Code project 2 - Check user credentials
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
