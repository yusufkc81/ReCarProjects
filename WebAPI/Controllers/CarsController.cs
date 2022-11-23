using Business.Abstract;
using Core.Utilities;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {

        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        //---------------------------------------------------------------
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        //----------------------------------------------------------------

        [HttpPost("add")]
        public ActionResult Add(Cars cars)
        {
            var result = _carService.Add(cars);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        //------------------------------------------------------------------------

        [HttpPost("delete")]
        public ActionResult Delete(Cars cars)
        {
            var result = _carService.Delete(cars);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }

        }
        //----------------------------------------------------------------------------------------
        [HttpPost("update")]
        public ActionResult Update(Cars cars)
        {
            var result = _carService.Update(cars);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }

        }
        //----------------------------------------------------------------------------------------





    }
}
