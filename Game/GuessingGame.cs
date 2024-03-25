using DiceRollGame.UserCommunication;

namespace DiceRollGame.Game
{
    public class GuessingGame
    {
        private readonly Dice _dice;
        private const int initialTries = 3;

        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }

        public GameResult Play()
        {
            var diceRollResult = _dice.Roll();
            Console.WriteLine("Diced Rolled. Try to guess a number.");

            int triesLeft = initialTries;

            while (triesLeft > 0)
            {
                int gusessedNumber = ConsoleReader.ReadInteger("Enter a number: ");

                if (gusessedNumber == diceRollResult)
                {
                    return GameResult.Victory;
                }
                Console.WriteLine("Wrong number.");


                --triesLeft;
                Console.WriteLine($"{triesLeft} tries left");
            }
            return GameResult.Loss;
        }

        public static void PrintResult(GameResult gameResult)
        {
            string message = gameResult == GameResult.Victory
                 ? "You won!"
                 : "You lost!";
            Console.WriteLine(message);
        }

    }
}
