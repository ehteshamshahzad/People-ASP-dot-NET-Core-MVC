using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace People.Models
{
    public class Person
    {
        public int ID { get; set; }

        public Name PersonName { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public List<PersonAddress> PersonAddresses { get; set; }

    }
}