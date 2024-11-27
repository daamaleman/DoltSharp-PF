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
using MetroFramework;

namespace DoltSharp
{
    public partial class FrmTask : MetroFramework.Forms.MetroForm
    {
        private readonly TaskServices _taskServices;

        public FrmTask()
        {
            InitializeComponent();
            _taskServices = new TaskServices(); // Inicializamos el servicio de tareas.
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
                // Obtener los datos ingresados por el usuario en el formulario
                string taskName = TxtTaskName.Text.Trim();
                string taskDescription = TxtTaskDescription.Text.Trim();
                DateTime taskDeadline = DtpTaskDeadLine.Value;
                string taskPriority = CmbTaskPriority.SelectedItem?.ToString();
                string taskStatus = CmbTaskStatus.SelectedItem?.ToString();

                // Validar los campos de la tarea
                if (!_taskServices.ValidateTask(taskName, taskDescription, taskPriority, taskStatus, taskDeadline, out string errorMessage))
                {
                    MetroMessageBox.Show(this, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Guardar la tarea utilizando TaskServices
                _taskServices.AddTask(taskName, taskDescription, taskDeadline, taskPriority, taskStatus);

                // Mostrar mensaje de éxito
                MetroMessageBox.Show(this, "Tarea guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirigir automáticamente a la pantalla principal
                FrmMainPage mainPage = new FrmMainPage();
                mainPage.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error general
                MetroMessageBox.Show(this, $"Error al guardar la tarea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para limpiar los campos después de guardar
        private void ClearFormFields()
        {
            TxtTaskName.Clear();
            TxtTaskDescription.Clear();
            CmbTaskPriority.SelectedIndex = -1;
            CmbTaskStatus.SelectedIndex = -1;
            DtpTaskDeadLine.Value = DateTime.Now;
        }

        private void FrmTask_Load(object sender, EventArgs e)
        {
            ReadConfig();
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