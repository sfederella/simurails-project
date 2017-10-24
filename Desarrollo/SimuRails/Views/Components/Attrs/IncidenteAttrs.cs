using System.Windows.Forms;
using SimuRails.Models;

namespace SimuRails.Views.Components.Attrs
{
    public partial class IncidenteAttrs : UserControl
    {
        private Incidente pIncidente;

        public IncidenteAttrs(Incidente incidente)
        {
            InitializeComponent();
            pIncidente = incidente;
            BindingSourceIncidente.DataSource = pIncidente;

        }

        public bool applyTo(Incidente incidente)
        {
            if (pIncidente.Nombre==null || pIncidente.Nombre =="") { MessageBox.Show("Se debe completar un nombre que identifique al Incidente."); return false; }
            incidente = pIncidente;
            return true;
        }
    }
}
