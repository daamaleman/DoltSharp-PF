using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoltSharp.Services
{
    internal class TaskFile
    {
        private readonly string _filePath;

        // Constructor: inicializa la clase con la ruta del archivo donde se guardarán las tareas.
        public TaskFile()
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TasksDoltSharp.txt");

            // Si el archivo no existe, lo crea vacío.
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
            }
        }

        // Método para guardar una nueva tarea en el archivo.
        public void SaveTask(string name, string description, DateTime deadline, string priority, string status)
        {
            ValidateTaskFields(name, description, deadline, priority, status);

            // Escribe los datos de la tarea en el archivo de forma organizada.
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine("-------------------------------");
                writer.WriteLine($"Nombre: {name.Trim()}");
                writer.WriteLine($"Descripción: {description.Trim()}");
                writer.WriteLine($"Fecha Límite: {deadline:yyyy-MM-dd}");
                writer.WriteLine($"Prioridad: {priority.Trim()}");
                writer.WriteLine($"Estado: {status.Trim()}");
                writer.WriteLine("-------------------------------");
            }
        }

        // Método para leer todas las tareas almacenadas en el archivo.
        public List<string> ReadTasks()
        {
            if (!File.Exists(_filePath))
                throw new FileNotFoundException("El archivo de tareas no existe.");

            return new List<string>(File.ReadAllLines(_filePath));
        }

        // Método para borrar todas las tareas del archivo.
        public void ClearTasks()
        {
            // Limpia el archivo eliminando todo su contenido.
            File.WriteAllText(_filePath, string.Empty);
        }

        // Método privado para validar los datos de la tarea.
        private void ValidateTaskFields(string name, string description, DateTime deadline, string priority, string status)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("El nombre de la tarea no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("La descripción no puede estar vacía.");
            if (string.IsNullOrWhiteSpace(priority))
                throw new ArgumentException("La prioridad no puede estar vacía.");
            if (string.IsNullOrWhiteSpace(status))
                throw new ArgumentException("El estado no puede estar vacío.");
            if (deadline < DateTime.Now.Date)
                throw new ArgumentException("La fecha límite no puede ser anterior a hoy.");
        }
    }
}