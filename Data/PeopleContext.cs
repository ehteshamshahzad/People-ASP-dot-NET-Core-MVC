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
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Group> Groups { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonAddress>()
                .HasKey(t => new { t.PersonID, t.AddressID });

            modelBuilder.Entity<PersonAddress>()
                .HasOne(pt => pt.Person)
                .WithMany(p => p.PersonAddresses)
                .HasForeignKey(pt => pt.PersonID);

            modelBuilder.Entity<PersonAddress>()
                .HasOne(pt => pt.Address)
                .WithMany(t => t.PersonAddresses)
                .HasForeignKey(pt => pt.AddressID);



            modelBuilder.Entity<PersonGroup>()
                .HasKey(p => new { p.PersonID, p.GroupID });

            modelBuilder.Entity<PersonGroup>()
                .HasOne(pt => pt.Person)
                .WithMany(p => p.PersonGroups)
                .HasForeignKey(pt => pt.PersonID);

            modelBuilder.Entity<PersonGroup>()
                .HasOne(pt => pt.Group)
                .WithMany(t => t.PersonGroups)
                .HasForeignKey(pt => pt.GroupID);

        }

    }
}