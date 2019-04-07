using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationPostgresTest.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class BaseController : Controller
    {
        protected IActionResult SendResponse(dynamic response)
        {
            switch (response.Status)
            {
                case HttpStatusCode.BadRequest:
                    return BadRequest(response);
                case HttpStatusCode.OK:
                    return Ok(response);
                case HttpStatusCode.NotFound:
                    return NotFound(response);
                case HttpStatusCode.Unauthorized:
                    return Unauthorized();
                case HttpStatusCode.Conflict:
                    return Conflict(response);
                default:
                    return Ok(null);
            }
        }

        private IActionResult Conflict(dynamic response)
        {
            return response;
        }
    }
}