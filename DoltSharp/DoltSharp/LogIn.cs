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
        // Propiedad estática para almacenar el ID del usuario autenticado.
        public static string LoggedInUserId { get; set; } // Ahora el setter es público.

        public LogIn()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Verifica que los campos de correo y contraseña no estén vacíos.
            if (string.IsNullOrWhiteSpace(TxtEmail.Text) || string.IsNullOrWhiteSpace(TxtPw.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Los campos no deben estar vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Codifica la contraseña ingresada para compararla con la almacenada.
            string encodedPassword = Convert.ToBase64String(Encoding.UTF8.GetBytes(TxtPw.Text));
            string filePath = "registro_usuarios_DoltSharp.txt";
            bool loginSuccessful = false;

            // Verifica si el archivo de usuarios existe.
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith("ID: "))
                    {
                        string currentUserId = lines[i].Substring(4).Trim(); // Extrae el ID del usuario.
                        string email = "";
                        string password = "";

                        for (int j = i + 1; j < lines.Length && !lines[j].StartsWith("-------------------------------"); j++)
                        {
                            if (lines[j].StartsWith("Correo: "))
                                email = lines[j].Substring(8).Trim(); // Extrae el correo.
                            else if (lines[j].StartsWith("Contraseña: "))
                                password = lines[j].Substring(12).Trim(); // Extrae la contraseña.
                        }

                        // Valida el correo y la contraseña.
                        if (email == TxtEmail.Text.Trim() && password == encodedPassword)
                        {
                            loginSuccessful = true;
                            LoggedInUserId = currentUserId; // Guarda el ID del usuario autenticado.
                            break;
                        }
                    }
                }
            }
            else
            {
                // Muestra un mensaje de error si no se encuentra el archivo.
                MetroFramework.MetroMessageBox.Show(this, "No se encontró el archivo de registro de usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Muestra un mensaje dependiendo del resultado de la validación.
            if (loginSuccessful)
            {
                MetroFramework.MetroMessageBox.Show(this, "Bienvenido", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new FrmMainPage().Show();
                this.Hide();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Correo o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxSee_CheckedChanged(object sender, EventArgs e)
        {
            // Alterna entre mostrar y ocultar la contraseña.
            if (CbxSee.Checked)
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

        private void LnRegister_Click(object sender, EventArgs e)
        {
            // Redirige a la ventana de registro y oculta la ventana actual.
            FrmRegister register = new FrmRegister();
            register.Show();
            this.Hide();
        }
    }
}