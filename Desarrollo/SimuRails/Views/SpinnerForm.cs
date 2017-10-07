using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuRails.Views
{
    public partial class SpinnerForm : Form
    {
        private Simulacion simulacionForm;

        public SpinnerForm(Simulacion simulacionForm)
        {
            InitializeComponent();
            this.simulacionForm = simulacionForm;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            simulacionForm.Visible = true;
        }
    }
}
