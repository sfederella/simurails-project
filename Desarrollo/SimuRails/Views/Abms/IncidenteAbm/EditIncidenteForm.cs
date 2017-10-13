using SimuRails.DB;
using SimuRails.Models;
using SimuRails.Views.Components.Attrs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuRails.Views.Abms.IncidenteAbm
{
    public partial class EditIncidenteForm : Form
    {
        private IncidentesListForm listForm;
        private IncidenteAttrs attrs;
        private Incidente incidente;
        private Repositorio repositorioIncidente;

        public EditIncidenteForm(IncidentesListForm listForm, Repositorio repositorioIncidente, Incidente incidente)
        {
            InitializeComponent();
            this.listForm = listForm;
            this.attrs = new IncidenteAttrs(incidente);
            this.incidente = incidente;
            this.repositorioIncidente = repositorioIncidente;
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
            this.attrs.applyTo(incidente);
            repositorioIncidente.Actualizar(incidente);
            listForm.updateList();
            this.cerrar();
        }

        private void EditIncidenteForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(this.attrs);
            this.attrs.Width = 970;
            this.attrs.Location = new System.Drawing.Point(0, 50);
            this.attrs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top)));
            this.attrs.Name = "attrs";
        }
    }
}
