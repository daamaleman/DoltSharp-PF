using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System;
using System.IO; 



namespace DoltSharp
{
    public partial class FrmUsuarioConfig : MetroFramework.Forms.MetroForm
    {
        private readonly string filePath = "RegisteredUsersDoltSharp.txt";

        public FrmUsuarioConfig()
        {
            InitializeComponent();
        }

        private void BtnSaveUpdates_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
            {
                MetroFramework.MetroMessageBox.Show(this, "El archivo de usuarios no existe o está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            bool userFound = false;
            List<string> updatedLines = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("ID: ") && lines[i].Contains(LogIn.LoggedInUserId))
                {
                    userFound = true;

                    if (!ValidatePassword(lines, i, TxtUpdateAPw.Text.Trim()))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "La contraseña actual no es correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    updatedLines.Add(lines[i]);
                    updatedLines.Add("Nombre: " + TxtUpdateName.Text.Trim());
                    updatedLines.Add("Apellido: " + TxtUpdateLastName.Text.Trim());
                    updatedLines.Add("Correo: " + TxtUpdateEmail.Text.Trim());
                    updatedLines.Add("Fecha de nacimiento: " + DtpUpdateBirthDate.Value.ToString("dd/MM/yyyy"));
                    updatedLines.Add("Contraseña: " + Convert.ToBase64String(Encoding.UTF8.GetBytes(TxtNewPw.Text.Trim())));

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
                MetroFramework.MetroMessageBox.Show(this, "Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            File.WriteAllLines(filePath, updatedLines);
            MetroFramework.MetroMessageBox.Show(this, "Información actualizada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmMainPage mainPage = new FrmMainPage();
            mainPage.Show();
            this.Close();
        }

        private bool ValidatePassword(string[] lines, int index, string currentPassword)
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
            FrmMainPage mainPage = new FrmMainPage();
            mainPage.Show();
            this.Close();
        }
    }
}