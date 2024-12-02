using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DoltSharp.Services
{
    internal class UserConfigServices
    {
        private readonly string filePath;

        public UserConfigServices(string filePath)
        {
            this.filePath = filePath;
        }

        public bool FileExists()
        {
            return File.Exists(filePath);
        }

        public string[] ReadAllLines()
        {
            return File.ReadAllLines(filePath);
        }

        public void WriteAllLines(string[] lines)
        {
            File.WriteAllLines(filePath, lines);
        }

        public bool ValidatePassword(string[] lines, int index, string currentPassword)
        {
            for (int j = index + 1; j < lines.Length && !lines[j].StartsWith("-------------------------------"); j++)
            {
                if (lines[j].StartsWith("Contraseña: "))
                {
                    string encodedPasswordFromFile = lines[j].Substring(12).Trim();
                    string decodedPasswordFromFile = Encoding.UTF8.GetString(Convert.FromBase64String(encodedPasswordFromFile));

                    if (decodedPasswordFromFile == currentPassword)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public List<string> UpdateUserInformation(string[] lines, string userId, Dictionary<string, string> updates)
        {
            bool userFound = false;
            List<string> updatedLines = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("ID: ") && lines[i].Contains(userId))
                {
                    userFound = true;

                    updatedLines.Add(lines[i]); // Mantener el ID

                    foreach (var update in updates)
                    {
                        updatedLines.Add($"{update.Key}: {update.Value}");
                    }

                    while (i < lines.Length && !lines[i].StartsWith("-------------------------------")) i++;

                    updatedLines.Add("-------------------------------");
                }
                else
                {
                    updatedLines.Add(lines[i]);
                }
            }

            if (!userFound)
            {
                throw new Exception("Usuario no encontrado.");
            }

            return updatedLines;
        }
    }
}