using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rentcar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public OrderController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<OrderController>
        [HttpGet]
        public ActionResult Get()
        {
            // var ListOrders = _context.Orders.FromSqlRaw("SELECT * FROM Orders where Status = '1'").Include(b => b.User).Include(c => c.Car).ToList();
            var ListOrders = _context.Orders.Where(a => a.Status == 1).Include(b => b.User).Include(c => c.Car).ToList();

            if (ListOrders.Count == 0)
            {
                return NotFound();
            }

            return Ok(ListOrders);
        }

        // GET api/Available/2
        [HttpGet("ByUser/{id}")]

        public IActionResult ByUser(int id)
        {
            //var OrderUser = _context.Orders.FromSqlRaw("SELECT * FROM Orders where Status = '1' and UserId = id").Include(b => b.User).Include(c => c.Car).ToList();
            var OrderUser = _context.Orders.Where(a => a.Status == 1).Where(b => b.UserId == id).Include(c => c.User).Include(d => d.Car).ToList();

            if (OrderUser.Count == 0)
            {
                return NotFound();
            }

            return Ok(OrderUser);
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var order = _context.Orders.Where(b => b.Id == id).Include(c => c.User).Include(d => d.Car).First();

                if (order == null)
                {
                    return NotFound();
                }

                return Ok(order);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<OrderController>
        [HttpPost]
        public ActionResult Order([FromForm] Models.Order order)
        {

            try
            {
                _context.Add(order);
                _context.SaveChanges();

                return Ok(order);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromForm] Models.Order order)
        {
            try
            {

                var OrderData = _context.Orders.FirstOrDefault(s => s.Id.Equals(id));
                OrderData.Agencia = order.Agencia;
                OrderData.FechaInicioAlquiler = order.FechaInicioAlquiler;
                OrderData.FechaFinAlquiler = order.FechaFinAlquiler;
                OrderData.Status = order.Status;
                OrderData.CreadoPor = order.CreadoPor;
                OrderData.CarId = order.CarId;
                OrderData.UserId = order.UserId;

                var isAgenciaModified = _context.Entry(OrderData).Property("Agencia").IsModified;
                var isFechaInicioAlquilerModified = _context.Entry(OrderData).Property("FechaInicioAlquiler").IsModified;
                var isFechaFinAlquilerModified = _context.Entry(OrderData).Property("FechaFinAlquiler").IsModified;
                var isStatusModified = _context.Entry(OrderData).Property("Status").IsModified;
                var isCreadoPorModified = _context.Entry(OrderData).Property("CreadoPor").IsModified;
                var isCarIdModified = _context.Entry(OrderData).Property("CarId").IsModified;
                var isUserIdModified = _context.Entry(OrderData).Property("UserId").IsModified;

                _context.SaveChanges();

                return NoContent();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public ActionResult<Models.Order> Delete(int id)
        {
            try
            {
                var order = _context.Orders.Find(id);

                if (order == null)
                {
                    return NotFound();
                }

                _context.Remove(order);
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
