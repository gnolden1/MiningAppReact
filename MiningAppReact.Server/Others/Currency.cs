namespace MiningAppReact.Server.Others {
    public class Currency {
        private int _copper { get; set; }
        public int Copper => _copper;

        public Currency(int copper)
        {
            _copper = copper;
        }

        public Currency() : this(0) { }

        public static Currency FromCopper(int copper)
            => new(copper);

        public static Currency FromSilver(int silver)
            => new(silver * 10);

        public static Currency FromGold(int gold)
            => new(gold * 100);

        public static Currency operator +(Currency a)
            => a;
        public static Currency operator -(Currency a)
            => new(-a.Copper);
        public static Currency operator +(Currency left, Currency right)
            => new(left.Copper + right.Copper);
        public static Currency operator -(Currency left, Currency right)
            => new(left.Copper - right.Copper);
        public static Currency operator *(Currency currency, int factor)
            => new(currency.Copper * factor);
        public static Currency operator *(Currency currency, decimal factor)
            => new((int)decimal.Round(currency.Copper * factor));
        public static Currency operator /(Currency currency, int factor)
            => new(currency.Copper / factor);
        public static Currency operator /(Currency currency, decimal factor)
            => new((int)decimal.Round(currency.Copper / factor));
    }
}
