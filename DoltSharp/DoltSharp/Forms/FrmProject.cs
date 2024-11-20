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
    public partial class FrmProject : MetroFramework.Forms.MetroForm
    {
        public FrmProject()
        {
            InitializeComponent();
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
            DateTime startDate = DtpProjectStartDate.Value;
            DateTime deadline = DtpProjectDeadLine.Value;
            string resources = TxtProjectResources.Text;

            // Valida que los campos no estén vacíos.
            if (string.IsNullOrWhiteSpace(projectName) ||
                string.IsNullOrWhiteSpace(projectDescription) ||
                string.IsNullOrWhiteSpace(resources))
            {
                MetroFramework.MetroMessageBox.Show(this,
                    "Llena todos los campos.",
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

                // Redirige a la pantalla principal después de guardar.
                FrmMainPage mainPage = new FrmMainPage();
                mainPage.Show();
                this.Close(); // Cierra la ventana actual.

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


