using System;

namespace TicTakBeta
{
    class Tictak
    {
        static void Main()
        {
            string[] choices = {"rock", "paper", "scissor" };
            Random random = new Random();
            bool game = true;

            while (game) 
            {
                Console.WriteLine("Choise: paper-rock-scissor");
                string player = Console.ReadLine().ToLower();
                string PC = choices[random.Next(choices.Length)];

                Console.WriteLine($"PC choice: {PC}");

                if (PC == player) 
                {
                    Console.WriteLine("-Tie!-");
                }

                else if ((player == "paper" && PC == "rock") ||
                    (player == "rock" && PC == "scissor") ||
                    (player == "scissor" && PC == "paper"))
                {
                    Console.WriteLine("-You win!-");
                } else
                {
                    Console.WriteLine("-You Lose!-");
                }

                Console.WriteLine("Play again? y/n");
                game = Console.ReadLine().ToLower() == "y";
            }
        }
    }
}