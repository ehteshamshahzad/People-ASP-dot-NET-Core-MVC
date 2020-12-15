using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using People.Data;
using People.Models;

namespace People.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepo _user;

        public UsersController(IUserRepo user)
        {
            _user = user;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            var result = await _user.GetAllUsers();
            return result;
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = _user.GetUserById(id);

            if (user == null)
            {
                return NotFound();
            }
            return user;
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public IActionResult PutUser(int id, User user)
        {
            if (id != user.ID)
            {
                return BadRequest();
            }
            _user.UpdateUser(user);

            return CreatedAtAction("GetUser", new { id = user.ID }, user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public ActionResult<User> DeleteUser(int id)
        {
            var user = _user.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }

            _user.DeleteUser(id);

            return user;
        }

        [Route("name/{name}")]
        [HttpGet]
        public IEnumerable<User> GetUsersByTheirName(string name)
        {
            return _user.GetUsersByName(name);
        }
    }
}