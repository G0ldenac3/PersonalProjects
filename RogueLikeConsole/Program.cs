using System;
using System.ComponentModel.DataAnnotations;

namespace RogueLikeConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Enemy creation

            Enemy slimeStarter = new Enemy(30, 5);
            Enemy Skeleton = new Enemy(50, 10);

            //Random generators

            Random BasicChest = new Random();

            //Variables

            string actionInput;
            int action;
            int BasicChestLoot = BasicChest.Next(1, 5);
            string UserYN;
           

            //Creating a player with 100 health + other player stats


            Player player = new Player(100, 0);
            int Flasks = 0;
            int HealthGain = 20;

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
            Console.WriteLine();

            Thread.Sleep(1000);

            



            //loop for fighting

            while (true)
            {
                Console.WriteLine("What is your action?");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Heal");
                actionInput = Console.ReadLine();

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
                            Thread.Sleep(1000);
                            if (slimeStarter.IsDead())
                            {
                                break;
                            }
                            else;
                            {
                                Console.WriteLine();
                                Console.WriteLine("The slime attacks you!");
                                slimeStarter.Attack(player);
                                player.DisplayHealth();
                                break;
                            }


                        case 2:
                            if (Flasks > 0)
                            {
                                Console.WriteLine("You drink a flask of health!");
                                Console.WriteLine();
                                Thread.Sleep(1000);
                                player.Heal(HealthGain);
                                player.DisplayHealth();
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                Console.WriteLine("The slime attacks you!");
                                slimeStarter.Attack(player);
                                player.DisplayHealth();
                                Flasks--;
                            }
                            else
                            {
                                Console.WriteLine("You have no flasks left!");
                                Console.WriteLine();
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid input, please select 1 or 2.");
                            Console.WriteLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, either you are annoying as shit, or you dont know what a number is");
                    Console.WriteLine();
                }
                if (slimeStarter.IsDead())
                {
                    break;
                }


            }
            
            //Reseting slime after fight

            slimeStarter.Reset();

           
            //starting rewards

            Console.WriteLine();
            Console.WriteLine("The slime has been slain you won!");
            Thread.Sleep(1000);
            Console.WriteLine("You gained 5 Healhtpotions!");
            Flasks = Flasks + 5;
            Console.WriteLine("....");
            Console.WriteLine("....");
            Thread.Sleep(1000);

            //First hallway
            while (true) 
            {

                Console.WriteLine("As you finally enter the dungeon you come across two paths");
                Thread.Sleep(500);
                Console.WriteLine("Which path will you take?");
                Console.WriteLine("1. Left");
                Console.WriteLine("2. right ");
                actionInput = Console.ReadLine();

                if (int.TryParse(actionInput, out action))
                {
                    switch (action)
                    {
                        //LEFT PATH

                        case 1:
                            while (true)
                            {
                                Console.WriteLine("You take the left path");
                                Thread.Sleep(1000);
                                Console.WriteLine("After walking a while you notice a room next to the pathway, in the middle of that room there stands a chest.");
                                Thread.Sleep(1000);
                                Console.WriteLine("Do you want to open the chest? Y/N");
                                UserYN = Console.ReadLine().ToUpper();
                                switch (UserYN)
                                {
                                    case "Y":
                                        //CHEST LOOP

                                        if (BasicChestLoot == 1)
                                        {
                                            Console.WriteLine("You Found a better weapon!");
                                            player.AddDamage(5);
                                            Console.WriteLine("Your damage is now: " + player.GetDamage());
                                        }
                                        else if (BasicChestLoot == 2)
                                        {
                                            Console.WriteLine("You Found a better healthpotion!");
                                            HealthGain = HealthGain + 10;
                                        }
                                        else if (BasicChestLoot == 3)
                                        {
                                            Console.WriteLine("The chest was trapped!");
                                            player.TakeDamage(5);
                                            player.DisplayHealth();
                                        }
                                        else if (BasicChestLoot == 4)
                                        {
                                            Console.WriteLine("The chest was empty.");
                                            
                                        }
                                        else if (BasicChestLoot == 5)
                                        {
                                            Console.WriteLine("The chest was empty.");
                                        }

                                        break;
                                        //CHEST LOOP END

                                    case "N":
                                        Console.WriteLine("You decide to leave the chest alone.");
                                        break;
                                    default:
                                        Console.WriteLine("Invalid input, please enter Y or N.");
                                        continue;
                                }
                                break;
                                
                            }
                            break;

                        //RIGHT PATH

                        case 2:
                            Console.WriteLine("You take the right path.");
                            Thread.Sleep(1000);
                            Console.WriteLine();


                            //ENEMY ENCOUNTER LOOP
                            while (true)
                            {
                                Console.WriteLine("You encounter an enemy skeleton");
                            }
                            break;

                        default:
                                Console.WriteLine("Invalid input, please select 1 or 2.");
                         continue;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, either you are annoying as shit, or you don't know what a number is");
                    Console.WriteLine();
                }
            }

            //END OF HALLWAY LOOP

            Console.WriteLine("END LOOP");

        }
    }
}
