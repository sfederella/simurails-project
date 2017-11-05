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

namespace SimuRails.Views.Abms.FormacionAbm
{
    public partial class EditFormacionForm : Form
    {
        private FormacionListForm listForm;
        private FormacionAttr attrs;
        private Formacion formacion;

        public EditFormacionForm(FormacionListForm listForm, Formacion formacion, Repositorio repositorio)
        {
            InitializeComponent();
            this.listForm = listForm;
            this.attrs = new FormacionAttr(formacion, repositorio);
            this.formacion = formacion;
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
            if (this.attrs.applyTo(formacion))
            {
                using (var repositorio = new Repositorio())
                {
                    repositorio.GuardarOActualizar(formacion);
                }
                listForm.updateList();
                this.cerrar();
            }
        }

        private void EditFormacionForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(this.attrs);
            this.attrs.Width = 970;
            this.attrs.Location = new System.Drawing.Point(10, 50);
            this.attrs.Anchor = ((AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left));
            this.attrs.Name = "attrs";
        }
    }
}
