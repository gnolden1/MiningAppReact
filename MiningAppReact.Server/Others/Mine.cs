using MiningAppReact.Server.MineProducts;

namespace MiningAppReact.Server.Others {
    public class Mine {
        public static Currency MinerCost => Currency.FromSilver(14);
        public static Currency ArtisanCost => Currency.FromGold(14);

        public required string Name { get; set; }
        public required Environment Environment { get; init; }
        public required MineProduct MainProduct { get; init; }
        public required IEnumerable<Gemstone> Byproducts { get; init; }
        public required int Quality { get; init; }
        public required int Lifespan { get; set; }
        public required int Miners { get; set; }
        public required int SqFeetExcavated { get; set; }
        // Artisans if gemstones
        public required int Artisans { get; set; }
        // Smelter if metal
        // Equipment

    }
}
