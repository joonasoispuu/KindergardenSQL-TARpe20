using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class GroupHistory
    {
        [Key]
        public int GroupHistoryId { get; set; }
        public DateTime BeginningDay { get; set; }
        public DateTime EndDay { get; set; }
    }
}
