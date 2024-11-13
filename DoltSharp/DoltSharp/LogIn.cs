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
    public partial class LogIn : MetroFramework.Forms.MetroForm
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(TxtEmail.Text) || string.IsNullOrWhiteSpace(TxtPw.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Los campos no deben estar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!TxtEmail.Text.Contains("@") || !TxtEmail.Text.Contains("."))
            {
                MetroFramework.MetroMessageBox.Show(this, "El correo no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TxtPw.Text.Length < 8)
            {
                MetroFramework.MetroMessageBox.Show(this, "La contraseña debe tener al menos 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Leer el archivo y verificar las credenciales
            string filePath = "registro_usuarios_DoltSharp.txt";
            bool loginSuccessful = false;

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                string encodedPassword = Convert.ToBase64String(Encoding.UTF8.GetBytes(TxtPw.Text));

                // Variables para almacenar los datos actuales del bloque de usuario
                string email = string.Empty;
                string password = string.Empty;

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith("Correo: "))
                    {
                        email = lines[i].Substring(8).Trim();
                    }
                    else if (lines[i].StartsWith("Contraseña: ")) // Ajuste aquí
                    {
                        password = lines[i].Substring(12).Trim();
                    }

                    // Si ambos correo y contraseña están presentes, verificar si coinciden
                    if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
                    {
                        if (email == TxtEmail.Text && password == encodedPassword)
                        {
                            loginSuccessful = true;
                            break;
                        }

                        // Reiniciar para el siguiente bloque de usuario
                        email = string.Empty;
                        password = string.Empty;
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "No se encontró el archivo de registro de usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (loginSuccessful)
            {
                MetroFramework.MetroMessageBox.Show(this, "Bienvenido", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Correo o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }@

        // Mostrar u ocultar contraseña
        private void CbxSee_CheckedChanged(object sender, EventArgs e)
        {
            if(CbxSee.Checked)
            {
                TxtPw.PasswordChar = '\0';
                CbxSee.Text = "Ocultar";
            }
            else
            {
                TxtPw.PasswordChar = '*';
                CbxSee.Text = "Ver";
            }
        }

        // Redireccionar a la ventana de registro
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
