// User permission (self guided)



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
