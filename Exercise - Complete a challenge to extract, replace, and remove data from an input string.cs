//Exercise - Complete a challenge to extract, replace, and remove data from an input string


//I spent too long trying to input the length of the <div>'s in  
// somethin like =   output.remove(output.indexof("<div>"),"<div>".length) (not what i actually wrote)
// which may or may not have worked but i ended up going the ease way and doing it the magic way :)))))


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
