using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsTask = DoltSharp.Models.Task;
using DoltSharp.Models;

namespace DoltSharp.Services
{
    internal class TaskServices
    {
        private readonly TaskFile _taskFile;

        public TaskServices()
        {
            _taskFile = new TaskFile();
        }

        // Valida los datos de una tarea antes de guardarla
        public bool ValidateTask(string name, string description, string priority, string status, DateTime deadline, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                errorMessage = "El nombre de la tarea no puede estar vacío.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                errorMessage = "La descripción no puede estar vacía.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(priority))
            {
                errorMessage = "Debes seleccionar una prioridad.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(status))
            {
                errorMessage = "Debes seleccionar un estado.";
                return false;
            }

            if (deadline < DateTime.Now.Date)
            {
                errorMessage = "La fecha límite no puede ser anterior a hoy.";
                return false;
            }

            errorMessage = string.Empty; // Sin errores
            return true;
        }

        // Agrega una tarea utilizando TaskFile
        public void AddTask(string name, string description, DateTime deadline, string priority, string status)
        {
            _taskFile.AddTask(name, description, deadline, priority, status);
        }

        // Devuelve tareas próximas a vencer o ya vencidas
        public List<ModelsTask> GetTasksDueSoon()
        {
            // Obtener todas las tareas desde TaskFile
            var tasks = _taskFile.GetAllTasks();
            var dueTasks = new List<ModelsTask>();

            foreach (var task in tasks) // task ahora es ModelsTask
            {
                TimeSpan timeRemaining = task.TaskDeadline - DateTime.Now;

                if (timeRemaining.TotalHours > 0 && timeRemaining.TotalHours <= 24)
                {
                    // Tarea próxima a vencer
                    dueTasks.Add(task);
                }
                else if (timeRemaining.TotalHours <= 0)
                {
                    // Tarea ya vencida
                    dueTasks.Add(task);
                }
            }

            return dueTasks;
        }

        // Maneja el flujo completo de notificaciones
        public List<ModelsTask> HandleNotifications()
        {
            // Devuelve las tareas vencidas o próximas a vencer
            return GetTasksDueSoon();
        }
    }
}