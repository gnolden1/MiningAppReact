using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace MiningAppReact.Server.MineProducts {
    public class MineProduct {
        public required string Name { get; init; }

        public static IEnumerable<MineProduct> All
        {
            get
            {
                return Gemstones.All
                    .Concat<MineProduct>(Stones.All)
                    .Concat(Metals.All)
                    .Concat(ExoticMaterials.All);
            }
        }
    }
}
