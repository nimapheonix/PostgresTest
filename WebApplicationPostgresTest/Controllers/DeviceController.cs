using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationPostgresTest.Logic;
using WebApplicationPostgresTest.ViewModel;

namespace WebApplicationPostgresTest.Controllers
{
    [Produces("application/json")]
    [Route("api/Device")]
    public class DeviceController : BaseController
    {
        private readonly IDeviceLogic deviceLogic;
        public DeviceController(IDeviceLogic deviceLogic)
        {
            this.deviceLogic = deviceLogic;
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add([FromBody] DeviceModel model)
        {
            if (!ModelState.IsValid)
            {
                return SendResponse("BadRequset");
            }
            var response = await deviceLogic.Add(model);
            return SendResponse(response);
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            var response = await deviceLogic.GetAll();
            return SendResponse(response);
        }
    }
}