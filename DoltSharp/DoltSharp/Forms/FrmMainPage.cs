using DoltSharp;
using DoltSharp.Models;
using DoltSharp.Properties;
using MaterialSkin.Properties;
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
    public partial class FrmMainPage : MetroFramework.Forms.MetroForm
    {
        public FrmMainPage()
        {
            InitializeComponent();
        }

        private void BtnSalida_Click(object sender, EventArgs e)
        {
            // Limpia el usuario autenticado actual.
            LogIn.LoggedInUserId = null;

            // Redirige al formulario de inicio de sesión.
            LogIn login = new LogIn();
            login.Show();
            this.Close();
        }

        private void BtnEditarInformarcion_Click(object sender, EventArgs e)
        {
            FrmUsuarioConfig usuarioConfig = new FrmUsuarioConfig();
            usuarioConfig.Show();
            this.Close();
        }

        private void BtnNewTask_Click(object sender, EventArgs e)
        {
            FrmTask task = new FrmTask();
            task.Show();
            this.Hide();
        }

        private void BtnNewProject_Click(object sender, EventArgs e)
        {
            FrmProject project = new FrmProject();
            project.Show();
            this.Hide();
        }

        private void BtnConfiguration_Click(object sender, EventArgs e)
        {
            FrmConfig configPersonalizacion = new FrmConfig();
            configPersonalizacion.Show();
            this.Close();
        }
    }
}