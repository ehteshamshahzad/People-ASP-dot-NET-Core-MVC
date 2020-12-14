using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using People.Data;

namespace People.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UsersContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<UsersContext>>()))
            {
                // Look for any movies.
                if (context.Users.Any())
                {
                    return;   // DB has been seeded
                }

                context.Users.AddRange(
                    new User
                    {
                        Name = "Gary Chester",
                        Email = "GaryChester@gmail.com",
                        Password = "chesterPasswordISTRONG!",
                        PhoneNumber = "0900780601",
                        IsActive = true
                    },

                    new User
                    {
                        Name = "Randy Kline",
                        Email = "Randy@Kline@.com",
                        Password = "Qwertyuiop!",
                        PhoneNumber = "0110885621",
                        IsActive = true
                    },

                    new User
                    {
                        Name = "Mccauley Doherty",
                        Email = "Doherty@outlook.com",
                        Password = "password1!",
                        PhoneNumber = "0213778509",
                        IsActive = true
                    },

                    new User
                    {
                        Name = "Louise Lyons",
                        Email = "Louise@gmail.com",
                        Password = "Es!u0l$n0yl",
                        PhoneNumber = "0753154952",
                        IsActive = true
                    }
                );
                context.SaveChanges();
            }
        }
    }
}