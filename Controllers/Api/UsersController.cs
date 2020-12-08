using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IEnumerable<User> GetUsers()
        {
            return _user.GetAllUsers();
        }

        // GET: api/Users/5
        // [HttpGet("{id}")]
        // public async Task<ActionResult<User>> GetUser(int id)
        // {
        //     var user = await _context.Users.FindAsync(id);

        //     if (user == null)
        //     {
        //         return NotFound();
        //     }

        //     return user;
        // }

        // // PUT: api/Users/5
        // [HttpPut("{id}")]
        // public async Task<IActionResult> PutUser(int id, User user)
        // {
        //     if (id != user.ID)
        //     {
        //         return BadRequest();
        //     }

        //     _context.Entry(user).State = EntityState.Modified;

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         if (!UserExists(id))
        //         {
        //             return NotFound();
        //         }
        //         else
        //         {
        //             throw;
        //         }
        //     }

        //     return NoContent();
        // }

        // // POST: api/Users
        // [HttpPost]
        // public async Task<ActionResult<User>> PostUser(User user)
        // {
        //     _context.Users.Add(user);
        //     await _context.SaveChangesAsync();

        //     return CreatedAtAction("GetUser", new { id = user.ID }, user);
        // }

        // // DELETE: api/Users/5
        // [HttpDelete("{id}")]
        // public async Task<ActionResult<User>> DeleteUser(int id)
        // {
        //     var user = await _context.Users.FindAsync(id);
        //     if (user == null)
        //     {
        //         return NotFound();
        //     }

        //     _context.Users.Remove(user);
        //     await _context.SaveChangesAsync();

        //     return user;
        // }

        // private bool UserExists(int id)
        // {
        //     return _context.Users.Any(e => e.ID == id);
        // }
    }
}
