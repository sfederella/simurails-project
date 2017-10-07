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
            this.modeloField.Text = coche.Modelo;
            this.locomotoraCheck.Checked = coche.EsLocomotora;
            this.consumoCombo.SelectedItem = coche.TipoDeConsumo;
            this.consumoAndandoField.Text = coche.ConsumoMovimiento.ToString();
            this.consumoParadoField.Text = coche.ConsumoParado.ToString();
            this.capacidadLegalField.Text = coche.MaximoLegalPasajeros.ToString();
            this.capacidadTotalField.Text = coche.CapacidadMaximaPasajeros.ToString();
        }

        private void CocheAttrs_Load(object sender, EventArgs e)
        {

        }

        public void applyTo(Coche coche)
        {
            coche.Modelo = this.modeloField.Text;
            coche.EsLocomotora = this.locomotoraCheck.Checked;
            coche.TipoDeConsumo = this.consumoCombo.SelectedItem.ToString();
            coche.ConsumoMovimiento = int.Parse(this.consumoAndandoField.Text);
            coche.ConsumoParado = int.Parse(this.consumoParadoField.Text);
            coche.MaximoLegalPasajeros = int.Parse(this.capacidadLegalField.Text);
            coche.CapacidadMaximaPasajeros = int.Parse(this.capacidadTotalField.Text);
        }
    }
}
