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
        private Repositorio repositorioIncidentes = new Repositorio();
        private Estacion pEstacion; 
        public EstacionAttrs(Estacion estacion)
        {
            InitializeComponent();
            pEstacion = estacion;
            BindingSourceEstacion.DataSource = pEstacion;
           // BindIncidentes();
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
            ListBoxAsignados.DataSource = pEstacion.Incidentes;
            BindingSourceEstacion.SuspendBinding();
            List<Incidente> lst = new List<Incidente>();
            foreach (Incidente incidente in repositorioIncidentes.Listar<Incidente>())
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
            //if ((BindingSourceIncidentesDisponibles.Current != null))
            //{
            //    pEstacion.Incidentes.Add((Incidente)BindingSourceIncidentesDisponibles.Current);
            //    BindIncidentes();
            //}
        }

        private void ButtonDesasignar_Click(object sender, EventArgs e)
        {
            //if ((BindingSourceIncidentesAsignados.Current != null))
            //{
            //    pEstacion.Incidentes.Remove((Incidente)BindingSourceIncidentesAsignados.Current);
            //    BindIncidentes();
            //}
         }
        #endregion

    }
}
