using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Kitchen
    {
        [Key]
        public int KitchenId { get; set; }
        public string Cook { get; set; }
        public int MenuId { get; set; }
        public IEnumerable<Menu> Menu { get; set; }
        public IEnumerable<Employees> Employees { get; set; }
        

    }
}
