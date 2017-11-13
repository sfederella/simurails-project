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
using SimuRails.Views.Validables;

namespace SimuRails.Views.Components.Attrs
{
    public partial class EstacionAttrs : UserControl
    {
        private Estacion pEstacion;
        private List<Incidente> pIncidentes;

        private List<Validable> validables = new List<Validable>();

        public EstacionAttrs(Estacion estacion, Repositorio repositorio)
        {
            InitializeComponent();
            pEstacion = estacion;

            validables.Add(new Validator<Estacion>(pEstacion, ReglaConcreta<Estacion>.dePresencia((unaEstacion=> unaEstacion.Nombre)), this.errorNombreLbl, this.nombreField));
            validables.Add(new Validator<Estacion>(pEstacion, ReglaCompuesta<Estacion>.minimoMaximoNoNegativos(e => e.PersonasEsperandoMinIda, e => e.PersonasEsperandoMaxIda), 
                this.errorSubidaIda, this.esperandoMaxIdaField));
            validables.Add(new Validator<Estacion>(pEstacion, ReglaCompuesta<Estacion>.minimoMaximoNoNegativos(e => e.PersonasEsperandoMinVuelta, e => e.PersonasEsperandoMaxVuelta), 
                this.errorSubidaVuelta, this.esperandoMaxVueltaField));
            validables.Add(new Validator<Estacion>(pEstacion, ReglaCompuesta<Estacion>.minimoMaximoNoNegativos(e => e.PersonasDesciendenMinIda, e => e.PersonasDesciendenMaxIda), 
                this.errorBajadaIda, this.desciendenMaxIdaField));
            validables.Add(new Validator<Estacion>(pEstacion, ReglaCompuesta<Estacion>.minimoMaximoNoNegativos(e => e.PersonasDesciendenMinVuelta, e => e.PersonasDesciendenMaxVuelta), 
                this.errorBajadaVuelta, this.desciendenMaxVueltaField));

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
            validables.ForEach(validable => validable.mostrarError());
            return validables.TrueForAll(validable => validable.esValido());
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
