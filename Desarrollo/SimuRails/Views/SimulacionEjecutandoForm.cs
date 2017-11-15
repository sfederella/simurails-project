using SimuRails.DB;
using SimuRails.Models;
using SimuRails.Report;
using SimuRails.Views.Abms;
using System;
using System.Threading;
using System.Windows.Forms;

namespace SimuRails.Views
{
    public partial class SimulacionEjecutandoForm : Form
    {
        private SimulacionesListForm form;
        private Simulacion simulacion;

        public SimulacionEjecutandoForm(SimulacionesListForm form, Simulacion simulacion)
        {
            InitializeComponent();
            this.form = form;
            this.simulacion = simulacion;
            form.Visible = false;
        }

        private void materialRaisedButton1_Click(object sender, System.EventArgs e)
        {
            SimulacionBackgroundWorker.CancelAsync();
        }

        private void SpinnerForm_Load(object sender, System.EventArgs e)
        {
            SimulacionBackgroundWorker.RunWorkerAsync();
        }

        private void SimulacionBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var id = simulacion.Id;
            using (var session = NHibernateHelper.OpenSession())
            {
                simulacion = session.Get<Simulacion>(id);
                //Convierto días a minutos
                simulacion.Duracion = simulacion.Duracion * 1440;
                bool finalizada = simulacion.Ejecutar(SimulacionBackgroundWorker);
                e.Cancel = !finalizada;
            }
        }

        private void SimulacionBackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            percentageLabel.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void SimulacionBackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                form.Visible = true;
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Ocurrió un problema al ejecutar la simulación. Por favor intente nuevamente.");
                form.Visible = true;
            } else
            {
                form.mainForm.EmbedForm(new ReportGraphsForm(form, simulacion), form.tabPage);
            }
            Close();
        }
    }
}
