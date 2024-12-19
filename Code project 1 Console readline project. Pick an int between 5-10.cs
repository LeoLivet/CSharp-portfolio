// Code project 1 Console readline project. Pick an int between 5-10

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

