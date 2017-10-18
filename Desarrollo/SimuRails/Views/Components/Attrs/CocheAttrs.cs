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

namespace SimuRails.Views.Components
{
    public partial class CocheAttrs : UserControl
    {

        public CocheAttrs(Coche coche)
        {
            InitializeComponent();
            if (coche.Modelo != "") { this.modeloField.Text = coche.Modelo; }
            this.locomotoraCheck.Checked = coche.EsLocomotora;
            this.consumoCombo.SelectedItem = coche.TipoDeConsumo.ToString();
            if (coche.ConsumoMovimiento != 0) { this.consumoAndandoField.Text = coche.ConsumoMovimiento.ToString(); }
            if (coche.ConsumoParado != 0) { this.consumoParadoField.Text = coche.ConsumoParado.ToString(); }
            if (coche.MaximoLegalPasajeros != 0) { this.capacidadLegalField.Text = coche.MaximoLegalPasajeros.ToString(); }
            if (coche.CapacidadMaximaPasajeros != 0) { this.capacidadTotalField.Text = coche.CapacidadMaximaPasajeros.ToString(); }
        }

        public bool applyTo(Coche coche)
        {

            if (this.modeloField.Text != "") { coche.Modelo = this.modeloField.Text; } else { MessageBox.Show("Se debe completar un modelo que identifique al Coche."); return false; }
            coche.EsLocomotora = this.locomotoraCheck.Checked;
            if (this.consumoCombo.SelectedItem != null) { coche.TipoDeConsumo = (Coche.TipoConsumo) Enum.Parse(typeof(Coche.TipoConsumo),this.consumoCombo.SelectedItem.ToString().ToUpper()); }
            int aux = 0;
            int.TryParse(this.consumoAndandoField.Text, out aux);
            coche.ConsumoMovimiento = aux;
            int.TryParse(this.consumoParadoField.Text, out aux);
            coche.ConsumoParado = aux;
            int.TryParse(this.capacidadLegalField.Text, out aux);
            coche.MaximoLegalPasajeros = aux;
            int.TryParse(this.capacidadTotalField.Text, out aux);
            coche.CapacidadMaximaPasajeros = aux;
            return true;
        }
    }
}
