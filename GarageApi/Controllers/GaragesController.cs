using System;
using GarageApi.Business;
using GarageApi.Business.Commands;
using GarageApi.Business.Entities;
using GarageApi.Business.Queries;
using Microsoft.AspNetCore.Mvc;

/// <summary>
/// https://crosscuttingconcerns.com/CommandQuery-Object-pattern
/// </summary>
namespace GarageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaragesController : ControllerBase
    {
        private readonly IDataAccess _dataAccess;

        public GaragesController(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
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
            var query = new GarageById(garageId);
            //var query = new GarageByIdNoVehicles(garageId);
            var garage = query.Execute(_dataAccess);

            return Ok(garage);
        }

        [HttpGet]
        [Route("{garageId}/{regNo}")]
        public IActionResult GetVehicle(int garageId, string regNo)
        {
            var query = new VehicleByGarageAndRegNo(garageId, regNo);
            var vehicle = query.Execute(_dataAccess);

            return vehicle != null ? (IActionResult) Ok(vehicle) : NotFound();
        }

        [HttpPost]
        [Route("{garageId}")]
        public IActionResult CheckInVehilce(int garageId, Vehicle vehicle)
        {
            var command = new CheckInVehicle(garageId, vehicle.RegNo);
            command.Execute(_dataAccess);

            return Ok();
        }

        [HttpDelete]
        [Route("{garageId}/{regNo}")]
        public IActionResult CheckOutVehicle(int garageId, string regNo)
        {
            var command = new CheckOutVechicle(garageId, regNo);
            command.Execute(_dataAccess);

            return Ok();
        }
    }
}