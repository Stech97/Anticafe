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
    public class CashClientController : ControllerBase
    {
        [Route("Add")]
        [HttpPost]
        public IActionResult AddCash()
        {
            return Ok();
        }

        [Route("Balance")]
        [HttpGet]
        public IActionResult GetBalance()
        {
            return Ok();
        }
    }
}
