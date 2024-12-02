using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoltSharp.Models;

namespace DoltSharp.Services
{
    internal class ProjectServices
    {
        private readonly ProyectFile _proyectFile;

        public ProjectServices()
        {
            _proyectFile = new ProyectFile();
        }

        // Valida los campos del proyecto
        public bool ValidateProjectFields(string title, string description)
        {
            return !string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(description);
        }

        // Crea un nuevo proyecto
        public Project CreateProject(string title, string description, DateTime deadline)
        {
            return new Project
            {
                ProjectId = new Random().Next(1, 10000), // Generar un ID aleatorio
                ProjectTitle = title,
                ProjectDescription = description,
                ProjectDueDate = deadline,
                IsCompleteProject = false // Iniciar como incompleto
            };
        }

        // Guarda el proyecto en el archivo
        public void SaveProject(Project project)
        {
            _proyectFile.SaveProject(project);
        }
    }
}