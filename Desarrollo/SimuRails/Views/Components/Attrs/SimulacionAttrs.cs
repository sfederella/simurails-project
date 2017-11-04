using System.Windows.Forms;
using SimuRails.Models;
using SimuRails.DB;
using System.Collections.Generic;
using System.Linq;

namespace SimuRails.Views.Components.Attrs
{
    public partial class SimulacionAttrs : UserControl
    {
        private Simulacion pSimulacion;
        private Repositorio repositorioTrazas = new Repositorio();
        public SimulacionAttrs(Simulacion simulacion)
        {
            InitializeComponent();
            pSimulacion = simulacion;
            BindingSourceSimulacion.DataSource = pSimulacion;
            List<Traza> list = repositorioTrazas.Listar<Traza>();
            BindingSourceTraza.DataSource = list;
            ComboBoxTraza.listaDatos = list.Select(x => x.Nombre).ToList();
            contadorMinutosText.Text = (simulacion.Duracion * 1440).ToString();
        }

        public bool applyTo(Simulacion simulacion)
        {
            if (pSimulacion.Nombre == null || pSimulacion.Nombre == "") { MessageBox.Show("Se debe completar un nombre que identifique a la simulación."); return false; }
            pSimulacion.TrazaSimulada = (Traza)ComboBoxTraza.SelectedItem;
            if (pSimulacion.TrazaSimulada == null ) { MessageBox.Show("Se debe establecer la traza a simular."); return false; }
            simulacion = pSimulacion;
            return true;
        }

        private void duracionField_KeyUp(object sender, KeyEventArgs e)
        {
            //long dias = duracionField.Text != "" ? long.Parse(duracionField.Text) : 0;
            contadorMinutosText.Text = (pSimulacion.Duracion * 1440).ToString();
        }

        private void infoMinutos_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("La simulación maneja minutos como unidad de tiempo.");
        }
    }
}
