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
        public static string LoggedInUserId { get; set; }

        private readonly string filePath = "RegisteredUsersDoltSharp.txt";

        public LogIn()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtEmail.Text) || string.IsNullOrWhiteSpace(TxtPw.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Los campos no deben estar vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string encodedPassword = Convert.ToBase64String(Encoding.UTF8.GetBytes(TxtPw.Text));
            bool loginSuccessful = false;

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith("ID: "))
                    {
                        string currentUserId = lines[i].Substring(4).Trim();
                        string email = "";
                        string password = "";

                        for (int j = i + 1; j < lines.Length && !lines[j].StartsWith("-------------------------------"); j++)
                        {
                            if (lines[j].StartsWith("Correo: ")) email = lines[j].Substring(8).Trim();
                            else if (lines[j].StartsWith("Contraseña: ")) password = lines[j].Substring(12).Trim();
                        }

                        if (email == TxtEmail.Text.Trim() && password == encodedPassword)
                        {
                            loginSuccessful = true;
                            LoggedInUserId = currentUserId;
                            break;
                        }
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "No se encontró el archivo de usuarios registrados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (loginSuccessful)
            {
                MetroFramework.MetroMessageBox.Show(this, "Bienvenido", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new FrmMainPage().Show();
                this.Hide();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Correo o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxSee_CheckedChanged(object sender, EventArgs e)
        {
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
            FrmRegister register = new FrmRegister();
            register.Show();
            this.Hide();
        }
    }
}