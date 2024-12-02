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
        private Timer timer = new Timer();
        private readonly TaskServices _taskServices;
        private Timer timerNotificaciones;
        public FrmMainPage()
        {
            InitializeComponent();

            _mainPageServices = new MainPageServices();

            // Configuración de DataGridView
            ConfigureProjectDataGridView();
            ConfigureTaskDataGridView();

            // Suscribirse a los eventos DataError
            DgvProjectsList.DataError += DgvProjectsList_DataError;
            DgvTaskList.DataError += DgvTaskList_DataError;

            // Carga inicial de datos
            LoadProjectsIntoGrid();
            LoadTasksIntoGrid();

            // Inicializa servicios y listas
            _mainPageServices = new MainPageServices();
            projects = new List<Project>();
            tasks = new List<DoltSharp.Models.Task>();
            _taskServices = new TaskServices(); // Inicializar TaskServices

            
        }
        private void MostrarFormularioDeNotificaciones()
        {
            // Obtener las notificaciones desde TaskServices
            var notificaciones = _taskServices.HandleNotifications();

            // Si hay notificaciones, abrir el formulario de notificaciones
            if (notificaciones.Count > 0)
            {
                FrmNotifications form = new FrmNotifications(notificaciones); // Cambié el nombre del formulario
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay tareas próximas a vencer.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            DgvProjectsList.Columns.Add("ProjectId", "ID");
            DgvProjectsList.Columns.Add("ProjectTitle", "Título");
            DgvProjectsList.Columns.Add("ProjectDescription", "Descripción");
            DgvProjectsList.Columns.Add("ProjectStartDate", "Fecha de Inicio");
            DgvProjectsList.Columns.Add("ProjectDueDate", "Fecha Límite");

            // Columna editable para "Estado" usando un ComboBox
            DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Estado",
                Name = "Status",
                DataSource = new List<string> { "Pendiente", "En progreso", "Completado" }, // Valores válidos
                FlatStyle = FlatStyle.Flat
            };

            // Agregar la columna al DataGridView
            DgvProjectsList.Columns.Add(statusColumn);

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

            // Columna editable para el estado
            DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Estado",
                Name = "Status",
                DataSource = new List<string> { "Pendiente", "En progreso", "Completado" }, // Valores válidos
                FlatStyle = FlatStyle.Flat
            };
        }

        private void DgvTaskList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvTaskList.Columns["TaskStatus"].Index)
            {
                if (int.TryParse(DgvTaskList.Rows[e.RowIndex].Cells["TaskId"].Value.ToString(), out int taskId))
                {
                    string nuevoEstado = DgvTaskList.Rows[e.RowIndex].Cells["TaskStatus"].Value.ToString();
                    var tarea = tasks.FirstOrDefault(t => t.TaskId == taskId);

                    if (tarea != null)
                    {
                        tarea.TaskStatus = nuevoEstado;
                        _mainPageServices.SaveTasks(tasks); // Guardar los cambios en el archivo
                    }
                }
            }
        }

        private void DgvProjectsList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si el cambio ocurrió en la columna "Status"
            if (e.ColumnIndex == DgvProjectsList.Columns["Status"].Index)
            {
                // Intentar obtener el ID del proyecto desde la celda "ProjectId"
                if (int.TryParse(DgvProjectsList.Rows[e.RowIndex].Cells["ProjectId"].Value.ToString(), out int projectId))
                {
                    // Obtener el nuevo estado seleccionado
                    string nuevoEstado = DgvProjectsList.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                    // Buscar el proyecto correspondiente en la lista "projects"
                    var proyecto = projects.FirstOrDefault(p => p.ProjectId == projectId);

                    if (proyecto != null) // Si el proyecto existe
                    {
                        // Actualizar el estado del proyecto
                        proyecto.IsCompleteProject = nuevoEstado == "Completado";

                        // Guardar los cambios utilizando el servicio
                        _mainPageServices.SaveProjects(projects); // Guardar los cambios en el archivo o base de datos
                    }
                }
            }
        }

        private void LoadProjectsIntoGrid()
        {
            try
            {
                // Limpia las filas existentes en el DataGridView
                DgvProjectsList.Rows.Clear();

                // Carga los proyectos usando el servicio
                projects = _mainPageServices.LoadProjects() ?? new List<Project>();

                // Opciones válidas del ComboBox
                var validStatuses = new List<string> { "Pendiente", "En progreso", "Completado" };

                // Agrega cada proyecto al DataGridView
                foreach (var project in projects)
                {
                    // Validar el estado
                    string estado = project.IsCompleteProject ? "Completado" : "Pendiente";

                    if (!validStatuses.Contains(estado))
                    {
                        estado = "Pendiente"; // Valor por defecto si no es válido
                    }

                    // Agregar el proyecto al DataGridView
                    DgvProjectsList.Rows.Add(
                        project.ProjectId,
                        project.ProjectTitle,
                        project.ProjectDescription,
                        project.ProjectDueDate.ToShortDateString(),
                        estado // Asigna el estado validado
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
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
                // Limpia las filas existentes en el DataGridView
                DgvTaskList.Rows.Clear();

                // Carga las tareas desde el servicio
                tasks = _mainPageServices.LoadTasks() ?? new List<DoltSharp.Models.Task>();

                foreach (var task in tasks)
                {
                    // Validar la fecha límite
                    string fechaLimite = task.TaskDeadline == DateTime.MinValue
                        ? "Sin fecha" // Reemplazar fechas inválidas por "Sin fecha"
                        : task.TaskDeadline.ToShortDateString();

                    // Agregar la tarea al DataGridView
                    DgvTaskList.Rows.Add(
                        task.TaskId,
                        task.TaskName,
                        task.TaskDescription,
                        fechaLimite,
                        task.TaskPriority,
                        task.TaskStatus
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
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
        private void DgvProjectsList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
    // Verifica si la columna con error es un ComboBoxColumn
    if (DgvProjectsList.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn comboBoxColumn)
    {
        // Usa el primer valor permitido como predeterminado
        var defaultValue = ((List<string>)comboBoxColumn.DataSource)[0];
        DgvProjectsList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = defaultValue;
    }

    // Opcional: Muestra un mensaje informativo
    MessageBox.Show(
        $"Error en la celda [{e.RowIndex}, {e.ColumnIndex}]. Se asignó un valor predeterminado.",
        "Error de datos",
        MessageBoxButtons.OK,
        MessageBoxIcon.Warning
    );

    e.ThrowException = false; // Evita que la excepción se propague
}
        private void DgvTaskList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(
                $"Error al procesar los datos en la celda [{e.RowIndex}, {e.ColumnIndex}]: {e.Exception.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            //  Establecer un valor predeterminado en caso de error
            if (e.ColumnIndex == DgvTaskList.Columns["TaskStatus"].Index)
            {
                DgvTaskList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Pendiente";
            }

            e.ThrowException = false;
        }

        private void DgvProjectsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex < 0 || e.RowIndex >= DgvProjectsList.Rows.Count) return;

                if (e.ColumnIndex == DgvProjectsList.Columns["Actions"].Index)
                {
                    if (int.TryParse(DgvProjectsList.Rows[e.RowIndex].Cells["ProjectId"].Value?.ToString(), out int projectId))
                    {
                        var project = projects.FirstOrDefault(p => p.ProjectId == projectId);

                        if (project != null)
                        {
                            var result = MetroMessageBox.Show(
                                this,
                                "¿Qué acción deseas realizar?\nSí: Ver detalles\nNo: Eliminar",
                                "Acción requerida",
                                MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Question
                            );

                            if (result == DialogResult.Yes)
                            {
                                var details = _mainPageServices.GetProjectDetails(project);
                                MetroMessageBox.Show(this, details, "Detalles del Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (result == DialogResult.No)
                            {
                                projects.RemoveAll(p => p.ProjectId == projectId);
                                SaveProjectsToFile();
                                LoadProjectsIntoGrid();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID de proyecto no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this,
                    $"Error al procesar acción: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DgvTaskList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.RowIndex >= DgvTaskList.Rows.Count) return;

                if (e.ColumnIndex == DgvTaskList.Columns["Actions"].Index)
                {
                    if (int.TryParse(DgvTaskList.Rows[e.RowIndex].Cells["TaskId"].Value?.ToString(), out int taskId))
                    {
                        var task = tasks.FirstOrDefault(t => t.TaskId == taskId);

                        if (task != null)
                        {
                            var result = MetroMessageBox.Show(
                                this,
                                "¿Qué acción deseas realizar?\nSí: Ver detalles\nNo: Eliminar",
                                "Acción requerida",
                                MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Question
                            );

                            if (result == DialogResult.Yes)
                            {
                                var details = _mainPageServices.GetTaskDetails(task);
                                MetroMessageBox.Show(this, details, "Detalles de la Tarea", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (result == DialogResult.No)
                            {
                                _mainPageServices.DeleteTask(taskId);
                                LoadTasksIntoGrid();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID de tarea no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this,
                    $"Error al procesar acción: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
        private void ConfigurarNotificacionesDiarias()
        {
            timerNotificaciones = new Timer
            {
                Interval = 60000 // 1 minuto
            };

            timerNotificaciones.Tick += (s, e) =>
            {
                // Mostrar notificaciones automáticamente a la hora deseada
                if (DateTime.Now.Hour == 18 && DateTime.Now.Minute == 30)
                {
                    MostrarFormularioDeNotificaciones();
                }
            };

            timerNotificaciones.Start();
        }
        private void FrmMainPage_Load(object sender, EventArgs e)
        {
            ReadConfig();

            string greeting;

            int hour = DateTime.Now.Hour;
            if (hour < 12)
                greeting = "¡Buenos días!";
            else if (hour < 18)
                greeting = "¡Buenas tardes!";
            else
                greeting = "¡Buenas noches!";

            LblWelcome.Text = $"{greeting} Bienvenido a DoltSharp.";

            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
            ConfigurarNotificacionesDiarias();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            LblClock.Text = DateTime.Now.ToString("HH:mm:ss");

            // Verificar si es la hora específica para mostrar notificaciones (ejemplo: 9:00 AM)
            if (DateTime.Now.Hour == 9 && DateTime.Now.Minute == 0)
            {
                MostrarFormularioDeNotificaciones();
            }
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

        private void BtnViewReport_Click(object sender, EventArgs e)
        {
            ProjectDao projectDao = new ProjectDao();
            ProyectFile projectFile = new ProyectFile();
            List<Project> projects = new List<Project>();
            projects = projectFile.GetAllProjects();

            ReportDataSource dataSource = new ReportDataSource("DsDatos", projects);

            FrmReports frmReports = new FrmReports();
            frmReports.reportViewer1.LocalReport.DataSources.Clear();
            frmReports.reportViewer1.LocalReport.DataSources.Add(dataSource);

            //Configurar el archivo de reporte
            frmReports.reportViewer1.LocalReport.ReportEmbeddedResource = "DoltSharp.Reports.RptProject.rdlc";

            //Refrescarv el reporte 
            frmReports.reportViewer1.RefreshReport();

            //Visualizar el reporte 
            frmReports.ShowDialog();

        }
    }
}


