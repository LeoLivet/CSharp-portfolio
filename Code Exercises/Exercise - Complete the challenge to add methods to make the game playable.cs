Exercise - Complete the challenge to add methods to make the game playable

// had some trouble with the console output writing some lines twice. Found out that i had put two messages in two methods. Whoopsie, that took a while for nothing lmao.
//Anyways heres my solution
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
	PlayGame();
}

void PlayGame()
{
	var play = true;

	while (play)
	{
		int target = random.Next(1,6);
		int roll = random.Next(1,7);

		Console.WriteLine(WinOrLose(target, roll));
		Console.WriteLine("\nPlay again? (Y/N)");
		play = ShouldPlay();
	}
}

bool ShouldPlay()
{
	while(true)
	{
		string? choice = Console.ReadLine().ToLower();
		if (choice == "y")
		{
			return true;
		}
		else if (choice == "n")
		{
			return false;
		}
		else
		{
			Console.WriteLine("Invalid input please enter Y or N");
		}
	}
}

string WinOrLose(int targetNumber, int rollThrow)
{
	Console.WriteLine($"Roll a number greater than {targetNumber} to win!");
	Console.WriteLine($"You rolled a {rollThrow}");

	return (rollThrow > targetNumber) ? "you win!" : "You Lose!";
	
}

//and heres the one from microsoft:

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
	PlayGame();
}

bool ShouldPlay() 
{
	string response = Console.ReadLine();
	return response.ToLower().Equals("y");
}

void PlayGame() 
{
	var play = true;

	while (play) {
		var target = GetTarget();
		var roll = RollDice();

		Console.WriteLine($"Roll a number greater than {target} to win!");
		Console.WriteLine($"You rolled a {roll}");
		Console.WriteLine(WinOrLose(roll, target));
		Console.WriteLine("\nPlay again? (Y/N)");

		play = ShouldPlay();
	}
}

int GetTarget() 
{
	return random.Next(1, 6);
}

int RollDice() 
{
	return random.Next(1, 7);
}

string WinOrLose(int roll, int target) 
{
	if (roll > target) 
	{
		return "You win!";
	}
	return "You lose!";
}