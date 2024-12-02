using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DoltSharp.Services
{
    internal class LogInServices
    {
        private readonly string _filePath;

        public LogInServices(string filePath)
        {
            _filePath = filePath;
        }

        // Validar que los campos no estén vacíos
        public bool AreFieldsValid(string email, string password, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                errorMessage = "Los campos no deben estar vacíos.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        // Encriptar la contraseña en Base64
        public string EncryptPassword(string password)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
        }

        // Verificar credenciales del usuario
        public bool AuthenticateUser(string email, string encryptedPassword, out string userId)
        {
            userId = null;

            if (!File.Exists(_filePath))
            {
                throw new FileNotFoundException("No se encontró el archivo de usuarios registrados.");
            }

            var lines = File.ReadAllLines(_filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("ID: "))
                {
                    string currentUserId = lines[i].Substring(4).Trim();
                    string storedEmail = "";
                    string storedPassword = "";

                    for (int j = i + 1; j < lines.Length && !lines[j].StartsWith("-------------------------------"); j++)
                    {
                        if (lines[j].StartsWith("Correo: ")) storedEmail = lines[j].Substring(8).Trim();
                        else if (lines[j].StartsWith("Contraseña: ")) storedPassword = lines[j].Substring(12).Trim();
                    }

                    if (storedEmail == email && storedPassword == encryptedPassword)
                    {
                        userId = currentUserId;
                        return true;
                    }
                }
            }

            return false;
        }
    }
}