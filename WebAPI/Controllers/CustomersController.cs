using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerDal;
        public CustomersController(ICustomerService colorDal)
        {
            _customerDal = colorDal;
        }


        [HttpGet("getall")]
        public ActionResult GetAll()
        {
            var result = _customerDal.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        //------------------------------------------------------------------

        [HttpPost("add")]
        public ActionResult Add(Customer  customer)
        {
            var result = _customerDal.Add(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        //------------------------------------------------------------------

        [HttpPost("delete")]
        public ActionResult Delete(Customer customer)
        {
            var result = _customerDal.Delete(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        //------------------------------------------------------------------

        [HttpPost("update")]
        public ActionResult Update(Customer customer)
        {
            var result = _customerDal.Update(customer);
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
