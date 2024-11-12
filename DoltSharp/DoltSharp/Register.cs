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
