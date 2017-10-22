using System.Windows.Forms;
using SimuRails.Models;

namespace SimuRails.Views.Components
{
    public partial class CocheAttrs : UserControl
    {

        private Coche pCoche;
        public CocheAttrs(Coche coche)
        {
            InitializeComponent();
            pCoche = coche;
            BindingSourceCoche.DataSource = pCoche;
        }

        public bool applyTo(Coche coche)
        {
            if (pCoche.Modelo == null || pCoche.Modelo == "") { MessageBox.Show("Se debe completar un modelo que identifique al coche."); return false; }
            coche = pCoche;
            return true;
        }
    }
}
