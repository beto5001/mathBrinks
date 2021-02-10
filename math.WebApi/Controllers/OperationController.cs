using math.Application.AppServices;
using math.Domain.Models;
using math.Domain.ViewModels;
using math.Helper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace math.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        private readonly OperationApp _service;
        private readonly OperationModelToVm _adapter;

        public OperationController()
        {
            _service = new OperationApp();
            _adapter = new OperationModelToVm();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Operation> operations = _service.GetOperations();
                List<OperationVM> response = _adapter.OperationsToOperationVM(operations);

                return Ok(response);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }
    }
}
