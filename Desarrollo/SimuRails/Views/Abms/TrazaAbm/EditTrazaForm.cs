using SimuRails.DB;
using SimuRails.Models;
using SimuRails.Views.Components.Attrs;
using System;
using System.Windows.Forms;

namespace SimuRails.Views.Abms
{
    public partial class EditTrazaForm : Form
    {
        private TrazasListForm listForm;
        private TrazaAttrs attrs;
        private Traza traza;
        private Repositorio repositorioTraza;

        public EditTrazaForm(TrazasListForm listForm, Repositorio repositorioTraza, Traza traza)
        {
            InitializeComponent();
            this.listForm = listForm;
            this.attrs = new TrazaAttrs(traza);
            this.traza = traza;
            this.repositorioTraza = repositorioTraza;
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
            if (this.attrs.applyTo(traza))
            {
                repositorioTraza.Actualizar(traza);
                listForm.updateList();
                this.cerrar();
            }

        }

        private void EditTrazaForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(this.attrs);
            this.attrs.Width = 970;
            this.attrs.Location = new System.Drawing.Point(10, 50);
            this.attrs.Anchor = ((AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left));
            this.attrs.Name = "attrs";
        }
    }
}
