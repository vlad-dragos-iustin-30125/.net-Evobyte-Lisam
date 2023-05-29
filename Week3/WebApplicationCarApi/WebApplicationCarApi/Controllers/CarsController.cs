using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using WebApplicationCarApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationCarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private static List<Car> cars = new List<Car>()
            {
                new Car () {Id = Guid.NewGuid(), Name = "Audi A4", Description = "Motorizare 2.0 L", DOM = DateTime.Now, Fuel = "Gasoline"},
                new Car () {Id = Guid.NewGuid(), Name = "Audi RS e-tron", Description = "Motorizare 3.0 ", DOM = DateTime.Now, Fuel = "Electric"},
                new Car () {Id = Guid.NewGuid(), Name = "Audi S7", Description = "Motorizare 4.0 L", DOM = DateTime.Now, Fuel = "Gasoline"},
                new Car () {Id = Guid.NewGuid(), Name = "Audi A5", Description = "Motorizare 2.0 L", DOM = DateTime.Now, Fuel = "Gasoline"},
            };
        public CarsController()
        {

        }
        // GET: api/<CarsController>
        [HttpGet]
        public Car[] Get()
        {
            return cars.ToArray();
        }

        // GET api/<CarsController>/5
        [HttpGet("{id}")]
        public Car Get(Guid id)
        {
            return cars.FirstOrDefault(x => x.Id == id);

        }

        // POST api/<CarsController>
        [HttpPost]
        public void Post([FromBody] Car car)
        {
            cars.Add(car);
        }

        // PUT api/<CarsController>/5
        [HttpPut("{id}")]
        public NotFoundResult Put(Guid id, [FromBody] Car car)
        {
            var car1 = cars.FirstOrDefault((x) => x.Id == id);
            if (car1 != null) {
                car1.Name = car.Name;
                car1.Description = car.Description;
                car1.DOM = car.DOM;
                car1.Fuel = car.Fuel;

               
            }

            return NotFound ();
    
        }

        // DELETE api/<CarsController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var car = cars.FirstOrDefault((x) => x.Id == id);
            if(car != null)
            {
                for (int i = 0; i<cars.Count; i++)
                {
                    if (cars[i].Id == id)
                    {
                        cars.RemoveAt(i);
                       
                    }
                }
            }
   
        }
    }
}