using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Employees
    {
        [Key]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactEmail { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Position { get; set; }
        public int Payment { get; set; }
        public DateTime WorkStart { get; set; }
        public DateTime WorkEnd { get; set; }
        public IEnumerable<Absences> Absence { get; set; }
        public IEnumerable<GroupHistory> GroupHistory { get; set; }
        public IEnumerable<Job> Job { get; set; }
        public IEnumerable<Group> Group { get; set; }
    }
}
