using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        //db
        private StudentModel db;

        public StudentController(StudentModel db) {
            this.db = db;
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id) {

            Student student = db.Students.Find(id);
            if (student == null) {
                return NotFound();

            }
            return Ok(student);
        }

        //post: api/albums
        [HttpPost]

        public ActionResult Post([FromBody] Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Students.Add(student);
            db.SaveChanges();
            return CreatedAtAction("Post", student);
        }


        //PUT: apiSgtudents/s
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            db.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return NoContent();
        }


        //DELETE :api/students

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Student student = db.Students.Find(id);
            if(student == null)
            {
                return NotFound();
                }
            db.Students.Remove(student);
            db.SaveChanges();
            return ok();
        }

        private ActionResult ok()
        {
            throw new NotImplementedException();
        }
    }
}