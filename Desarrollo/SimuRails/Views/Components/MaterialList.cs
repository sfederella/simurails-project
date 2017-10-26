using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuRails.Views.Components
{
    public partial class MaterialList : UserControl
    {
        private List<Control> renglones = new List<Control>();

        public MaterialList()
        {
            InitializeComponent();
            this.panel1.Visible = false;
            this.agregarControlEn(new RenglonListaVacia(), 5, 0, this);
        }

        public void setearRenglones(List<Control> renglones)
        {
            this.vaciar();
            this.agregarRenglones(renglones);
        }

        public void agregarRenglones(List<Control> renglones)
        {
            renglones.ForEach(renglon => this.agregarRenglon(renglon));
        }

        public void agregarRenglon(Control renglon)
        {
            var indice = this.panel1.Controls.Count;
            this.agregarControlEn(renglon, 5, indice * 50, this.panel1);
            this.panel1.Visible = true;
        }

        private void agregarControlEn(Control control, int x, int y, Control container)
        {
            control.Location = new System.Drawing.Point(x, y);
            control.Width = container.Width;
            control.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            container.Controls.Add(control);
        }

        public void vaciar()
        {
            this.panel1.Controls.Clear();
            this.panel1.Visible = false;
        }

        private void MaterialList_Load(object sender, EventArgs e)
        {

        }
    }
}
