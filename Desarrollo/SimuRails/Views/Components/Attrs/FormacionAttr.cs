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

namespace SimuRails.Views.Components.Attrs
{
    public partial class FormacionAttr : UserControl
    {
        private void FormacionAttr_Load(object sender, EventArgs e)
        {

        }

        private Formacion pFormacion;
        public FormacionAttr(Formacion formacion)
        {
            InitializeComponent();
            pFormacion = formacion;
            bindingSourceFormacion.DataSource = pFormacion;
        }

        public bool applyTo(Formacion formacion)
        {
            return true;
        }
    }
}
