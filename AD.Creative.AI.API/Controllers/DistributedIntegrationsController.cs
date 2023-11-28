﻿using AdCreative.Service;
using Microsoft.AspNetCore.Mvc;

namespace AD.Creative.AI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistributedIntegrationsController : ControllerBase
    {
        private readonly DistributedIntegrationService _distributedIntegrationService;

        public DistributedIntegrationsController(DistributedIntegrationService distributedIntegrationService)
        {
            _distributedIntegrationService = distributedIntegrationService;
        }


        [HttpPut]
        public IActionResult ProcessItem([FromBody] string itemContent)
        {
            _distributedIntegrationService.PutItem(itemContent);
            return Ok();
        }


        [HttpGet]
        public IActionResult GetItem()
        {
            return Ok(_distributedIntegrationService.GetItem());
        }
    }
}
