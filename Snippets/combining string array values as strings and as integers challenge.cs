//combining string array values as strings and as integers challenge

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




