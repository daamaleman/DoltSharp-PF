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
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(TxtEmail.Text) || string.IsNullOrWhiteSpace(TxtPw.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Los campos no deben estar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Codificar la contraseña ingresada para compararla
            string encodedPassword = Convert.ToBase64String(Encoding.UTF8.GetBytes(TxtPw.Text));
            string filePath = "registro_usuarios_DoltSharp.txt";
            bool loginSuccessful = false;

            // Verificar si el archivo existe y leerlo
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);

                for (int i = 0; i < lines.Length; i++)
                {
                    // Buscar líneas que contienen el correo y la contraseña juntos
                    if (lines[i].Contains("Correo: " + TxtEmail.Text) &&
                        lines[i + 2].Contains("Contraseña: " + encodedPassword))
                    {
                        loginSuccessful = true;
                        break;
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "No se encontró el archivo de registro de usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Resultado de la validación de inicio de sesión
            if (loginSuccessful)
            {
                MetroFramework.MetroMessageBox.Show(this, "Bienvenido", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new MainPage().Show();
                this.Hide();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Correo o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
