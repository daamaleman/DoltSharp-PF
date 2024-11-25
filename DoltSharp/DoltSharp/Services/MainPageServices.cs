using DoltSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoltSharp.Services
{
    internal class MainPageServices
    {
        private readonly ProyectFile _proyectFile;
        private readonly TaskFile _taskFile;

        public MainPageServices()
        {
            _proyectFile = new ProyectFile();
            _taskFile = new TaskFile();
        }

        public List<Project> LoadProjects()
        {
            var projects = _proyectFile.LoadProjects();
            return projects ?? new List<Project>(); // Evitar null usando ??.
        }

        public void SaveProjects(List<Project> projects)
        {
            System.IO.File.WriteAllText(_proyectFile.GetFilePath(), string.Empty);

            foreach (var project in projects)
            {
                _proyectFile.SaveProject(project);
            }
        }

        public List<DoltSharp.Models.Task> LoadTasks()
        {
            var tasks = _taskFile.GetAllTasks();
            return tasks ?? new List<DoltSharp.Models.Task>(); // Evitar null usando ??.
        }

        public void DeleteTask(int taskId)
        {
            _taskFile.DeleteTask(taskId);
        }

        public string GetProjectDetails(Project project)
        {
            return $"Título: {project.ProjectTitle}\n" +
                   $"Descripción: {project.ProjectDescription}\n" +
                   $"Fecha de Inicio: {DateTime.Now.ToShortDateString()}\n" +
                   $"Fecha Límite: {project.ProjectDueDate.ToShortDateString()}\n" +
                   $"Estado: {(project.IsCompleteProject ? "Completado" : "En progreso")}";
        }

        public string GetTaskDetails(DoltSharp.Models.Task task)
        {
            return $"Nombre: {task.TaskName}\n" +
                   $"Descripción: {task.TaskDescription}\n" +
                   $"Fecha Límite: {task.TaskDeadline:dd/MM/yyyy}\n" +
                   $"Prioridad: {task.TaskPriority}\n" +
                   $"Estado: {task.TaskStatus}";
        }
    }
}