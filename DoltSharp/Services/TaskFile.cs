using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoltSharp.Services;
using DoltSharp.Models;
using DoltSharp.Dao;
using System.Globalization;

namespace DoltSharp.Services
{
    public class TaskFile
    {
        private readonly TaskDao _taskDao; // DAO para manejar tareas en memoria.
        private readonly string _filePath; // Ruta del archivo donde se guardarán las tareas.

        // Constructor que inicializa el DAO y define la ruta del archivo.
        public TaskFile()
        {
            _taskDao = new TaskDao();
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TasksDoltSharp.txt");

            // Si el archivo ya existe se cargan las tareas desde el archivo.
            if (File.Exists(_filePath))
            {
                LoadTasksFromFile();
            }
        }

        // Método público para obtener la ruta del archivo
        public string GetFilePath()
        {
            return _filePath;
        }

        // Agrega una nueva tarea al DAO y la guarda en el archivo.
        public void AddTask(string name, string description, DateTime deadline, string priority, string status)
        {
            // Validar fecha límite
            if (deadline == DateTime.MinValue || deadline.Year < 1900)
            {
                deadline = DateTime.Now; // Fecha predeterminada
            }

            var newTask = new DoltSharp.Models.Task
            {
                TaskId = GenerateRandomId(), // Genera un ID aleatorio
                TaskName = name,
                TaskDescription = description,
                TaskDeadline = deadline,
                TaskPriority = priority,
                TaskStatus = string.IsNullOrEmpty(status) ? "Pendiente" : status // Validar estado
            };

            // Verifica si ya existe una tarea con el mismo ID antes de agregarla
            if (!_taskDao.GetTasks().Any(t => t.TaskId == newTask.TaskId))
            {
                _taskDao.AddTask(newTask);
                SaveTasksToFile();
            }
            else
            {
                Console.WriteLine($"La tarea con ID {newTask.TaskId} ya existe. Ignorando...");
            }
        }

        private int GenerateRandomId()
        {
            Random random = new Random();
            return random.Next(1000, 9999); // Genera un número entre 1000 y 9999
        }

        // Devuelve todas las tareas almacenadas en el DAO.
        public List<DoltSharp.Models.Task> GetAllTasks()
        {
            return _taskDao.GetTasks();
        }

        public void DeleteTask(int id)
        {
            _taskDao.DeleteTaskById(id); // Elimina la tarea del DAO.
            SaveTasksToFile(); // Guarda los cambios en el archivo.
        }

        // Guarda todas las tareas actuales en el archivo con el formato especificado.
        private void SaveTasksToFile()
        {
            try
            {
                using (var writer = new StreamWriter(_filePath, false))
                {
                    var validTasks = _taskDao.GetTasks().Where(IsValidTask).ToList();
                    if (!validTasks.Any())
                    {
                        Console.WriteLine("No hay tareas válidas para guardar.");
                        return;
                    }

                    int taskCounter = 1;
                    foreach (var task in validTasks)
                    {
                        writer.WriteLine("-------------------------------");
                        writer.WriteLine($"Tarea: {taskCounter}");
                        writer.WriteLine($"ID de la Tarea: {task.TaskId}");
                        writer.WriteLine($"Nombre de la Tarea: {task.TaskName}");
                        writer.WriteLine($"Descripción: {task.TaskDescription}");
                        writer.WriteLine($"Fecha de Inicio: {DateTime.Now:dd/MM/yyyy}");
                        writer.WriteLine($"Fecha Límite: {task.TaskDeadline:dd/MM/yyyy}");
                        writer.WriteLine($"Prioridad: {task.TaskPriority}");
                        writer.WriteLine($"Estado: {task.TaskStatus}");
                        writer.WriteLine("-------------------------------");
                        taskCounter++;
                    }

                    Console.WriteLine($"{validTasks.Count} tareas guardadas exitosamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar las tareas en el archivo: {ex.Message}");
            }
        }
        // Carga todas las tareas desde el archivo y las agrega al DAO.
        private void LoadTasksFromFile()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    DoltSharp.Models.Task task = null;

                    foreach (var line in File.ReadAllLines(_filePath))
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        if (line.StartsWith("-------------------------------"))
                        {
                            if (task != null && IsValidTask(task))
                            {
                                if (!_taskDao.GetTasks().Any(t => t.TaskId == task.TaskId))
                                {
                                    _taskDao.AddTask(task);
                                }
                            }
                            task = new DoltSharp.Models.Task(); // Nueva tarea
                        }
                        else if (line.StartsWith("ID de la Tarea:"))
                        {
                            if (int.TryParse(line.Replace("ID de la Tarea:", "").Trim(), out int id))
                            {
                                task.TaskId = id;
                            }
                        }
                        else if (line.StartsWith("Nombre de la Tarea:"))
                        {
                            task.TaskName = line.Replace("Nombre de la Tarea:", "").Trim();
                        }
                        else if (line.StartsWith("Descripción:"))
                        {
                            task.TaskDescription = line.Replace("Descripción:", "").Trim();
                        }
                        else if (line.StartsWith("Fecha Límite:"))
                        {
                            if (DateTime.TryParseExact(line.Replace("Fecha Límite:", "").Trim(),
                                "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime deadline))
                            {
                                task.TaskDeadline = deadline;
                            }
                        }
                        else if (line.StartsWith("Prioridad:"))
                        {
                            task.TaskPriority = line.Replace("Prioridad:", "").Trim();
                        }
                        else if (line.StartsWith("Estado:"))
                        {
                            task.TaskStatus = line.Replace("Estado:", "").Trim();
                        }
                    }

                    // Agregar la última tarea si es válida
                    if (task != null && IsValidTask(task))
                    {
                        if (!_taskDao.GetTasks().Any(t => t.TaskId == task.TaskId))
                        {
                            _taskDao.AddTask(task);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar las tareas desde el archivo: {ex.Message}");
            }
        }


        // Método auxiliar para validar si una tarea está completa
        private bool IsValidTask(DoltSharp.Models.Task task)
        {
            return !string.IsNullOrEmpty(task.TaskName) &&
                   !string.IsNullOrEmpty(task.TaskDescription) &&
                   task.TaskDeadline != DateTime.MinValue &&
                   !string.IsNullOrEmpty(task.TaskPriority) &&
                   !string.IsNullOrEmpty(task.TaskStatus);
        }

        // Genera un ID único para las tareas.
        private int GenerateUniqueId()
        {
            // Obtiene el mayor ID de las tareas existentes
            var maxId = _taskDao.GetTasks().Select(t => t.TaskId).DefaultIfEmpty(999).Max();
            return maxId + 1; // Incrementa el ID máximo en 1
        }
    }
}