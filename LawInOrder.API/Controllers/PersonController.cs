using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LawInOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllTimeList()
        {

            return Ok();
        }

        [HttpPost]
        public IActionResult SaveTimeData([FromBody])
        {
            return Ok();
        }
    }
}