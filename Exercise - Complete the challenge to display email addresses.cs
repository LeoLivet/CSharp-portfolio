//Exercise - Complete the challenge to display email addresses

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

