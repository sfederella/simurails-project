using System;
using System.Windows.Forms;
using SimuRails.Models;
using System.Collections.Generic;
using SimuRails.DB;
using System.Linq;
using SimuRails.Views.Validables;

namespace SimuRails.Views.Components.Attrs
{
    public partial class TrazaAttrs : UserControl
    {
        private Traza pTraza;
        private List<Servicio> pServicios;
        private List<Validable> validables = new List<Validable>();

        public TrazaAttrs(Traza traza, Repositorio repositiorio)
        {
            InitializeComponent();
            pTraza = traza;

            validables.Add(new Validator<Traza>(pTraza, ReglaConcreta<Traza>.dePresencia((s => s.Nombre)), this.errorNombreLbl, this.nombreField));
            validables.Add(new Validator<Traza>(pTraza, new ReglaConcreta<Traza>((s => s.Servicios.Count > 0), "Debe haber al menos un servicio asignado"), this.errorServiciosLbl));

            BindingSourceTraza.DataSource = pTraza;
            pServicios = repositiorio.Listar<Servicio>();
            BindServicios();
        }

        public bool applyTo(Traza traza)
        {
            validables.ForEach(validable => validable.mostrarError());
            return validables.TrueForAll(validable => validable.esValido());
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
                errorServiciosLbl.Visible = false;
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

        private void TrazaAttrs_Load(object sender, EventArgs e)
        {

        }
    }
}
