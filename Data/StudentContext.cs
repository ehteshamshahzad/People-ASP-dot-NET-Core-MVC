using Microsoft.EntityFrameworkCore;
using People.Models;

namespace People.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext (DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
    }
}