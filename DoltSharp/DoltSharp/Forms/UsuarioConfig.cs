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
    public partial class UsuarioConfig : MetroFramework.Forms.MetroForm
    {
        public UsuarioConfig()
        {
            InitializeComponent();
        }

        private void BtnSaveUpdates_Click(object sender, EventArgs e)
        {
            // Validaciones básicas de los campos
            // Verifica que ningún campo esté vacío
            if (string.IsNullOrWhiteSpace(TxtUpdateName.Text) || string.IsNullOrWhiteSpace(TxtUpdateLastName.Text) ||
                string.IsNullOrWhiteSpace(TxtUpdateEmail.Text) || string.IsNullOrWhiteSpace(TxtUpdateAPw.Text) ||
                string.IsNullOrWhiteSpace(TxtNewPw.Text) || string.IsNullOrWhiteSpace(TxtVNewPw.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Ninguno de los campos puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica que la fecha de nacimiento no sea posterior a 2006
            if (DtpUpdateBirthDate.Value.Year > 2006)
            {
                MetroFramework.MetroMessageBox.Show(this, "La fecha no puede ser mayor al año 2006", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Valida que el correo tenga un formato básico (contenga '@' y '.')
            if (!TxtUpdateEmail.Text.Contains("@") || !TxtUpdateEmail.Text.Contains("."))
            {
                MetroFramework.MetroMessageBox.Show(this, "El correo no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica que la nueva contraseña tenga al menos 8 caracteres
            if (TxtNewPw.Text.Length < 8)
            {
                MetroFramework.MetroMessageBox.Show(this, "La contraseña debe tener al menos 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica que las dos contraseñas nuevas coincidan
            if (TxtNewPw.Text != TxtVNewPw.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "Las nuevas contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el ID del usuario autenticado
            // Se obtiene el ID desde LogIn para identificar al usuario actual
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
                // Verifica si el archivo existe y no está vacío
                if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "El archivo de usuarios no existe o está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lee todas las líneas del archivo
                lines = File.ReadAllLines(filePath);
            }
            catch (Exception ex)
            {
                // Captura cualquier error al leer el archivo
                MetroFramework.MetroMessageBox.Show(this, $"Error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool userFound = false; // Indica si se encontró el usuario en el archivo
            List<string> updatedLines = new List<string>(); // Lista para las líneas actualizadas del archivo

            try
            {
                // Recorre las líneas del archivo
                for (int i = 0; i < lines.Length; i++)
                {
                    // Busca el bloque del usuario mediante el ID
                    if (lines[i].StartsWith("ID: ") && lines[i].Contains(currentUserId))
                    {
                        userFound = true;

                        // Reemplazar el bloque del usuario
                        // Añade las nuevas líneas actualizadas del usuario
                        updatedLines.Add(lines[i]); // ID del usuario
                        updatedLines.Add("Nombre: " + TxtUpdateName.Text.Trim());
                        updatedLines.Add("Apellido: " + TxtUpdateLastName.Text.Trim());
                        updatedLines.Add("Correo: " + TxtUpdateEmail.Text.Trim());
                        updatedLines.Add("Fecha de nacimiento: " + DtpUpdateBirthDate.Value.ToString("dd/MM/yyyy"));
                        string newPasswordEncoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(TxtNewPw.Text.Trim()));
                        updatedLines.Add("Contraseña: " + newPasswordEncoded);

                        // Saltar las líneas del bloque antiguo
                        while (i < lines.Length && !lines[i].StartsWith("-------------------------------"))
                        {
                            i++;
                        }

                        // Añade el separador para el bloque actualizado
                        updatedLines.Add("-------------------------------");
                    }
                    else
                    {
                        // Mantiene las líneas de otros usuarios sin cambios
                        updatedLines.Add(lines[i]);
                    }
                }

                // Si el usuario no fue encontrado, muestra un mensaje de error
                if (!userFound)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Escribe las líneas actualizadas en el archivo
                File.WriteAllLines(filePath, updatedLines);

                // Mensaje de éxito
                MetroFramework.MetroMessageBox.Show(this, "Información actualizada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Regresa a la página principal
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                // Captura errores al actualizar los datos
                MetroFramework.MetroMessageBox.Show(this, $"Error al actualizar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Manejo de la visibilidad de las contraseñas
        private void CbxConfigSee1_CheckedChanged(object sender, EventArgs e)
        {
            // Alterna entre mostrar y ocultar la contraseña actual
            TxtUpdateAPw.PasswordChar = CbxConfigSee1.Checked ? '\0' : '*';
            CbxConfigSee1.Text = CbxConfigSee1.Checked ? "Ocultar" : "Ver";
        }

        private void CbxConfigSee2_CheckedChanged(object sender, EventArgs e)
        {
            // Alterna entre mostrar y ocultar la nueva contraseña
            TxtNewPw.PasswordChar = CbxConfigSee2.Checked ? '\0' : '*';
            CbxConfigSee2.Text = CbxConfigSee2.Checked ? "Ocultar" : "Ver";
        }

        private void CbxConfigSee3_CheckedChanged(object sender, EventArgs e)
        {
            // Alterna entre mostrar y ocultar la confirmación de la nueva contraseña
            TxtVNewPw.PasswordChar = CbxConfigSee3.Checked ? '\0' : '*';
            CbxConfigSee3.Text = CbxConfigSee3.Checked ? "Ocultar" : "Ver";
        }

        // Botón para cancelar y regresar a la página principal
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }
    }
}