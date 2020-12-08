using Microsoft.AspNetCore.Mvc;
using People.Data;
using People.Models;

namespace People.Controllers
{
    public class UsersController : Controller
    {
        private readonly UsersContext _context;
        private readonly IUserRepo _user;

        public UsersController(UsersContext context, IUserRepo user)
        {
            _context = context;
            _user = user;
        }

        // GET: Users
        public IActionResult Index()
        {
            return View(_user.GetAllUsers());
        }

        // GET: Users/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = _user.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ID,Name,Email,Password,PhoneNumber,IsActive")] User user)
        {
            if (ModelState.IsValid)
            {
                user.IsActive = true;
                _user.CreateUser(user);

                // _context.Add(user);
                // await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = _user.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("ID,Name,Email,Password,PhoneNumber,IsActive")] User user)
        {
            if (id != user.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _user.UpdateUser(user);

                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = _user.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _user.DeleteUser(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
