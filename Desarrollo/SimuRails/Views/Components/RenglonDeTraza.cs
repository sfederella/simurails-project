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
    public partial class RenglonDeTraza : UserControl
    {
        public RenglonDeTraza(Traza traza)
        {
            InitializeComponent();
            this.materialLabel1.Text = traza.Nombre;
        }
    }
}
