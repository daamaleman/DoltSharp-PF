using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoltSharp.Services
{
    internal class UserRegisterServices
    {
        private readonly UserRegisterFile _userRegisterFile;

        public UserRegisterServices(string filePath)
        {
            _userRegisterFile = new UserRegisterFile(filePath);
        }

        // Validar campos obligatorios
        public bool AreFieldsValid(string name, string lastName, string email, string password, string confirmPassword, DateTime birthDate, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                errorMessage = "Ninguno de los campos puede estar vacío.";
                return false;
            }

            if (birthDate.Year > 2006)
            {
                errorMessage = "La fecha no puede ser mayor al año 2006.";
                return false;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                errorMessage = "El correo no es válido.";
                return false;
            }

            if (password.Length < 8)
            {
                errorMessage = "La contraseña debe tener al menos 8 caracteres.";
                return false;
            }

            if (password != confirmPassword)
            {
                errorMessage = "Las contraseñas no coinciden.";
                return false;
            }

            errorMessage = string.Empty; // Sin errores
            return true;
        }

        // Verificar si el correo ya está registrado
        public bool IsEmailRegistered(string email)
        {
            return _userRegisterFile.IsEmailRegistered(email);
        }

        // Registrar usuario
        public void RegisterUser(string name, string lastName, string email, DateTime birthDate, string password)
        {
            _userRegisterFile.RegisterUser(name, lastName, email, birthDate, password);
        }
    }
}