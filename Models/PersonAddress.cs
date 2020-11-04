using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace People.Models
{
    public class PersonAddress
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }

        public int AddressID { get; set; }
        public Address Address { get; set; }
    }
}