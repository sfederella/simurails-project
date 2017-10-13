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
            if (incidente.Nombre != "") { this.nombreField.Text = incidente.Nombre; }
            if (incidente.Descripcion != "") { this.descripcionField.Text = incidente.Descripcion; }
            if (incidente.ProbabilidadDeOcurrencia != 0) { this.probabilidadField.Text = incidente.ProbabilidadDeOcurrencia.ToString(); }
            if (incidente.TiempoDemora != 0) { this.demoraField.Text = incidente.TiempoDemora.ToString(); }
        }

        public bool applyTo(Incidente incidente)
        {
            if (this.nombreField.Text != "") { incidente.Nombre = this.nombreField.Text; } else { MessageBox.Show("Se debe completar un nombre que identifique al Incidente."); return false; }
            if (this.descripcionField.Text != "") { incidente.Descripcion = this.descripcionField.Text; }
            double aux = 0;
            double.TryParse(this.probabilidadField.Text, out aux);
            incidente.ProbabilidadDeOcurrencia = aux;
            int aux2 = 0;
            int.TryParse(this.demoraField.Text, out aux2);
            incidente.TiempoDemora = aux2;
            return true;
        }
    }
}
