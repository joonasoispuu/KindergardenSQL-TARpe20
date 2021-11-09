using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Absences
    {
        [Key]
        public int AbsenceId { get; set; }
        public DateTime DateOfAbsence { get; set; }
        public string Reason { get; set; }
    }
}
