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

        public ProyectFile()
        {
            // Define la ruta del archivo.
            _filePath = "ProyectsDoltSharp.txt";
        }

        // Guarda un proyecto en el archivo.
        public void SaveProject(Project project)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true)) // `true` permite agregar al archivo.
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

        // Carga todos los proyectos desde el archivo.
        public List<Project> LoadProjects()
        {
            var projects = new List<Project>();

            if (!File.Exists(_filePath)) // Verifica si el archivo existe.
            {
                return projects; // Devuelve una lista vacía si no existe.
            }

            var lines = File.ReadAllLines(_filePath);

            for (int i = 0; i < lines.Length; i += 7) // Cada proyecto ocupa 7 líneas.
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
                catch
                {
                    // Ignorar líneas mal formateadas.
                }
            }

            return projects;
        }

        // Devuelve la ruta del archivo.
        public string GetFilePath()
        {
            return _filePath;
        }
    }
}
