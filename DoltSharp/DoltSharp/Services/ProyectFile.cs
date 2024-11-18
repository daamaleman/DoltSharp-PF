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
            // Define el nombre del archivo.
            _filePath = "ProyectsDoltSharp.txt"; // Archivo con el nuevo nombre.
        }

        /// Guarda los datos del proyecto en el archivo.
        public void SaveProject(string name, string description, DateTime startDate, DateTime deadline, string resources)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true)) // `true` para agregar datos al archivo existente.
            {
                writer.WriteLine("-------------------------------");        //Añadir proyectID
                writer.WriteLine("Nombre del Proyecto: " + name.Trim());
                writer.WriteLine("Descripción: " + description.Trim());
                writer.WriteLine("Fecha de Inicio: " + startDate.ToShortDateString());
                writer.WriteLine("Fecha Límite: " + deadline.ToShortDateString());
                writer.WriteLine("Asignaciones de Recursos: " + resources.Trim());
                writer.WriteLine("-------------------------------");
            }
        }
    }
}