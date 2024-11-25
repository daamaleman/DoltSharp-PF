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
            LogIn.LoggedInUserId = null;
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

        private void ConfigureProjectDataGridView()
        {
            DgvProjectsList.Columns.Clear();
            DgvProjectsList.Columns.Add("ProjectId", "ID");
            DgvProjectsList.Columns.Add("ProjectTitle", "Título");
            DgvProjectsList.Columns.Add("Status", "Estado");

            DataGridViewButtonColumn actionsColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Acciones",
                Text = "Ver/Eliminar",
                UseColumnTextForButtonValue = true,
                Name = "Actions"
            };
            DgvProjectsList.Columns.Add(actionsColumn);

            DgvProjectsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvProjectsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProjectsList.RowHeadersVisible = false;
            DgvProjectsList.AllowUserToAddRows = false;
        }

        private void ConfigureTaskDataGridView()
        {
            DgvTaskList.Columns.Clear();
            DgvTaskList.Columns.Add("TaskId", "ID");
            DgvTaskList.Columns.Add("TaskName", "Nombre");
            DgvTaskList.Columns.Add("TaskDescription", "Descripción");
            DgvTaskList.Columns.Add("TaskDeadline", "Fecha Límite");
            DgvTaskList.Columns.Add("TaskPriority", "Prioridad");
            DgvTaskList.Columns.Add("TaskStatus", "Estado");

            DataGridViewButtonColumn actionsColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Acciones",
                Text = "Ver/Eliminar",
                UseColumnTextForButtonValue = true,
                Name = "Actions"
            };
            DgvTaskList.Columns.Add(actionsColumn);

            DgvTaskList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvTaskList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvTaskList.RowHeadersVisible = false;
            DgvTaskList.AllowUserToAddRows = false;
        }

        private void LoadProjectsIntoGrid()
        {
            DgvProjectsList.Rows.Clear();
            projects = _mainPageServices.LoadProjects();

            foreach (var project in projects)
            {
                DgvProjectsList.Rows.Add(
                    project.ProjectId,
                    project.ProjectTitle,
                    project.IsCompleteProject ? "Completado" : "En progreso"
                );
            }
        }

        private void LoadTasksIntoGrid()
        {
            DgvTaskList.Rows.Clear();
            tasks = _mainPageServices.LoadTasks();

            foreach (var task in tasks)
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

        private void SaveProjectsToFile()
        {
            _mainPageServices.SaveProjects(projects);
        }

        private void DgvProjectsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= DgvProjectsList.Rows.Count) return;

            if (e.ColumnIndex == DgvProjectsList.Columns["Actions"].Index)
            {
                var projectId = Convert.ToInt32(DgvProjectsList.Rows[e.RowIndex].Cells["ProjectId"].Value);
                var project = projects.FirstOrDefault(p => p.ProjectId == projectId);

                if (project != null)
                {
                    var result = MetroFramework.MetroMessageBox.Show(
                        this,
                        "¿Qué acción deseas realizar?\nSí: Ver detalles\nNo: Eliminar",
                        "Acción requerida",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        var details = _mainPageServices.GetProjectDetails(project);
                        MetroFramework.MetroMessageBox.Show(this, details, "Detalles del Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (result == DialogResult.No)
                    {
                        projects.RemoveAll(p => p.ProjectId == projectId);
                        SaveProjectsToFile();
                        LoadProjectsIntoGrid();
                    }
                }
            }
        }

        private void DgvTaskList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= DgvTaskList.Rows.Count) return;

            if (e.ColumnIndex == DgvTaskList.Columns["Actions"].Index)
            {
                var taskId = Convert.ToInt32(DgvTaskList.Rows[e.RowIndex].Cells["TaskId"].Value);
                var task = tasks.FirstOrDefault(t => t.TaskId == taskId);

                if (task != null)
                {
                    var result = MetroFramework.MetroMessageBox.Show(
                        this,
                        "¿Qué acción deseas realizar?\nSí: Ver detalles\nNo: Eliminar",
                        "Acción requerida",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        var details = _mainPageServices.GetTaskDetails(task);
                        MetroFramework.MetroMessageBox.Show(this, details, "Detalles de la Tarea", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (result == DialogResult.No)
                    {
                        _mainPageServices.DeleteTask(taskId);
                        LoadTasksIntoGrid();
                    }
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
    }

}
    

