using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnticafeCORE.Controllers.Client
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Client")]
    public class VisitClientController : ControllerBase
    {
        [Route("CurrentVisit")]
        [HttpGet]
        public IActionResult GetCurrentVisit()
        {
            return Ok();
        }

        [Route("AllVisit")]
        [HttpGet]
        public IActionResult GetAllVisits()
        {
            return Ok();
        }
    }
}
