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
    public partial class IncidenteAttrs : UserControl
    {
        public IncidenteAttrs(Incidente incidente)
        {
            InitializeComponent();
            this.nombreField.Text = incidente.Nombre;
            this.descripcionField.Text = incidente.Descripcion;
            this.probabilidadField.Text = incidente.ProbabilidadDeOcurrencia.ToString();
            this.demoraField.Text = incidente.TiempoDemora.ToString();
        }

        private void IncidenteAttrs_Load(object sender, EventArgs e)
        {

        }

        public void applyTo(Incidente incidente)
        {
            incidente.Nombre = this.nombreField.Text;
            incidente.Descripcion = this.descripcionField.Text;
            incidente.ProbabilidadDeOcurrencia = double.Parse(this.probabilidadField.Text);
            incidente.TiempoDemora = int.Parse(this.demoraField.Text);
        }
    }
}
