using MiningAppReact.Server.Others;
using static MiningAppReact.Server.MineProducts.NonGemstoneExtensions;

namespace MiningAppReact.Server.MineProducts {
    public static class Metals
    {
        public static Metal Adamantine { get; } = new Metal()
        {
            Name = "Adamantine",
            Values = new int[] { 200, 300, 400, 500, 600, 700, 800, 900, 1000, 1100, 1200, 1300 }.Select(Currency.FromGold).ToArray(),
            Byproducts = []
        };

        public static Metal Copper { get; } = new Metal()
        {
            Name = "Copper",
            Values = new int[] { 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65 }.Select(Currency.FromGold).ToArray(),
            Byproducts = [
                new() { Gemstone = Gemstones.Azurite, LowerBound = 61, UpperBound = 66 },
                new() { Gemstone = Gemstones.Malachite, LowerBound = 67, UpperBound = 82 },
                new() { Gemstone = Gemstones.Turquoise, LowerBound = 83, UpperBound = 100 },
            ]
        };

        public static Metal Gold { get; } = new Metal()
        {
            Name = "Gold",
            Values = new int[] { 35, 55, 77, 100, 120, 135, 155, 175, 200, 220, 235, 260 }.Select(Currency.FromGold).ToArray(),
            Byproducts = []
        };

        public static Metal Iron { get; } = new Metal()
        {
            Name = "Iron",
            Values = new int[] { 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37 }.Select(Currency.FromGold).ToArray(),
            Byproducts = [
                new() { Gemstone = Gemstones.Hematite, LowerBound = 51, UpperBound = 71 },
                new() { Gemstone = Gemstones.Rhodocrosite, LowerBound = 72, UpperBound = 87 },
                new() { Gemstone = Gemstones.Bloodstone, LowerBound = 88, UpperBound = 90 },
                new() { Gemstone = Gemstones.Carnelian, LowerBound = 91, UpperBound = 93 },
                new() { Gemstone = Gemstones.Chrysoprase, LowerBound = 94, UpperBound = 96 },
                new() { Gemstone = Gemstones.Alexandrite, LowerBound = 97, UpperBound = 98 },
                new() { Gemstone = Gemstones.Jade, LowerBound = 99, UpperBound = 100 },
            ]
        };

        public static Metal Lead { get; } = new Metal()
        {
            Name = "Lead",
            Values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }.Select(Currency.FromGold).ToArray(),
            Byproducts = []
        };

        public static Metal Mithril { get; } = new Metal()
        {
            Name = "Mithril",
            Values = new int[] { 150, 210, 280, 340, 410, 480, 550, 620, 690, 770, 830, 910 }.Select(Currency.FromGold).ToArray(),
            Byproducts = []
        };

        public static Metal Platinum { get; } = new Metal()
        {
            Name = "Platinum",
            Values = new int[] { 80, 130, 177, 225, 275, 320, 370, 420, 465, 560, 610, 660 }.Select(Currency.FromGold).ToArray(),
            Byproducts = []
        };

        public static Metal Silver { get; } = new Metal()
        {
            Name = "Silver",
            Values = new int[] { 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130 }.Select(Currency.FromGold).ToArray(),
            Byproducts = []
        };

        public static Metal Tin { get; } = new Metal()
        {
            Name = "Tin",
            Values = new int[] { 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51 }.Select(Currency.FromGold).ToArray(),
            Byproducts = []
        };

        public static Metal Zinc { get; } = new Metal()
        {
            Name = "Zinc",
            Values = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24 }.Select(Currency.FromGold).ToArray(),
            Byproducts = []
        };

        public static IEnumerable<Metal> All
            => [Adamantine, Copper, Gold, Iron, Lead, Mithril, Platinum, Silver, Tin, Zinc];
    }

    public class Metal : NonGemstone { } 
}
