using System;

using System.Windows.Forms;
using DoltSharp.Services;
using MetroFramework;

namespace DoltSharp
{
    public partial class FrmRegister : MetroFramework.Forms.MetroForm
    {
        private readonly UserRegisterServices _userRegisterServices;

        public FrmRegister()
        {
            InitializeComponent();
            _userRegisterServices = new UserRegisterServices("RegisteredUsersDoltSharp.txt");
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // Obtener valores de los campos
            string name = TxtRegisterName.Text;
            string lastName = TxtRegisterLastName.Text;
            string email = TxtRegisterEmail.Text;
            string password = TxtRegisterPw.Text;
            string confirmPassword = TxtRegisterVPw.Text;
            DateTime birthDate = DtpBirthDate.Value;

            // Validaciones
            if (!_userRegisterServices.AreFieldsValid(name, lastName, email, password, confirmPassword, birthDate, out string errorMessage))
            {
                MetroMessageBox.Show(this, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si el correo ya está registrado
            if (_userRegisterServices.IsEmailRegistered(email))
            {
                MetroMessageBox.Show(this, "El correo ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intentar registrar al usuario
            try
            {
                _userRegisterServices.RegisterUser(name, lastName, email, birthDate, password);
                MetroMessageBox.Show(this, "Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LogIn logIn = new LogIn();
                logIn.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxRegisterSeePw_CheckedChanged(object sender, EventArgs e)
        {
            TxtRegisterPw.PasswordChar = CbxRegisterSeePw.Checked ? '\0' : '*';
            CbxRegisterSeePw.Text = CbxRegisterSeePw.Checked ? "Ocultar" : "Ver";
        }

        private void CbxRegisterSeePw2_CheckedChanged(object sender, EventArgs e)
        {
            TxtRegisterVPw.PasswordChar = CbxRegisterSeePw2.Checked ? '\0' : '*';
            CbxRegisterSeePw2.Text = CbxRegisterSeePw2.Checked ? "Ocultar" : "Ver";
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
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