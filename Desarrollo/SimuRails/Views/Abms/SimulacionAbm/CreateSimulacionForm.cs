using SimuRails.DB;
using SimuRails.Models;
using SimuRails.Views.Components.Attrs;
using System;
using System.Windows.Forms;

namespace SimuRails.Views.Abms
{
    public partial class CreateSimulacionForm : Form
    {
        private SimulacionesListForm listForm;
        private SimulacionAttrs attrs;
        private Simulacion simulacion;

        public CreateSimulacionForm(SimulacionesListForm listForm, Simulacion simulacion, Repositorio repositorio)
        {
            InitializeComponent();
            this.attrs = new SimulacionAttrs(simulacion, repositorio);
            this.simulacion = simulacion;
            this.listForm = listForm;
        }

        private void CreateSimulacionForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(this.attrs);
            this.attrs.Width = 970;
            this.attrs.Location = new System.Drawing.Point(10, 50);
            this.attrs.Anchor = ((AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left));
            this.attrs.Name = "attrs";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (this.attrs.applyTo(simulacion))
            {
                listForm.addSimulacion(simulacion);
                this.cerrar();
            }
        }
    }
}
