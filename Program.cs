

namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerPosition = 0;
            int diceRolls = 0;
            Random random = new Random();
            while (playerPosition != 100)
            {
                int diceNumber = random.Next(1, 7);
                diceRolls++;
                Console.WriteLine("Dice rolled: " + diceNumber);
                int option = random.Next(0, 3);
                switch (option)
                {
                    case 0:
                        Console.WriteLine("No Play. Stay in the same position.");
                        break;
                    case 1:
                        Console.WriteLine("Ladder! Move ahead by " + diceNumber + " positions.");
                        Console.WriteLine("Moves ahead by " + diceNumber + " positions.");
                        playerPosition += diceNumber;
                        break;
                    case 2:
                        Console.WriteLine("Snake! Move back by " + diceNumber + " positions.");
                        Console.WriteLine("Moves behind by " + diceNumber + " positions.");
                        playerPosition -= diceNumber;
                        break;
                }
                Console.WriteLine("Current position: " + playerPosition);
                Console.WriteLine();
            }

            Console.WriteLine(" You won the game.");
            Console.WriteLine("Total dice rolls: " + diceRolls);
            Console.ReadLine();

        }
    }
}