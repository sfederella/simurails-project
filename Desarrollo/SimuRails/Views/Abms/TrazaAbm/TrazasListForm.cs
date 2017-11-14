using NHibernate.Linq;
using SimuRails.DB;
using SimuRails.Models;
using SimuRails.Sharing;
using SimuRails.Views.Abms.FormacionAbm;
using SimuRails.Views.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SimuRails.Views.Abms
{
    public partial class TrazasListForm : Form
    {
        private MainForm mainForm;
        private TabPage tabPage;
        private List<Control> renglones = new List<Control>();

        public TrazasListForm()
        {
            InitializeComponent();
        }

        public TrazasListForm(MainForm mainForm, TabPage tabPage)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tabPage = tabPage;
        }

        private void TrazasListForm_Load_1(object sender, EventArgs e)
        {
            using (var repositorio = new Repositorio())
            {
                this.dibujarRenglones(repositorio);
            }
        }

        public void addTraza(Traza Traza)
        {
            using (var repositorio = new Repositorio())
            {
                repositorio.Guardar(Traza);
                this.dibujarRenglones(repositorio);
            }
                
        }

        private RenglonDeTraza renglonDe(Traza traza, int indice)
        {
            var renglon = new RenglonDeTraza(traza, this.OnTrazaEdit, this.onTrazaRemove, this.OnTrazaExport);
            this.incluirEnLista(indice, renglon);
            return renglon;
        }

        private void incluirEnLista(int indice, Control renglon)
        {
            renglon.Location = new System.Drawing.Point(5, 25 + indice * 50);
            renglon.Width = this.listPanel.Width;
            renglon.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            this.listPanel.Controls.Add(renglon);
            renglones.Add(renglon);
        }

        private void onTrazaRemove(int id)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar la traza?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var repositorio = new Repositorio())
                {
                    Traza traza = this.findTraza(id);
                    repositorio.Eliminar(traza);
                    this.dibujarRenglones(repositorio);
                }
            }              
        }

        private void OnTrazaExport(int id)
        {
            using (var repositorio = new Repositorio())
            {
                var trazaAExportar = repositorio.Obtener<Traza>(id);
                SharingUtils.Exportar(trazaAExportar);
            }

        }

        public void dibujarRenglones(Repositorio repositorio)
        {
            var trazas = repositorio.Listar<Traza>();

            renglones.ForEach(unRenglon => this.removeRenglon(unRenglon));
            for (int i = 0; i < trazas.Count; i++)
            {
                renglones.Add(this.renglonDe(trazas.ElementAt(i), i));

            }
            if (trazas.Count == 0)
            {
                this.incluirEnLista(0, new RenglonListaVacia());
            }
        }

        private void removeRenglon(Control unRenglon)
        {
            this.Controls.Remove(unRenglon);
            unRenglon.Dispose();
        }

        public void OnTrazaEdit(int trazaId)
        {
            using (var repositorio = new Repositorio())
            {
                Traza traza = findTraza(trazaId);
                this.mainForm.EmbedForm(new EditTrazaForm(this, repositorio, traza), tabPage);
            }

            this.Visible = false;
        }

        private Traza findTraza(int trazaId)
        {
            using (var repositorio = new Repositorio())
            {
                return repositorio.Obtener<Traza>(trazaId);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            using (var repositorio = new Repositorio())
            {
                Traza traza = new Traza();
                this.mainForm.EmbedForm(new CreateTrazaForm(this, traza, repositorio), tabPage);
                this.Visible = false;
            }
        }

        private void ImportarButton_Click(object sender, EventArgs e)
        {
            Traza trazaRecuperada = SharingUtils.Importar();
            if (trazaRecuperada != null)
            {
                ImportarTraza(trazaRecuperada);
            }
            
            Application.Restart();
        }

        private void ImportarTraza(Traza trazaRecuperada)
        {
            #region incidentes
            var incidentesEvaluados = new Dictionary<int, Incidente>();
            var incidentes = trazaRecuperada.Servicios.SelectMany(x => x.Tramos).Select(y => y.EstacionOrigen).SelectMany(z => z.Incidentes).ToList();
            incidentes.AddRange(trazaRecuperada.Servicios.SelectMany(x => x.Tramos).Select(y => y.EstacionDestino).SelectMany(z => z.Incidentes).ToList());

            foreach (var unIncidente in incidentes)
            {
                if (!incidentesEvaluados.ContainsKey(unIncidente.Id))
                {
                    var idAnterior = unIncidente.Id;
                    incidentesEvaluados.Add(idAnterior, unIncidente);
                }
            }

            foreach (var estacionOrigen in trazaRecuperada.Servicios.SelectMany(x => x.Tramos).Select(y => y.EstacionOrigen))
            {
                var nuevosIncidentes = new List<Incidente>();

                foreach (var incidenteDeOrigen in estacionOrigen.Incidentes)
                {
                    nuevosIncidentes.Add(incidentesEvaluados[incidenteDeOrigen.Id]);
                }

                estacionOrigen.Incidentes.Clear();

                nuevosIncidentes.ForEach(x => x.Id = 0);

                estacionOrigen.Incidentes = nuevosIncidentes;
            }

            foreach (var estacionDestino in trazaRecuperada.Servicios.SelectMany(x => x.Tramos).Select(y => y.EstacionDestino))
            {
                var nuevosIncidentes = new List<Incidente>();

                foreach (var incidenteDeDestino in estacionDestino.Incidentes)
                {
                    nuevosIncidentes.Add(incidentesEvaluados[incidenteDeDestino.Id]);
                }

                estacionDestino.Incidentes.Clear();

                nuevosIncidentes.ForEach(x => x.Id = 0);

                estacionDestino.Incidentes = nuevosIncidentes;
            }
            #endregion

            #region estaciones y tramo
            var estacionesEvaluadas = new Dictionary<int, Estacion>();
            var estaciones = trazaRecuperada.Servicios.SelectMany(x => x.Tramos).Select(y => y.EstacionOrigen).ToList();
            estaciones.AddRange(trazaRecuperada.Servicios.SelectMany(x => x.Tramos).Select(y => y.EstacionDestino));

            foreach (var unaEstacion in estaciones)
            {
                if (!estacionesEvaluadas.ContainsKey(unaEstacion.Id))
                {
                    var idAnterior = unaEstacion.Id;
                    estacionesEvaluadas.Add(idAnterior, unaEstacion);
                }
            }

            foreach (var unTramo in trazaRecuperada.Servicios.SelectMany(x => x.Tramos))
            {
                if (unTramo.EstacionOrigen.Id != 0)
                {
                    var nuevaEstacionOrigen = estacionesEvaluadas[unTramo.EstacionOrigen.Id];

                    unTramo.EstacionOrigen = new Estacion();

                    nuevaEstacionOrigen.Id = 0;

                    unTramo.EstacionOrigen = nuevaEstacionOrigen;
                }


                if (unTramo.EstacionDestino.Id != 0)
                {
                    var nuevaEstacionDestino = estacionesEvaluadas[unTramo.EstacionDestino.Id];

                    unTramo.EstacionDestino = new Estacion();

                    nuevaEstacionDestino.Id = 0;

                    unTramo.EstacionDestino = nuevaEstacionDestino;
                }
            }
            #endregion

            #region tipos de coches y formaciones
            var cochesEvaluados = new Dictionary<int, Coche>();
            var coches = trazaRecuperada.Servicios.SelectMany(x => x.TiposFormacion).Select(y => y.Key).SelectMany(z => z.TiposCoche).Select(t => t.Key).ToList();

            foreach (var unCoche in coches)
            {
                if (!cochesEvaluados.ContainsKey(unCoche.Id))
                {
                    var idAnterior = unCoche.Id;
                    cochesEvaluados.Add(idAnterior, unCoche);
                }
            }

            foreach (var unaFormacion in trazaRecuperada.Servicios.SelectMany(x => x.TiposFormacion).Select(y => y.Key))
            {
                var nuevosTipoDeCoche = new Dictionary<Coche, int>();

                foreach (var tipoDeCoche in unaFormacion.TiposCoche)
                {
                    nuevosTipoDeCoche.Add(cochesEvaluados[tipoDeCoche.Key.Id], tipoDeCoche.Value);
                }

                unaFormacion.TiposCoche.Clear();

                nuevosTipoDeCoche.Keys.ToList().ForEach(x => x.Id = 0);

                unaFormacion.TiposCoche = nuevosTipoDeCoche;
            }
            #endregion

            #region tipos de formaciones y servicios
            var formacionesEvaluadas = new Dictionary<int, Formacion>();
            var formaciones = trazaRecuperada.Servicios.SelectMany(x => x.TiposFormacion).Select(y => y.Key).ToList();

            foreach (var unaFormacion in formaciones)
            {
                if (!formacionesEvaluadas.ContainsKey(unaFormacion.Id))
                {
                    var idAnterior = unaFormacion.Id;
                    formacionesEvaluadas.Add(idAnterior, unaFormacion);
                }
            }

            foreach (var unServicio in trazaRecuperada.Servicios)
            {
                var nuevosTiposDeFormacion = new Dictionary<Formacion, int>();

                foreach (var tipoDeFormacion in unServicio.TiposFormacion)
                {
                    nuevosTiposDeFormacion.Add(formacionesEvaluadas[tipoDeFormacion.Key.Id], tipoDeFormacion.Value);
                }

                unServicio.TiposFormacion.Clear();

                nuevosTiposDeFormacion.Keys.ToList().ForEach(x => x.Id = 0);

                unServicio.TiposFormacion = nuevosTiposDeFormacion;
            }


            #endregion


            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                trazaRecuperada.Id = 0;
                trazaRecuperada.Servicios.ToList().ForEach(x => x.Id = 0);
                trazaRecuperada.Servicios.SelectMany(x => x.Tramos).ToList().ForEach(x => x.Id = 0);
                trazaRecuperada.Servicios.SelectMany(x => x.TiposFormacion).Select(y => y.Key).ToList().ForEach(x => x.Id = 0);

                foreach (var formacion in trazaRecuperada.Servicios.SelectMany(x => x.TiposFormacion).Select(y => y.Key).ToList())
                {
                    foreach (var coche in formacion.TiposCoche.Keys)
                    {
                        session.Persist(coche);
                    }
                    session.Persist(formacion);
                }

                session.Persist(trazaRecuperada);

                transaction.Commit();
            }
        }

        private void materialRaisedButtonLimpiar_Click(object sender, EventArgs e)
        {
            string msg = string.Format("ATENCION: Al limpiar todo se eliminarán todos los elementos que contiene su base de datos.{0}¿Está seguro que desea continuar?", Environment.NewLine);
            if (MessageBox.Show(msg, "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var session = NHibernateHelper.OpenSession())
                using (var transaction = session.BeginTransaction())
                {
                    var incidentes = session.Query<Incidente>().ToList();
                    var estaciones = session.Query<Estacion>().ToList();
                    var tramos = session.Query<Tramo>().ToList();

                    var coches = session.Query<Coche>().ToList();
                    var formaciones = session.Query<Formacion>().ToList();

                    var servicios = session.Query<Servicio>().ToList();

                    var trazas = session.Query<Traza>().ToList();

                    foreach (var incidente in incidentes)
                        session.Delete(incidente);

                    foreach (var tramo in tramos)
                        session.Delete(tramo);

                    foreach (var coche in coches)
                        session.Delete(coche);

                    foreach (var estacion in estaciones)
                        session.Delete(estacion);

                    foreach (var formacion in formaciones)
                        session.Delete(formacion);

                    foreach (var servicio in servicios)
                        session.Delete(servicio);

                    foreach (var traza in trazas)
                        session.Delete(traza);

                    transaction.Commit();
                }

                Application.Restart();
            }
        }
    }
}
