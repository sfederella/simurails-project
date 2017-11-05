using SimuRails.DB;
using SimuRails.Models;
using SimuRails.Views.Components.Attrs;
using System;
using System.Windows.Forms;

namespace SimuRails.Views.Abms
{
    public partial class EditIncidenteForm : Form
    {
        private IncidentesListForm listForm;
        private IncidenteAttrs attrs;
        private Incidente incidente;

        public EditIncidenteForm(IncidentesListForm listForm, Incidente incidente)
        {
            InitializeComponent();
            this.listForm = listForm;
            this.attrs = new IncidenteAttrs(incidente);
            this.incidente = incidente;
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
            if (this.attrs.applyTo(incidente))
            {
                using (var repositorio = new Repositorio())
                {
                    repositorio.Actualizar(incidente);
                    listForm.dibujarRenglones(repositorio);
                }

                this.cerrar();
            }

        }

        private void EditIncidenteForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(this.attrs);
            this.attrs.Width = 970;
            this.attrs.Location = new System.Drawing.Point(10, 50);
            this.attrs.Anchor = ((AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left));
            this.attrs.Name = "attrs";
        }
    }
}
