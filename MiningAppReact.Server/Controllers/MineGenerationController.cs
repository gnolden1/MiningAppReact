using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiningAppReact.Server.MineProducts;
using MiningAppReact.Server.Others;
using Environments = MiningAppReact.Server.Others.Environments;

namespace MiningAppReact.Server.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class MineGenerationController : ControllerBase {
        private ILogger<MineGenerationController> _logger { get; }

        public MineGenerationController(ILogger<MineGenerationController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Environments")]
        public IEnumerable<string> GetEnvironments()
            => Environments.AllEnvironments.Select(environment => environment.Name);

        [HttpGet("{environmentName}/MineProductTypes")]
        public IEnumerable<string> GetMineProductTypes(string environmentName)
        {
            var environment = Environments.AllEnvironments.First(environment => environment.Name == environmentName);
            var mineProductTypes = environment.AvailableMineProducts.Select(product => product.ProductTypeName).Distinct();
            return mineProductTypes;
        }

        [HttpGet("{environmentName}/{mineProductType}/MineProducts")]
        public IEnumerable<string> GetMineProducts(string environmentName, string mineProductType)
        {
            var environment = Environments.AllEnvironments.First(environment => environment.Name == environmentName);
            var mineProducts = environment.AvailableMineProducts.Where(product => product.ProductTypeName == mineProductType);
            return mineProducts.Select(product => product.Name);
        }
    }
}
