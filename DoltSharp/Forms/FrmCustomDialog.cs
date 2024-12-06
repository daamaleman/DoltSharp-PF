using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace DoltSharp.Forms
{
    public partial class FrmCustomDialog : MetroFramework.Forms.MetroForm
    {
        // Propiedad para la opción seleccionada
        public string SelectedOption { get; private set; } = "Salir";

        // Constructor que acepta el mensaje y el título
        public FrmCustomDialog(string message, string title)
        {
            InitializeComponent();

            // Configurar el título y el mensaje
            this.Text = title; // Establece el título del formulario
            LblMessage.Text = "¿Qué reporte desea visualizar?";

            // Quitar el título y bordes del formulario
            this.FormBorderStyle = FormBorderStyle.None; // Quitar bordes y título
            this.ControlBox = false; // Deshabilitar el control de ventana
            this.Text = string.Empty; // Eliminar texto del título


        }

        // Evento del botón "Tareas"
        private void BtnTask_Click(object sender, EventArgs e)
        {
            SelectedOption = "Tareas";
            this.Close(); // Cierra el formulario
        }

        // Evento del botón "Proyectos"
        private void BtnProject_Click(object sender, EventArgs e)
        {
            SelectedOption = "Proyectos";
            this.Close(); // Cierra el formulario
        }

        // Evento del botón "Salir"
        private void BtnLeave_Click(object sender, EventArgs e)
        {
            SelectedOption = "Salir";
            this.Close(); // Cierra el formulario
        }
    }

    // Clase estática para mostrar el diálogo
    public static class CustomDialogHelper
    {
        public static string Show(string message, string title)
        {
            // Instanciar y mostrar el formulario
            using (var dialog = new FrmCustomDialog(message, title))
            {
                dialog.ShowDialog(); // Muestra el formulario como diálogo modal
                return dialog.SelectedOption; // Devuelve la opción seleccionada
            }
        }
    }
}

