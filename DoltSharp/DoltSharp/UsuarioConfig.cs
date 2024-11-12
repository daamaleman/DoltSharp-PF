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
    public partial class UsuarioConfig : MetroFramework.Forms.MetroForm
    {
        public UsuarioConfig()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            // Regresar a Main page cuando haga click en el boton
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();

        }
    }
}
