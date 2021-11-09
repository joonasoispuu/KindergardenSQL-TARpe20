using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public  class Parent
    {
        [Key]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactEmail { get; set; }
        public IEnumerable<Child> Child { get; set; }
    }
}
