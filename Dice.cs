namespace DiceRollGame
{
    public class Dice
    {
        private readonly Random _random;
        private const int SidesCount = 6;

        public int GeneratedNumber { get => _random.Next(1, SidesCount + 1); }

        public Dice(Random random, int sidesCount)
        {
            _random = random;
        }
    }
}
