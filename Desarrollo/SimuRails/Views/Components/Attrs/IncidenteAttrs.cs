using System.Windows.Forms;
using SimuRails.Models;
using SimuRails.Views.Validables;
using System.Collections.Generic;

namespace SimuRails.Views.Components.Attrs
{
    public partial class IncidenteAttrs : UserControl
    {
        private Incidente pIncidente;
        private List<Validable> validables = new List<Validable>();

        public IncidenteAttrs(Incidente incidente)
        {
            InitializeComponent();
            pIncidente = incidente;

            validables.Add(new Validator<Incidente>(pIncidente, ReglaConcreta<Incidente>.dePresencia((unIncidente => unIncidente.Nombre)), this.errorNombreLbl, this.nombreField));
            validables.Add(new Validator<Incidente>(pIncidente, 
                new ReglaConcreta<Incidente>(unIncidente => unIncidente.ProbabilidadDeOcurrencia >= 0 && unIncidente.ProbabilidadDeOcurrencia <= 100, "Debe ser un valor entre 0 y 100"), 
                this.errorOcurrenciaLbl, this.probabilidadField));
            validables.Add(new Validator<Incidente>(pIncidente, ReglaConcreta<Incidente>.dePositivo((unIncidente => unIncidente.TiempoDemora)), this.errorDemoraLbl, this.demoraField));

            BindingSourceIncidente.DataSource = pIncidente;

            probabilidadField.IsNumeric = true;
            demoraField.IsNumeric = true;

        }

        public bool applyTo(Incidente incidente)
        {
            validables.ForEach(validable => validable.mostrarError());
            return validables.TrueForAll(validable => validable.esValido());
        }
    }
}
