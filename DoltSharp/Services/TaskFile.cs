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
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(priority))
            {
                throw new ArgumentException("Todos los campos son obligatorios.");
            }

            if (deadline < DateTime.Now.Date)
            {
                throw new ArgumentException("La fecha límite no puede ser anterior a hoy.");
            }

            var newTask = new DoltSharp.Models.Task
            {
                TaskId = GenerateRandomId(),
                TaskName = name,
                TaskDescription = description,
                TaskDeadline = deadline,
                TaskPriority = priority,
                TaskStatus = string.IsNullOrEmpty(status) ? "Pendiente" : status
            };

            _taskDao.AddTask(newTask);
            SaveTasksToFile();
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
            var lines = new List<string>();
            int taskCounter = 1;

            foreach (var task in _taskDao.GetTasks())
            {
                lines.Add("-------------------------------");
                lines.Add($"Tarea: {taskCounter}");
                lines.Add($"ID de la Tarea: {task.TaskId}");
                lines.Add($"Nombre de la Tarea: {task.TaskName}");
                lines.Add($"Descripción: {task.TaskDescription}");
                lines.Add($"Fecha de Inicio: {DateTime.Now:dd/MM/yyyy}");
                lines.Add($"Fecha Límite: {task.TaskDeadline:dd/MM/yyyy}");
                lines.Add($"Prioridad: {task.TaskPriority}");
                lines.Add($"Estado: {task.TaskStatus}");
                lines.Add("-------------------------------");

                taskCounter++;
            }

            File.WriteAllLines(_filePath, lines);
        }

        // Carga todas las tareas desde el archivo y las agrega al DAO.
        private void LoadTasksFromFile()
        {
            try
            {
                DoltSharp.Models.Task task = null;

                foreach (var line in File.ReadAllLines(_filePath))
                {
                    if (line.StartsWith("-------------------------------"))
                    {
                        if (task != null)
                        {
                            _taskDao.AddTask(task);
                        }
                        task = new DoltSharp.Models.Task();
                    }
                    else if (line.StartsWith("ID de la Tarea:"))
                    {
                        if (int.TryParse(line.Replace("ID de la Tarea:", "").Trim(), out int id))
                        {
                            task.TaskId = id;
                        }
                        else
                        {
                            Console.WriteLine($"Error al leer el ID de la tarea. Línea: {line}");
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
                        string fechaTexto = line.Replace("Fecha Límite:", "").Trim();
                        if (DateTime.TryParseExact(
                                fechaTexto,
                                "dd/MM/yyyy",
                                new System.Globalization.CultureInfo("es-ES"),
                                System.Globalization.DateTimeStyles.None,
                                out DateTime fecha))
                        {
                            task.TaskDeadline = fecha;
                        }
                        else
                        {
                            Console.WriteLine($"Advertencia: Fecha inválida encontrada ('{fechaTexto}'). Asignando fecha actual.");
                            task.TaskDeadline = DateTime.Now;
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

                if (task != null)
                {
                    _taskDao.AddTask(task);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar tareas desde el archivo: {ex.Message}");
            }
        }

        // Genera un ID único para las tareas.
        private int GenerateRandomId()
        {
            var tasks = _taskDao.GetTasks();
            return tasks.Any() ? tasks.Max(t => t.TaskId) + 1 : 1;
        }
    }
}