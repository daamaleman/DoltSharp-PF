using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoltSharp.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; } 
        public string TaskDescription { get; set; } 
        public DateTime TaskDeadline { get; set; } 
        public string TaskPriority { get; set; } 
        public string TaskStatus { get; set; } 
    }
}