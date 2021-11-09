using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Queue
    {
        [Key]
        public int QueueId { get; set; }
        public string QueueType { get; set; }
        public IEnumerable<Group> Group { get; set; }
    }
}
