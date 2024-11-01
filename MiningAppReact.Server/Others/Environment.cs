using MiningAppReact.Server.MineProducts;

namespace MiningAppReact.Server.Others {
    public static class Environments
    {
        public static Environment Desert { get; } = new()
        {
            Name = "Desert",
            AvailableMineProducts = [
                Metals.Lead,
                Metals.Zinc,
                Metals.Iron,
                Metals.Copper,
                Metals.Gold,
                Metals.Silver,
                .. ExoticMaterials.All,
            ],
            FavoredMineProducts = [
                ExoticMaterials.Coal,
                ExoticMaterials.Petroleum,
            ],
            ProspectingDC = 20,
            TimeRequired = 1,
            SurfaceCovered = 4,
            DepositChance = 10,
        };

        public static Environment Hill { get; } = new()
        {
            Name = "Hill",
            AvailableMineProducts = [
                .. Metals.All.Except([Metals.Mithril]),
                Stones.Granite,
                Stones.Marble,
                .. Gemstones.All,
                ExoticMaterials.Coal,
                ExoticMaterials.RadioActiveMaterials,
            ],
            FavoredMineProducts = [
                .. Metals.All,
            ],
            ProspectingDC = 15,
            TimeRequired = 1,
            SurfaceCovered = 2,
            DepositChance = 30,
        };

        public static Environment Jungle { get; } = new()
        {
            Name = "Jungle",
            AvailableMineProducts = [
                Metals.Silver,
                Metals.Gold,
                Metals.Platinum,
                .. Gemstones.All.Where(gem => gem.Group == GemstoneGroup.Precious || gem.Group == GemstoneGroup.Gems || gem.Group == GemstoneGroup.Jewels),
                .. ExoticMaterials.All,
            ],
            FavoredMineProducts = [
                .. Gemstones.All,
            ],
            ProspectingDC = 25,
            TimeRequired = 2,
            SurfaceCovered = 2,
            DepositChance = 15,
        };

        public static Environment Mountain { get; } = new()
        {
            Name = "Mountain",
            AvailableMineProducts = [
                .. MineProduct.All.Except([ExoticMaterials.Coal, ExoticMaterials.Petroleum]),
            ],
            FavoredMineProducts = [
                .. MineProduct.All,
            ],
            ProspectingDC = 15,
            TimeRequired = 1,
            SurfaceCovered = 1,
            DepositChance = 30,
        };

        public static Environment Plain { get; } = new()
        {
            Name = "Plain",
            AvailableMineProducts = [
                .. ExoticMaterials.All,
            ],
            FavoredMineProducts = [
                ExoticMaterials.Coal,
            ],
            ProspectingDC = 12,
            TimeRequired = 2,
            SurfaceCovered = 6,
            DepositChance = 26,
        };

        public static Environment VolcanicLand { get; } = new()
        {
            Name = "Volcanic Land",
            AvailableMineProducts = [
                Stones.Granite,
                Stones.Basalt,
                .. Gemstones.All.Where(gem => gem.Group == GemstoneGroup.Gems || gem.Group == GemstoneGroup.Jewels),
            ],
            FavoredMineProducts = [
                Stones.Basalt,
            ],
            ProspectingDC = 18,
            TimeRequired = 1,
            SurfaceCovered = 2,
            DepositChance = 35,
        };

        public static IEnumerable<Environment> AllEnvironments
            => [Desert, Hill, Jungle, Mountain, Plain, VolcanicLand];
    }

    public class Environment {
        public required string Name { get; set; }
        public required IEnumerable<MineProduct> AvailableMineProducts { get; init; }
        public required IEnumerable<MineProduct> FavoredMineProducts { get; init; }
        public required int ProspectingDC { get; init; }
        public required int TimeRequired { get; init; }
        public required int SurfaceCovered { get; init; }
        public required int DepositChance { get; init; }
    }
}
