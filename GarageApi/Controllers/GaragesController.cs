using System;
using GarageApi.Business.Models;
using GarageApi.Business.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GarageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaragesController : ControllerBase
    {
        private readonly IGarageRepository _garageRepository;

        public GaragesController(IGarageRepository garageRepository)
        {
            _garageRepository = garageRepository;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetGarages()
        {
            throw new NotSupportedException("Listing all garages not supported, please specify a single garage.");
        }

        [HttpGet]
        [Route("{garageId}")]
        public IActionResult GetGarage(int garageId)
        {
            var garage = _garageRepository.GetGarage(garageId);

            return Ok(garage);
        }

        [HttpGet]
        [Route("{garageId}/{regNo}")]
        public IActionResult GetVehicle(int garageId, string regNo)
        {
            var vehicle = _garageRepository.GetVehicle(garageId, regNo);

            return vehicle != null ? (IActionResult) Ok(vehicle) : NotFound();
        }

        [HttpPost]
        [Route("{garageId}")]
        public IActionResult CheckInVehilce(int garageId, Vehicle vehicle)
        {
            _garageRepository.CheckInVehicle(garageId, vehicle);

            return Ok();
        }

        [HttpDelete]
        [Route("{garageId}/{regNo}")]
        public IActionResult CheckOutVehicle(int garageId, string regNo)
        {
            _garageRepository.CheckOutVehicle(garageId, regNo);

            return Ok();
        }
    }
}