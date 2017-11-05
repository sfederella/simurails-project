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
using NHibernate.Linq;
using SimuRails.Views.Validables;
using NHibernate;

namespace SimuRails.Views.Components.Attrs
{
    public partial class FormacionAttr : UserControl
    {
        private void FormacionAttr_Load(object sender, EventArgs e)
        {

        }

        private Formacion pFormacion;
        private AgrupacionCoche pCocheEditando = new AgrupacionCoche();
        private List<AgrupacionCoche> cochesListados = new List<AgrupacionCoche>();
        private List<Validable> validables = new List<Validable>();

        private List<Validable> validablesParaLista = new List<Validable>();

        public FormacionAttr(Formacion formacion, Repositorio repositorio)
        {
            InitializeComponent();
            pFormacion = formacion;
            validables.Add(new Validator<Formacion>(pFormacion, ReglaConcreta<Formacion>.dePresencia(unaFormacion => unaFormacion.Nombre), errorNombreLbl, bindingSourceFormacion));
            validables.Add(new Validator<Formacion>(pFormacion, ReglaConcreta<Formacion>.dePositivo(unaFormacion => unaFormacion.KilometrosMantenimiento), errorDistanciaLbl, bindingSourceFormacion));
            validables.Add(new Validator<Formacion>(pFormacion, ReglaConcreta<Formacion>.dePositivo(unaFormacion => unaFormacion.DuracionMantenimiento), errorTiempoManteLbl, bindingSourceFormacion));
            validables.Add(new Validator<Formacion>(pFormacion, new ReglaConcreta<Formacion>(unaFormacion => unaFormacion.TiposCoche.Keys.Count > 0, "Debe tener por lo menos un tipo de coche"), errorCochesLbl));

            cochesListados = AgrupacionCoche.From(formacion.TiposCoche);
            var modelos = repositorio.Listar<Coche>();
            modeloCbo.Items.AddRange(modelos.ToArray());

            validablesParaLista.Add(new Validator<AgrupacionCoche>(pCocheEditando, ReglaConcreta<AgrupacionCoche>.dePositivo(unaAgrupacionCoche => unaAgrupacionCoche.Cantidad), errorCantidadLbl));
            validablesParaLista.Add(new Validator<AgrupacionCoche>(pCocheEditando, new ReglaCompuesta<AgrupacionCoche>(new List<Regla<AgrupacionCoche>> {
                new ReglaConcreta<AgrupacionCoche>(unaAgrupacion => unaAgrupacion.Coche != null, "Este campo es requerido"),
                new ReglaConcreta<AgrupacionCoche>(unaAgrupacion => cochesListados.TrueForAll(otraAgrupacion => !unaAgrupacion.Coche.Equals(otraAgrupacion.Coche)), "No se puede usar el mismo tipo\n de coche dos veces")
            }), errorModeloLbl));


            bindingSourceFormacion.DataSource = pFormacion;
            bindingSourceCocheEditando.DataSource = pCocheEditando;
            this.dibujarListado();

            distanciaManteField.IsNumeric = true;
            tiempoEnManteField.IsNumeric = true;
            cantidadCocheField.IsNumeric = true;
        }

        private void dibujarListado()
        {
            List<Control> renglones = this.cochesListados.Select(agrupacionCoche => this.renglonDe(agrupacionCoche)).ToList();
            this.listadoCoches.setearRenglones(renglones);
        }

        private Control renglonDe(AgrupacionCoche agrupacionCoche)
        {
            return new RenglonDeAgrupacionCoche(agrupacionCoche, this.onCocheRemove);
        }

        private void onCocheRemove(AgrupacionCoche agrupacion)
        {
            this.cochesListados.Remove(agrupacion);
            this.dibujarListado();
        }

        public bool applyTo(Formacion formacion)
        {
            this.pFormacion.TiposCoche = AgrupacionCoche.ToDictionary(cochesListados);
            validables.ForEach(validable => validable.mostrarError());
            return validables.TrueForAll(validable => validable.esValido());
        }

        private void registrarValidables()
        {
            
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            validablesParaLista.ForEach(validable => validable.mostrarError());
            if(validablesParaLista.TrueForAll(validable => validable.esValido()))
            {
                var nuevoCocheListado = pCocheEditando.crearCopia();
                pCocheEditando.limpiar();
                cochesListados.Add(nuevoCocheListado);
                this.listadoCoches.agregarRenglon(this.renglonDe(nuevoCocheListado));

                bindingSourceCocheEditando.ResetBindings(true);

                modeloCbo.SelectedItem = null;
                errorCochesLbl.Visible = false;
            }
        }
    }
}
