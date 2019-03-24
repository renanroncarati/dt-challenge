using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge.Core.Domain.Services;
using Challenge.Core.Domain.Services.Api;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DTChallenge.Ui.Controllers
{
    public class VehicleSalesController : Controller
    {
        private readonly IVehicleServiceClient _httpVehicleClient;

        public VehicleSalesController(IVehicleServiceClient httpVehicleClient)
        {
            _httpVehicleClient = httpVehicleClient;
        }

        // GET: VehicleSales
        public async Task<ActionResult> Index()
        {
            var vehicleSales = await _httpVehicleClient.GetVehicleSales();

            SortVehicleSales(ref vehicleSales);            

            return View(vehicleSales);
        }

        private void SortVehicleSales(ref ICollection<VehicleSalesResponse> vehicleSales)
        {
            //ordering by the most often sold  
            vehicleSales = vehicleSales.GroupBy(v => v.Vehicle)
                        .OrderByDescending(g => g.Count())
                        .SelectMany(g => g)
                        .ToList();
        }
    }
}