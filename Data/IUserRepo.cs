using Microsoft.AspNetCore.Mvc;
using People.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace People.Data
{
    public interface IUserRepo
    {
        User CreateUser(User user);
        Task<IEnumerable<User>> GetAllUsers();
        User GetUserById(int? id);
        User UpdateUser(User user);
        User DeleteUser(int id);
        IEnumerable<User> GetUsersByName(string name);
    }
}