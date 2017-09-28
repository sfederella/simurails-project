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
    public partial class RenglonDeServicio : UserControl
    {
        public RenglonDeServicio(Servicio servicio)
        {
            InitializeComponent();
            this.servicioLbl.Text = servicio.Nombre;
            this.estacionesLbl.Text = "13";
            this.origenLbl.Text = servicio.Desde.Nombre;
            this.destinoLbl.Text = servicio.Hasta.Nombre;
        }

        private void RenglonDeServicio_Load(object sender, EventArgs e)
        {

        }
    }
}
