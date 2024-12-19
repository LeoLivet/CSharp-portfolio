// Challenge project - Create a Minigame

// this was quite fun. I feel i still want to give myself a lot of scope creep which ended up making some spaghetti code but alas except for the bug with the speed bonus(i think one solution would be to move the player 3x1 times instead of 3 tiles at once)

using System;
#region variables
Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;

// Console position of the player
int playerX = 0;
int playerY = 0;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = { "('-')", "(^-^)", "(X_X)" };
string[] foods = { "@@@@@", "$$$$$", "#####" };

// Current player string displayed in the Console
string player = states[0];

// Index of the current food
int food = 0;
#endregion

#region start game

InitializeGame();
while (!shouldExit)
{
	PlayerAteFood();
	if (PlayerStatus() == 3)
	{
		FreezePlayer();
	}
	Move(wasdEnabled: true, otherKeys: false, moveSpeed: PlayerStatus(), enableSpeed: true);
	if (TerminalResized())
	{
		Console.Clear();
		Console.WriteLine("Terminal resized. Exiting program");
		shouldExit = TerminalResized();
	}

}

#endregion

// Returns true if the Terminal was resized 
bool TerminalResized()
{
	return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

// Displays random food at a random location
void ShowFood()
{
	// Update food to a random index
	food = random.Next(0, foods.Length);

	// Update food position to a random location
	foodX = random.Next(0, width - player.Length);
	foodY = random.Next(0, height - 1);

	// Display the food at the location
	Console.SetCursorPosition(foodX, foodY);
	Console.Write(foods[food]);
}

// Changes the player to match the food consumed
void ChangePlayer()
{
	player = states[food];
	Console.SetCursorPosition(playerX, playerY);
	Console.Write(player);
}


// Checks if player ate food

bool PlayerAteFood()
{
	// if ate food(player xy position == food position{ player = states[1]}
	
	//TODO Change this to check if characters are gone from screen. Currently game does not work properly if speed bonus is applied and player Coords isnt 100% on top of food
	if ((playerX == foodX) && (playerY == foodY))
	{
		ChangePlayer();
		ShowFood();
		return true;
	}
	else
	{
		return false;
	}
}

// Temporarily stops the player from moving
void FreezePlayer()
{
	System.Threading.Thread.Sleep(1000);
	player = states[0];
}

// Checks current status of food eaten
int PlayerStatus()
{
	if (player == states[1]) // happy ^_^
	{
		return 2;
	}
	else if (player == states[2]) // poisoned X_X
	{
		return 3;
	}
	else // Default '-'
	{
		return 1;
	}
}

// Reads directional input from the Console and moves the player
void Move(bool wasdEnabled = true, bool otherKeys = false, int moveSpeed = 1, bool enableSpeed = false)
{
	enableSpeed = false;
	int speedModifier = moveSpeed;
	
	int lastX = playerX;
	int lastY = playerY;
	

	if (moveSpeed == 2 && enableSpeed == true)
	{
		speedModifier = 3;
	}
	else
	{
		speedModifier = 1;
	}
	
	if (wasdEnabled)
	{
		switch (Console.ReadKey(true).Key)
		{
			case ConsoleKey.UpArrow or ConsoleKey.W:
				playerY--;
				break;
			case ConsoleKey.DownArrow or ConsoleKey.S:
				playerY++;
				break;
			case ConsoleKey.LeftArrow or ConsoleKey.A:
				playerX -= speedModifier;
				break;
			case ConsoleKey.RightArrow or ConsoleKey.D:
				playerX += speedModifier;
				break;
			case ConsoleKey.Escape:
				shouldExit = true;
				break;
			default:
				if (!otherKeys)
				{
					Console.WriteLine("\tUse only the directional keys or WASD");
					shouldExit = true;
				}
				break;
		}
	}
	else
	{

		switch (Console.ReadKey(true).Key)
		{
			case ConsoleKey.UpArrow:
				playerY --;
				break;
			case ConsoleKey.DownArrow:
				playerY++;
				break;
			case ConsoleKey.LeftArrow:
				playerX -= speedModifier;
				break;
			case ConsoleKey.RightArrow:
				playerX += speedModifier;
				break;
			case ConsoleKey.Escape:
				shouldExit = true;
				break;
			default:
				if (!otherKeys)
				{
					Console.WriteLine("\tUse only the directional keys!");
					shouldExit = true;
				}
				break;
		}
	}


	// Clear the characters at the previous position
	Console.SetCursorPosition(lastX, lastY);
	for (int i = 0; i < player.Length; i++)
	{
		Console.Write(" ");
	}

	// Keep player position within the bounds of the Terminal window
	playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
	playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

	// Draw the player at the new location
	Console.SetCursorPosition(playerX, playerY);
	Console.Write(player);
}

// Clears the console, displays the food and player
void InitializeGame()
{
	Console.Clear();
	ShowFood();
	Console.SetCursorPosition(0, 0);
	Console.Write(player);
}

// as always heres the microsoft solution:

using System;

Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;

// Console position of the player
int playerX = 0;
int playerY = 0;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = {"('-')", "(^-^)", "(X_X)"};
string[] foods = {"@@@@@", "$$$$$", "#####"};

// Current player string displayed in the Console
string player = states[0];

// Index of the current food
int food = 0;

InitializeGame();
while (!shouldExit) 
{
	if (TerminalResized()) 
	{
		Console.Clear();
		Console.Write("Console was resized. Program exiting.");
		shouldExit = true;
	} 
	else 
	{
		if (PlayerIsFaster()) 
		{
			Move(1, false);
		} 
		else if (PlayerIsSick()) 
		{
			FreezePlayer();
		} else 
		{
			Move(otherKeysExit: false);
		}
		if (GotFood())
		{
			ChangePlayer();
			ShowFood();
		}
	}
}

// Returns true if the Terminal was resized 
bool TerminalResized() 
{
	return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

// Displays random food at a random location
void ShowFood() 
{
	// Update food to a random index
	food = random.Next(0, foods.Length);

	// Update food position to a random location
	foodX = random.Next(0, width - player.Length);
	foodY = random.Next(0, height - 1);

	// Display the food at the location
	Console.SetCursorPosition(foodX, foodY);
	Console.Write(foods[food]);
}

// Returns true if the player location matches the food location
bool GotFood() 
{
	return playerY == foodY && playerX == foodX;
}

// Returns true if the player appearance represents a sick state
bool PlayerIsSick() 
{
	return player.Equals(states[2]);
}

// Returns true if the player appearance represents a fast state
bool PlayerIsFaster() 
{
	return player.Equals(states[1]);
}

// Changes the player to match the food consumed
void ChangePlayer() 
{
	player = states[food];
	Console.SetCursorPosition(playerX, playerY);
	Console.Write(player);
}

// Temporarily stops the player from moving
void FreezePlayer() 
{
	System.Threading.Thread.Sleep(1000);
	player = states[0];
}

// Reads directional input from the Console and moves the player
void Move(int speed = 1, bool otherKeysExit = false) 
{
	int lastX = playerX;
	int lastY = playerY;
	
	switch (Console.ReadKey(true).Key) {
		case ConsoleKey.UpArrow:
			playerY--; 
			break;
		case ConsoleKey.DownArrow: 
			playerY++; 
			break;
		case ConsoleKey.LeftArrow:  
			playerX -= speed; 
			break;
		case ConsoleKey.RightArrow: 
			playerX += speed; 
			break;
		case ConsoleKey.Escape:     
			shouldExit = true; 
			break;
		default:
			// Exit if any other keys are pressed
			shouldExit = otherKeysExit;
			break;
	}

	// Clear the characters at the previous position
	Console.SetCursorPosition(lastX, lastY);
	for (int i = 0; i < player.Length; i++) 
	{
		Console.Write(" ");
	}

	// Keep player position within the bounds of the Terminal window
	playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
	playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

	// Draw the player at the new location
	Console.SetCursorPosition(playerX, playerY);
	Console.Write(player);
}

// Clears the console, displays the food and player
void InitializeGame() 
{
	Console.Clear();
	ShowFood();
	Console.SetCursorPosition(0, 0);
	Console.Write(player);
}





