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
    public partial class MainPage : MetroFramework.Forms.MetroForm
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnSalida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditarInformarcion_Click(object sender, EventArgs e)
        {
            UsuarioConfig usuarioConfig = new UsuarioConfig();
            usuarioConfig.Show();
            this.Hide();
        }
    }
}
