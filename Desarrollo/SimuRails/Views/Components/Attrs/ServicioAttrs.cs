using System;
using System.Windows.Forms;
using SimuRails.Models;
using System.Collections.Generic;
using SimuRails.DB;
using System.Linq;
using NHibernate.Linq;
using SimuRails.Views.Abms.ServicioAbm;
using SimuRails.Views.Validables;

namespace SimuRails.Views.Components.Attrs
{
    public partial class ServicioAttrs : UserControl
    {
        private Servicio pServicio;
        private AgrupacionFormacion pFormacionEditando = new AgrupacionFormacion();
        private Tramo pTramoEditando = new Tramo();
        private List<AgrupacionFormacion> formacionesListadas = new List<AgrupacionFormacion>();
        private List<Validable> validables = new List<Validable>();

        public ServicioAttrs(Servicio servicio, Repositorio repositorio)
        {
            InitializeComponent();
            pServicio = servicio;
            formacionesListadas = AgrupacionFormacion.From(servicio.TiposFormacion);
            var nombreFormaciones = repositorio.Listar<Formacion>();
            var nombreEstaciones = repositorio.Listar<Estacion>();
            nombreFormacionCbo.Items.AddRange(nombreFormaciones.ToArray());
            origenTramoCbo.Items.AddRange(nombreEstaciones.ToArray());
            destinoTramoCbo.Items.AddRange(nombreEstaciones.ToArray());

            validables.Add(new Validator<Servicio>(pServicio, ReglaConcreta<Servicio>.dePresencia((unServicio => unServicio.Nombre)), this.errorNombreLbl, this.nombreField));
            validables.Add(new Validator<Servicio>(pServicio, ReglaConcreta<Servicio>.noNegativo((unServicio => unServicio.CantidadFormacionesInicio)), this.errorCantidadEnInicio, this.cantidadEnInicioField));
            validables.Add(new Validator<Servicio>(pServicio, new ReglaConcreta<Servicio>((unServicio => unServicio.Tramos.Count > 0), "Al menos debe tener un tramo"), this.errorTramoLbl));
            validables.Add(new Validator<Servicio>(pServicio, new ReglaConcreta<Servicio>((unServicio => unServicio.TiposFormacion.Keys.Count > 0), "Al menos debe tener una formación"), this.errorFormacionesLbl));
            
            BindingSourceServicio.DataSource = pServicio;
            bindingSourceFormacionEditando.DataSource = pFormacionEditando;
            bindingSourceTramoEditando.DataSource = pTramoEditando;
            this.dibujarListadoFormaciones();
            this.dibujarListadoTramos();

            materialSingleLineTextField1.IsNumeric = true;
            materialSingleLineTextField2.IsNumeric = true;
            materialSingleLineTextField3.IsNumeric = true;
            cantidadEnInicioField.IsNumeric = true;
        }

        public bool applyTo(Servicio servicio)
        {
            this.pServicio.TiposFormacion = AgrupacionFormacion.ToDictionary(formacionesListadas);
            validables.ForEach(validable => validable.mostrarError());
            return validables.TrueForAll(validable => validable.esValido());
        }

        private void dibujarListadoFormaciones()
        {
            List<Control> renglones = this.formacionesListadas.Select(agrupacionFormacion => this.renglonDe(agrupacionFormacion)).ToList();
            this.listadoFormaciones.setearRenglones(renglones);
        }

        private void dibujarListadoTramos()
        {
            List<Control> renglones = this.pServicio.Tramos.Select(tramo => this.renglonDe(tramo)).ToList();
            this.listadoTramos.setearRenglones(renglones);
        }

        private Control renglonDe(AgrupacionFormacion agrupacionFormacion)
        {
            return new RenglonDeAgrupacionFormacion(agrupacionFormacion, this.onFormacionRemove);
        }

        private Control renglonDe(Tramo tramo)
        {
            return new RenglonDeTramo(tramo, this.onTramoRemove);
        }

        private void onFormacionRemove(AgrupacionFormacion agrupacion)
        {
            this.formacionesListadas.Remove(agrupacion);
            this.dibujarListadoFormaciones();
        }

        private void onTramoRemove(Tramo tramo)
        {
            this.pServicio.Tramos.Remove(tramo);
            this.dibujarListadoTramos();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            List<Validable> validablesFormacion = new List<Validable>();

            validablesFormacion.Add(new Validator<AgrupacionFormacion>(pFormacionEditando, ReglaConcreta<AgrupacionFormacion>.dePresencia((a => a.Formacion)), this.errorFormacionLbl));
            validablesFormacion.Add(new Validator<AgrupacionFormacion>(pFormacionEditando, ReglaConcreta<AgrupacionFormacion>.dePositivo((a => a.Cantidad)), this.errorCantidadLbl));

            validablesFormacion.ForEach(validable => validable.mostrarError());
            if (validablesFormacion.TrueForAll(validable => validable.esValido()))
            {
                formacionesListadas.Add(pFormacionEditando);
                this.listadoFormaciones.agregarRenglon(this.renglonDe(pFormacionEditando));
                pFormacionEditando = new AgrupacionFormacion();
                bindingSourceFormacionEditando.DataSource = pFormacionEditando;
                nombreFormacionCbo.SelectedItem = null;

                errorFormacionesLbl.Visible = false;
            } 
        }

        private void agregarTramoClick(object sender, EventArgs e)
        {
            List<Validable> validablesTramo = new List<Validable>();

            validablesTramo.Add(new Validator<Tramo>(pTramoEditando, ReglaConcreta<Tramo>.dePresencia((tramo => tramo.EstacionOrigen)), this.errorEstacionSalidaLbl));
            validablesTramo.Add(new Validator<Tramo>(pTramoEditando, ReglaConcreta<Tramo>.dePresencia((tramo => tramo.EstacionDestino)), this.errorEstacionLlegadaLbl));
            validablesTramo.Add(new Validator<Tramo>(pTramoEditando, ReglaConcreta<Tramo>.dePositivo((tramo => tramo.Distancia)), this.errorDistanciaLbl));
            validablesTramo.Add(new Validator<Tramo>(pTramoEditando, ReglaConcreta<Tramo>.dePositivo((tramo => tramo.TiempoViaje)), this.errorTiempoLbl));

            validablesTramo.ForEach(validable => validable.mostrarError());
            if (validablesTramo.TrueForAll(validable => validable.esValido()))
            {
                this.pServicio.Tramos.Add(pTramoEditando);
                this.listadoTramos.agregarRenglon(this.renglonDe(pTramoEditando));
                pTramoEditando = new Tramo();
                bindingSourceTramoEditando.DataSource = pTramoEditando;
                origenTramoCbo.SelectedItem = null;
                destinoTramoCbo.SelectedItem = null;

                errorTramoLbl.Visible = false;
            }
        }

        private void programacionIdaButton_Click(object sender, EventArgs e)
        {
            var programacion = pServicio.ProgramacionIda.Keys.ToList();
            using (ProgramacionServicioForm frmProg = new ProgramacionServicioForm(programacion))
            {
                if (frmProg.ShowDialog() == DialogResult.OK)
                {
                    pServicio.ProgramacionIda = frmProg.Programacion.ToDictionary(x => x, x => false);
                }
            }
        }

        private void programacionVueltaButton_Click(object sender, EventArgs e)
        {
            var programacion = pServicio.ProgramacionVuelta.Keys.ToList();
            using (ProgramacionServicioForm frmProg = new ProgramacionServicioForm(programacion))
            {
                if (frmProg.ShowDialog() == DialogResult.OK)
                {
                    pServicio.ProgramacionVuelta = frmProg.Programacion.ToDictionary(x => x, x => false);
                }
            }
        }
    }
}
