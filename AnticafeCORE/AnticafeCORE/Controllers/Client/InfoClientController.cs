using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnticafeCORE.Controllers.Client
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Client")]
    public class InfoClientController : ControllerBase
    {
        [Route("TotalInfo")]
        [HttpGet]
        public IActionResult GetTotalInfo()
        {
            return Ok();
        }

        [Route("UpdateInfo")]
        [HttpPost]
        public IActionResult UpdateInfo()
        {
            return Ok();
        }
    }
}
