using System;
using System.Windows.Forms;
using SimuRails.Models;
using System.Collections.Generic;
using SimuRails.DB;
using System.Linq;

namespace SimuRails.Views.Components.Attrs
{
    public partial class TrazaAttrs : UserControl
    {
        private Traza pTraza;
        private List<Servicio> pServicios;

        public TrazaAttrs(Traza traza, Repositorio repositiorio)
        {
            InitializeComponent();
            pTraza = traza;
            BindingSourceTraza.DataSource = pTraza;
            pServicios = repositiorio.Listar<Servicio>();
            BindServicios();
        }

        public bool applyTo(Traza traza)
        {
            if (pTraza.Nombre == null || pTraza.Nombre == "") { MessageBox.Show("Se debe completar un nombre que identifique a la Traza."); return false; }
            if (pTraza.Servicios.Count == 0) { MessageBox.Show("La traza debe incluir al menos un servicio."); return false; }
            traza = pTraza;
            return true;
          }

        #region " Servicios "
        private void BindServicios()
        {
            BindingSourceServiciosAsignados.DataSource = GetLstServiciosAsignados();
            BindingSourceTraza.SuspendBinding();
            List<Servicio> lst = new List<Servicio>();
            foreach (Servicio servicio in pServicios)
            {
                if (!pTraza.Servicios.Any(i => i.Id == servicio.Id))
                {
                    lst.Add(servicio);
                }
            }
            BindingSourceServiciosDisponibles.DataSource = lst;
            BindingSourceTraza.ResumeBinding();
        }
        private void ButtonAsignar_Click(object sender, EventArgs e)
        {
            if ((BindingSourceServiciosDisponibles.Current != null))
            {
                pTraza.Servicios.Add((Servicio)BindingSourceServiciosDisponibles.Current);
                BindServicios();
            }
        }

        private void ButtonDesasignar_Click(object sender, EventArgs e)
        {
            if ((BindingSourceServiciosAsignados.Current != null))
            {
                Servicio select = pTraza.Servicios.Where(i => i.Id == ((KeyValue)BindingSourceServiciosAsignados.Current).Clave).First();
                pTraza.Servicios.Remove(select);
                BindServicios();
            }
        }

        private List<KeyValue> GetLstServiciosAsignados()
        {
            return (from x in pTraza.Servicios select new KeyValue(x.Id, x.Nombre)).ToList();
        }
        #endregion
    }
}
