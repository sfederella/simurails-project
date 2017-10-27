using SimuRails.DB;
using SimuRails.Models;
using SimuRails.Views.Components.Attrs;
using System;
using System.Windows.Forms;

namespace SimuRails.Views.Abms
{
    public partial class EditEstacionForm : Form
    {
        private EstacionesListForm listForm;
        private EstacionAttrs attrs;
        private Estacion estacion;
        private Repositorio repositorioEstacion;

        public EditEstacionForm(EstacionesListForm listForm, Repositorio repositorioEstacion, Estacion estacion)
        {
            InitializeComponent();
            this.listForm = listForm;
            this.attrs = new EstacionAttrs(estacion);
            this.estacion = estacion;
            this.repositorioEstacion = repositorioEstacion;
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
            if(this.attrs.applyTo(estacion))
            {
                repositorioEstacion.Actualizar(estacion);
                listForm.updateList();
                this.cerrar();
            }
        }

        private void EditEstacionForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(this.attrs);
            this.attrs.Width = 970;
            this.attrs.Location = new System.Drawing.Point(10, 50);
            this.attrs.Anchor = ((AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left));
            this.attrs.Name = "attrs";
        }
    }
}
