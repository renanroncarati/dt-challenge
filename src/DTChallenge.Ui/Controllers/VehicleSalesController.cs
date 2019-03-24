using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return View(vehicleSales);
        }

        // GET: VehicleSales/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VehicleSales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehicleSales/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VehicleSales/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VehicleSales/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VehicleSales/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VehicleSales/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}