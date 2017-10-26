using SimuRails.Models;
using SimuRails.Report;
using SimuRails.Views.Abms;
using System.Threading;
using System.Windows.Forms;

namespace SimuRails.Views
{
    public partial class SpinnerForm : Form
    {
        private Simulacion simulacion;
        private SimulacionesListForm form;

        public SpinnerForm(SimulacionesListForm form, Simulacion simulacion)
        {
            InitializeComponent();
            this.simulacion = simulacion;
            this.form = form;
            form.Visible = false;
        }

        private void materialRaisedButton1_Click(object sender, System.EventArgs e)
        {
            form.Visible = true;
            this.Close();
        }

        private void SpinnerForm_Load(object sender, System.EventArgs e)
        {
            this.Show();
        }

        private void showResultadoReport()
        {
            this.Close();
            this.form.mainForm.embedForm(new ReportGraphsForm(this.simulacion), this.form.tabPage);
        }

        private void SpinnerForm_Shown(object sender, System.EventArgs e)
        {
            Application.DoEvents();
            // simulacion.Ejecutar();           
            //System.Threading.Thread.Sleep(2000);
            //showResultadoReport();
        }
    }
}
