#Perform operations on arrays using helper methods in C#



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

