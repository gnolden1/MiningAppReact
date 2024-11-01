using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiningAppReact.Server.MineProducts;

namespace MiningAppReact.Server.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class GemstoneController : ControllerBase {
        private ILogger<GemstoneController> _logger { get; }

        public GemstoneController(ILogger<GemstoneController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetGemstones")]
        public IEnumerable<object> Get()
        {
            return Gemstones.All.Select(gem => new
            {
                Name = gem.Name,
                Value = gem.Value,
                Group = gem.Group.ToString()
            });
        }
    }
}
