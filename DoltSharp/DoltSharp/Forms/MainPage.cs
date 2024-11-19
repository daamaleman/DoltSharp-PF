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
    public partial class MainPage : MetroFramework.Forms.MetroForm
    {
        public MainPage()
        {
            InitializeComponent();
        }
        

        private void BtnSalida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEditarInformarcion_Click(object sender, EventArgs e)
        {
            UsuarioConfig usuarioConfig = new UsuarioConfig();
            usuarioConfig.Show();
            this.Close();
        }

        private void BtnNewTask_Click(object sender, EventArgs e)
        {
            Task task = new Task();
            task.Show();
            this.Hide();   

        }

        private void BtnNewProject_Click(object sender, EventArgs e)
        {
            Project project = new Project();
            project.Show();
            this.Hide();
        }

        private void BtnConfiguration_Click(object sender, EventArgs e)
        {
            ConfigPersonalizacion configPersonalizacion = new ConfigPersonalizacion();
            configPersonalizacion.Show();
            this.Close();
        }

        // metodos para animar el logo (si es que funciona) 
        //Nota estube intentandolo y no parece funcionar porque Resources no reconoce ningun archivo xd


    }
}