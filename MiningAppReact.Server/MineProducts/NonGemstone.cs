using MiningAppReact.Server.Others;

namespace MiningAppReact.Server.MineProducts {
    public abstract class NonGemstone : MineProduct {
        public required List<Byproduct> Byproducts { get; init; }
        public required Currency[] Values { get; init; }
    }

    public class Byproduct {
        public required Gemstone Gemstone { get; init; }
        public required int LowerBound { get; init; }
        public required int UpperBound { get; init; }
    }

    public static class NonGemstoneExtensions
    {
        public static Currency GetValue(this NonGemstone self, int quality)
        {
            if (quality < 1 || quality > 12)
            {
                throw new IndexOutOfRangeException($"The quality {quality} is invalid: must be between 1 and 12");
            }
            return self.Values[quality - 1];
        }
    }
}
