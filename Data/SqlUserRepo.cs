using System.Collections.Generic;
using System.Linq;
using People.Models;

namespace People.Data
{
    public class SqlUserRepo : IUserRepo
    {
        private readonly UsersContext _context;

        public SqlUserRepo(UsersContext context)
        {
            _context = context;
        }
        public User CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }

        public User DeleteUser(int id)
        {
            var user = _context.Users.Find(id);

            _context.Users.Remove(user);
            _context.SaveChanges();

            return user;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int? id)
        {
            var user = _context.Users.FirstOrDefault(m => m.ID == id);
            return user;
        }

        public IEnumerable<User> GetUsersByName(string name)
        {
            name = name.ToLower();
            var allUsers = _context.Users.ToList();
            var result = allUsers.FindAll(u => u.Name.Contains(name));
            return result;
        }

        public User UpdateUser(User user)
        {
            _context.Update(user);
            _context.SaveChanges();

            return user;
        }
    }
}