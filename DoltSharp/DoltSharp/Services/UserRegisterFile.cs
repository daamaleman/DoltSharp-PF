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
        private readonly string _directoryPath;

        public UserRegisterFile(string directoryPath)
        {
            _directoryPath = directoryPath;

            // Crear la carpeta si no existe
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }
        }

        /// <summary>
        /// Verifica si un correo ya está registrado.
        /// </summary>
        public bool IsEmailRegistered(string email)
        {
            foreach (var filePath in Directory.GetFiles(_directoryPath, "*.txt"))
            {
                var lines = File.ReadAllLines(filePath);
                if (lines.Any(line => line.Contains($"Correo: {email.Trim()}")))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Obtiene los datos del usuario basado en su ID.
        /// </summary>
        public Dictionary<string, string> GetUserDataById(string userId)
        {
            string userFilePath = Path.Combine(_directoryPath, $"{userId}.txt");

            if (!File.Exists(userFilePath))
                throw new FileNotFoundException("El archivo del usuario no existe.");

            var userData = new Dictionary<string, string>();
            foreach (var line in File.ReadAllLines(userFilePath))
            {
                if (line.Contains(":"))
                {
                    var parts = line.Split(new[] { ':' }, 2);
                    if (parts.Length == 2)
                    {
                        userData[parts[0].Trim()] = parts[1].Trim();
                    }
                }
            }
            return userData;
        }

        /// <summary>
        /// Actualiza los datos del usuario.
        /// </summary>
        public void UpdateUserData(string userId, string name, string lastName, string email, DateTime birthDate, string password)
        {
            string userFilePath = Path.Combine(_directoryPath, $"{userId}.txt");

            if (!File.Exists(userFilePath))
                throw new FileNotFoundException("El archivo del usuario no existe.");

            string encryptedPassword = Convert.ToBase64String(Encoding.UTF8.GetBytes(password));

            using (var writer = new StreamWriter(userFilePath, false))
            {
                writer.WriteLine("-------------------------------");
                writer.WriteLine($"ID: {userId}");
                writer.WriteLine($"Nombre: {name}");
                writer.WriteLine($"Apellido: {lastName}");
                writer.WriteLine($"Correo: {email}");
                writer.WriteLine($"Fecha de nacimiento: {birthDate:dd/MM/yyyy}");
                writer.WriteLine($"Contraseña: {encryptedPassword}");
                writer.WriteLine("-------------------------------");
            }
        }

        /// <summary>
        /// Valida si una contraseña coincide con la almacenada para un usuario.
        /// </summary>
        public bool ValidateUserPassword(string userId, string inputPassword)
        {
            var userData = GetUserDataById(userId);

            if (!userData.TryGetValue("Contraseña", out var encodedPassword))
                throw new InvalidOperationException("No se encontró la contraseña en los datos del usuario.");

            string decodedPassword = Encoding.UTF8.GetString(Convert.FromBase64String(encodedPassword));

            return decodedPassword == inputPassword;
        }
    }
}