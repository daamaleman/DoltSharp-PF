using DoltSharp;
using DoltSharp.Models;
using DoltSharp.Properties;
using DoltSharp.Services;
using MaterialSkin.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoltSharp
{
    public partial class FrmMainPage : MetroFramework.Forms.MetroForm
    {
        private readonly ProyectFile _proyectFile; // Instancia para manejar el archivo.
        private List<Project> projects; // Lista local de proyectos.

        public FrmMainPage()
        {
            InitializeComponent();

            // Configura las columnas del DataGridView.
            ConfigureDataGridView();

            // Inicializa la instancia de ProyectFile.
            _proyectFile = new ProyectFile();

            // Carga los proyectos en el DataGridView.
            LoadProjectsIntoGrid();
        }

        private void BtnSalida_Click(object sender, EventArgs e)
        {
            // Limpia el usuario autenticado actual.
            LogIn.LoggedInUserId = null;

            // Redirige al formulario de inicio de sesión.
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
            if (e.RowIndex >= 0)
            {
                // Verifica si el clic fue en la columna de acciones.
                if (e.ColumnIndex == DgvProjectsList.Columns["Actions"].Index)
                {
                    int projectId = int.Parse(DgvProjectsList.Rows[e.RowIndex].Cells["ProjectId"].Value.ToString());

                    // Buscar el proyecto correspondiente.
                    var project = projects.FirstOrDefault(p => p.ProjectId == projectId);

                    if (project != null)
                    {
                        // Mostrar un menú para seleccionar Ver Detalles o Eliminar.
                        var result = MetroFramework.MetroMessageBox.Show(
                            this,
                            "¿Qué acción deseas realizar?\nSí: Ver detalles\nNo: Eliminar",
                            "Acción requerida",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question
                        );

                        if (result == DialogResult.Yes)
                        {
                            // Mostrar todos los detalles del proyecto en el cuadro de mensaje.
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
                            // Eliminar el proyecto de la lista.
                            projects.RemoveAll(p => p.ProjectId == projectId);

                            // Actualizar el archivo y recargar la vista.
                            SaveProjectsToFile();
                            LoadProjectsIntoGrid();
                        }
                    }
                }
            }
        }

        // Configura las columnas del DataGridView.
        private void ConfigureDataGridView()
        {
            // Limpia las columnas existentes.
            DgvProjectsList.Columns.Clear();

            // Agrega las columnas necesarias.
            DgvProjectsList.Columns.Add("ProjectId", "ID");
            DgvProjectsList.Columns.Add("ProjectTitle", "Título");
            DgvProjectsList.Columns.Add("Status", "Estado");

            // Columna de botones para acciones.
            DataGridViewButtonColumn actionsColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Acciones",
                Text = "Ver/Eliminar",
                UseColumnTextForButtonValue = true,
                Name = "Actions"
            };
            DgvProjectsList.Columns.Add(actionsColumn);

            // Ajusta el estilo del DataGridView.
            DgvProjectsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvProjectsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProjectsList.RowHeadersVisible = false; // Oculta el encabezado de filas para ahorrar espacio.
        }

        // Carga los proyectos desde el archivo al DataGridView.
        private void LoadProjectsIntoGrid()
        {
            // Limpia el DataGridView antes de cargar datos.
            DgvProjectsList.Rows.Clear();

            // Carga los proyectos desde el archivo.
            projects = _proyectFile.LoadProjects();

            // Si no hay proyectos, simplemente deja el grid vacío.
            if (projects == null || projects.Count == 0)
            {
                return; // No hacer nada.
            }

            // Agrega cada proyecto al DataGridView.
            foreach (var project in projects)
            {
                DgvProjectsList.Rows.Add(
                    project.ProjectId,
                    project.ProjectTitle,
                    project.IsCompleteProject ? "Completado" : "En progreso"
                );
            }
        }

        // Guarda los proyectos actuales al archivo.
        private void SaveProjectsToFile()
        {
            // Limpia el archivo antes de guardar los proyectos actualizados.
            System.IO.File.WriteAllText(_proyectFile.GetFilePath(), string.Empty);

            // Guarda cada proyecto en el archivo.
            foreach (var project in projects)
            {
                _proyectFile.SaveProject(project);
            }
        }
    }
}