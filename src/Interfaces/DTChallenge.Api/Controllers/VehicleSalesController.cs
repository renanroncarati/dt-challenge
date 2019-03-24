using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge.Core.Domain.Entities;
using Challenge.Core.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DTChallenge.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleSalesController : ControllerBase
    {
        private readonly IVehicleSalesService _vehicleSalesService;

        public VehicleSalesController(IVehicleSalesService vehicleSalesService)
        {
            _vehicleSalesService = vehicleSalesService;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetSoldVehiclesAsync()
        {
            var result = await _vehicleSalesService.GetSoldVehiclesAsync();
            return Ok(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
       
    }
}
