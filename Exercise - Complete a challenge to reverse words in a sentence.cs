//Exercise - Complete a challenge to reverse words in a sentence

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

