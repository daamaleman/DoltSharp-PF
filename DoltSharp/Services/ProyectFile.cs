using DoltSharp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoltSharp.Services
{
    internal class ProyectFile
    {
        private readonly string _filePath;

        // Constructor que define la ruta del archivo
        public ProyectFile()
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ProyectsDoltSharp.txt");
        }

        // Método para guardar un proyecto en el archivo
        public void SaveProject(Project project)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true)) // `true` permite agregar al archivo
            {
                writer.WriteLine("-------------------------------");
                writer.WriteLine("ID del Proyecto: " + project.ProjectId);
                writer.WriteLine("Nombre del Proyecto: " + project.ProjectTitle.Trim());
                writer.WriteLine("Descripción: " + project.ProjectDescription.Trim());
                writer.WriteLine("Fecha de Inicio: " + DateTime.Now.ToShortDateString());
                writer.WriteLine("Fecha Límite: " + project.ProjectDueDate.ToShortDateString());
                writer.WriteLine("Estado: " + (project.IsCompleteProject ? "Completado" : "En progreso"));
                writer.WriteLine("-------------------------------");
            }
        }

        // Método para cargar todos los proyectos desde el archivo
        public List<Project> LoadProjects()
        {
            var projects = new List<Project>();

            if (!File.Exists(_filePath))
            {
                return projects; // Devuelve una lista vacía si no existe
            }

            var lines = File.ReadAllLines(_filePath);

            for (int i = 0; i < lines.Length; i += 7) // Cada proyecto ocupa 7 líneas
            {
                try
                {
                    var project = new Project
                    {
                        ProjectId = int.Parse(lines[i + 1].Split(':')[1].Trim()),
                        ProjectTitle = lines[i + 2].Split(':')[1].Trim(),
                        ProjectDescription = lines[i + 3].Split(':')[1].Trim(),
                        ProjectDueDate = DateTime.Parse(lines[i + 4].Split(':')[1].Trim()),
                        IsCompleteProject = lines[i + 5].Contains("Completado")
                    };
                    projects.Add(project);
                }
                catch (Exception ex)
                {
                    // Log para proyectos mal formateados
                    Console.WriteLine($"Error al procesar proyecto en línea {i + 1}: {ex.Message}");
                }
            }

            return projects;
        }

        // Alias para cargar todos los proyectos
        public List<Project> GetAllProjects()
        {
            return LoadProjects();
        }

        // Método para obtener la ruta del archivo
        public string GetFilePath()
        {
            return _filePath;
        }

        // Método para eliminar todos los proyectos del archivo
        public void ClearProjects()
        {
            File.WriteAllText(_filePath, string.Empty); // Limpia el contenido del archivo
        }

        // Método para eliminar un proyecto específico por ID
        public void DeleteProject(int projectId)
        {
            var projects = LoadProjects(); // Carga todos los proyectos
            var updatedProjects = projects.Where(p => p.ProjectId != projectId).ToList(); // Filtra los proyectos

            ClearProjects(); // Limpia el archivo
            foreach (var project in updatedProjects)
            {
                SaveProject(project); // Guarda los proyectos restantes
            }
        }
    }
}