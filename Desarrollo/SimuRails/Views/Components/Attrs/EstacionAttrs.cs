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
            this.EsMantenimientoCheck.Checked = estacion.EsEstacionDeMantenimiento;
            if (estacion.PersonasEsperandoMaxIda != 0) { this.esperandoMaxIdaField.Text = estacion.PersonasEsperandoMaxIda.ToString(); }
            if (estacion.PersonasEsperandoMaxVuelta != 0) { this.esperandoMaxVueltaField.Text = estacion.PersonasEsperandoMaxVuelta.ToString(); }
            if (estacion.PersonasEsperandoMinIda != 0) { this.esperandoMinIdaField.Text = estacion.PersonasEsperandoMinIda.ToString(); }
            if (estacion.PersonasEsperandoMinVuelta != 0) { this.esperandoMinVueltaField.Text = estacion.PersonasEsperandoMinVuelta.ToString(); }
            if (estacion.PersonasDesciendenMaxIda != 0) { this.desciendenMaxIdaField.Text = estacion.PersonasDesciendenMaxIda.ToString(); }
            if (estacion.PersonasDesciendenMaxVuelta != 0) { this.desciendenMaxVueltaField.Text = estacion.PersonasDesciendenMaxVuelta.ToString(); }
            if (estacion.PersonasDesciendenMinIda != 0) { this.desciendenMinIdaField.Text = estacion.PersonasDesciendenMinIda.ToString(); }
            if (estacion.PersonasDesciendenMinVuelta != 0) { this.desciendenMinVueltaField.Text = estacion.PersonasDesciendenMinVuelta.ToString(); }
         
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
            estacion.EsEstacionDeMantenimiento = this.EsMantenimientoCheck.Checked;
            int aux = 0;
            int.TryParse(this.esperandoMaxIdaField.Text, out aux);
            estacion.PersonasEsperandoMaxIda = aux;
            aux = 0;
            int.TryParse(this.esperandoMaxVueltaField.Text, out aux);
            estacion.PersonasEsperandoMaxVuelta = aux;
            aux = 0;
            int.TryParse(this.esperandoMinIdaField.Text, out aux);
            estacion.PersonasEsperandoMinIda = aux;
            aux = 0;
            int.TryParse(this.esperandoMinVueltaField.Text, out aux);
            estacion.PersonasEsperandoMinVuelta = aux;
            aux = 0;
            int.TryParse(this.desciendenMaxIdaField.Text, out aux);
            estacion.PersonasDesciendenMaxIda = aux;
            aux = 0;
            int.TryParse(this.desciendenMaxVueltaField.Text, out aux);
            estacion.PersonasDesciendenMaxVuelta = aux;
            aux = 0;
            int.TryParse(this.desciendenMinIdaField.Text, out aux);
            estacion.PersonasDesciendenMinIda = aux;
            aux = 0;
            int.TryParse(this.desciendenMinVueltaField.Text, out aux);
            estacion.PersonasDesciendenMinVuelta = aux;

                   //if (this.FDPCombo.SelectedItem != null) { estacion.TipoFDP = this.FDPCombo.SelectedItem.ToString(); }
            //    estacion.Incidentes = new List<Incidente>();
            //    foreach (Incidente i in clbIncidentes.CheckedItems)
            //    {
            //       estacion.Incidentes.Add(i);
            //    }
            return true;
        }

    }
}
