using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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

            // Encriptar la contraseña en Base64
            string encryptedPassword = Convert.ToBase64String(Encoding.UTF8.GetBytes(TxtRegisterPw.Text));

            MetroFramework.MetroMessageBox.Show(this, "Usuario registrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();

            // Guardar los datos en un archivo de texto
            string filePath = "registro_usuarios_DoltSharp.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("-------------------------------");
                writer.WriteLine("Nombre: " + TxtRegisterName.Text);
                writer.WriteLine("Apellido: " + TxtRegisterLastName.Text);
                writer.WriteLine("Correo: " + TxtRegisterEmail.Text);
                writer.WriteLine("Fecha de nacimiento: " + DtpBirthDate.Value.ToShortDateString());
                writer.WriteLine("Contraseña: " + encryptedPassword);
                writer.WriteLine("-------------------------------");
            }
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

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            // Regresar a LogIn page cuando haga click en el boton
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }
    }
}
