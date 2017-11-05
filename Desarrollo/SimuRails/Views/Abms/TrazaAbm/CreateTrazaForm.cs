using SimuRails.DB;
using SimuRails.Models;
using SimuRails.Views.Components.Attrs;
using System;
using System.Windows.Forms;

namespace SimuRails.Views.Abms
{
    public partial class CreateTrazaForm : Form
    {
        private TrazasListForm listForm;
        private TrazaAttrs attrs;
        private Traza traza;

        public CreateTrazaForm(TrazasListForm listForm, Traza traza, Repositorio repositiorio)
        {
            InitializeComponent();
            this.attrs = new TrazaAttrs(traza, repositiorio);
            this.traza = traza;
            this.listForm = listForm;
        }

        private void CreateTrazaForm_Load(object sender, EventArgs e)
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
            if (this.attrs.applyTo(traza))
            {
                listForm.addTraza(traza);
                this.cerrar();
            }
        }
    }
}
