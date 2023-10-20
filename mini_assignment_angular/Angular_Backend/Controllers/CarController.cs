using Angular_Backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class CarController : ControllerBase
    {


        private readonly IConfiguration _config;
        private readonly UserContext _context;

        public CarController(IConfiguration config, UserContext newcontext)
        {
            _config = config;
            _context = newcontext;
        }

        [HttpGet("GetCar")]
        public IActionResult Get()
        {
            var cars = _context.Cars.ToList();
            return Ok(cars);
        }

        [HttpPost("AddCar")]

        public IActionResult Add(Car car)
        {
            if (_context.Cars.Where(c => c.Brand == car.Brand).FirstOrDefault() != null)
            {
                return Ok("ALREADY EXISTS");
            }
            _context.Cars.Add(car);
            _context.SaveChanges();
            return Ok("Success car added");
        }

        [HttpDelete("DeleteCar/{id}")]
        public IActionResult DeleteCar(int id)
        {
            var car = _context.Cars.Find(id);
            if (car == null)
            {
                return NotFound(); 
            }

            _context.Cars.Remove(car);
            _context.SaveChanges();
            return Ok("Car deleted successfully");
        }

    }
}
