using System.ComponentModel.Design;
using System.Reflection.Metadata;
using Microsoft.Win32.SafeHandles;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Give the Player a choice

            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("Please choose one by typing the following numbers:");
            Console.WriteLine("(1) Rock");
            Console.WriteLine("(2) Paper");
            Console.WriteLine("(3) Scissors");
            Console.Write("What is your choice?  ");
            //Get player response

            string UserChoice = Console.ReadLine();
            int UserChoiceNumber = Convert.ToInt32(UserChoice);

            //Validate Player Choice

            if (UserChoiceNumber == 1)
            {
                Console.WriteLine("You chose Rock"); 
            }
            else if (UserChoiceNumber == 2)
            {
                Console.WriteLine("You chose Paper");
            }
            else if (UserChoiceNumber == 3)
            {
                Console.WriteLine("You chose Scissors");
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }


            //Generate Answer

            Random rnd = new Random();
            int ComputerChoiceNumber = rnd.Next(1, 4);

            if (ComputerChoiceNumber == 1)
            {
                Console.WriteLine("Computer chose Rock");
            }
            else if (ComputerChoiceNumber == 2)
            {
                Console.WriteLine("Computer chose Paper");
            }
            else if (ComputerChoiceNumber == 3)
            {
                Console.WriteLine("Computer chose Scissors");
            }

            // Determine Winner

            if ((ComputerChoiceNumber == 1) && (UserChoiceNumber == 2))
            { 
             Console.WriteLine("You Win!"); 
            }
            else if ((ComputerChoiceNumber == 2) && (UserChoiceNumber == 3))
            {
                Console.WriteLine("You Win!");
            }
            else if ((ComputerChoiceNumber == 3) && (UserChoiceNumber == 1))
            {
                Console.WriteLine("You Win!");
            }
            else if ((ComputerChoiceNumber == 1) && (UserChoiceNumber == 3))
            {
                Console.WriteLine("You Lose!");
            }
            else if ((ComputerChoiceNumber == 2) && (UserChoiceNumber == 1))
            {
                Console.WriteLine("You Lose!");
            }
            else if ((ComputerChoiceNumber == 3) && (UserChoiceNumber == 2))
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.WriteLine("It's a Tie!");
            }

            //Rematch

            Console.WriteLine("Would you like to play again? (y/n)");
            string rematch = Console.ReadLine();
            if (rematch == "y")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
            }

        }
    }
}
