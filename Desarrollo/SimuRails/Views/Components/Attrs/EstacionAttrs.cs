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
        private Estacion pEstacion;
        private List<Incidente> pIncidentes;

        public EstacionAttrs(Estacion estacion, Repositorio repositorio)
        {
            InitializeComponent();
            pEstacion = estacion;
            BindingSourceEstacion.DataSource = pEstacion;
            this.pIncidentes = repositorio.Listar<Incidente>();
            BindIncidentes();

            esperandoMinIdaField.IsNumeric = true;
            esperandoMaxIdaField.IsNumeric = true;
            esperandoMinVueltaField.IsNumeric = true;
            esperandoMaxVueltaField.IsNumeric = true;
            desciendenMinIdaField.IsNumeric = true;
            desciendenMaxIdaField.IsNumeric = true;
            desciendenMinVueltaField.IsNumeric = true;
            desciendenMaxVueltaField.IsNumeric = true;
        }

        public bool applyTo(Estacion estacion)
        {
            if (pEstacion.Nombre == null || pEstacion.Nombre == "") { MessageBox.Show("Se debe completar un nombre que identifique a la Estación."); return false; }
            estacion = pEstacion;
            return true;
        }

        #region " Incidentes "
        private void BindIncidentes()
        {
            BindingSourceIncidentesAsignados.DataSource = GetLstTrazasAsignadas();
            BindingSourceEstacion.SuspendBinding();
            List<Incidente> lst = new List<Incidente>();
            foreach (Incidente incidente in this.pIncidentes)
            {
                if (!pEstacion.Incidentes.Any(i => i.Id==incidente.Id))
                {
                    lst.Add(incidente);
                }
            }
            BindingSourceIncidentesDisponibles.DataSource = lst;
            BindingSourceEstacion.ResumeBinding();
        }
        private void ButtonAsignar_Click(object sender, EventArgs e)
        {
            if ((BindingSourceIncidentesDisponibles.Current != null))
            {
                pEstacion.Incidentes.Add((Incidente)BindingSourceIncidentesDisponibles.Current);
                BindIncidentes();
            }
        }

        private void ButtonDesasignar_Click(object sender, EventArgs e)
        {
            if ((BindingSourceIncidentesAsignados.Current != null))
            {
                Incidente select = pEstacion.Incidentes.Where(i => i.Id == ((KeyValue)BindingSourceIncidentesAsignados.Current).Clave).First();
                pEstacion.Incidentes.Remove(select);
                BindIncidentes();
            }
        }

        private List<KeyValue> GetLstTrazasAsignadas()
        {
            return (from x in pEstacion.Incidentes select new KeyValue(x.Id, x.Nombre)).ToList();
        }

        #endregion

    }
}
