using DoltSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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
            var projects = new List<Project>();

            // Obtiene la ruta del archivo usando ProyectFile
            string filePath = _proyectFile.GetFilePath();

            if (!File.Exists(filePath)) // Verifica si el archivo existe.
            {
                return projects; // Devuelve una lista vacía si no existe.
            }

            // Lee todo el contenido del archivo
            var lines = File.ReadAllLines(filePath);
            var currentProject = new Project();

            for (int i = 0; i < lines.Length; i++)
            {
                try
                {
                    var line = lines[i].Trim();

                    // Identifica las líneas relevantes basadas en su contenido
                    if (line.StartsWith("ID del Proyecto:"))
                    {
                        currentProject.ProjectId = int.Parse(line.Split(':')[1].Trim());
                    }
                    else if (line.StartsWith("Nombre del Proyecto:"))
                    {
                        currentProject.ProjectTitle = line.Split(':')[1].Trim();
                    }
                    else if (line.StartsWith("Descripción:"))
                    {
                        currentProject.ProjectDescription = line.Split(':')[1].Trim();
                    }
                    else if (line.StartsWith("Fecha Límite:"))
                    {
                        currentProject.ProjectDueDate = DateTime.Parse(line.Split(':')[1].Trim());
                    }
                    else if (line.StartsWith("Estado:"))
                    {
                        currentProject.IsCompleteProject = line.Contains("Completado");
                    }
                    if (line == "-------------------------------")
                    {
                        if (!string.IsNullOrWhiteSpace(currentProject.ProjectTitle))
                        {
                            projects.Add(currentProject);
                        }
                        currentProject = new Project(); // Reinicia para el siguiente proyecto
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error procesando línea {i + 1}: {ex.Message}");
                }
            }

            return projects;
        }

        public void SaveProjects(List<Project> projects)
        {
            // Obtiene la ruta del archivo desde la instancia de ProyectFile
            string filePath = _proyectFile.GetFilePath();

            // Limpia el contenido del archivo
            File.WriteAllText(filePath, string.Empty);

            // Guarda todos los proyectos en el archivo
            foreach (var project in projects)
            {
                _proyectFile.SaveProject(project);
            }
        }

        public List<DoltSharp.Models.Task> LoadTasks()
        {
            var tasks = _taskFile.GetAllTasks();
            return tasks ?? new List<DoltSharp.Models.Task>();
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