using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMgr.Shared
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        public JobLocation TaskLocation { get; set; }
        public string? JobDetail { get; set; }
        public Worker? AssignTo { get; set; }

        public int Status { get; set; }  // 0 is not Assign, 1 is Assigned and running, 2 is complted, 3 is failed ,4 Close
        public DateTime? CompletedDate { get; set; }
        public string? CompletedNote{ get; set; }
        public DateTime? FailedDate { get; set; }
        public string? FailedNote{ get; set; }
        public DateTime? AssignedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
