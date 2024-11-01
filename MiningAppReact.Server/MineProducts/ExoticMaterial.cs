using MiningAppReact.Server.Others;
using static MiningAppReact.Server.MineProducts.NonGemstoneExtensions;

namespace MiningAppReact.Server.MineProducts {
    public static class ExoticMaterials
    {
        public static ExoticMaterial Coal { get; } = new()
        {
            Name = "Coal",
            Values = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24 }.Select(Currency.FromGold).ToArray(),
            Byproducts = [
                new() { Gemstone = Gemstones.Amber, LowerBound = 51, UpperBound = 75 },
                new() { Gemstone = Gemstones.Jet, LowerBound = 76, UpperBound = 100 },
            ]
        };

        public static ExoticMaterial Petroleum { get; } = new()
        {
            Name = "Petroleum",
            Values = new int[] { 5, 8, 11, 14, 17, 21, 24, 27, 30, 33, 36, 39 }.Select(Currency.FromGold).ToArray(),
            Byproducts = [new() { Gemstone = Gemstones.BlueCalcite, LowerBound = 51, UpperBound = 100 }]
        };

        public static ExoticMaterial RadioActiveMaterials { get; } = new()
        {
            Name = "Radio-active Materials",
            Values = new int[] { 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 63 }.Select(Currency.FromGold).ToArray(),
            Byproducts = []
        };

        public static IEnumerable<ExoticMaterial> All
            => [Coal, Petroleum, RadioActiveMaterials];
    }

    public class ExoticMaterial : NonGemstone { }
}
