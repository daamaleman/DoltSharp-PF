using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoltSharp{
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // Validaciones
            // 1. Verificar que ningún campo esté vacío
            if (string.IsNullOrWhiteSpace(TxtRegisterName.Text) || string.IsNullOrWhiteSpace(TxtRegisterLastName.Text) ||
                string.IsNullOrWhiteSpace(TxtRegisterEmail.Text) || string.IsNullOrWhiteSpace(TxtRegisterPw.Text) ||
                string.IsNullOrWhiteSpace(TxtRegisterVPw.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Ninguno de los campos puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Validar que la fecha de nacimiento no sea mayor al año 2006
            if (DtpBirthDate.Value.Year > 2006)
            {
                MetroFramework.MetroMessageBox.Show(this, "La fecha no puede ser mayor al año 2006", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Verificar el formato del correo
            if (!TxtRegisterEmail.Text.Contains("@") || !TxtRegisterEmail.Text.Contains("."))
            {
                MetroFramework.MetroMessageBox.Show(this, "El correo no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Validar la longitud mínima de la contraseña
            if (TxtRegisterPw.Text.Length < 8)
            {
                MetroFramework.MetroMessageBox.Show(this, "La contraseña debe tener al menos 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5. Validar que ambas contraseñas coincidan
            if (TxtRegisterPw.Text != TxtRegisterVPw.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ruta del archivo
            string filePath = "registro_usuarios_DoltSharp.txt";

            // 6. Validar que el correo no esté registrado previamente
            if (File.Exists(filePath) && File.ReadAllLines(filePath).Any(line => line.Contains("Correo: " + TxtRegisterEmail.Text.Trim())))
            {
                MetroFramework.MetroMessageBox.Show(this, "El correo ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Encriptar la contraseña usando Base64
            string encryptedPassword = Convert.ToBase64String(Encoding.UTF8.GetBytes(TxtRegisterPw.Text));

            // Generar un ID único corto
            Random random = new Random();
            string userId;
            do
            {
                userId = "USR" + random.Next(10000, 99999);
            } while (File.Exists(filePath) && File.ReadAllLines(filePath).Any(line => line.Contains("ID: " + userId)));

            // Guardar los datos en el archivo
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("-------------------------------");
                    writer.WriteLine("ID: " + userId); // Guardar el ID único
                    writer.WriteLine("Nombre: " + TxtRegisterName.Text.Trim());
                    writer.WriteLine("Apellido: " + TxtRegisterLastName.Text.Trim());
                    writer.WriteLine("Correo: " + TxtRegisterEmail.Text.Trim());
                    writer.WriteLine("Fecha de nacimiento: " + DtpBirthDate.Value.ToShortDateString());
                    writer.WriteLine("Contraseña: " + encryptedPassword); // Contraseña encriptada
                    writer.WriteLine("-------------------------------");
                }

                MetroFramework.MetroMessageBox.Show(this, "Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirigir al Login
                LogIn logIn = new LogIn();
                logIn.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                // Manejo de errores al guardar el archivo
                MetroFramework.MetroMessageBox.Show(this, $"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // No permitir números en el campo de nombre
        private void TxtRegisterName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MetroFramework.MetroMessageBox.Show(this, "No puede poner números en el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // No permitir números en el campo de apellido
        private void TxtRegisterLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MetroFramework.MetroMessageBox.Show(this, "No puede poner números en el apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Mostrar u ocultar la contraseña principal
        private void CbxRegisterSeePw_CheckedChanged(object sender, EventArgs e)
        {
            TxtRegisterPw.PasswordChar = CbxRegisterSeePw.Checked ? '\0' : '*';
            CbxRegisterSeePw.Text = CbxRegisterSeePw.Checked ? "Ocultar" : "Ver";
        }

        // Mostrar u ocultar la confirmación de contraseña
        private void CbxRegisterSeePw2_CheckedChanged(object sender, EventArgs e)
        {
            TxtRegisterVPw.PasswordChar = CbxRegisterSeePw2.Checked ? '\0' : '*';
            CbxRegisterSeePw2.Text = CbxRegisterSeePw2.Checked ? "Ocultar" : "Ver";
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }
    }
}