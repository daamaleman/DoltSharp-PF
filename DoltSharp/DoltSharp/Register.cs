using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoltSharp
{
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // Validaciones
            // 1. Ningun campo puede estar vacio
            if (string.IsNullOrWhiteSpace(TxtRegisterName.Text) || string.IsNullOrWhiteSpace(TxtRegisterLastName.Text) || string.IsNullOrWhiteSpace(TxtRegisterEmail.Text) || string.IsNullOrWhiteSpace(TxtRegisterPw.Text) || string.IsNullOrWhiteSpace(TxtRegisterVPw.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Ninguno de los campos puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. La fecha no puede ser mayor al año 2006
            if (DtpBirthDate.Value.Year > 2006)
            {
                MetroFramework.MetroMessageBox.Show(this, "La fecha no puede ser mayor al año 2006", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. El correo debe tener @ y .
            if (!TxtRegisterEmail.Text.Contains("@") || !TxtRegisterEmail.Text.Contains("."))
            {
                MetroFramework.MetroMessageBox.Show(this, "El correo no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. La contraseña debe tener al menos 8 caracteres
            if (TxtRegisterPw.Text.Length < 8)
            {
                MetroFramework.MetroMessageBox.Show(this, "La contraseña debe tener al menos 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5. Las contraseñas deben coincidir
            if (TxtRegisterPw.Text != TxtRegisterVPw.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MetroFramework.MetroMessageBox.Show(this, "Usuario registrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Hacer que cuando de click en el ok del mensaje se regrese a la ventana de LogIn nuevamente
        }
        
        // 6. No puede contener numeros 
        private void TxtRegisterName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                MetroFramework.MetroMessageBox.Show(this, "No puede poner numeros en el Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 7. No puede contener numeros
        private void TxtRegisterLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                MetroFramework.MetroMessageBox.Show(this, "No puede poner numeros en el Apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxRegisterSeePw_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxRegisterSeePw.Checked)
            {
                TxtRegisterPw.PasswordChar = '\0';
                CbxRegisterSeePw.Text = "Ocultar";
            }
            else
            {
                TxtRegisterPw.PasswordChar = '*';
                CbxRegisterSeePw.Text = "Ver";
            }
        }

        private void CbxRegisterSeePw2_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxRegisterSeePw2.Checked)
            {
                TxtRegisterVPw.PasswordChar = '\0';
                CbxRegisterSeePw2.Text = "Ocultar";
            }
            else
            {
                TxtRegisterVPw.PasswordChar = '*';
                CbxRegisterSeePw2.Text = "Ver";
            }
        }
    }
}
