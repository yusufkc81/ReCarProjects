using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorService  _colorDal;
        public ColorsController(IColorService colorDal)
        {
            _colorDal = colorDal;
        }


        [HttpGet("getall")]
        public ActionResult GetAll()
        {
            var result = _colorDal.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        //---------------------------------------------------------------------

        [HttpPost("add")]
        public ActionResult Add(Color color)
        {
            var result = _colorDal.Add(color);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        //---------------------------------------------------------------------
        
        [HttpPost("Delete")]
        public ActionResult Delete(Color color)
        {
            var result = _colorDal.Delete(color);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        //---------------------------------------------------------------------

        [HttpPost("Update")]
        public ActionResult Update(Color color)
        {
            var result = _colorDal.Update(color);
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
