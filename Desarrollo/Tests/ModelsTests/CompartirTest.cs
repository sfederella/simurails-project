using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimuRails.Models;
using SimuRails.Sharing;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;
using SimuRails.DB;
using NHibernate.Linq;
using System.Linq;

namespace Tests.ModelsTests
{
    [TestClass]
    public class CompartirTest
    {
        Traza traza;

        public CompartirTest()
        {
            traza = new ModelMock().Traza;
        }

        [TestMethod]
        public void ExportarImportar()
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                SharingUtils.Exportar(traza);
                Traza trazaRecuperada = SharingUtils.Importar();
                Assert.IsNotNull(trazaRecuperada);

                session.SaveOrUpdate(trazaRecuperada);
                transaction.Commit();

                session.Flush();

                var trazaImportadaYPersistida = session.Query<Traza>().Where(x => x.Id == trazaRecuperada.Id).FirstOrDefault();
                Assert.IsNotNull(trazaImportadaYPersistida);
            }
        }

        [TestMethod]
        public void ObtenerBorrarTodoLaBase()
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

                foreach (var estacion in estaciones)
                {
                    session.Delete(estacion);
                }

                foreach (var incidente in incidentes)
                {
                    session.Delete(incidente);
                }

                foreach (var tramo in tramos)
                {
                    session.Delete(tramo);
                }

                foreach (var coche in coches)
                {
                    session.Delete(coche);
                }

                foreach (var formacion in formaciones)
                {
                    session.Delete(formacion);
                }

                foreach (var servicio in servicios)
                {
                    session.Delete(servicio);
                }

                foreach (var traza in trazas)
                {
                    session.Delete(traza);
                }

                transaction.Commit();
            }
        }

        [TestMethod]
        public void ProbandoImportacionDeTrazas()
        {
            Traza trazaRecuperada = SharingUtils.Importar();

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

            using (var session = NHibernateHelper.OpenSession())
            {
                var trazaPersistida = session.Query<Traza>().Where(x => x.Nombre == trazaRecuperada.Nombre).FirstOrDefault();

                Assert.IsNotNull(trazaPersistida);
            }
        }
    }
}
