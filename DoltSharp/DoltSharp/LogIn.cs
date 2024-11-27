using DoltSharp.Services;
using MetroFramework;
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

        private readonly LogInServices _logInServices;

        public LogIn()
        {
            InitializeComponent();
            _logInServices = new LogInServices("RegisteredUsersDoltSharp.txt");
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Obtener datos ingresados por el usuario
            string email = TxtEmail.Text.Trim();
            string password = TxtPw.Text;

            // Validar campos
            if (!_logInServices.AreFieldsValid(email, password, out string errorMessage))
            {
                MetroMessageBox.Show(this, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cifrar la contraseña
            string encryptedPassword = _logInServices.EncryptPassword(password);

            // Intentar autenticar al usuario
            try
            {
                if (_logInServices.AuthenticateUser(email, encryptedPassword, out string userId))
                {
                    LoggedInUserId = userId;
                    MetroMessageBox.Show(this, "Bienvenido", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    new FrmMainPage().Show();
                    this.Hide();
                }
                else
                {
                    MetroMessageBox.Show(this, "Correo o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FileNotFoundException ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void LogIn_Load(object sender, EventArgs e)
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