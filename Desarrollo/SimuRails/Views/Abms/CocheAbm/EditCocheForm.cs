using SimuRails.Models;
using SimuRails.Views.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuRails.Views.Abms
{
    public partial class EditCocheForm : Form
    {
        private CochesListForm listForm;
        private CocheAttrs attrs;
        private Coche coche;

        public EditCocheForm(CochesListForm listForm, Coche coche)
        {
            InitializeComponent();
            this.listForm = listForm;
            this.attrs = new CocheAttrs(coche);
            this.coche = coche;
        }

        private void EditCocheForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(this.attrs);
            this.attrs.Width = 970;
            this.attrs.Location = new System.Drawing.Point(0, 50);
            this.attrs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top)));
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
            this.attrs.applyTo(coche);
            listForm.updateList();
            this.cerrar();
        }
    }
}
