using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleProject.Repository;
using VehicleProject.Model;

namespace VehicleProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository _vRepository;

        public VehicleController(IVehicleRepository vRepository)
        {
            _vRepository = vRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var products = _vRepository.GetVehicles();
            return new OkObjectResult(products);
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var product = _vRepository.GetVehicleByID(id);
            return new OkObjectResult(product);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Vehicle vehicle)
        {
            using (var scope = new TransactionScope())
            {
                _vRepository.InsertVehicle(vehicle);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { id = vehicle.VehicleNumber }, vehicle);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Vehicle vehicle)
        {
            if (vehicle != null)
            {
                using (var scope = new TransactionScope())
                {
                    _vRepository.UpdateVehicle(vehicle);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _vRepository.DeleteVehicle(id);
            return new OkResult();
        }
    }
}

