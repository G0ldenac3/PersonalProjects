using System;
using System.ComponentModel.DataAnnotations;

namespace RogueLikeConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating a player with 100 health + other player stats


            Player player = new Player(100, 0);
            int Flasks = 0;

            //Start Menu

            Console.WriteLine("Welcome to the game!");
            Console.WriteLine("This a fun little project i am making!, The game is roguelike without safe points.");
            Console.WriteLine("You will have to survive as long as you can, Good luck!");
            Thread.Sleep(500);
            Console.WriteLine("....");
            Thread.Sleep(1000);
            Console.WriteLine("Please choose your difficulty: This will effect your starting health and damage.");
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
                player.SetDamage(25);
                Console.WriteLine("Damage is set to: " + player.GetDamage());
            }
            else if (difficultyInt == 2)
            {
                player.TakeDamage(50);
                player.SetDamage(20);
                player.DisplayHealth();
                Console.WriteLine("Damage is set to: " + player.GetDamage());
            }
            else if (difficultyInt == 3)
            {
                player.TakeDamage(75);
                player.SetDamage(10);
                player.DisplayHealth();
                Console.WriteLine("Damage is set to: " + player.GetDamage());
            }
            else
            {
                Console.WriteLine("Invalid input, Default option is easy.");
            }

            //First Encounter

            Console.WriteLine("....");
            Thread.Sleep(1000);
            Console.WriteLine("....");
            Thread.Sleep(1000);
            Console.WriteLine("....");
            Thread.Sleep(1000);
            Console.WriteLine("The heavy iron door groans as you push against it, revealing a slimy, green figure.");
            Thread.Sleep(1000);
            Console.WriteLine("The figure turns around it is a slime protecting the enterance to the dungeon.");

            Thread.Sleep(1000);

            Enemy slimeStarter = new Enemy(30, 5);



            //loop for fighting

            while (true)
            {
                Console.WriteLine("What is your action?");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Heal");
                string actionInput = Console.ReadLine();
                int action;
                if (int.TryParse(actionInput, out action))
                {
                    switch (action)
                    {
                        case 1:
                            Console.WriteLine("You swing at the enemy!");
                            Console.WriteLine();
                            slimeStarter.TakeDamage(player.GetDamage());
                            Thread.Sleep(1000);
                            Console.WriteLine("The slime takes damage!");
                            slimeStarter.DisplayHealth();
                            break;

                        case 2:
                            if (Flasks > 0)
                            {
                                Console.WriteLine("You drink a flask of health!");
                                Console.WriteLine();
                                Thread.Sleep(1000);
                                player.Heal(20);
                                player.DisplayHealth();
                                Flasks--;
                            }
                            else
                            {
                                Console.WriteLine("You have no flasks left!");
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid input, please select 1 or 2.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, either you are annoying as shit, or you dont know what a number is");
                }
                if (slimeStarter.IsDead())
                {
                    break;
                }

                Console.WriteLine("you won");
            }
            Console.WriteLine("you won");
        }   
    }
}
