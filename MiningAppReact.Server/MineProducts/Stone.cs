using MiningAppReact.Server.Others;
using static MiningAppReact.Server.MineProducts.NonGemstoneExtensions;

namespace MiningAppReact.Server.MineProducts {
    public static class Stones
    {
#pragma warning disable CA1861 // Avoid constant arrays as arguments
        public static Stone Basalt { get; } = new()
        {
            Name = "Basalt",
            Values = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24 }.Select(Currency.FromGold).ToArray(),
            Byproducts = [
                new() { Gemstone = Gemstones.Agate, LowerBound = 51, UpperBound = 62 },
                new() { Gemstone = Gemstones.Obsidian, LowerBound = 63, UpperBound = 75 },
                new() { Gemstone = Gemstones.Quartz, LowerBound = 76, UpperBound = 85 },
                new() { Gemstone = Gemstones.Amethyst, LowerBound = 86, UpperBound = 90 },
                new() { Gemstone = Gemstones.Fluorite, LowerBound = 91, UpperBound = 95 },
            ]
        };

        public static Stone Granite { get; } = new()
        {
            Name = "Granite",
            Values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }.Select(Currency.FromGold).ToArray(),
            Byproducts = [
                new() { Gemstone = Gemstones.Agate, LowerBound = 51, UpperBound = 70 },
                new() { Gemstone = Gemstones.Bloodstone, LowerBound = 71, UpperBound = 72 },
                new() { Gemstone = Gemstones.Carnelian, LowerBound = 73, UpperBound = 75 },
                new() { Gemstone = Gemstones.Citrine, LowerBound = 76, UpperBound = 78 },
                new() { Gemstone = Gemstones.Jasper, LowerBound = 79, UpperBound = 81 },
                new() { Gemstone = Gemstones.Moonstone, LowerBound = 82, UpperBound = 84 },
                new() { Gemstone = Gemstones.Onyx, LowerBound = 85, UpperBound = 87 },
                new() { Gemstone = Gemstones.Tourmaline, LowerBound = 88, UpperBound = 90 },
                new() { Gemstone = Gemstones.Zircon, LowerBound = 91, UpperBound = 93 },
                new() { Gemstone = Gemstones.Fluorite, LowerBound = 94, UpperBound = 95 },
            ]
        };

        public static Stone Marble { get; } = new()
        {
            Name = "Marble",
            Values = new int[] { 4, 8, 16, 32, 36, 40, 44, 48, 52, 56, 60, 64 }.Select(Currency.FromGold).ToArray(),
            Byproducts = [
                new() { Gemstone = Gemstones.LapisLazuli, LowerBound = 51, UpperBound = 91 },
            ]
        };
#pragma warning restore CA1861 // Avoid constant arrays as arguments

        public static IEnumerable<Stone> All
            => [Basalt, Granite, Marble];
    }

    public class Stone : NonGemstone { }
}
