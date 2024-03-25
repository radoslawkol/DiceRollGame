using DiceRollGame.Game;

namespace DiceRollGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello in Dice Roll Game!");
            Console.WriteLine("Try to guess what number 1-6 was generated. You have three chances.");

            Random random = new Random();
            Dice dice = new Dice(random);

            GuessingGame guessingGame = new GuessingGame(dice);

            GameResult gameResult = guessingGame.Play();
            GuessingGame.PrintResult(gameResult);

            Console.ReadKey();

        }
    }
}
