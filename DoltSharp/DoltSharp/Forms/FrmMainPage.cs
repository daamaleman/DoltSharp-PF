using DoltSharp;
using DoltSharp.Forms;
using DoltSharp.Models;
using DoltSharp.Properties;
using DoltSharp.Services;
using MaterialSkin.Properties;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DoltSharp.Dao;
using MetroFramework;

namespace DoltSharp
{
    public partial class FrmMainPage : MetroFramework.Forms.MetroForm
    {
        private readonly MainPageServices _mainPageServices;
        private List<Project> projects;
        private List<DoltSharp.Models.Task> tasks; // Uso explícito para evitar ambigüedad

        public FrmMainPage()
        {
            InitializeComponent();

            // Inicializa servicios y listas
            _mainPageServices = new MainPageServices();
            projects = new List<Project>();
            tasks = new List<DoltSharp.Models.Task>();

            // Configura los DataGridView
            ConfigureProjectDataGridView();
            ConfigureTaskDataGridView();

            // Carga los datos
            LoadProjectsIntoGrid();
            LoadTasksIntoGrid();
        }

        private void BtnSalida_Click(object sender, EventArgs e)
        {
            var result = MetroFramework.MetroMessageBox.Show(this,
                 "¿Estás seguro de que deseas cerrar la sesión?",
                 "Confirmación",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LogIn.LoggedInUserId = null;

                // Instancia y muestra el formulario de inicio de sesión
                LogIn loginForm = new LogIn();
                loginForm.Show();

                // Cierra el formulario actual
                this.Close();
            }
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

        private void ConfigureProjectDataGridView()
        {

            DgvProjectsList.Columns.Clear();

            // Definir columnas
            DgvProjectsList.Columns.Add("ProjectId", "ID");
            DgvProjectsList.Columns.Add("ProjectTitle", "Título");
            DgvProjectsList.Columns.Add("ProjectDescription", "Descripción");
            DgvProjectsList.Columns.Add("ProjectStartDate", "Fecha de Inicio");
            DgvProjectsList.Columns.Add("ProjectDueDate", "Fecha Límite");
            DgvProjectsList.Columns.Add("Status", "Estado");

            // Columna para eliminar
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true,
                Name = "Delete"
            };
            DgvProjectsList.Columns.Add(deleteColumn);

            // Configuración general
            DgvProjectsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvProjectsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProjectsList.RowHeadersVisible = false;
            DgvProjectsList.AllowUserToAddRows = false;
            DgvProjectsList.ReadOnly = true; // Hace que no sea editable
        }

        private void ConfigureTaskDataGridView()
        {
            DgvTaskList.Columns.Clear();

            // Definir columnas
            DgvTaskList.Columns.Add("TaskId", "ID");
            DgvTaskList.Columns.Add("TaskName", "Nombre");
            DgvTaskList.Columns.Add("TaskDescription", "Descripción");
            DgvTaskList.Columns.Add("TaskDeadline", "Fecha Límite");
            DgvTaskList.Columns.Add("TaskPriority", "Prioridad");
            DgvTaskList.Columns.Add("TaskStatus", "Estado");

            // Columna para eliminar
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true,
                Name = "Delete"
            };
            DgvTaskList.Columns.Add(deleteColumn);

            // Configuración general
            DgvTaskList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvTaskList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvTaskList.RowHeadersVisible = false;
            DgvTaskList.AllowUserToAddRows = false;
            DgvTaskList.ReadOnly = true; // Hace que no sea editable
        }

        private void LoadProjectsIntoGrid()
        {
            try
            {
                // Limpia las filas existentes en el DataGridView
                DgvProjectsList.Rows.Clear();

                // Carga los proyectos usando el servicio
                projects = _mainPageServices.LoadProjects();

                // Depuración: verifica los proyectos cargados
                foreach (var project in projects)
                {
                    Console.WriteLine($"Cargando proyecto: ID={project.ProjectId}, Título={project.ProjectTitle}");
                }

                // Agrega cada proyecto al DataGridView
                foreach (var project in projects)
                {
                    if (!string.IsNullOrWhiteSpace(project.ProjectTitle) && project.ProjectId > 0)
                    {
                        DgvProjectsList.Rows.Add(
                            project.ProjectId,
                            project.ProjectTitle,
                            project.ProjectDescription,
                            DateTime.Now.ToShortDateString(), // Fecha de inicio (puedes actualizarla si es dinámica)
                            project.ProjectDueDate.ToShortDateString(),
                            project.IsCompleteProject ? "Completado" : "En progreso"
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this,
                    $"Error al cargar los proyectos: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadTasksIntoGrid()
        {
            try
            {
                DgvTaskList.Rows.Clear();
                tasks = _mainPageServices.LoadTasks();

                foreach (var task in tasks)
                {
                    if (!string.IsNullOrWhiteSpace(task.TaskName))
                    {
                        DgvTaskList.Rows.Add(
                            task.TaskId,
                            task.TaskName,
                            task.TaskDescription,
                            task.TaskDeadline.ToString("dd/MM/yyyy"),
                            task.TaskPriority,
                            task.TaskStatus
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this,
                    $"Error al cargar las tareas: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SaveProjectsToFile()
        {
            _mainPageServices.SaveProjects(projects);
        }

        private void DgvProjectsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DgvProjectsList.Columns["Delete"].Index)
            {
                if (int.TryParse(DgvProjectsList.Rows[e.RowIndex].Cells["ProjectId"].Value?.ToString(), out int projectId))
                {
                    var confirmResult = MetroFramework.MetroMessageBox.Show(this,
                        "¿Estás seguro de que deseas eliminar este proyecto?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        projects.RemoveAll(p => p.ProjectId == projectId);
                        SaveProjectsToFile();
                        LoadProjectsIntoGrid();
                    }
                }
                else
                {
                    MessageBox.Show("ID de proyecto no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DgvTaskList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DgvTaskList.Columns["Delete"].Index)
            {
                if (int.TryParse(DgvTaskList.Rows[e.RowIndex].Cells["TaskId"].Value?.ToString(), out int taskId))
                {
                    var confirmResult = MetroFramework.MetroMessageBox.Show(this,
                        "¿Estás seguro de que deseas eliminar esta tarea?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        _mainPageServices.DeleteTask(taskId);
                        LoadTasksIntoGrid();
                    }
                }
                else
                {
                    MessageBox.Show("ID de tarea no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnViewReports_Click(object sender, EventArgs e)
        {
            TaskDao taskDao = new TaskDao();
            TaskFile taskFile = new TaskFile();
            List<Task> tasks = new List<Task>();
            tasks = taskFile.GetAllTasks();




            ReportDataSource dataSource = new ReportDataSource("DsDatos", tasks);

            FrmReports frmReports = new FrmReports();
            frmReports.reportViewer1.LocalReport.DataSources.Clear();
            frmReports.reportViewer1.LocalReport.DataSources.Add(dataSource);

            //Configurar el archivo de reporte
            frmReports.reportViewer1.LocalReport.ReportEmbeddedResource = "DoltSharp.Reports.RptTask.rdlc";

            //Refrescarv el reporte 
            frmReports.reportViewer1.RefreshReport();

            //Visualizar el reporte 
            frmReports.ShowDialog();
        }

        private void FrmMainPage_Load(object sender, EventArgs e)
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
    

