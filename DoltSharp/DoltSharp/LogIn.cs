using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            // 1. Ningun campo puede estar vacio
            if (string.IsNullOrWhiteSpace(TxtEmail.Text) || string.IsNullOrWhiteSpace(TxtPw.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Los campos no deben estar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. El correo debe tener @ y .
            if (!TxtEmail.Text.Contains("@") || !TxtEmail.Text.Contains("."))
            {
                MetroFramework.MetroMessageBox.Show(this, "El correo no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. La contraseña debe tener al menos 8 caracteres
            if (TxtPw.Text.Length < 8)
            {
                MetroFramework.MetroMessageBox.Show(this, "La contraseña debe tener al menos 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MetroFramework.MetroMessageBox.Show(this, "Bienvenido", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
