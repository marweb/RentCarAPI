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
    public class UserController : ControllerBase
    {

        private readonly AplicationDbContext _context;
        public UserController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<UserController>
        [HttpGet]
        public ActionResult Get()
        {
            var ListUsers = _context.Users.ToList();

            if (ListUsers.Count == 0)
            {
                return NotFound();
            }

            return Ok(ListUsers);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult<Models.User> Get(int id)
        {
            try
            {
                var user = _context.Users.Find(id);

                if (user == null)
                {
                    return NotFound();
                }

                return Ok(user);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult Usuario([FromForm] Models.User user)
        {

            try
            {
                _context.Add(user);
                _context.SaveChanges();

                return Ok(user);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromForm] Models.User user)
        {
            try
            {

                if (id != user.Id)
                {
                    return BadRequest();
                }

                _context.Entry(user).State = EntityState.Modified;
                _context.Update(user);
                _context.SaveChanges();

                return Ok(user);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public ActionResult<Models.User> Delete(int id)
        {
            try
            {
                var user = _context.Users.Find(id);

                if (user == null)
                {
                    return NotFound();
                }

                _context.Remove(user);
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
