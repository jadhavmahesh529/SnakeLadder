
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
                { }
                playerPosition -= diceNumber;
            
                break;

            }
            if (playerPosition < 0)
            {
                playerPosition = 0;
            }
        }

          
                     
        
    }
}
