using System;
using System.Windows.Forms;
using SimuRails.Models;
using SimuRails.Views.Abms;
using SimuRails.DB;

namespace SimuRails.Views.Components
{
    public partial class RenglonDeSimulacion : UserControl
    {
        private int id;
        public delegate void Del(int id);
        private Del handleEdit;
        private Del handleRemove;

        private Simulacion simulacion;
        private SimulacionesListForm form;

        public int Id { get; set; }

        public RenglonDeSimulacion(Simulacion simulacion, Del handleEdit, Del handleRemove,SimulacionesListForm form)
        {
            InitializeComponent();
            this.nombreLbl.Text = simulacion.Nombre;
            this.duracionLbl.Text = simulacion.Duracion.ToString();
            this.trazaLbl.Text = simulacion.TrazaSimulada.Nombre;
            this.id = simulacion.Id;
            this.handleEdit = handleEdit;
            this.handleRemove = handleRemove;
            this.simulacion = simulacion;
            this.form = form;
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if(this.handleEdit != null)
            {
                handleEdit(id);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (this.handleRemove != null)
            {
                handleRemove(id);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.form.mainForm.EmbedForm(new SpinnerForm(this.form,this.simulacion), this.form.tabPage);   
            var id = simulacion.Id;           
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                Simulacion sim = session.Get<Simulacion>(id);
                sim.Metodo = new TiempoComprometido();
                sim.Ejecutar();
                transaction.Commit();
            }
        }
    }
}
