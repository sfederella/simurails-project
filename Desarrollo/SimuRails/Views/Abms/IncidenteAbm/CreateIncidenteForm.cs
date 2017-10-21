using SimuRails.Models;
using SimuRails.Views.Components.Attrs;
using System;
using System.Windows.Forms;

namespace SimuRails.Views.Abms.IncidenteAbm
{
    public partial class CreateIncidenteForm : Form
    {
        private IncidentesListForm listForm;
        private IncidenteAttrs attrs;
        private Incidente incidente;

        public CreateIncidenteForm(IncidentesListForm listForm, Incidente incidente)
        {
            InitializeComponent();
            this.attrs = new IncidenteAttrs(incidente);
            this.incidente = incidente;
            this.listForm = listForm;
        }

        private void CreateIncidenteForm_Load(object sender, EventArgs e)
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
            if (this.attrs.applyTo(incidente))
            {
                 listForm.addIncidente(incidente);
                this.cerrar();
            }
        }
    }
}
