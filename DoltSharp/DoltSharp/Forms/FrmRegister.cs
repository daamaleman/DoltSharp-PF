using System;

using System.Windows.Forms;
using DoltSharp.Services;

namespace DoltSharp
{
    public partial class FrmRegister : MetroFramework.Forms.MetroForm
    {
        private readonly UserRegisterFile _userRegisterFile;

        public FrmRegister()
        {
            InitializeComponent();
            _userRegisterFile = new UserRegisterFile("registro_usuarios_DoltSharp.txt");
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(TxtRegisterName.Text) || string.IsNullOrWhiteSpace(TxtRegisterLastName.Text) ||
                string.IsNullOrWhiteSpace(TxtRegisterEmail.Text) || string.IsNullOrWhiteSpace(TxtRegisterPw.Text) ||
                string.IsNullOrWhiteSpace(TxtRegisterVPw.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Ninguno de los campos puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DtpBirthDate.Value.Year > 2006)
            {
                MetroFramework.MetroMessageBox.Show(this, "La fecha no puede ser mayor al año 2006", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!TxtRegisterEmail.Text.Contains("@") || !TxtRegisterEmail.Text.Contains("."))
            {
                MetroFramework.MetroMessageBox.Show(this, "El correo no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TxtRegisterPw.Text.Length < 8)
            {
                MetroFramework.MetroMessageBox.Show(this, "La contraseña debe tener al menos 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TxtRegisterPw.Text != TxtRegisterVPw.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_userRegisterFile.IsEmailRegistered(TxtRegisterEmail.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "El correo ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Guardar datos usando UserRegisterFile
            try
            {
                _userRegisterFile.RegisterUser(TxtRegisterName.Text, TxtRegisterLastName.Text, TxtRegisterEmail.Text, DtpBirthDate.Value, TxtRegisterPw.Text);
                MetroFramework.MetroMessageBox.Show(this, "Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LogIn logIn = new LogIn();
                logIn.Show(); 
                this.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}