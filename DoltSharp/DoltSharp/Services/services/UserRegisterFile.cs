using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoltSharp.Services
{
    internal class UserRegisterFile
    {
        private readonly string _filePath;

        public UserRegisterFile(string filePath)
        {
            _filePath = filePath;
        }

        /// Verifica si un correo ya está registrado en el archivo.
        public bool IsEmailRegistered(string email)
        {
            if (!File.Exists(_filePath))
                return false;

            return File.ReadAllLines(_filePath).Any(line => line.Contains("Correo: " + email.Trim()));
        }

        /// Registra un usuario en el archivo.
        public void RegisterUser(string name, string lastName, string email, DateTime birthDate, string password)
        {
            // Generar ID único
            string userId = GenerateUniqueUserId();

            // Encriptar contraseña
            string encryptedPassword = EncryptPassword(password);

            // Guardar datos
            SaveUser(userId, name, lastName, email, birthDate, encryptedPassword);
        }

        /// Genera un ID único para el usuario.
        private string GenerateUniqueUserId()
        {
            Random random = new Random();
            string userId;
            do
            {
                userId = "USR" + random.Next(10000, 99999);
            } while (File.Exists(_filePath) && File.ReadAllLines(_filePath).Any(line => line.Contains("ID: " + userId)));

            return userId;
        }

        /// Encripta una contraseña usando Base64.
        private string EncryptPassword(string password)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
        }

        /// Guarda los datos del usuario en el archivo.
        private void SaveUser(string userId, string name, string lastName, string email, DateTime birthDate, string encryptedPassword)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine("-------------------------------");
                writer.WriteLine("ID: " + userId); // Guardar el ID único
                writer.WriteLine("Nombre: " + name.Trim());
                writer.WriteLine("Apellido: " + lastName.Trim());
                writer.WriteLine("Correo: " + email.Trim());
                writer.WriteLine("Fecha de nacimiento: " + birthDate.ToShortDateString());
                writer.WriteLine("Contraseña: " + encryptedPassword); // Contraseña encriptada
                writer.WriteLine("-------------------------------");
            }
        }
    }
}