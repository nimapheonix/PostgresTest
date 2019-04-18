using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationPostgresTest.ViewModel;

namespace WebApplicationPostgresTest.Controllers
{
    //[Produces("application/json")]
    [Route("api/TC")]
    public class TCController : BaseController
    {
        public TCController()
        {
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add([FromBody] TCModel model)
        {
            if (!ModelState.IsValid)
            {
                return SendResponse("BadRequset");
            }
            //var response = await positionLogic.Add(model);
            return SendResponse("GoodRequset");
        }
    }
}