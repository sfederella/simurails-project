using System.Windows.Forms;
using SimuRails.Models;
using System.Collections.Generic;
using static SimuRails.Models.Coche;

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

            List<int> lst = new List<int>();
        }

        public bool applyTo(Coche coche)
        {
            if (pCoche.Modelo == null || pCoche.Modelo == "") { MessageBox.Show("Se debe completar un modelo que identifique al coche."); return false; }
            coche = pCoche;
            return true;
        }
    }
}
