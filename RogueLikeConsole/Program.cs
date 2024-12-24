namespace RogueLikeConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player Health = new Player();
            Health.Health = 100;

            System.Console.WriteLine("type yes");
            if (System.Console.ReadLine() == "yes")
            {
                Health.Health = 50;
            }
            else
            {
                System.Console.WriteLine("You didn't type yes");
            }


        }
    }
}
