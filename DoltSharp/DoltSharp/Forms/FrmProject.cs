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

namespace DoltSharp
{
    public partial class FrmProject : MetroFramework.Forms.MetroForm
    {
        private readonly ProyectFile _proyectFile;

        public FrmProject()
        {
            InitializeComponent();
            _proyectFile = new ProyectFile(); // Inicializamos la clase de guardado en archivo.
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            FrmMainPage mainPage = new FrmMainPage();
            mainPage.Show();
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos.
            string projectName = TxtProjectName.Text;
            string projectDescription = TxtProjectDescription.Text;
            DateTime deadline = DtpProjectDeadLine.Value;

            // Valida que los campos no estén vacíos.
            if (string.IsNullOrWhiteSpace(projectName) ||
                string.IsNullOrWhiteSpace(projectDescription))
            {
                MetroFramework.MetroMessageBox.Show(this,
                    "Llena todos los campos.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Crear un nuevo proyecto usando el modelo `Project`.
            var project = new Project
            {
                ProjectId = new Random().Next(1, 10000), // Generar ID aleatorio. Para algo más robusto, usar un contador único.
                ProjectTitle = projectName,
                ProjectDescription = projectDescription,
                ProjectDueDate = deadline,
                IsCompleteProject = false // Iniciar como incompleto.
            };

            // Guardar el proyecto usando `ProyectFile`.
            try
            {
                _proyectFile.SaveProject(project);

                // Mostrar un mensaje de éxito usando MetroMessageBox.
                MetroFramework.MetroMessageBox.Show(this,
                    "Proyecto guardado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Redirigir a la pantalla principal después de guardar.
                FrmMainPage mainPage = new FrmMainPage();
                mainPage.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de excepción.
                MetroFramework.MetroMessageBox.Show(this,
                    $"Error al guardar el proyecto: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

