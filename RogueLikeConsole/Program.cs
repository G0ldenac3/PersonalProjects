using System.ComponentModel.DataAnnotations;

namespace RogueLikeConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating a player with 100 health + other player stats


            Player player = new Player(100);

            //Start Menu

            Console.WriteLine("Welcome to the game!");
            Console.WriteLine("This a fun little project i am making!, The game is roguelike without safe points");
            Console.WriteLine("You will have to survive as long as you can, Good luck!");
            Thread.Sleep(500);
            Console.WriteLine("....");
            Thread.Sleep(1000);
            Console.WriteLine("Please choose your difficulty: This will effect your starting health");
            Thread.Sleep(1000);
            Console.WriteLine("1. Easy");
            Thread.Sleep(1000);
            Console.WriteLine("2. Normal");
            Thread.Sleep(1000);
            Console.WriteLine("3. Hard");
            string difficulty = Console.ReadLine();
            int difficultyInt = Convert.ToInt32(difficulty);

            //Difficulty settings

            if (difficultyInt == 1)
            {
                player.DisplayHealth();
            }
            else if (difficultyInt == 2)
            {
                player.TakeDamage(50);  
                player.DisplayHealth();
            }
            else if (difficultyInt == 3)
            {
                player.TakeDamage(75);
                player.DisplayHealth();
            }
            else
            {
                Console.WriteLine("Invalid input, Default option is easy");
            }


        }
    }
}
