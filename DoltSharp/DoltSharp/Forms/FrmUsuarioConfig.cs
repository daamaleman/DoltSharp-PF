using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System;
using System.IO;
using DoltSharp.Services;
using MetroFramework.Forms;
using MetroFramework;

namespace DoltSharp
{
    public partial class FrmUsuarioConfig : MetroForm
    {
        private readonly UserConfigServices userService;

        public FrmUsuarioConfig()
        {
            InitializeComponent();
            userService = new UserConfigServices("RegisteredUsersDoltSharp.txt");
        }

        private void BtnSaveUpdates_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar existencia del archivo
                if (!userService.FileExists())
                {
                    MetroMessageBox.Show(this, "El archivo de usuarios no existe o está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Leer datos del archivo
                string[] lines = userService.ReadAllLines();

                // Buscar y validar contraseña
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith("ID: ") && lines[i].Contains(LogIn.LoggedInUserId))
                    {
                        if (!userService.ValidatePassword(lines, i, TxtUpdateAPw.Text.Trim()))
                        {
                            MetroMessageBox.Show(this, "La contraseña actual no es correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    }
                }

                // Crear actualizaciones
                var updates = new Dictionary<string, string>
                {
                    { "Nombre", TxtUpdateName.Text.Trim() },
                    { "Apellido", TxtUpdateLastName.Text.Trim() },
                    { "Correo", TxtUpdateEmail.Text.Trim() },
                    { "Fecha de nacimiento", DtpUpdateBirthDate.Value.ToString("dd/MM/yyyy") },
                    { "Contraseña", Convert.ToBase64String(Encoding.UTF8.GetBytes(TxtNewPw.Text.Trim())) }
                };

                // Actualizar usuario
                var updatedLines = userService.UpdateUserInformation(lines, LogIn.LoggedInUserId, updates);

                // Guardar cambios
                userService.WriteAllLines(updatedLines.ToArray());

                // Mensaje de éxito
                MetroMessageBox.Show(this, "Información actualizada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Volver al formulario principal
                FrmMainPage mainPage = new FrmMainPage();
                mainPage.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void FrmUsuarioConfig_Load(object sender, EventArgs e)
        {
            ReadConfig();
        }
        private void ReadConfig()
        {
            AppConfigServices appConfigServices = new AppConfigServices();
            appConfigServices.LoadConfigFile();
            if (appConfigServices.MyDarkMode)
            {
                this.Theme = MetroThemeStyle.Dark;
            }
            else
            {
                this.Theme = MetroThemeStyle.Light;
            }
            this.Style = (MetroColorStyle)Enum.Parse(typeof(MetroColorStyle), appConfigServices.MyStyle);
        }
    }
}