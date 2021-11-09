using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public int AgeGroup{ get; set; }
        public int ChildrenAmount { get; set; }
        public ICollection<Child> Children { get; set; }
        public ICollection<Employees> Employees { get; set; }
        public ICollection<Kitchen> Kitchen { get; set; }
    }
}
