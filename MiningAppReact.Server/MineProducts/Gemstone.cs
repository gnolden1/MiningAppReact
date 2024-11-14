using MiningAppReact.Server.MineProducts;
using MiningAppReact.Server.Others;

namespace MiningAppReact.Server.MineProducts {
    public enum GemstoneGroup {
        Ornamental,
        SemiPrecious,
        Fancy,
        Precious,
        Gems,
        Jewels
    }

    public static class Gemstones {
        public static Gemstone Azurite { get; } = new() { Name = "Azurite", Group = GemstoneGroup.Ornamental };
        public static Gemstone Agate { get; } = new() { Name = "Agate", Group = GemstoneGroup.Ornamental };
        public static Gemstone BlueCalcite { get; } = new () { Name = "Blue Calcite", Group = GemstoneGroup.Ornamental };
        public static Gemstone Hematite { get; } = new() { Name = "Hematite", Group = GemstoneGroup.Ornamental };
        public static Gemstone LapisLazuli { get; } = new() { Name = "Lapis Lazuli", Group = GemstoneGroup.Ornamental };
        public static Gemstone Malachite { get; } = new() { Name = "Malachite", Group = GemstoneGroup.Ornamental };
        public static Gemstone Obsidian { get; } = new() { Name = "Obsidian", Group = GemstoneGroup.Ornamental };
        public static Gemstone Rhodocrosite { get; } = new() { Name = "Rhodocrosite", Group = GemstoneGroup.Ornamental };
        public static Gemstone Turquoise { get; } = new() { Name = "Turquoise", Group = GemstoneGroup.Ornamental };
        public static Gemstone Bloodstone { get; } = new() { Name = "Bloodstone", Group = GemstoneGroup.SemiPrecious };
        public static Gemstone Carnelian { get; } = new() { Name = "Carnelian", Group = GemstoneGroup.SemiPrecious };
        public static Gemstone Chrysoprase { get; } = new() { Name = "Chrysoprase", Group = GemstoneGroup.SemiPrecious };
        public static Gemstone Citrine { get; } = new() { Name = "Citrine", Group = GemstoneGroup.SemiPrecious };
        public static Gemstone Jasper { get; } = new() { Name = "Jasper", Group = GemstoneGroup.SemiPrecious };
        public static Gemstone Moonstone { get; } = new() { Name = "Moonstone", Group = GemstoneGroup.SemiPrecious };
        public static Gemstone Onyx { get; } = new() { Name = "Onyx", Group = GemstoneGroup.SemiPrecious };
        public static Gemstone Quartz { get; } = new() { Name = "Quartz", Group = GemstoneGroup.SemiPrecious };
        public static Gemstone Tourmaline { get; } = new() { Name = "Tourmaline", Group = GemstoneGroup.SemiPrecious };
        public static Gemstone Zircon { get; } = new() { Name = "Zircon", Group = GemstoneGroup.SemiPrecious };
        public static Gemstone Alexandrite { get; } = new() { Name = "Alexandrite", Group = GemstoneGroup.Fancy };
        public static Gemstone Amber { get; } = new() { Name = "Amber", Group = GemstoneGroup.Fancy };
        public static Gemstone Amethyst { get; } = new() { Name = "Amethyst", Group = GemstoneGroup.Fancy };
        public static Gemstone Fluorite { get; } = new() { Name = "Fluorite", Group = GemstoneGroup.Fancy };
        public static Gemstone Jade { get; } = new() { Name = "Jade", Group = GemstoneGroup.Fancy };
        public static Gemstone Jet { get; } = new() { Name = "Jet", Group = GemstoneGroup.Fancy };
        public static Gemstone Aquamarine { get; } = new() { Name = "Aquamarine", Group = GemstoneGroup.Precious };
        public static Gemstone BlueSpinel { get; } = new() { Name = "Blue Spinel", Group = GemstoneGroup.Precious };
        public static Gemstone Peridot { get; } = new() { Name = "Peridot", Group = GemstoneGroup.Precious };
        public static Gemstone Topaz { get; } = new() { Name = "Topaz", Group = GemstoneGroup.Precious };
        public static Gemstone Garnet { get; } = new() { Name = "Garnet", Group = GemstoneGroup.Gems };
        public static Gemstone Jacinth { get; } = new() { Name = "Jacinth", Group = GemstoneGroup.Gems };
        public static Gemstone Opal { get; } = new() { Name = "Opal", Group = GemstoneGroup.Gems };
        public static Gemstone RedSpinel { get; } = new() { Name = "Red Spinel", Group = GemstoneGroup.Gems };
        public static Gemstone Diamond { get; } = new() { Name = "Diamond", Group = GemstoneGroup.Jewels };
        public static Gemstone Emerald { get; } = new() { Name = "Emerald", Group = GemstoneGroup.Jewels };
        public static Gemstone Ruby { get; } = new() { Name = "Ruby", Group = GemstoneGroup.Jewels };
        public static Gemstone Sapphire { get; } = new() { Name = "Sapphire", Group = GemstoneGroup.Jewels };

        public static IEnumerable<Gemstone> All
            => [Azurite, Agate, BlueCalcite, Hematite, LapisLazuli, Malachite, Obsidian, Rhodocrosite, Turquoise, Bloodstone, Carnelian, Chrysoprase,
                Citrine, Jasper, Moonstone, Onyx, Quartz, Tourmaline, Zircon, Alexandrite, Amber, Amethyst, Fluorite, Jade, Jet, Aquamarine, BlueSpinel,
                Peridot, Topaz, Garnet, Jacinth, Opal, RedSpinel, Diamond, Emerald, Ruby, Sapphire];
    }

    public class Gemstone : MineProduct {
        public required GemstoneGroup Group { get; init; }

        public override string ProductTypeName => "Gemstone";

        public Currency Value => Group.GetValue();
        public DiceRoll GetDiceRoll(int quality) => Group.GetDiceRoll(quality);
    }

    public static class GemstoneGroupExtensions
    {
        private static Dictionary<GemstoneGroup, DiceRoll[]> _gemstoneGroupDiceRolls { get; } = new()
        {
            {
                GemstoneGroup.Ornamental,
                [
                    new([8], []),
                    new([8], [1]),
                    new([10], []),
                    new([10], [1]),
                    new([12], []),
                    new([6, 6], []),
                    new([6, 6], [1]),
                    new([6, 6], [2]),
                    new([6, 6], [3]),
                    new([6, 6], [4]),
                    new([6, 6], [5]),
                    new([6, 6], [6]),
                ]
            },
            {
                GemstoneGroup.SemiPrecious,
                [
                    new([6], []),
                    new([6], [1]),
                    new([8], []),
                    new([8], [1]),
                    new([8], [2]),
                    new([8], [2]),
                    new([8], [3]),
                    new([10], [1]),
                    new([6, 6], [3]),
                    new([6, 6], [4]),
                    new([6, 6], [5]),
                    new([6, 6], [6]),
                ]
            },
            {
                GemstoneGroup.Fancy,
                [
                    new([4],[]),
                    new([4],[1]),
                    new([6],[]),
                    new([6],[1]),
                    new([6],[2]),
                    new([8],[1]),
                    new([8],[2]),
                    new([8],[3]),
                    new([8],[1]),
                    new([10],[1]),
                    new([10],[2]),
                    new([12],[1]),
                ]
            },
            {
                GemstoneGroup.Precious,
                [
                    new([8], []),
                    new([8], [1]),
                    new([8], [2]),
                    new([8], [3]),
                    new([8], [4]),
                    new([8], [5]),
                    new([8], [6]),
                    new([8], [7]),
                    new([8], [8]),
                    new([8], [9]),
                    new([8], [10]),
                    new([8], [11]),
                ]
            },
            {
                GemstoneGroup.Gems,
                [
                    new([6], []),
                    new([6], [1]),
                    new([6], [2]),
                    new([6], [3]),
                    new([6], [4]),
                    new([6], [5]),
                    new([6], [6]),
                    new([6], [7]),
                    new([6], [8]),
                    new([6], [9]),
                    new([6], [10]),
                    new([6], [11]),
                ]
            },
            {
                GemstoneGroup.Jewels,
                [
                    new([4], []),
                    new([4], [1]),
                    new([4], [2]),
                    new([4], [3]),
                    new([4], [4]),
                    new([4], [5]),
                    new([4], [6]),
                    new([4], [7]),
                    new([4], [8]),
                    new([4], [9]),
                    new([4], [10]),
                    new([4], [11]),
                ]
            }
        };

        public static Currency GetValue(this GemstoneGroup group)
        {
            return group switch
            {
                GemstoneGroup.Ornamental => Currency.FromGold(10),
                GemstoneGroup.SemiPrecious => Currency.FromGold(50),
                GemstoneGroup.Fancy => Currency.FromGold(100),
                GemstoneGroup.Precious => Currency.FromGold(500),
                GemstoneGroup.Gems => Currency.FromGold(1000),
                GemstoneGroup.Jewels => Currency.FromGold(5000),
                _ => throw new NotImplementedException($"The gemstone group {group} is not implemented.")
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="group"></param>
        /// <param name="quality"></param>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public static DiceRoll GetDiceRoll(this GemstoneGroup group, int quality)
        {
            if (quality < 1 || quality > 12)
            {
                throw new IndexOutOfRangeException($"The quality {quality} is invalid: must be between 1 and 12");
            }
            return _gemstoneGroupDiceRolls[group][quality - 1];
        }
        
    }
}
