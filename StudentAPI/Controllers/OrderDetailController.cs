using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IActionResult : ControllerBase
    {
        private IActionResult db;


        public IActionResult(IActionResult context)
        {
            this.db = db;
        }

        public object orderDetail { get; private set; }

        //Get: api/OrderDetails
        [HttpGet("{id}")]
        //public ActionResult Get(int id)
        //{
            
            
        //}

        private OrderDetail OrderDetail()
        {
            throw new NotImplementedException();
        }

        //Post : api/OrderDetail
        [HttpPost]
        public ActionResult Post([FromBody] OrderDetail orderDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //db.OrderDetail.Add(orderDetail);
            //db.SaveChanges();
            return CreatedAtAction("Post", orderDetail);
        }


        //PUT :Api/OrderDetail
        public ActionResult Put(int id,[FromBody] OrderDetail orderdetail)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return NoContent();
        }


        //Delete :api/orderDetail
        //public ActionResult (int id)
        //{
           
        //}
    }
}