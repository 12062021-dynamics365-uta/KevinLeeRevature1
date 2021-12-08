using System;

namespace Rock_Paper_Scissors_Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
			//get input form the user
			Console.WriteLine("Hello. Welcome to Rock-Paper-Scissors Game!");
			Console.WriteLine("Please enter number 1 for ROCK, 2 for PAPER, 3 for SCISSORS");

			int computerChoice;
			int tie = 0;
			int playerPoints = 0;
			int computerPoints = 0;

			while(playerPoints < 2 && computerPoints < 2) 
			{
				int playerChoice = -1;
				bool conversionBool = false;

				do
				{
					string userInput = Console.ReadLine();
					conversionBool = Int32.TryParse(userInput, out playerChoice);
					if (!conversionBool || playerChoice < 1 || playerChoice > 3)
					{
						Console.Write("Invalid input! Please enter 1 through 3.");
					}

				} while (!(playerChoice > 0 && playerChoice < 4));

				computerChoice = new Random().Next(1, 4);

				switch (playerChoice)
				{
					case 1:
						Console.WriteLine("You choose ROCK");
						if (computerChoice == 1)
						{
							Console.WriteLine("It is a tie");
							tie++;
						}

						else if (computerChoice == 2)
						{
							Console.WriteLine("Computer Wins");
							computerPoints++;
						}

						else if (computerChoice == 3)
						{
							Console.WriteLine("Player Wins");
							playerPoints++;
						}
						break;


					case 2:
						Console.WriteLine("You choose Paper");
						if (computerChoice == 1)
						{
							Console.WriteLine("Player Wins");
							playerPoints++;
						}

						else if (computerChoice == 2)
						{
							Console.WriteLine("It is a tie");
							tie++;
						}

						else if (computerChoice == 3)
						{
							Console.WriteLine("Computer Wins");
							computerPoints++;
						}
						break;

					case 3:
						Console.WriteLine("You choose Scissors");
						if (computerChoice == 1)
						{
							Console.WriteLine("Computer Wins");
							computerPoints++;
						}

						else if (computerChoice == 2)
						{
							Console.WriteLine("Player Wins");
							playerPoints++;
						}

						else if (computerChoice == 3)
						{
							Console.WriteLine("It is a tie");
							tie++;
						}
						break;
				}
			}
			
			if (playerPoints == 2)
				Console.WriteLine("\nYou Won!");

			else
				Console.WriteLine("\nYou Lost!");
			Console.Write($"\nPlayer Score: {playerPoints}\nComputer Score: {computerPoints}\nTied games: {tie}");


			/**homework - 
			 * 1. get a random number for the computer
			 * 2. compare who won the round
			 * 3. refactor the code to have a best of three game
			 * 4. print out the winner, and how many games were won by each (and ties)
			 * 5. and exit the program.
			**/

		}
	}
}
