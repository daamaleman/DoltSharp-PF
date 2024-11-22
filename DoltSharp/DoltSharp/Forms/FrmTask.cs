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
using DoltSharp.Dao;
using DoltSharp.Models;

namespace DoltSharp
{
    public partial class FrmTask : MetroFramework.Forms.MetroForm
    {
        private readonly TaskFile _taskFile; // Ahora se llama TaskFile.

        public FrmTask()
        {
            InitializeComponent();
            _taskFile = new TaskFile(); // Inicializamos TaskFile.
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            FrmMainPage mainPage = new FrmMainPage();
            mainPage.Show();
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos ingresados por el usuario en el formulario.
                string taskName = TxtTaskName.Text.Trim(); // Nombre de la tarea.
                string taskDescription = TxtTaskDescription.Text.Trim(); // Descripción de la tarea.
                DateTime taskDeadline = DtpTaskDeadLine.Value; // Fecha límite.
                string taskPriority = CmbTaskPriority.SelectedItem?.ToString(); // Prioridad.
                string taskStatus = CmbTaskStatus.SelectedItem?.ToString(); // Estado.

                // Validar campos antes de intentar guardar.
                if (string.IsNullOrWhiteSpace(taskName))
                {
                    MetroFramework.MetroMessageBox.Show(this,
                        "El nombre de la tarea no puede estar vacío.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(taskDescription))
                {
                    MetroFramework.MetroMessageBox.Show(this,
                        "La descripción no puede estar vacía.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(taskPriority))
                {
                    MetroFramework.MetroMessageBox.Show(this,
                        "Debes seleccionar una prioridad.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(taskStatus))
                {
                    MetroFramework.MetroMessageBox.Show(this,
                        "Debes seleccionar un estado.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (taskDeadline < DateTime.Now.Date)
                {
                    MetroFramework.MetroMessageBox.Show(this,
                        "La fecha límite no puede ser anterior a hoy.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                // Usar TaskFile para agregar la tarea.
                _taskFile.AddTask(taskName, taskDescription, taskDeadline, taskPriority, taskStatus);

                // Mostrar mensaje de éxito.
                MetroFramework.MetroMessageBox.Show(this,
                    "Tarea guardada correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Redirigir automáticamente a la pantalla principal.
                FrmMainPage mainPage = new FrmMainPage();
                mainPage.Show();
                this.Close(); // Cierra el formulario actual.

            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error general.
                MetroFramework.MetroMessageBox.Show(this,
                    $"Error al guardar la tarea: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Método para limpiar los campos después de guardar.
        private void ClearFormFields()
        {
            TxtTaskName.Clear(); // Limpia el nombre de la tarea.
            TxtTaskDescription.Clear(); // Limpia la descripción.
            CmbTaskPriority.SelectedIndex = -1; // Limpia la selección de prioridad.
            CmbTaskStatus.SelectedIndex = -1; // Limpia la selección de estado.
            DtpTaskDeadLine.Value = DateTime.Now; // Restaura la fecha límite a hoy.
        }
    }
}