using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimuRails.Models;

namespace SimuRails.Views.Components
{
    public partial class RenglonDeTrazaSimu : UserControl
    {
        public event EventHandler Selected;

        public RenglonDeTrazaSimu(Traza traza)
        {
            InitializeComponent();
            this.materialLabel1.Text = traza.Nombre;
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            EventHandler handler = Selected;

            if (handler != null && radioButton.Checked)
            {
                handler(this, EventArgs.Empty);
            }
        }

        public void deseleccionar()
        {
            radioButton.Checked = false;
        }
    }
}
