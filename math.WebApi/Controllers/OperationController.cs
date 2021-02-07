using Microsoft.AspNetCore.Mvc;
using System;

namespace math.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            try
            {


                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }
    }
}
