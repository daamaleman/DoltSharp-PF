using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoltSharp.Models
{
    public class Task
    {
        public int TaskId { get; set; } // Identificador único.
        public string TaskName { get; set; } // Nombre de la tarea.
        public string TaskDescription { get; set; } // Descripción de la tarea.
        public DateTime TaskDeadline { get; set; } // Fecha límite.
        public string TaskPriority { get; set; } // Prioridad de la tarea (e.g., Alta, Media, Baja).
        public string TaskStatus { get; set; } // Estado de la tarea (e.g., Pendiente, En Proceso, Completada).
    }
}