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


            // Mostrar notificaciones en el ListBox
            LtbNotifications.DataSource = notifications;
        }
    }
}
