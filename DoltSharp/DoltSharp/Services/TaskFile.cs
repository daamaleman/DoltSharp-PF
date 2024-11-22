using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoltSharp.Services;
using DoltSharp.Models;
using DoltSharp.Dao;

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

        // Agrega una nueva tarea al DAO y la guarda en el archivo.
        public void AddTask(string name, string description, DateTime deadline, string priority, string status)
        {
            var newTask = new DoltSharp.Models.Task
            {
                TaskId = GenerateRandomId(),
                TaskName = name,
                TaskDescription = description,
                TaskDeadline = deadline,
                TaskPriority = priority,
                TaskStatus = status
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
            using (var writer = new StreamWriter(_filePath, false)) // Abre el archivo en modo sobrescritura.
            {
                int taskCounter = 1; // Contador para asignar números a las tareas.

                foreach (var task in _taskDao.GetTasks())
                {
                    // Escribe la tarea en el archivo en el formato deseado.
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

                    taskCounter++; // Incrementa el contador para la próxima tarea.
                }
            }
        }

        // Carga todas las tareas desde el archivo y las agrega al DAO.
        private void LoadTasksFromFile()
        {
            DoltSharp.Models.Task task = null; // Variable para almacenar temporalmente una tarea.

            foreach (var line in File.ReadAllLines(_filePath)) // Lee el archivo línea por línea.
            {
                if (line.StartsWith("-------------------------------"))
                {
                    // Si hay una tarea previa, la agregamos al DAO.
                    if (task != null)
                    {
                        _taskDao.AddTask(task);
                    }

                    // Inicia una nueva tarea.
                    task = new DoltSharp.Models.Task();
                }
                else if (line.StartsWith("ID de la Tarea:"))
                {
                    task.TaskId = int.Parse(line.Replace("ID de la Tarea:", "").Trim());
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
                    task.TaskDeadline = DateTime.Parse(line.Replace("Fecha Límite:", "").Trim());
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

        // Genera un ID aleatorio de 4 dígitos para las tareas.
        private int GenerateRandomId()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
        }
    }
}