using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rentcar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public CarController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<CarController>
        [HttpGet]
        public ActionResult<List<Models.Car>> Get()
        {
                try
                {
                var listCars = _context.Cars.ToList();
                return Ok(listCars);
                }
                catch (Exception ex)
                {
                return BadRequest(ex.Message);
                }
           
        }

        // GET api/Available
        [HttpGet("Available")]

        public IActionResult Available()
        {
            var AvailableCars = _context.Cars.Where(a => a.Status == 1).Where(b => b.Stock >= 1).ToList();

            if (AvailableCars.Count == 0)
            {
                return NotFound();
            }

            return Ok(AvailableCars);
        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]

        public ActionResult<Models.Car> Get(int id)
        {

            try
            {
                var car = _context.Cars.Find(id);

                if (car == null)
                {
                    return NotFound();
                }

                return Ok(car);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // POST api/<CarController>
        [HttpPost]
        public ActionResult Car([FromForm] Models.Car car)
        {

            try
            {
                _context.Add(car);
                _context.SaveChanges();

                return Ok(car);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromForm] Models.Car car)
        {
            try
            {

                if(id != car.Id)
                {
                    return BadRequest();
                }

                _context.Entry(car).State = EntityState.Modified;
                _context.Update(car);
                _context.SaveChanges();

                return Ok(car);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
        public ActionResult<Models.Car> Delete(int id)
        {
            try
            {
                var car = _context.Cars.Find(id);

                if (car == null)
                {
                    return NotFound();
                }

                _context.Remove(car);
                _context.SaveChanges();

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
