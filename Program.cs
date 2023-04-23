using System;


namespace Project_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            var player = Player.GetInstance();
            while (player.IsAlive())
            {
                Console.WriteLine("Welcome to Faster Than Light");
                Map.mapDisplay();
                Combat.CombatSystem(player);
                Console.WriteLine();
            }
            Console.Write("Game Over");

        }
    }
}