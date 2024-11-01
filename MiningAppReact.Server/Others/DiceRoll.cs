namespace MiningAppReact.Server.Others {
    public class DiceRoll {
        public List<int> Dice { get; }
        public List<int> Modifiers { get; }
        private Random _random { get; }

        public DiceRoll() : this([], []) { }

        public DiceRoll(List<int> dice, List<int> modifiers)
        {
            Dice = dice;
            Modifiers = modifiers;
            _random = Random.Shared;
        }

        public int Roll
            => Dice.Select(die => _random.Next(die) + 1).Sum() + Modifiers.Sum();

        public decimal Average
            => (decimal)(Dice.Average() + Modifiers.Average());

        public static DiceRoll operator +(DiceRoll a, DiceRoll b)
            => new([.. a.Dice, .. b.Dice], [.. a.Modifiers, .. b.Modifiers]);

        public static DiceRoll operator *(DiceRoll diceRoll, int factor)
            => new([.. Enumerable.Range(0, factor).SelectMany(_ => diceRoll.Dice)], [diceRoll.Modifiers.Sum() * factor]);
    }
}
