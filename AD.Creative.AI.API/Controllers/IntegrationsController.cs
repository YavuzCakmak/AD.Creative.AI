using AdCreative.Service;
using Microsoft.AspNetCore.Mvc;

namespace AD.Creative.AI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegrationsController : ControllerBase
    {
        private readonly IntegrationService _integrationService;

        public IntegrationsController(IntegrationService integrationService)
        {
            _integrationService = integrationService;
        }

        [HttpPost]
        public IActionResult ProcessItem([FromBody] string itemContent)
        {
            string result = _integrationService.ProcessItem(itemContent);
            return Ok(result);
        }
    }
}
