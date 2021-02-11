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

                var UserData = _context.Users.FirstOrDefault(s => s.Id.Equals(id));
                UserData.Name = user.Name;
                UserData.Email = user.Email;
                UserData.Phone = user.Phone;
                UserData.Direccion = user.Direccion;
                UserData.Status = user.Status;

                var isNameModified = _context.Entry(UserData).Property("Name").IsModified;
                var isEmailModified = _context.Entry(UserData).Property("Email").IsModified;
                var isPhoneModified = _context.Entry(UserData).Property("Phone").IsModified;
                var isDireccionModified = _context.Entry(UserData).Property("Direccion").IsModified;
                var isStatusModified = _context.Entry(UserData).Property("Status").IsModified;

                _context.SaveChanges();

                return NoContent();

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
