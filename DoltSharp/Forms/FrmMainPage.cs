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
        private readonly ReportService _reportService;

        public FrmMainPage()
        {
            InitializeComponent();

            _mainPageServices = new MainPageServices();
            _reportService = new ReportService();
            _taskServices = new TaskServices();

            projects = _mainPageServices.LoadProjects();
            tasks = _mainPageServices.LoadTasks();

            ConfigureProjectDataGridView();
            ConfigureTaskDataGridView();

            LoadProjectsIntoGrid();
            LoadTasksIntoGrid();


        }
        private void MostrarFormularioDeNotificaciones()
        {
            // Obtener las tareas próximas a vencer o ya vencidas
            var tareasVencidas = _taskServices.HandleNotifications();

            if (tareasVencidas.Count > 0)
            {
                string mensaje = "Tareas próximas o ya vencidas:\n\n";

                int contador = 1;
                foreach (var tarea in tareasVencidas)
                {
                    mensaje += $"{contador}. La tarea \"{tarea.TaskName}\" ya está vencida.\n" +
                               $"   Fecha límite: {tarea.TaskDeadline:dd/MM/yyyy}\n\n";
                    contador++;
                }

                MessageBox.Show(mensaje, "Notificaciones de Tareas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay tareas próximas a vencer.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnLeave_Click(object sender, EventArgs e)
        {
            var result = MetroFramework.MetroMessageBox.Show(this,
                 "¿Estás seguro de que deseas cerrar la sesión?",
                 "Confirmación",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LogIn.LoggedInUserId = null;

                // Salir de la app 
                Application.Exit();
            }
        }
        private void BtnSalida_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditarInformarcion_Click(object sender, EventArgs e)
        {
            FrmUsuarioConfig usuarioConfig = new FrmUsuarioConfig();
            usuarioConfig.Show();
            this.Close();
        }

        private void BtnNewProject_Click(object sender, EventArgs e)
        {
            FrmProject project = new FrmProject();
            project.Show();
            this.Hide();
        }

        private void BtnNewTask_Click(object sender, EventArgs e)
        {
            FrmTask task = new FrmTask();
            task.Show();
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

            // Columna para eliminar
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true,
                Name = "Delete"
            };
            DgvProjectsList.Columns.Add(deleteColumn);

            DgvProjectsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvProjectsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProjectsList.RowHeadersVisible = false;
            DgvProjectsList.AllowUserToAddRows = false;
            DgvProjectsList.ReadOnly = true; // Hace que no sea editable

        }

        private void ConfigureTaskDataGridView()
        {
            DgvTaskList.Columns.Clear();
            DgvTaskList.Columns.Add("TaskId", "ID");
            DgvTaskList.Columns.Add("TaskName", "Nombre");
            DgvTaskList.Columns.Add("TaskDescription", "Descripción");
            DgvTaskList.Columns.Add("TaskDeadline", "Fecha Límite");
            DgvTaskList.Columns.Add("TaskPriority", "Prioridad");

            // Hacer el DataGridView no editable
            DgvTaskList.ReadOnly = true;

            // Columna de acción con botón para eliminar
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true,
                Name = "Delete"
            };
            DgvTaskList.Columns.Add(deleteButtonColumn);

            // Ajustes generales
            DgvTaskList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvTaskList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvTaskList.AllowUserToAddRows = false; // Evita que el usuario agregue filas manualmente
            DgvTaskList.RowHeadersVisible = false;
            DgvTaskList.ReadOnly = true; // Hace que no sea editable

        }

        private void DgvTaskList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvTaskList.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {
                try
                {
                    // Obtener el ID de la tarea seleccionada
                    if (int.TryParse(DgvTaskList.Rows[e.RowIndex].Cells["TaskId"].Value?.ToString(), out int taskId))
                    {
                        var result = MessageBox.Show(
                            "¿Estás seguro de que deseas eliminar esta tarea?",
                            "Confirmación",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            // Lógica para eliminar la tarea
                            _mainPageServices.DeleteTask(taskId);

                            // Recargar la lista de tareas en el DataGridView
                            LoadTasksIntoGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID de tarea no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Error al intentar eliminar la tarea: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
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
        private void DgvProjectsList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Verifica si la columna con error es un ComboBoxColumn
            if (DgvProjectsList.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn comboBoxColumn)
            {
                // Usa el primer valor permitido como predeterminado
                var defaultValue = ((List<string>)comboBoxColumn.DataSource)[0];
                DgvProjectsList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = defaultValue;
            }

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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            var result = MetroFramework.MetroMessageBox.Show(this,
                 "¿Estás seguro de que deseas cerrar la sesión?",
                 "Confirmación",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LogIn.LoggedInUserId = null;

                // Salir de la app 
                Application.Exit();
            }
        }

        private void BtnShowNotif_Click(object sender, EventArgs e)
        {
            MostrarFormularioDeNotificaciones();
        }

        private void BtnShowReport_Click_1(object sender, EventArgs e)
        {
            // Mostrar el cuadro de diálogo personalizado sin enumeración
            string selectedOption = CustomDialogHelper.Show(
                "Seleccione el reporte que desea visualizar:\n" +
                "- Reporte de Tareas\n" +
                "- Reporte de Proyectos\n" +
                "- Salir sin realizar ninguna acción.",
                "Seleccionar Reporte"
            );

            // Acciones según la opción seleccionada
            if (selectedOption == "Tareas")
            {
                // Generar el reporte de tareas
                var taskService = new TaskFile();
                var tasks = taskService.GetAllTasks();
                _reportService.ShowTaskReport(tasks);
            }
            else if (selectedOption == "Proyectos")
            {
                // Generar el reporte de proyectos
                var projectService = new ProyectFile();
                var projects = projectService.GetAllProjects();
                _reportService.ShowProjectReport(projects);
            }
            else if (selectedOption == "Salir")
            {
                MetroFramework.MetroMessageBox.Show(
                    this,
                    "La operación fue cancelada.",
                    "Cancelar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}