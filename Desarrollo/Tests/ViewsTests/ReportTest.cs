using SimuRails.Models;
using SimuRails.Report;
using SimuRails.Views;
using SimuRails.Views.Abms;
using System;
using System.Windows.Forms;
using Tests.ModelsTests;

namespace SimuRails
{
    static class ReportTest
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Simulacion simu = new Simulacion();
            simu.Nombre = "Test Simulacion";
            simu.Duracion = 30;
            ModelMock mo = new ModelMock();
            mo.MockResultados();
            simu.TrazaSimulada = mo.Traza;
            ReportGraphsForm frm = new ReportGraphsForm(new SimulacionesListForm(), simu);
            frm.ShowDialog();
        }
    }
}
