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
        private readonly ProyectFile _proyectFile;
        private readonly TaskFile _taskFile;
        private List<Project> projects;
        private List<DoltSharp.Models.Task> tasks;
        private object task;

        public FrmMainPage()
        {
            InitializeComponent();

            // Configura las columnas de ambos DataGridView.
            ConfigureProjectDataGridView();
            ConfigureTaskDataGridView();

            // Inicializa las instancias de ProyectFile y TaskFile.
            _proyectFile = new ProyectFile();
            _taskFile = new TaskFile();

            // Carga los datos iniciales en los DataGridView.
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

        private void DgvProjectsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= DgvProjectsList.Rows.Count) return;

            if (e.ColumnIndex == DgvProjectsList.Columns["Actions"].Index)
            {
                var cellValue = DgvProjectsList.Rows[e.RowIndex].Cells["ProjectId"].Value;
                if (cellValue == null || string.IsNullOrEmpty(cellValue.ToString()))
                {
                    MessageBox.Show("La celda ProjectId está vacía o nula.", "Error");
                    return;
                }

                int projectId;
                if (!int.TryParse(cellValue.ToString(), out projectId))
                {
                    MessageBox.Show("ProjectId no es un número válido.", "Error");
                    return;
                }

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
                        MetroFramework.MetroMessageBox.Show(
                            this,
                            $"Título: {project.ProjectTitle}\n" +
                            $"Descripción: {project.ProjectDescription}\n" +
                            $"Fecha de Inicio: {DateTime.Now.ToShortDateString()}\n" +
                            $"Fecha Límite: {project.ProjectDueDate.ToShortDateString()}\n" +
                            $"Estado: {(project.IsCompleteProject ? "Completado" : "En progreso")}",
                            "Detalles del Proyecto",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
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
            DgvProjectsList.AllowUserToAddRows = false; // Evita filas vacías.
        }

        private void LoadProjectsIntoGrid()
        {
            DgvProjectsList.Rows.Clear();
            projects = _proyectFile.LoadProjects();

            if (projects == null || projects.Count == 0) return;

            foreach (var project in projects)
            {
                DgvProjectsList.Rows.Add(
                    project.ProjectId,
                    project.ProjectTitle,
                    project.IsCompleteProject ? "Completado" : "En progreso"
                );
            }
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
            DgvTaskList.AllowUserToAddRows = false; // Evita filas vacías.
        }

        private void LoadTasksIntoGrid()
        {
            DgvTaskList.Rows.Clear();
            tasks = _taskFile.GetAllTasks();

            if (tasks == null || tasks.Count == 0) return;

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
            System.IO.File.WriteAllText(_proyectFile.GetFilePath(), string.Empty);

            foreach (var project in projects)
            {
                _proyectFile.SaveProject(project);
            }
        }

        private void DgvTaskList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= DgvTaskList.Rows.Count) return;

            if (e.ColumnIndex == DgvTaskList.Columns["Actions"].Index)
            {
                var cellValue = DgvTaskList.Rows[e.RowIndex].Cells["TaskId"].Value;
                if (cellValue == null || string.IsNullOrEmpty(cellValue.ToString()))
                {
                    MessageBox.Show("La celda TaskId está vacía o nula.", "Error");
                    return;
                }

                int taskId;
                if (!int.TryParse(cellValue.ToString(), out taskId))
                {
                    MessageBox.Show("TaskId no es un número válido.", "Error");
                    return;
                }

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
                        MetroFramework.MetroMessageBox.Show(
                            this,
                            $"Nombre: {task.TaskName}\n" +
                            $"Descripción: {task.TaskDescription}\n" +
                            $"Fecha Límite: {task.TaskDeadline:dd/MM/yyyy}\n" +
                            $"Prioridad: {task.TaskPriority}\n" +
                            $"Estado: {task.TaskStatus}",
                            "Detalles de la Tarea",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else if (result == DialogResult.No)
                    {
                        _taskFile.DeleteTask(taskId);
                        LoadTasksIntoGrid();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la tarea especificada.", "Error");
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