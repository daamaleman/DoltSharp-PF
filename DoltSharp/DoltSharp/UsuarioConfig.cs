using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            // Validaciones
            // 1. Ningún campo puede estar vacío
            if (string.IsNullOrWhiteSpace(TxtUpdateName.Text) || string.IsNullOrWhiteSpace(TxtUpdateLastName.Text) ||
                string.IsNullOrWhiteSpace(TxtUpdateEmail.Text) || string.IsNullOrWhiteSpace(TxtUpdateAPw.Text) ||
                string.IsNullOrWhiteSpace(TxtNewPw.Text) || string.IsNullOrWhiteSpace(TxtVNewPw.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Ninguno de los campos puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. La fecha no puede ser mayor al año 2006
            if (DtpUpdateBirthDate.Value.Year > 2006)
            {
                MetroFramework.MetroMessageBox.Show(this, "La fecha no puede ser mayor al año 2006", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. El correo debe tener @ y .
            if (!TxtUpdateEmail.Text.Contains("@") || !TxtUpdateEmail.Text.Contains("."))
            {
                MetroFramework.MetroMessageBox.Show(this, "El correo no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. La contraseña debe tener al menos 8 caracteres
            if (TxtNewPw.Text.Length < 8)
            {
                MetroFramework.MetroMessageBox.Show(this, "La contraseña debe tener al menos 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5. Las contraseñas deben coincidir
            if (TxtNewPw.Text != TxtVNewPw.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "Las nuevas contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 6. La contraseña actual debe coincidir con la almacenada
            string filePath = "registro_usuarios_DoltSharp.txt";
            string[] lines = System.IO.File.ReadAllLines(filePath);
            bool passwordMatch = false;

            foreach (string line in lines)
            {
                if (line.StartsWith("Contraseña: "))
                {
                    // Extraer la contraseña codificada del archivo y decodificarla
                    string encodedPasswordFromFile = line.Substring(12).Trim();
                    string decodedPasswordFromFile = Encoding.UTF8.GetString(Convert.FromBase64String(encodedPasswordFromFile));

                    // Comparar la contraseña decodificada del archivo con la contraseña actual ingresada
                    if (decodedPasswordFromFile == TxtUpdateAPw.Text.Trim())
                    {
                        passwordMatch = true;
                        break;
                    }
                }
            }

            if (!passwordMatch)
            {
                MetroFramework.MetroMessageBox.Show(this, "La contraseña actual no es correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualizar la información del usuario si la contraseña coincide
            string[] newLines = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("Nombre: "))
                {
                    newLines[i] = "Nombre: " + TxtUpdateName.Text.Trim();
                }
                else if (lines[i].StartsWith("Apellido: "))
                {
                    newLines[i] = "Apellido: " + TxtUpdateLastName.Text.Trim();
                }
                else if (lines[i].StartsWith("Correo: "))
                {
                    newLines[i] = "Correo: " + TxtUpdateEmail.Text.Trim();
                }
                else if (lines[i].StartsWith("Contraseña: "))
                {
                    // Encriptar la nueva contraseña en Base64 antes de guardarla
                    string newPasswordEncoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(TxtNewPw.Text.Trim()));
                    newLines[i] = "Contraseña: " + newPasswordEncoded;
                }
                else
                {
                    // Mantener otras líneas sin cambios
                    newLines[i] = lines[i];
                }
            }

            // Escribir las líneas actualizadas en el archivo
            System.IO.File.WriteAllLines(filePath, newLines);

            // Mensaje de confirmación de éxito
            MetroFramework.MetroMessageBox.Show(this, "Información actualizada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Regresar a la página principal
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void CbxConfigSee1_CheckedChanged(object sender, EventArgs e)
        {
            TxtUpdateAPw.PasswordChar = CbxConfigSee1.Checked ? '\0' : '*';
            CbxConfigSee1.Text = CbxConfigSee1.Checked ? "Ocultar" : "Ver";
        }

        private void CbxConfigSee2_CheckedChanged(object sender, EventArgs e)
        {
            TxtNewPw.PasswordChar = CbxConfigSee2.Checked ? '\0' : '*';
            CbxConfigSee2.Text = CbxConfigSee2.Checked ? "Ocultar" : "Ver";
        }

        private void CbxConfigSee3_CheckedChanged(object sender, EventArgs e)
        {
            TxtVNewPw.PasswordChar = CbxConfigSee3.Checked ? '\0' : '*';
            CbxConfigSee3.Text = CbxConfigSee3.Checked ? "Ocultar" : "Ver";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Regresar a Main page cuando haga click en el botón
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }
    }
}