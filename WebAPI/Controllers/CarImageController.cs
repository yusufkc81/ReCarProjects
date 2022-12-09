using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

        public class CarImageController : ControllerBase
        {
            ICarImageService _carImageService;
            public CarImageController(ICarImageService carImageService)
            {
                _carImageService = carImageService;
            }


        [HttpGet("getall")]
            public IActionResult GetAll()
            {
                var result = _carImageService.GetAll();
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(result);
                }
            }
            //-----------------------------------------------------------------------------------------------

            [HttpPost("add")]
            public IActionResult Add([FromForm] IFormFile file, [FromForm] CarImages carImage)
            {
                var result = _carImageService.Add(file,carImage);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(result);
                }    
            }
            //-----------------------------------------------------------------------------------------------
            [HttpPost("delete")]
            public IActionResult Delete([FromForm] IFormFile file, [FromForm] CarImages carImage)
            {
                var result = _carImageService.Delete(file, carImage);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(result);
                }
            }
            //-----------------------------------------------------------------------------------------------
            [HttpPost("update")]
            public IActionResult Update([FromForm] IFormFile file, [FromForm] CarImages carImage)
            {
                var result = _carImageService.Update(file, carImage);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(result);
                }
            }

        }
    }

