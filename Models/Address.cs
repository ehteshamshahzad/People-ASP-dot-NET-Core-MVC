using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace People.Models
{
    public class Address
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Location { get; set; }
        public List<PersonAddress> PersonAddresses { get; set; }
    }
}