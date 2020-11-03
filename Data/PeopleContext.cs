using Microsoft.EntityFrameworkCore;
using People.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace People.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions<PeopleContext> options)
        : base(options) { }
        
        public DbSet<Person> People { get; set; }
        public DbSet<Name> Name { get; set; }
        public DbSet<PhoneNumber> PhoneNumber { get; set; }

    }
}