using Microsoft.AspNetCore.Mvc;
using System.Data;
using Task_1.Filters;
using Task_1.Middelwares;
using Task_1.Models;


namespace Task_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ILogger<CarsController> _logger;
        private readonly RequestCounterMiddleware _requestCounter;
        public CarsController(ILogger<CarsController> logger,RequestCounterMiddleware requestCounter)
        {
            _logger = logger;
            _requestCounter = requestCounter;
        }
        // GET: api/<CarsController>
        [HttpGet]
        public ActionResult<List<Car>> Get()
        {
            return Car.Cars.ToList();
        }

        [HttpGet]
        [Route("Count")]
        public ActionResult<string> GetCountOfRequests()
        {
            //return _requestCounter._requestCount.ToString();
            return "heelo";
        }

        // GET api/<CarsController>/5
        [HttpGet("{id}")]
        public ActionResult<Car> GetByID(int id)
        {
            return Car.Cars.FirstOrDefault(c=>c.Id==id)!;
        }

        // POST api/<CarsController>
        [HttpPost]
        [Route("V1")]
        public ActionResult Post(Car newCar)
        {
            Car.Cars.Add(newCar);
            return CreatedAtAction(actionName: "GetByID", routeValues: new { id = newCar.Id }, value: new { message = "Car was inserted" });
        }

        [HttpPost]
        [Route("V2")]
        [ValidateTypeOFCar]
        public ActionResult PostV2(Car newCar)
        {
            Car.Cars.Add(newCar);
            return CreatedAtAction(actionName: "GetByID", routeValues: new { id = newCar.Id }, value: new { message = "Car was inserted" });
        }

        // PUT api/<CarsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, Car UpdatedCar)
        {
            if (UpdatedCar.Id != id)
                return BadRequest();

            Car mycar = Car.Cars.FirstOrDefault(c=>c.Id== id)!;
            if (mycar!=null)
            {
                mycar.Id = UpdatedCar.Id;
                mycar.Name = UpdatedCar.Name;
                mycar.Description = UpdatedCar.Name;

                _logger.LogInformation($"this is correct {Car.Cars.FirstOrDefault(c => c.Id == id)!.Name}, {mycar.Name}");

                return Ok();
            }
            return NotFound();
        }

        // DELETE api/<CarsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Car mycar = Car.Cars.FirstOrDefault(c => c.Id == id)!;

            if (mycar != null)
            {
                Car.Cars.Remove(mycar);
            }
            return NotFound();
        }
    }
}
