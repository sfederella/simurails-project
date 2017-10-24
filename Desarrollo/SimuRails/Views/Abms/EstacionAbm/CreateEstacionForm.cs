using SimuRails.Models;
using SimuRails.Views.Components.Attrs;
using System;
using System.Windows.Forms;

namespace SimuRails.Views.Abms
{
    public partial class CreateEstacionForm : Form
    {
        private EstacionesListForm listForm;
        private EstacionAttrs attrs;
        private Estacion estacion;

        public CreateEstacionForm(EstacionesListForm listForm, Estacion estacion)
        {
            InitializeComponent();
            this.attrs = new EstacionAttrs(estacion);
            this.estacion = estacion;
            this.listForm = listForm;
        }

        private void CreateEstacionForm_Load(object sender, EventArgs e)
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

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if(this.attrs.applyTo(estacion))
            {
                listForm.addEstacion(estacion);
                this.cerrar();
            }

        }
    }
}
