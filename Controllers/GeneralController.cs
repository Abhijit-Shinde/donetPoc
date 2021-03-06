using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetPoc.Services;
using dotnetPoc.ViewModels;
using dotnetPoc.Helpers;

namespace dotnetPoc.Controllers
{
    [Route("api/[controller]")]
    public class GeneralController : Controller
    {
        private readonly IGeneralService _generalService;
        public GeneralController(IGeneralService generalService)
        {
            _generalService = generalService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Things Works");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(Guid id)
        {
            var result = await _generalService.SingleProduct(id);
            return new OkObjectResult(result);
        }

        [HttpGet("AllProducts")]
        public async Task<IActionResult> AllProducts()
        {
            var result = await _generalService.AllProducts();
            return new OkObjectResult(result);
        }

        [HttpPost("GetByIDs")]
        public async Task<IActionResult> ProductsByIds([FromBody] IDsViewModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _generalService.AllProductsByIds(model);
            return new OkObjectResult(result);
        }

        [HttpPost("StoreShipment")]

        public async Task<IActionResult> StoreShipment([FromBody] ShipmentViewModel model)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            
             if (await _generalService.AddShipment(model))
                return new OkObjectResult(new { Message = "Success" });

            return BadRequest(Errors.AddErrorToModelState("Message", "Somethins Went Wrong", ModelState));
        }
    }
}