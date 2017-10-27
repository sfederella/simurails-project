using Microsoft.Reporting.WinForms;
using SimuRails.Models;
using System.Collections.Generic;

namespace SimuRails.Report
{
class ReportHelper
    {
        static char[] charToTrim = { ' ', ',', ')', '.' };
 
        public static void ProcessReport(Simulacion simulacion, List<ReportHelperGrafico> lstRutas, Microsoft.Reporting.WinForms.ReportViewer Viewer)
        {
            Viewer.LocalReport.ReportEmbeddedResource = "SimuRails.Report.ReportGrafico.rdlc";

            Viewer.LocalReport.EnableExternalImages = true;
            ReportDataSource dsRutas = new ReportDataSource();
            dsRutas.Value = lstRutas;
            dsRutas.Name = "DataSetRutas";
            Viewer.LocalReport.DataSources.Add(dsRutas);        

            List <ReportParameter>lstParam = new List<ReportParameter>();
            lstParam.Add(new ReportParameter("NombreSimulacion", simulacion.Nombre));
            lstParam.Add(new ReportParameter("DuracionSimulacion", simulacion.Duracion.ToString() + " minutos"));
            Viewer.LocalReport.SetParameters(lstParam);
            Viewer.LocalReport.DisplayName = "SimuRails - Simulación " + simulacion.Nombre;      
            Viewer.RefreshReport();
        }  
    }
}
