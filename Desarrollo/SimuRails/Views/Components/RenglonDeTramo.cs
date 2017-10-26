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
    public partial class RenglonDeTramo : UserControl
    {

        public delegate void DelTramo(Tramo tramo);
        private DelTramo handleRemove;

        public Tramo Tramo { get; set; }

        public RenglonDeTramo(Tramo tramo, DelTramo handleRemove)
        {
            InitializeComponent();
            this.Tramo = tramo;
            this.origenLbl.Text = tramo.EstacionOrigen.Nombre;
            this.destinoLbl.Text = tramo.EstacionDestino.Nombre;
            this.distanciaLbl.Text = tramo.Distancia.ToString() + " Km";
            this.tiempoLbl.Text = tramo.TiempoViaje.ToString() + " Min";
            this.handleRemove = handleRemove;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (this.handleRemove != null)
            {
                handleRemove(Tramo);
            }
        }
    }
}
