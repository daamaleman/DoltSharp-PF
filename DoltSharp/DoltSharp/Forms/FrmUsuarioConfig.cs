using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DoltSharp
{
    public partial class FrmUsuarioConfig : MetroFramework.Forms.MetroForm
    {
        public FrmUsuarioConfig()
        {
            InitializeComponent();
        }

        private void BtnSaveUpdates_Click(object sender, EventArgs e)
        {
            // Validaciones iniciales de los campos ingresados
            // Verificar que ninguno de los campos esté vacío
            if (string.IsNullOrWhiteSpace(TxtUpdateName.Text) || string.IsNullOrWhiteSpace(TxtUpdateLastName.Text) ||
                string.IsNullOrWhiteSpace(TxtUpdateEmail.Text) || string.IsNullOrWhiteSpace(TxtUpdateAPw.Text) ||
                string.IsNullOrWhiteSpace(TxtNewPw.Text) || string.IsNullOrWhiteSpace(TxtVNewPw.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Ninguno de los campos puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que la fecha de nacimiento no sea posterior a 2006
            if (DtpUpdateBirthDate.Value.Year > 2006)
            {
                MetroFramework.MetroMessageBox.Show(this, "La fecha no puede ser mayor al año 2006", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que el correo tenga un formato válido (contenga "@" y ".")
            if (!TxtUpdateEmail.Text.Contains("@") || !TxtUpdateEmail.Text.Contains("."))
            {
                MetroFramework.MetroMessageBox.Show(this, "El correo no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que la nueva contraseña tenga al menos 8 caracteres
            if (TxtNewPw.Text.Length < 8)
            {
                MetroFramework.MetroMessageBox.Show(this, "La contraseña debe tener al menos 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que las dos contraseñas nuevas coincidan
            if (TxtNewPw.Text != TxtVNewPw.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "Las nuevas contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el ID del usuario autenticado desde LogIn
            string currentUserId = LogIn.LoggedInUserId;
            if (string.IsNullOrWhiteSpace(currentUserId))
            {
                MetroFramework.MetroMessageBox.Show(this, "No se ha identificado al usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string filePath = "registro_usuarios_DoltSharp.txt";
            string[] lines;

            try
            {
                // Validar que el archivo exista y no esté vacío
                if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "El archivo de usuarios no existe o está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Leer todas las líneas del archivo
                lines = File.ReadAllLines(filePath);
            }
            catch (Exception ex)
            {
                // Capturar errores al intentar leer el archivo
                MetroFramework.MetroMessageBox.Show(this, $"Error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool userFound = false; // Bandera para indicar si se encontró el usuario
            List<string> updatedLines = new List<string>(); // Lista para almacenar las líneas actualizadas

            try
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    // Buscar el bloque correspondiente al usuario mediante su ID
                    if (lines[i].StartsWith("ID: ") && lines[i].Contains(currentUserId))
                    {
                        userFound = true;

                        // Validar la contraseña actual ingresada
                        bool passwordIsValid = false; // Bandera para indicar si la contraseña actual es válida
                        for (int j = i + 1; j < lines.Length && !lines[j].StartsWith("-------------------------------"); j++)
                        {
                            if (lines[j].StartsWith("Contraseña: "))
                            {
                                // Extraer y decodificar la contraseña almacenada en el archivo
                                string encodedPasswordFromFile = lines[j].Substring(12).Trim();
                                string decodedPasswordFromFile = Encoding.UTF8.GetString(Convert.FromBase64String(encodedPasswordFromFile));

                                // Comparar la contraseña almacenada con la ingresada por el usuario
                                if (decodedPasswordFromFile == TxtUpdateAPw.Text.Trim())
                                {
                                    passwordIsValid = true; // La contraseña actual es válida
                                    break;
                                }
                            }
                        }

                        // Si la contraseña actual es incorrecta, muestra un mensaje de error y detiene el proceso
                        if (!passwordIsValid)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "La contraseña actual no es correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Actualizar todo el bloque del usuario con los nuevos datos
                        updatedLines.Add(lines[i]); // ID del usuario
                        updatedLines.Add("Nombre: " + TxtUpdateName.Text.Trim());
                        updatedLines.Add("Apellido: " + TxtUpdateLastName.Text.Trim());
                        updatedLines.Add("Correo: " + TxtUpdateEmail.Text.Trim());
                        updatedLines.Add("Fecha de nacimiento: " + DtpUpdateBirthDate.Value.ToString("dd/MM/yyyy"));
                        string newPasswordEncoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(TxtNewPw.Text.Trim()));
                        updatedLines.Add("Contraseña: " + newPasswordEncoded);

                        // Saltar las líneas restantes del bloque actual del usuario
                        while (i < lines.Length && !lines[i].StartsWith("-------------------------------"))
                        {
                            i++;
                        }

                        // Añadir el separador al final del bloque
                        updatedLines.Add("-------------------------------");
                    }
                    else
                    {
                        // Mantener las líneas de otros usuarios sin cambios
                        updatedLines.Add(lines[i]);
                    }
                }

                // Si el usuario no fue encontrado, muestra un mensaje de error
                if (!userFound)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Escribir las líneas actualizadas en el archivo
                File.WriteAllLines(filePath, updatedLines);

                // Mostrar un mensaje de éxito
                MetroFramework.MetroMessageBox.Show(this, "Información actualizada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Regresar a la página principal
                FrmMainPage mainPage = new FrmMainPage();
                mainPage.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                // Capturar errores al intentar escribir en el archivo
                MetroFramework.MetroMessageBox.Show(this, $"Error al actualizar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxConfigSee1_CheckedChanged(object sender, EventArgs e)
        {
            // Alternar visibilidad de la contraseña actual
            TxtUpdateAPw.PasswordChar = CbxConfigSee1.Checked ? '\0' : '*';
            CbxConfigSee1.Text = CbxConfigSee1.Checked ? "Ocultar" : "Ver";
        }

        private void CbxConfigSee2_CheckedChanged(object sender, EventArgs e)
        {
            // Alternar visibilidad de la nueva contraseña
            TxtNewPw.PasswordChar = CbxConfigSee2.Checked ? '\0' : '*';
            CbxConfigSee2.Text = CbxConfigSee2.Checked ? "Ocultar" : "Ver";
        }

        private void CbxConfigSee3_CheckedChanged(object sender, EventArgs e)
        {
            // Alternar visibilidad de la confirmación de la nueva contraseña
            TxtVNewPw.PasswordChar = CbxConfigSee3.Checked ? '\0' : '*';
            CbxConfigSee3.Text = CbxConfigSee3.Checked ? "Ocultar" : "Ver";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Regresar a la página principal
            FrmMainPage mainPage = new FrmMainPage();
            mainPage.Show();
            this.Close();
        }
    }
}
