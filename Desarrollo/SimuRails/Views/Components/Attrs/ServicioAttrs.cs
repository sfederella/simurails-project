using System;
using System.Windows.Forms;
using SimuRails.Models;
using System.Collections.Generic;
using SimuRails.DB;
using System.Linq;
using NHibernate.Linq;
using SimuRails.Views.Abms.ServicioAbm;

namespace SimuRails.Views.Components.Attrs
{
    public partial class ServicioAttrs : UserControl
    {
        private Repositorio repositorioServicios = new Repositorio();
        private Servicio pServicio;
        private AgrupacionFormacion pFormacionEditando = new AgrupacionFormacion();
        private Tramo pTramoEditando = new Tramo();
        private List<AgrupacionFormacion> formacionesListadas = new List<AgrupacionFormacion>();

        public ServicioAttrs(Servicio servicio)
        {
            InitializeComponent();
            pServicio = servicio;
            formacionesListadas = AgrupacionFormacion.From(servicio.TiposFormacion);
            var nombreFormaciones = listaDeModelos();
            var nombreEstaciones = listaDeEstaciones();
            nombreFormacionCbo.Items.AddRange(nombreFormaciones.ToArray());
            origenTramoCbo.Items.AddRange(nombreEstaciones.ToArray());
            destinoTramoCbo.Items.AddRange(nombreEstaciones.ToArray());

            BindingSourceServicio.DataSource = pServicio;
            bindingSourceFormacionEditando.DataSource = pFormacionEditando;
            bindingSourceTramoEditando.DataSource = pTramoEditando;
            this.dibujarListadoFormaciones();
            this.dibujarListadoTramos();

            materialSingleLineTextField1.IsNumeric = true;
            materialSingleLineTextField2.IsNumeric = true;
            materialSingleLineTextField3.IsNumeric = true;
            materialSingleLineTextField4.IsNumeric = true;
        }

        public bool applyTo(Servicio servicio)
        {
            if (pServicio.Nombre == null || pServicio.Nombre == "") { MessageBox.Show("Se debe completar un nombre que identifique al Servicio."); return false; }
            this.pServicio.TiposFormacion = AgrupacionFormacion.ToDictionary(formacionesListadas);
            return true;
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

        private List<Formacion> listaDeModelos()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return session.Query<Formacion>().ToList();
            }
        }

        private List<Estacion> listaDeEstaciones()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return session.Query<Estacion>().ToList();
            }
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            formacionesListadas.Add(pFormacionEditando);
            this.listadoFormaciones.agregarRenglon(this.renglonDe(pFormacionEditando));
            pFormacionEditando = new AgrupacionFormacion();
            bindingSourceFormacionEditando.DataSource = pFormacionEditando;
            nombreFormacionCbo.SelectedItem = null;
        }

        private void agregarTramoClick(object sender, EventArgs e)
        {
            this.pServicio.Tramos.Add(pTramoEditando);
            this.listadoTramos.agregarRenglon(this.renglonDe(pTramoEditando));
            pTramoEditando = new Tramo();
            bindingSourceTramoEditando.DataSource = pTramoEditando;
            origenTramoCbo.SelectedItem = null;
            destinoTramoCbo.SelectedItem = null;
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
