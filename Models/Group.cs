using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace People.Models
{
    public class Group
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string GroupName { get; set; }

        public List<PersonGroup> PersonGroups { get; set; }
    }
}