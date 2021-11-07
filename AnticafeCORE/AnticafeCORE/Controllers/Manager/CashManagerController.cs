using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnticafeCORE.Controllers.Manager
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Manager")]
    [Authorize(Roles = "Administrator")]
    public class CashManagerController : ControllerBase
    {
        [Route("Add")]
        [HttpPost]
        public IActionResult AddCash()
        {
            return Ok();   
        }

        [Route("Add")]
        [HttpPost]
        public IActionResult WithdrawCash()
        {
            return Ok();
        }
    }
}
