using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoltSharp.Models;
using DoltSharp.Services;
using MetroFramework;

namespace DoltSharp
{
    public partial class FrmProject : MetroFramework.Forms.MetroForm
    {
        private readonly ProjectServices _projectServices;
        private Timer timer = new Timer();

        public FrmProject()
        {
            InitializeComponent();
            _projectServices = new ProjectServices(); // Inicializa el servicio de proyectos
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            FrmMainPage mainPage = new FrmMainPage();
            mainPage.Show();
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos
            string projectName = TxtProjectName.Text;
            string projectDescription = RtbProjectDescription.Text;
            DateTime deadline = DtpProjectDeadLine.Value;

            // Validar campos
            if (!_projectServices.ValidateProjectFields(projectName, projectDescription))
            {
                MetroMessageBox.Show(this,
                    "Llena todos los campos.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Crear el proyecto
            var project = _projectServices.CreateProject(projectName, projectDescription, deadline);

            // Guardar el proyecto
            try
            {
                _projectServices.SaveProject(project);

                // Mostrar un mensaje de éxito
                MetroMessageBox.Show(this,
                    "Proyecto guardado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Redirigir a la pantalla principal
                FrmMainPage mainPage = new FrmMainPage();
                mainPage.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de excepción
                MetroMessageBox.Show(this,
                    $"Error al guardar el proyecto: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmProject_Load(object sender, EventArgs e)
        {
            ReadConfig();

            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            LblClock.Text = DateTime.Now.ToString("HH:mm:ss");
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