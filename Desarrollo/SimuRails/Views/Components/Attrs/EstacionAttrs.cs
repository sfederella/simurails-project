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
using SimuRails.DB;

namespace SimuRails.Views.Components.Attrs
{
    public partial class EstacionAttrs : UserControl
    {
        public EstacionAttrs(Estacion estacion)
        {
            InitializeComponent();
            if (estacion.Nombre != "") { this.nombreField.Text = estacion.Nombre; }
            if (estacion.PersonasEsperandoMin != 0) { this.cantMinimaField.Text = estacion.PersonasEsperandoMin.ToString(); }
            if (estacion.PersonasEsperandoMax != 0) { this.cantMaximaField.Text = estacion.PersonasEsperandoMax.ToString(); }
            if (estacion.TipoFDP != "") { this.FDPCombo.SelectedItem = estacion.TipoFDP; }

            //clbIncidentes.DisplayMember = "Nombre";
            //clbIncidentes.Items.Clear();
            //Repositorio repoIncidentes = new Repositorio();
            //var incidentes = repoIncidentes.Listar<Incidente>();
            //incidentes.ToList().ForEach(x => {clbIncidentes.Items.Add(x);});         
            //foreach (Incidente i in estacion.Incidentes)
            //{
            //    clbIncidentes.SetItemChecked(clbIncidentes.Items.IndexOf(i), true);
            //}
        }

        public bool applyTo(Estacion estacion)
        {
            if (this.nombreField.Text != "") { estacion.Nombre = this.nombreField.Text; } else { MessageBox.Show("Se debe completar un nombre que identifique a la Estación."); return false; }
            int aux = 0;
            int.TryParse(this.cantMaximaField.Text, out aux);
            estacion.PersonasEsperandoMax = aux;
            int.TryParse(this.cantMinimaField.Text, out aux);
            estacion.PersonasEsperandoMin = aux;
            if (this.FDPCombo.SelectedItem != null) { estacion.TipoFDP = this.FDPCombo.SelectedItem.ToString(); }
            //    estacion.Incidentes = new List<Incidente>();
            //    foreach (Incidente i in clbIncidentes.CheckedItems)
            //    {
            //       estacion.Incidentes.Add(i);
            //    }
            return true;
        }

    }
}
