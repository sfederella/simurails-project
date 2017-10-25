using SimuRails.Models;
using SimuRails.Views.Components.Attrs;
using System;
using System.Windows.Forms;

namespace SimuRails.Views.Abms
{
    public partial class CreateServicioForm : Form
    {
        private ServiciosListForm listForm;
        private ServicioAttrs attrs;
        private Servicio servicio;

        public CreateServicioForm(ServiciosListForm listForm, Servicio servicio)
        {
            InitializeComponent();
            this.attrs = new ServicioAttrs(servicio);
            this.servicio = servicio;
            this.listForm = listForm;
        }

        private void CreateServicioForm_Load(object sender, EventArgs e)
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
            if (this.attrs.applyTo(servicio))
            {
                listForm.addServicio(servicio);
                this.cerrar();
            }
        }
    }
}
