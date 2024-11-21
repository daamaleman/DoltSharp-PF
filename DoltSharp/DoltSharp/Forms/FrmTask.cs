using DoltSharp.Services;
using DoltSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoltSharp
{
    public partial class FrmTask : MetroFramework.Forms.MetroForm
    {
        // Instancia de la clase TaskFile para manejar las tareas.
        private readonly TaskFile _taskFile;

        // Constructor del formulario.
        public FrmTask()
        {
            InitializeComponent();
            _taskFile = new TaskFile(); // Inicializa la clase TaskFile.
        }

        // Evento que regresa a la pantalla principal.
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            FrmMainPage mainPage = new FrmMainPage();
            mainPage.Show();
            this.Close();
        }

        // Evento que guarda una nueva tarea cuando se hace clic en el botón "Crear".
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos ingresados por el usuario en el formulario.
                string taskName = TxtTaskName.Text.Trim();
                string taskDescription = TxtTaskDescription.Text.Trim();
                DateTime taskDeadline = DtpTaskDeadLine.Value;
                string taskPriority = CmbTaskPriority.SelectedItem?.ToString();
                string taskStatus = CmbTaskStatus.SelectedItem?.ToString();

                // Validaciones de los campos.
                if (string.IsNullOrWhiteSpace(taskName))
                {
                    MetroFramework.MetroMessageBox.Show(this,
                        "El nombre de la tarea no puede estar vacío.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Cambiado a "Error" con cuadro rojo.
                    return;
                }

                if (string.IsNullOrWhiteSpace(taskDescription))
                {
                    MetroFramework.MetroMessageBox.Show(this,
                        "La descripción no puede estar vacía.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Cambiado a "Error" con cuadro rojo.
                    return;
                }

                if (string.IsNullOrWhiteSpace(taskPriority))
                {
                    MetroFramework.MetroMessageBox.Show(this,
                        "Debes seleccionar una prioridad.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Cambiado a "Error" con cuadro rojo.
                    return;
                }

                if (string.IsNullOrWhiteSpace(taskStatus))
                {
                    MetroFramework.MetroMessageBox.Show(this,
                        "Debes seleccionar un estado.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Cambiado a "Error" con cuadro rojo.
                    return;
                }

                if (taskDeadline < DateTime.Now.Date)
                {
                    MetroFramework.MetroMessageBox.Show(this,
                        "La fecha límite no puede ser anterior a hoy.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Cambiado a "Error" con cuadro rojo.
                    return;
                }

                // Guarda la tarea usando TaskFile.
                _taskFile.SaveTask(taskName, taskDescription, taskDeadline, taskPriority, taskStatus);

                // Mostrar mensaje de éxito.
                MetroFramework.MetroMessageBox.Show(this,
                    "Tarea guardada correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Redirigir a la pantalla principal.
                FrmMainPage mainPage = new FrmMainPage();
                mainPage.Show();
                this.Close(); // Cerrar el formulario actual.
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error general en caso de excepción.
                MetroFramework.MetroMessageBox.Show(this,
                    $"Error al guardar la tarea: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error); // Cambiado a "Error" con cuadro rojo.
            }
        }

        // Método que limpia los campos del formulario después de guardar una tarea.
        private void ClearFormFields()
        {
            TxtTaskName.Clear();
            TxtTaskDescription.Clear();
            CmbTaskPriority.SelectedIndex = -1;
            CmbTaskStatus.SelectedIndex = -1;
            DtpTaskDeadLine.Value = DateTime.Now;
        }
    }
}
