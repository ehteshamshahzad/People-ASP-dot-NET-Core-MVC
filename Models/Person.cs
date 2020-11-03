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

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }
        
        [StringLength(100)]
        public string Address { get; set; }
    }
}