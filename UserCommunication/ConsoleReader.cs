namespace DiceRollGame.UserCommunication
{
    public static class ConsoleReader
    {
        public static int ReadInteger(string message)
        {
            int guessedNumber;
            do
            {
                Console.WriteLine(message);

            } while (!int.TryParse(Console.ReadLine(), out guessedNumber));
            return guessedNumber;
        }
    }
}
