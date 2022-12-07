using System;

namespace RockPaperScisors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            bool rematch = true;
            double win = 0;
            double lose = 0;
            double draw = 0;
            

            while (rematch)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Choose [r]ock, [p]aper, [s]cissors: ");
                string input = Console.ReadLine().ToLower();

                Random compRandom = new Random();
                int compChoice = compRandom.Next(1, 4);

                while (true)
                {
                    if (input == "r" || input == "rock"
                        || input == "p" || input == "paper"
                        || input == "s" || input == "scissors")
                    {
                        break;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Try again...");
                    input = Console.ReadLine();
                }

                if (input == "r" || input == "rock" )
                {
                    input = Rock;
                }
                else if (input == "p" || input == "paper" )
                {
                    input = Paper;
                }
                else if (input == "s" || input == "scissors" )
                {
                    input = Scissors;
                }
                

                string compMove = string.Empty;

                switch (compChoice)
                {
                    case 1:
                        compMove = Rock;
                        break;
                    case 2:
                        compMove = Paper;
                        break;
                    case 3:
                        compMove = Scissors;
                        break;

                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"The computer chose: {compMove}");

                if ((input == Rock && compMove == Scissors) || (input == Scissors && compMove == Paper)
                    || (input == Paper && compMove == Rock))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win.");
                    win++;
                }
                else if ((input == Rock && compMove == Paper) || (input == Scissors && compMove == Rock)
                    || (input == Paper && compMove == Scissors))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose.");
                    lose++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("This game was draw.");
                    draw++;
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Do you wanna play again?");
                Console.Write("[y]es or [n]o: ");

                string rematching = Console.ReadLine().ToLower();
                
                while (true)
                {
                    if (rematching == "y" || rematching == "yes" || rematching == "n" || rematching == "no")
                    {
                        break;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Try again...");
                    rematching = Console.ReadLine();
                }

                if (rematching == "y" || rematching == "yes")
                {
                    continue;
                }
                else if (rematching == "n" || rematching == "no")
                {
                    rematch = false;
                }
                

            }
            Console.ForegroundColor = ConsoleColor.White;
            double totalGames = win + lose + draw;
            Console.WriteLine($"Total games played: {totalGames}");
            Console.WriteLine($"You won {win} games, with rate of {win / totalGames * 100:f2}%");
            Console.WriteLine($"You lost {lose} games, with rate of {lose / totalGames * 100:f2}%");
            Console.WriteLine($"Games that was draw {draw}, with rate of {draw / totalGames * 100:f2}%");

            

        }
    }
}
