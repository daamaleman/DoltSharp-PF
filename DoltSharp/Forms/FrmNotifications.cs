using Microsoft.ReportingServices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoltSharp.Forms
{
    public partial class FrmNotifications : MetroFramework.Forms.MetroForm
    {
        public FrmNotifications(List<string> notifications)
        {
            InitializeComponent();

            // Verifica que el ListBox esté configurado para aceptar notificaciones
            if (notifications != null && notifications.Count > 0)
            {
                LtbNotifications.DataSource = notifications;
            }
            else
            {
                LtbNotifications.Items.Add("No hay notificaciones pendientes.");
            }
        }

        private void BtnCloseNotifications_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
