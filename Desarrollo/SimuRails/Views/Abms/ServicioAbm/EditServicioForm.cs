using SimuRails.DB;
using SimuRails.Models;
using SimuRails.Views.Components.Attrs;
using System;
using System.Windows.Forms;

namespace SimuRails.Views.Abms
{
    public partial class EditServicioForm : Form
    {
        private ServiciosListForm listForm;
        private ServicioAttrs attrs;
        private Servicio servicio;
        private Repositorio repositorioServicio;

        public EditServicioForm(ServiciosListForm listForm, Repositorio repositorioServicio, Servicio servicio)
        {
            InitializeComponent();
            this.listForm = listForm;
            this.attrs = new ServicioAttrs(servicio);
            this.servicio = servicio;
            this.repositorioServicio = repositorioServicio;
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
            if (this.attrs.applyTo(servicio))
            {
                repositorioServicio.Actualizar(servicio);
                listForm.updateList();
                this.cerrar();
            }

        }

        private void EditServicioForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(this.attrs);
            this.attrs.Width = 970;
            this.attrs.Location = new System.Drawing.Point(10, 50);
            this.attrs.Anchor = ((AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left));
            this.attrs.Name = "attrs";
        }
    }
}
