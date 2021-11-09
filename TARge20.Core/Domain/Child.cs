using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{

    public class Child
    {
        [Key]
        public int ChildId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public ICollection<GroupHistory> groupHistory { get; set; }
        public int GroupId { get; set; }
        public IEnumerable<Group> Group { get; set; }
        public int AbsenceId { get; set; }
        public IEnumerable<Absences> Absence { get; set; }
        public IEnumerable<Parent> Parent { get; set; }
    }
}
