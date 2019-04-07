using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationPostgresTest.Logic;
using WebApplicationPostgresTest.ViewModel;
using System.Net;
using WebApplicationPostgresTest.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationPostgresTest.Controllers
{

    [Produces("application/json")]
    [Route("api/Position")]
    public class PositionController : BaseController
    {
        private readonly IPositionLogic positionLogic;
        public PositionController(IPositionLogic positionLogic)
        {
            this.positionLogic = positionLogic;      
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add([FromBody] PositionModel model)
        {
            if (!ModelState.IsValid)
            {
                return SendResponse("BadRequset");
            }
            var response = await positionLogic.Add(model);
            return SendResponse(response);
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            //var ddd = context.Positions.ToList();

            var response = await positionLogic.GetAll();
            return SendResponse(response);
        }

    }
}
