using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoltSharp.Services;

namespace DoltSharp
{
    public partial class Project : MetroFramework.Forms.MetroForm
    {
        public Project()
        {
            InitializeComponent();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos.
            string projectName = TxtProjectName.Text;
            string projectDescription = TxtProjectDescription.Text;
            DateTime startDate = DtpProjectStartDate.Value;
            DateTime deadline = DtpProjectDeadLine.Value;
            string resources = TxtProjectResources.Text;

            // Valida que los campos no estén vacíos.
            if (string.IsNullOrWhiteSpace(projectName) ||
                string.IsNullOrWhiteSpace(projectDescription) ||
                string.IsNullOrWhiteSpace(resources))
            {
                MetroFramework.MetroMessageBox.Show(this,
                    "Por favor, llena todos los campos obligatorios.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Instancia la clase `ProyectFile`.
            var projectFile = new ProyectFile();

            // Guarda los datos del proyecto.
            try
            {
                projectFile.SaveProject(projectName, projectDescription, startDate, deadline, resources);

                // Muestra un mensaje de éxito usando MetroMessageBox.
                MetroFramework.MetroMessageBox.Show(this,
                    "Proyecto guardado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error en caso de excepción.
                MetroFramework.MetroMessageBox.Show(this,
                    $"Error al guardar el proyecto: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }

}


