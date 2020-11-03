using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace People.Models
{
    public class PhoneNumber
    {
        public int ID { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Number { get; set; }
        public int PersonID { get; set; }
        public Person Person { get; set; }
    }
}