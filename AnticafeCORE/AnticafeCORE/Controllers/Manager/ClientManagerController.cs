using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnticafeCORE.Controllers.Manager
{
    [Route("api/[controller]")]
    [Authorize(Roles = "Manager")]
    [Authorize(Roles = "Administrator")]
    [ApiController]
    public class ClientManagerController : ControllerBase
    {
        [Route("NewClient")]
        [HttpPost]
        public IActionResult AddNewClient()
        {
            return Ok();
        }

        public IActionResult UpdateInfoClient()
        {
            return Ok();
        }

        public IActionResult InputClient()
        {
            return Ok();
        }

        public IActionResult OutputClient()
        {
            return Ok();
        }
    }
}
