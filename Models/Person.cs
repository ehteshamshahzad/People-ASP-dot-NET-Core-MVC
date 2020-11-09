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

        [StringLength(50)]
        public string FullName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PrimaryNumber { get; set; }
        
        public List<PhoneNumber> SecondaryNumbers { get; set; }
 
        [EmailAddress]
        public string Email { get; set; }

        public List<PersonAddress> PersonAddresses { get; set; }

        public List<PersonGroup> PersonGroups { get; set; }
    }
}