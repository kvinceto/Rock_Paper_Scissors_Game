using System;

namespace Rock_Paper_Scissors_Game
{
    internal class Program
    {

        static void Main(string[] args)
        {
            const string ROCK = "Rock";
            const string PAPER = "Paper";
            const string SCISSORS = "Scissors";

            Console.Title = "Rock - Paper - Scissors";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Make a move ('r' or 'rock'; 'p' or 'paper'; 's' or 'scissors'):");

            string playerMove = Console.ReadLine().ToLower();
            Random random = new Random();
            
            while (playerMove != "end")
            {
                int computerMove = random.Next(1, 4);
                string computerMoveToBePlayed = String.Empty;

                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = ROCK;
                    Console.WriteLine($"Your move: {ROCK}");
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = PAPER;
                    Console.WriteLine($"Your move: {PAPER}");
                }
                else if (playerMove == "s" || playerMove == "scissors")
                {
                    playerMove = SCISSORS;
                    Console.WriteLine($"Your move: {SCISSORS}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine("Valid inputs are: 'r' or 'rock'; 'p' or 'paper'; 's' or 'scissors'; or 'end' to end the game.");
                    playerMove = Console.ReadLine().ToLower();
                    continue;
                }

                if (computerMove == 1)
                {
                    computerMoveToBePlayed = ROCK;
                    Console.WriteLine($"Computer move: {ROCK}");
                }
                else if (computerMove == 2)
                {
                    computerMoveToBePlayed = PAPER;
                    Console.WriteLine($"Computer move: {PAPER}");
                }
                else if(computerMove == 3)
                {
                    computerMoveToBePlayed = SCISSORS;
                    Console.WriteLine($"Computer move: {SCISSORS}");
                }

                if ((playerMove == ROCK && computerMoveToBePlayed == SCISSORS) ||
                    (playerMove == PAPER && computerMoveToBePlayed == ROCK) ||
                    (playerMove == SCISSORS && computerMoveToBePlayed == PAPER))
                {
                    Console.WriteLine("You win!!!");
                    Console.WriteLine("Play one more time or enter 'end' to end the game:");
                }
                else if((playerMove == ROCK && computerMoveToBePlayed == PAPER) ||
                        (playerMove == PAPER && computerMoveToBePlayed == SCISSORS) ||
                        (playerMove == SCISSORS && computerMoveToBePlayed == ROCK))
                {
                    Console.WriteLine("You lost.");
                    Console.WriteLine("Play one more time or enter 'end' to end the game:");
                }
                else
                {
                    Console.WriteLine("It's a draw.");
                    Console.WriteLine("Play one more time or enter 'end' to end the game:");
                }


                playerMove = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Thank you for playing! See you next time!");
        }
    }
}
