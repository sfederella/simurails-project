using SimuRails.DB;
using SimuRails.Models;
using SimuRails.Views.Components.Attrs;
using System;
using System.Windows.Forms;

namespace SimuRails.Views.Abms
{
    public partial class EditSimulacionForm : Form
    {
        private SimulacionesListForm listForm;
        private SimulacionAttrs attrs;
        private Simulacion simulacion;
        private Repositorio repositorioSimulacion;

        public EditSimulacionForm(SimulacionesListForm listForm, Repositorio repositorioSimulacion, Simulacion simulacion)
        {
            InitializeComponent();
            this.listForm = listForm;
            this.attrs = new SimulacionAttrs(simulacion);
            this.simulacion = simulacion;
            this.repositorioSimulacion = repositorioSimulacion;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.cerrar();
        }

        private void cerrar()
        {
            this.Close();
            listForm.Visible = true;
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (this.attrs.applyTo(simulacion))
            {
                repositorioSimulacion.Actualizar(simulacion);
                listForm.updateList();
                this.cerrar();
            }

        }

        private void EditSimulacionForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(this.attrs);
            this.attrs.Width = 970;
            this.attrs.Location = new System.Drawing.Point(10, 50);
            this.attrs.Anchor = ((AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left));
            this.attrs.Name = "attrs";
        }
    }
}
