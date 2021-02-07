using math.Application.AppServices;
using Microsoft.AspNetCore.Mvc;
using System;

namespace math.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        private OperationApp _service;

        public OperationController()
        {
            _service = new OperationApp();
        }

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
