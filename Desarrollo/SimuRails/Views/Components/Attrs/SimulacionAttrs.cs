using System.Windows.Forms;
using SimuRails.Models;
using SimuRails.DB;
using System.Collections.Generic;
using System.Linq;
using SimuRails.Views.Validables;

namespace SimuRails.Views.Components.Attrs
{
    public partial class SimulacionAttrs : UserControl
    {
        private Simulacion pSimulacion;
        private List<Validable> validables = new List<Validable>();

        public SimulacionAttrs(Simulacion simulacion, Repositorio repositorio)
        {
            InitializeComponent();
            pSimulacion = simulacion;

            validables.Add(new Validator<Simulacion>(pSimulacion, ReglaConcreta<Simulacion>.dePresencia((s => s.Nombre)), this.errorNombreLbl, this.nombreField));
            validables.Add(new Validator<Simulacion>(pSimulacion, ReglaConcreta<Simulacion>.dePresencia((s => s.TrazaSimulada)), this.errorTrazaLbl, this.ComboBoxTraza));
            validables.Add(new Validator<Simulacion>(pSimulacion, ReglaConcreta<Simulacion>.dePositivo((s => s.Duracion)), this.errorDuracionLbl, this.duracionField));

            BindingSourceSimulacion.DataSource = pSimulacion;
            List<Traza> list = repositorio.Listar<Traza>();
            BindingSourceTraza.DataSource = list;
            ComboBoxTraza.listaDatos = list.Select(x => x.Nombre).ToList();
            contadorMinutosText.Text = (simulacion.Duracion * 1440).ToString();
            duracionField.IsNumeric = true;
        }

        public bool applyTo(Simulacion simulacion)
        {
            validables.ForEach(validable => validable.mostrarError());
            var validez = validables.TrueForAll(validable => validable.esValido());

            if(validez)
            {
                pSimulacion.TrazaSimulada = (Traza)ComboBoxTraza.SelectedItem;
            }

            return validez;
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
