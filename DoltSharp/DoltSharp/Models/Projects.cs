using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoltSharp.Models
{
    internal class Projects
    {
        public int ProjectId { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectDescription { get; set; }
        public DateTime ProjectDueDate { get; set; }
        public bool IsCompleteProject { get; set; }
    }
}
