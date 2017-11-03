using System.Windows.Forms;
using SimuRails.Models;
using System.Collections.Generic;
using SimuRails.Views.Validables;
using System;

namespace SimuRails.Views.Components
{
    public partial class CocheAttrs : UserControl
    {
        static Regla<Coche> reglaParaCapacidadMaxima = new ReglaCompuesta<Coche>(new List<Regla<Coche>> {
            ReglaConcreta<Coche>.dePositivo((unCoche => unCoche.CapacidadMaximaPasajeros)),
            new ReglaConcreta<Coche>(unCoche => unCoche.MaximoLegalPasajeros <= unCoche.CapacidadMaximaPasajeros, "Debe ser mayor o igual a\n la cantidad legal")
        });
        static Regla<Coche> reglaParaAsientos = new ReglaCompuesta<Coche>(new List<Regla<Coche>> {
            ReglaConcreta<Coche>.dePositivo((unCoche => unCoche.CantidadAsientos)),
            new ReglaConcreta<Coche>(unCoche => unCoche.CantidadAsientos <= unCoche.MaximoLegalPasajeros, "Debe ser menor o igual a\n la cantidad legal")
        });

        private Coche pCoche;
        private List<Validable> validables = new List<Validable>();

        public CocheAttrs(Coche coche)
        {
            InitializeComponent();
            pCoche = coche;


            validables.Add(new Validator<Coche>(pCoche, ReglaConcreta<Coche>.dePresencia((unCoche => unCoche.Modelo)), this.errorModeloLbl, this.modeloField));
            validables.Add(new Validator<Coche>(pCoche, ReglaConcreta<Coche>.dePositivo((unCoche => unCoche.MaximoLegalPasajeros)), this.errorLegalLbl, this.capacidadLegalField));
            validables.Add(new Validator<Coche>(pCoche, reglaParaCapacidadMaxima, this.errorMaximaLbl, this.capacidadTotalField));
            validables.Add(new Validator<Coche>(pCoche, ReglaConcreta<Coche>.dePositivo((unCoche => unCoche.CantidadAsientos)), this.errorAsientosLbl, this.asientosField));

            BindingSourceCoche.DataSource = pCoche;
        }

        public bool applyTo(Coche coche)
        {
            validables.ForEach(validable => validable.mostrarError());
            return validables.TrueForAll(validable => validable.esValido());
        }

        private void CocheAttrs_Load(object sender, System.EventArgs e)
        {

        }
    }
}
