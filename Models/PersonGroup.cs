using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace People.Models
{
    public class PersonGroup
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }

        public int GroupID { get; set; }
        public Group Group { get; set; }
    }
}