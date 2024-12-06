using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoltSharp.Services
{
    using System.Collections.Generic;
    using DoltSharp.Forms;
    using DoltSharp.Models;
    using Microsoft.Reporting.WinForms;

    internal class ReportService
    {
        // Método para mostrar el reporte de tareas
        public void ShowTaskReport(List<DoltSharp.Models.Task> tasks)
        {
            // Crear la fuente de datos del reporte
            ReportDataSource dataSource = new ReportDataSource("DsDatos", tasks);

            // Configurar el formulario de reportes
            FrmReports frmReports = new FrmReports();
            frmReports.reportViewer1.LocalReport.DataSources.Clear();
            frmReports.reportViewer1.LocalReport.DataSources.Add(dataSource);
            frmReports.reportViewer1.LocalReport.ReportEmbeddedResource = "DoltSharp.Reports.RptTask.rdlc";

            // Refrescar y mostrar el reporte
            frmReports.reportViewer1.RefreshReport();
            frmReports.ShowDialog();
        }

        // Método para mostrar el reporte de proyectos
        public void ShowProjectReport(List<Project> projects)
        {
            // Crear la fuente de datos del reporte
            ReportDataSource dataSource = new ReportDataSource("DsDatos", projects);

            // Configurar el formulario de reportes
            FrmReports frmReports = new FrmReports();
            frmReports.reportViewer1.LocalReport.DataSources.Clear();
            frmReports.reportViewer1.LocalReport.DataSources.Add(dataSource);
            frmReports.reportViewer1.LocalReport.ReportEmbeddedResource = "DoltSharp.Reports.RptProject.rdlc";

            // Refrescar y mostrar el reporte
            frmReports.reportViewer1.RefreshReport();
            frmReports.ShowDialog();
        }
    }
}