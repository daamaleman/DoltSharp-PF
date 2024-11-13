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
            // 1. Ningun campo puede estar vacio
            if (string.IsNullOrWhiteSpace(TxtUpdateName.Text) || string.IsNullOrWhiteSpace(TxtUpdateLastName.Text) || string.IsNullOrWhiteSpace(TxtUpdateEmail.Text) || string.IsNullOrWhiteSpace(TxtUpdateAPw.Text) || string.IsNullOrWhiteSpace(TxtNewPw.Text) || string.IsNullOrWhiteSpace(TxtVNewPw.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Ninguno de los campos puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MetroFramework.MetroMessageBox.Show(this, "El correo no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MetroFramework.MetroMessageBox.Show(this, "Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 6. La contraseña actual debe coincidir con la almacenada
            string filePath = "registro_usuarios_DoltSharp.txt";
            string[] lines = System.IO.File.ReadAllLines(filePath);
            string encodedPassword = Convert.ToBase64String(Encoding.UTF8.GetBytes(TxtUpdateAPw.Text));
            bool passwordMatch = false;
            foreach (string line in lines) {
                if (line.StartsWith("Contraseña: "))
                {
                    if (line.Substring(12).Trim() == encodedPassword)
                    {
                        passwordMatch = true;
                        break;
                    }
                }
            }
            if (passwordMatch) {
                MetroFramework.MetroMessageBox.Show(this, "Contraseña actual incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualizar la información del usuario
            string[] newLines = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("Nombre: "))
                {
                    newLines[i] = "Nombre: " + TxtUpdateName.Text;
                }
                else if (lines[i].StartsWith("Apellido: "))
                {
                    newLines[i] = "Apellido: " + TxtUpdateLastName.Text;
                }
                else if (lines[i].StartsWith("Correo: "))
                {
                    newLines[i] = "Correo: " + TxtUpdateEmail.Text;
                }
                else if (lines[i].StartsWith("Contraseña: "))
                {
                    newLines[i] = "Contraseña: " + Convert.ToBase64String(Encoding.UTF8.GetBytes(TxtNewPw.Text));
                }
                else
                {
                    newLines[i] = lines[i];
                }
            }
            System.IO.File.WriteAllLines(filePath, newLines);

            MetroFramework.MetroMessageBox.Show(this, "Información actualizada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Regresar a Main page cuando haga click en el boton
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void CbxConfigSee1_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxConfigSee1.Checked)
            {
                TxtUpdateAPw.PasswordChar = '\0';
                CbxConfigSee1.Text = "Ocultar";
            }
            else
            {
                TxtUpdateAPw.PasswordChar = '*';
                CbxConfigSee1.Text = "Ver";
            }
        }

        private void CbxConfigSee2_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxConfigSee2.Checked)
            {
                TxtNewPw.PasswordChar = '\0';
                CbxConfigSee2.Text = "Ocultar";
            }
            else
            {
                TxtNewPw.PasswordChar = '*';
                CbxConfigSee2.Text = "Ver";
            }
        }

        private void CbxConfigSee3_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxConfigSee3.Checked)
            {
                TxtVNewPw.PasswordChar = '\0';
                CbxConfigSee3.Text = "Ocultar";
            }
            else
            {
                TxtVNewPw.PasswordChar = '*';
                CbxConfigSee3.Text = "Ver";
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Regresar a Main page cuando haga click en el boton
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }
    }
}
