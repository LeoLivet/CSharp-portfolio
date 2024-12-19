//Code Project 3 - Write code that processes the contents of a string array

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