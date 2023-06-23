using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Task_1.Models;

namespace Task_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController1 : Controller
    {
        [HttpGet]
        public IActionResult get()
        {
            List<Course> crs = Courses.Course;
            if (crs.Count == 0)
                return NotFound();
            return Ok(crs);
        }

        [HttpDelete("{id:int}")]
        public IActionResult delete(int id)
        {
            Course crs = Courses.Course.Find(x => x.Id == id);
            if (crs == null)
                return NotFound();
            Courses.Course.Remove(crs);
            return Ok(crs);
        }


        [HttpPut]
        public IActionResult put(int id,Course Crs)
        {
            if (Crs.Id != id)
                return BadRequest();

            Course crs1 = Courses.Course.Find(x => x.Id == id);
            if (crs1 == null)
                return NotFound();

            crs1 = Crs;
            return NoContent();
        }


        [HttpPost]
        public IActionResult post(Course Crs)
        {
            if (Crs == null)
                return BadRequest();
            Courses.Course.Add(Crs);
            return Created($"~api/Course/{Crs.Id}", Crs);
        }

        [HttpGet("{id:int}")]
        public IActionResult getById(int id)
        {
            Course std = Courses.Course.Find(x => x.Id == id);
            if (std == null)
                return NotFound();
            return Ok(std);
        }



        [HttpGet("{name:alpha}")]
        public IActionResult couseByName(string Name)
        {
            Course std = Courses.Course.Find(x => x.Name == Name);
            if (std == null)
                return NotFound();
            return Ok(std);
        }


    }
}
