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

        // Cargar la lista de proyectos desde el archivo
        public List<Project> LoadProjects()
        {
            var projects = new List<Project>();
            string filePath = _proyectFile.GetFilePath();

            if (!File.Exists(filePath))
            {
                return projects; // Retorna lista vacía si no existe el archivo
            }

            var lines = File.ReadAllLines(filePath);
            var currentProject = new Project();

            for (int i = 0; i < lines.Length; i++)
            {
                try
                {
                    var line = lines[i].Trim();

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
                        if (!DateTime.TryParse(line.Split(':')[1].Trim(), out var dueDate))
                        {
                            dueDate = DateTime.Now; // Establece una fecha predeterminada si no es válida
                        }
                        currentProject.ProjectDueDate = dueDate;
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
                        currentProject = new Project(); // Reinicia el proyecto para la siguiente iteración
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error procesando línea {i + 1}: {ex.Message}");
                }
            }

            return projects;
        }

        // Guardar la lista de proyectos en el archivo
        public void SaveProjects(List<Project> projects)
        {
            string filePath = _proyectFile.GetFilePath();

            File.WriteAllText(filePath, string.Empty); // Limpia el archivo antes de guardar

            foreach (var project in projects)
            {
                _proyectFile.SaveProject(project);
            }
        }

        public List<DoltSharp.Models.Task> GetAllTasks()
        {
            var tasks = new List<DoltSharp.Models.Task>();

            // Obtén la ruta del archivo desde _taskFile
            string filePath = _taskFile.GetFilePath();

            // Verifica si el archivo existe
            if (!File.Exists(filePath))
            {
                Console.WriteLine("El archivo de tareas no existe. Retornando lista vacía.");
                return tasks;
            }

            // Leer todas las líneas del archivo
            var lines = File.ReadAllLines(filePath);

            Console.WriteLine($"Total de líneas encontradas en el archivo: {lines.Length}");

            // Iterar sobre las líneas
            foreach (var line in lines)
            {
                try
                {
                    // Ignorar líneas vacías
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        Console.WriteLine("Línea vacía encontrada. Saltando.");
                        continue;
                    }

                    // Dividir la línea en columnas
                    var columns = line.Split(',');

                    Console.WriteLine($"Procesando línea: {line}");

                    // Validar que haya al menos 6 columnas
                    if (columns.Length < 6)
                    {
                        Console.WriteLine($"Línea con formato inválido: {line}. Columnas esperadas: 6, encontradas: {columns.Length}");
                        continue;
                    }

                    // Crear la tarea y validar cada campo
                    var task = new DoltSharp.Models.Task
                    {
                        TaskId = int.TryParse(columns[0], out int taskId) ? taskId : -1,
                        TaskName = columns[1].Trim(),
                        TaskDescription = columns[2].Trim(),
                        TaskDeadline = DateTime.TryParse(columns[3], out DateTime deadline) ? deadline : DateTime.MinValue,
                        TaskPriority = columns[4].Trim(),
                        TaskStatus = string.IsNullOrEmpty(columns[5]) ? "Pendiente" : columns[5].Trim()
                    };

                    // Validar ID y Fecha
                    if (task.TaskId == -1)
                    {
                        Console.WriteLine($"ID inválido en la línea: {line}. Tarea no agregada.");
                        continue;
                    }

                    if (task.TaskDeadline == DateTime.MinValue)
                    {
                        Console.WriteLine($"Fecha inválida en la línea: {line}. Asignando fecha actual.");
                        task.TaskDeadline = DateTime.Now; // Fecha predeterminada
                    }

                    // Agregar la tarea a la lista
                    tasks.Add(task);
                    Console.WriteLine($"Tarea agregada: {task.TaskName}, Fecha Límite: {task.TaskDeadline}");
                }
                catch (Exception ex)
                {
                    // Capturar errores y continuar con las demás líneas
                    Console.WriteLine($"Error procesando línea: {line}. Detalles: {ex.Message}");
                }
            }

            return tasks;
        }

        // Cargar la lista de tareas desde el archivo
        public List<DoltSharp.Models.Task> LoadTasks()
        {
            var tasks = _taskFile.GetAllTasks() ?? new List<DoltSharp.Models.Task>();

            foreach (var task in tasks)
            {
                // Reemplazar fechas inválidas
                if (task.TaskDeadline == DateTime.MinValue || task.TaskDeadline.Year < 1900)
                {
                    task.TaskDeadline = DateTime.Now; // Fecha predeterminada
                }

                // Validar estado
                task.TaskStatus = string.IsNullOrEmpty(task.TaskStatus) ? "Pendiente" : task.TaskStatus;
            }

            return tasks;
        }

        // Guardar la lista de tareas en el archivo
        public void SaveTasks(List<DoltSharp.Models.Task> tasks)
        {
            string filePath = _taskFile.GetFilePath();

            File.WriteAllText(filePath, string.Empty); // Limpia el archivo antes de guardar

            foreach (var task in tasks)
            {
                // Reemplazar fechas inválidas antes de guardar
                if (task.TaskDeadline == DateTime.MinValue || task.TaskDeadline.Year < 1900)
                {
                    task.TaskDeadline = DateTime.Now; // Fecha predeterminada
                }

                task.TaskStatus = string.IsNullOrEmpty(task.TaskStatus) ? "Pendiente" : task.TaskStatus;

                _taskFile.AddTask(
                    task.TaskName,
                    task.TaskDescription,
                    task.TaskDeadline,
                    task.TaskPriority,
                    task.TaskStatus
                );
            }
        }

        // Eliminar una tarea por su ID
        public void DeleteTask(int taskId)
        {
            _taskFile.DeleteTask(taskId);
        }

        // Obtener detalles de un proyecto
        public string GetProjectDetails(Project project)
        {
            return $"Título: {project.ProjectTitle}\n" +
                   $"Descripción: {project.ProjectDescription}\n" +
                   $"Fecha Límite: {project.ProjectDueDate.ToShortDateString()}\n" +
                   $"Estado: {(project.IsCompleteProject ? "Completado" : "En progreso")}";
        }

        // Obtener detalles de una tarea
        public string GetTaskDetails(DoltSharp.Models.Task task)
        {
            return $"Nombre: {task.TaskName}\n" +
                   $"Descripción: {task.TaskDescription}\n" +
                   $"Fecha Límite: {task.TaskDeadline:dd/MM/yyyy}\n" +
                   $"Prioridad: {task.TaskPriority}\n" +
                   $"Estado: {task.TaskStatus}";
        }

        // Nuevo: Obtener proyectos con formato válido
        public List<Project> GetFormattedProjects()
        {
            var projects = LoadProjects();

            foreach (var project in projects)
            {
                // Asegura valores válidos para el ComboBox
                if (!project.IsCompleteProject)
                {
                    project.IsCompleteProject = false; // Por defecto, no completado
                }
            }

            return projects;
        }

        // Nuevo: Obtener tareas con formato válido
        public List<DoltSharp.Models.Task> GetFormattedTasks()
        {
            var tasks = LoadTasks();

            foreach (var task in tasks)
            {
                // Asegura que los estados sean válidos
                task.TaskStatus = task.TaskStatus ?? "Pendiente";
            }

            return tasks;
        }
    }
}
