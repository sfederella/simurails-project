using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimuRails;
using SimuRails.DB;
using SimuRails.Models;
using NHibernate.Linq;
using System.Linq;
using System.Collections.Generic;

namespace Tests.DBTests
{
    [TestClass]
    public class PersistanceTest
    {
        //[TestMethod]
        //public void seGuardaLaTrazaTest()
        //{
        //    using (var session = NHibernateHelper.OpenSession())
        //    using (var transaction = session.BeginTransaction())
        //    {
        //        var traza = new Traza()
        //        {
        //            Nombre = "Traza1"
        //        };

        //        session.SaveOrUpdate(traza);
        //        session.Flush();

        //        var existeTraza = session.Query<Traza>()
        //           .Any(x => x.Nombre == traza.Nombre);

        //        Assert.IsTrue(existeTraza);
        //    }
        //}

        [TestMethod]
        public void CRUDIncidente()
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var incidente = new Incidente()
                {
                    Nombre = "Incidente 1",
                    Descripcion = "Descripcion de incidente",
                    ProbabilidadDeOcurrencia = 10.45,
                    TiempoDemora = 100
                };

                session.SaveOrUpdate(incidente);
                session.Flush();

                var incidenteDB = session.Query<Incidente>()
                   .Where(x => x.Descripcion == incidente.Descripcion && x.Nombre == incidente.Nombre)
                   .FirstOrDefault();

                Assert.IsNotNull(incidenteDB);

                incidenteDB.ProbabilidadDeOcurrencia = 67.13;
                incidenteDB.Nombre = "otro nombre";

                session.SaveOrUpdate(incidente);
                session.Flush();

                incidenteDB = session.Query<Incidente>()
                   .Where(x => x.Descripcion == incidente.Descripcion && x.TiempoDemora == incidente.TiempoDemora)
                   .FirstOrDefault();

                Assert.AreEqual(incidenteDB.Nombre, "otro nombre");
                Assert.AreEqual(incidenteDB.ProbabilidadDeOcurrencia, 67.13);
                Assert.AreEqual(incidenteDB.Descripcion, incidente.Descripcion);

                session.Delete(incidenteDB);

                var existeIncidente = session.Query<Incidente>()
                   .Any(x => x.Descripcion == incidente.Descripcion && x.TiempoDemora == incidente.TiempoDemora);

                Assert.IsFalse(existeIncidente);
            }
        }

        [TestMethod]
        public void CRUDEstacion()
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var estacion = ObtenerEstacionDePrueba();

                session.SaveOrUpdate(estacion);
                session.Flush();

                var estacionDB = session.Query<Estacion>()
                   .Where(x => x.Nombre == estacion.Nombre && x.PersonasDesciendenMaxIda == estacion.PersonasDesciendenMaxIda)
                   .FirstOrDefault();

                Assert.IsNotNull(estacionDB);

                estacionDB.PersonasDesciendenMaxVuelta = 1000;
                estacionDB.Nombre = "otro nombre";

                session.SaveOrUpdate(estacion);
                session.Flush();

                estacionDB = session.Query<Estacion>()
                   .Where(x => x.Nombre == estacion.Nombre && x.PersonasDesciendenMaxIda == estacion.PersonasDesciendenMaxIda)
                   .FirstOrDefault();

                Assert.AreEqual(estacionDB.Nombre, "otro nombre");
                Assert.AreEqual(estacionDB.PersonasDesciendenMaxVuelta, 1000);

                session.Delete(estacionDB);

                var existeEstacion = session.Query<Estacion>()
                   .Any(x => x.Nombre == estacion.Nombre && x.PersonasDesciendenMaxIda == estacion.PersonasDesciendenMaxIda);

                Assert.IsFalse(existeEstacion);
            }
        }

        //[TestMethod]
        //public void CRUDRelacion()
        //{
        //    using (var session = NHibernateHelper.OpenSession())
        //    using (var transaction = session.BeginTransaction())
        //    {
        //        var relacion = new Relacion()
        //        {
        //            Distancia = 1000,
        //            VelocidadPromedio = 300,
        //            TiempoViaje = 20
        //        };

        //        session.SaveOrUpdate(relacion);
        //        session.Flush();

        //        var relacionDB = session.Query<Relacion>()
        //           .Where(x => x.Distancia == relacion.Distancia && x.VelocidadPromedio == relacion.VelocidadPromedio)
        //           .FirstOrDefault();

        //        Assert.IsNotNull(relacionDB);

        //        relacionDB.TiempoViaje = 30;

        //        session.SaveOrUpdate(relacion);
        //        session.Flush();

        //        relacionDB = session.Query<Relacion>()
        //           .Where(x => x.Distancia == relacion.Distancia && x.VelocidadPromedio == relacion.VelocidadPromedio)
        //           .FirstOrDefault();

        //        Assert.AreEqual(relacionDB.TiempoViaje, 30);

        //        session.Delete(relacionDB);

        //        var existeRelacion = session.Query<Relacion>()
        //           .Any(x => x.Distancia == relacion.Distancia && x.VelocidadPromedio == relacion.VelocidadPromedio);

        //        Assert.IsFalse(existeRelacion);
        //    }
        //}

        [TestMethod]
        public void CRUDServicio()
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var servicio = ObtenerServicioDePrueba();

                servicio.ProgramacionIda.Add(1, true);
                servicio.ProgramacionIda.Add(3, false);
                servicio.ProgramacionIda.Add(2, true);
                servicio.ProgramacionVuelta.Add(1, false);
                servicio.ProgramacionVuelta.Add(3, true);
                servicio.ProgramacionVuelta.Add(2, true);

                session.SaveOrUpdate(servicio);
                session.Flush();

                var servicioDB = session.Query<Servicio>()
                   .Where(x => x.Nombre == servicio.Nombre)
                   .FirstOrDefault();

                Assert.IsNotNull(servicioDB);
                Assert.AreEqual(servicioDB.ProgramacionIda, servicio.ProgramacionIda);
                Assert.AreEqual(servicioDB.ProgramacionIda[3], false);

                servicioDB.Nombre = "otro nombre";

                session.SaveOrUpdate(servicio);
                session.Flush();

                servicioDB = session.Query<Servicio>()
                   .Where(x => x.Nombre == servicio.Nombre)
                   .FirstOrDefault();

                Assert.AreEqual(servicioDB.Nombre, "otro nombre");

                session.Delete(servicioDB);

                var existeServicio = session.Query<Servicio>()
                   .Any(x => x.Nombre == servicio.Nombre);

                Assert.IsFalse(existeServicio);
            }
        }

        //[TestMethod]
        //public void CRUDSimulacion()
        //{
        //    using (var session = NHibernateHelper.OpenSession())
        //    using (var transaction = session.BeginTransaction())
        //    {
        //        var simulacion = new Simulacion()
        //        {
        //            Nombre = "nombre de simulacion",
        //            FrecuenciaDeSalida = 7
        //        };

        //        session.SaveOrUpdate(simulacion);
        //        session.Flush();

        //        var simulacionDB = session.Query<Simulacion>()
        //           .Where(x => x.Nombre == simulacion.Nombre)
        //           .FirstOrDefault();

        //        Assert.IsNotNull(simulacionDB);

        //        simulacionDB.Nombre = "otro nombre";
        //        simulacionDB.FrecuenciaDeSalida = 6;

        //        session.SaveOrUpdate(simulacion);
        //        session.Flush();

        //        simulacionDB = session.Query<Simulacion>()
        //           .Where(x => x.Nombre == simulacion.Nombre)
        //           .FirstOrDefault();

        //        Assert.AreEqual(simulacionDB.Nombre, "otro nombre");
        //        Assert.AreEqual(simulacionDB.FrecuenciaDeSalida, 6);

        //        session.Delete(simulacionDB);

        //        var existeSimulacion = session.Query<Simulacion>()
        //           .Any(x => x.Nombre == simulacion.Nombre);

        //        Assert.IsFalse(existeSimulacion);
        //    }
        //}

        [TestMethod]
        public void CRUDFormacion()
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var formacion = ObtenerFormacionDePrueba();
                var locomotora = ObtenerCocheDePrueba();
                var bagon = ObtenerCocheDePrueba();
                bagon.EsLocomotora = false;

                formacion.TiposCoche = new Dictionary<Coche, int>()
                {
                    { locomotora, 1 },
                    { bagon, 20 }
                };

                session.SaveOrUpdate(locomotora);
                session.SaveOrUpdate(bagon);
                session.Flush();

                session.SaveOrUpdate(formacion);
                session.Flush();

                var formacionDB = session.Query<Formacion>()
                   .Where(x => x.Nombre == formacion.Nombre)
                   .FirstOrDefault();

                Assert.IsNotNull(formacionDB);
                Assert.AreEqual(formacionDB.TiposCoche, formacion.TiposCoche);
                Assert.AreEqual(formacionDB.TiposCoche[bagon], 20);

                formacionDB.Nombre = "otro nombre";
                formacionDB.TiposCoche[locomotora] = 99;

                session.SaveOrUpdate(formacion);
                session.Flush();

                formacionDB = session.Query<Formacion>()
                   .Where(x => x.Nombre == formacion.Nombre)
                   .FirstOrDefault();

                Assert.AreEqual(formacionDB.Nombre, "otro nombre");
                Assert.AreEqual(formacionDB.TiposCoche[locomotora], 99);

                session.Delete(formacionDB);

                var existeFormacion = session.Query<Formacion>()
                   .Any(x => x.Nombre == formacion.Nombre);

                Assert.IsFalse(existeFormacion);
            }
        }

        [TestMethod]
        public void CRUDCoche()
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var coche = ObtenerCocheDePrueba();

                session.SaveOrUpdate(coche);
                session.Flush();

                var cocheDB = session.Query<Coche>()
                   .Where(x => x.Modelo == coche.Modelo && x.CapacidadMaximaPasajeros == coche.CapacidadMaximaPasajeros)
                   .FirstOrDefault();

                Assert.IsNotNull(cocheDB);

                cocheDB.Modelo = "otro modelo";
                cocheDB.MaximoLegalPasajeros = 190;
                cocheDB.EsLocomotora = true;

                session.SaveOrUpdate(coche);
                session.Flush();

                cocheDB = session.Query<Coche>()
                   .Where(x => x.Modelo == coche.Modelo && x.CapacidadMaximaPasajeros == coche.CapacidadMaximaPasajeros)
                   .FirstOrDefault();

                Assert.AreEqual(cocheDB.Modelo, "otro modelo");
                Assert.AreEqual(cocheDB.MaximoLegalPasajeros, 190);
                Assert.AreEqual(cocheDB.EsLocomotora, true);
                Assert.AreEqual(cocheDB.TipoDeConsumo, coche.TipoDeConsumo);
                Assert.AreEqual(cocheDB.CantidadAsientos, coche.CantidadAsientos);

                session.Delete(cocheDB);

                var existeCoche = session.Query<Coche>()
                   .Any(x => x.MaximoLegalPasajeros == coche.MaximoLegalPasajeros && x.Modelo == coche.Modelo);

                Assert.IsFalse(existeCoche);
            }
        }

        [TestMethod]
        public void CRUDTramo()
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var tramo = ObtenerTramoDePrueba();
                var unaEstacion = ObtenerEstacionDePrueba();
                var otraEstacion = ObtenerEstacionDePrueba();

                session.SaveOrUpdate(unaEstacion);
                session.SaveOrUpdate(otraEstacion);
                session.Flush();

                tramo.EstacionDestino = unaEstacion;
                tramo.EstacionOrigen = otraEstacion;

                session.SaveOrUpdate(tramo);
                session.Flush();

                var tramoDB = session.Query<Tramo>()
                   .Where(x => x.TiempoViaje == tramo.TiempoViaje && x.Distancia == tramo.Distancia)
                   .FirstOrDefault();

                Assert.IsNotNull(tramoDB);
                Assert.AreEqual(tramoDB.EstacionDestino, unaEstacion);

                tramo.Distancia = 999;

                session.SaveOrUpdate(tramo);
                session.Flush();

                tramoDB = session.Query<Tramo>()
                   .Where(x => x.TiempoViaje == tramo.TiempoViaje && x.Distancia == tramo.Distancia)
                   .FirstOrDefault();
                
                Assert.AreEqual(tramoDB.Distancia, 999);

                session.Delete(tramoDB);

                var existeTramo = session.Query<Tramo>()
                   .Any(x => x.TiempoViaje == tramo.TiempoViaje && x.Distancia == tramo.Distancia);

                Assert.IsFalse(existeTramo);
            }
        }


        [TestMethod]
        public void RelacionEstacionIncidente()
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var unIncidente = ObtenerIncidenteDePrueba();
                var otroIncidente = ObtenerIncidenteDePrueba();
                var unaEstacion = ObtenerEstacionDePrueba();

                unaEstacion.Incidentes.Add(unIncidente);
                unaEstacion.Incidentes.Add(otroIncidente);

                session.SaveOrUpdate(unIncidente);
                session.SaveOrUpdate(otroIncidente);
                session.Flush();

                session.SaveOrUpdate(unaEstacion);

                var estacionDB = session.Query<Estacion>().Where(x => x.Nombre == unaEstacion.Nombre).FirstOrDefault();

                Assert.IsNotNull(estacionDB);

                Assert.IsTrue(estacionDB.Incidentes.Count == 2);
            }
        }

        [TestMethod]
        public void RelacionServicioTipoFormaciones()
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var unaFormacion = ObtenerFormacionDePrueba();
                var otraFormacion = ObtenerFormacionDePrueba();
                var unServicio = ObtenerServicioDePrueba();

                unServicio.TiposFormacion.Add(unaFormacion, 2);
                unServicio.TiposFormacion.Add(otraFormacion, 5);

                session.SaveOrUpdate(unaFormacion);
                session.SaveOrUpdate(otraFormacion);
                session.Flush();

                session.SaveOrUpdate(unServicio);
                session.Flush();

                var servicioDB = session.Query<Servicio>().Where(x => x.Nombre == unServicio.Nombre).FirstOrDefault();

                Assert.IsNotNull(servicioDB);

                Assert.AreEqual(unServicio.TiposFormacion, servicioDB.TiposFormacion);
                Assert.AreEqual(servicioDB.TiposFormacion[unaFormacion], 2);
            }
        }

        [TestMethod]
        public void RelacionServicioTramos()
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var unTramo = ObtenerTramoDePrueba();
                var otroTramo = ObtenerTramoDePrueba();
                var unServicio = ObtenerServicioDePrueba();

                unServicio.Tramos.Add(unTramo);
                unServicio.Tramos.Add(otroTramo);

                session.SaveOrUpdate(unTramo);
                session.SaveOrUpdate(otroTramo);
                session.Flush();

                session.SaveOrUpdate(unServicio);
                session.Flush();

                var servicioDB = session.Query<Servicio>().Where(x => x.Nombre == unServicio.Nombre).FirstOrDefault();

                Assert.IsNotNull(servicioDB);

                Assert.AreEqual(unServicio.Tramos, servicioDB.Tramos);
                Assert.AreEqual(servicioDB.Tramos.FirstOrDefault(), unTramo);
            }
        }

        //[TestMethod]
        //public void RelacionTrazaServicios()
        //{
        //    using (var session = NHibernateHelper.OpenSession())
        //    using (var transaction = session.BeginTransaction())
        //    {
        //        var unServicio = ObtenerServicioDePrueba();
        //        var otroServicioIgual = ObtenerServicioDePrueba();
        //        var unaTraza = ObtenerTrazaDePrueba();

        //        unaTraza.Servicios.Add(unServicio);
        //        unaTraza.Servicios.Add(otroServicioIgual);

        //        session.SaveOrUpdate(unServicio);
        //        session.SaveOrUpdate(otroServicioIgual);
        //        session.Flush();

        //        session.SaveOrUpdate(unaTraza);

        //        var trazaDB = session.Query<Traza>().Where(x => x.Nombre == unaTraza.Nombre).FirstOrDefault();

        //        Assert.IsNotNull(trazaDB);

        //        Assert.IsTrue(trazaDB.Servicios.Count == 2);
        //    }
        //}

        //[TestMethod]
        //public void RelacionTrazaSimulaciones()
        //{
        //    using (var session = NHibernateHelper.OpenSession())
        //    using (var transaction = session.BeginTransaction())
        //    {
        //        var unaSimluacion = ObtenerSimulacionDePrueba();
        //        var otraSimulacion = ObtenerSimulacionDePrueba();
        //        var unaTraza = ObtenerTrazaDePrueba();

        //        unaTraza.Simulaciones.Add(unaSimluacion);
        //        unaTraza.Simulaciones.Add(otraSimulacion);

        //        session.SaveOrUpdate(unaSimluacion);
        //        session.SaveOrUpdate(otraSimulacion);
        //        session.Flush();

        //        session.SaveOrUpdate(unaTraza);

        //        var trazaDB = session.Query<Traza>().Where(x => x.Nombre == unaTraza.Nombre).FirstOrDefault();

        //        Assert.IsNotNull(trazaDB);

        //        Assert.IsTrue(trazaDB.Simulaciones.Count == 2);
        //    }
        //}



        private Coche ObtenerCocheDePrueba()
        {
            return new Coche()
            {
                Modelo = "modelo",
                EsLocomotora = true,
                TipoDeConsumo = Coche.TipoConsumo.DIESEL,
                ConsumoMovimiento = 400,
                ConsumoParado = 40,
                CantidadAsientos = 20,
                MaximoLegalPasajeros = 200,
                CapacidadMaximaPasajeros = 260
            };
        }

        private Formacion ObtenerFormacionDePrueba()
        {
            return new Formacion()
            {
                Nombre = "nombre de formacion",
                KilometrosMantenimiento = 1000,
                DuracionMantenimiento = 300
            };
        }

        private static Estacion ObtenerEstacionDePrueba()
        {
            var estacion = new Estacion()
            {
                Nombre = "nombre de estacion",
                PersonasEsperandoMaxIda = 10,
                PersonasEsperandoMaxVuelta = 15,
                PersonasEsperandoMinIda = 5,
                PersonasEsperandoMinVuelta = 10,
                PersonasDesciendenMaxIda = 20,
                PersonasDesciendenMaxVuelta = 25,
                PersonasDesciendenMinIda = 10,
                PersonasDesciendenMinVuelta = 15
            };
            return estacion;
        }

        private static Incidente ObtenerIncidenteDePrueba()
        {
            var incidente = new Incidente()
            {
                Nombre = "Incidente",
                Descripcion = "Descripcion de incidente",
                ProbabilidadDeOcurrencia = 10.45,
                TiempoDemora = 100
            };
            return incidente;
        }

        private static Tramo ObtenerTramoDePrueba()
        {
            var tramo = new Tramo()
            {
                Distancia = 7000,
                TiempoViaje = 40
            };
            return tramo;
        }

        //private static Relacion ObtenerRelacionDePrueba()
        //{
        //    var relacion = new Relacion()
        //    {
        //        Distancia = 1000,
        //        VelocidadPromedio = 300,
        //        TiempoViaje = 20
        //    };
        //    return relacion;
        //}

        private static Servicio ObtenerServicioDePrueba()
        {
            var servicio = new Servicio()
            {
                Nombre = "nombre de servicio",
                CantidadFormacionesInicio = 6
            };
            return servicio;
        }

        //private static Traza ObtenerTrazaDePrueba()
        //{
        //    var traza = new Traza()
        //    {
        //        Nombre = "Traza"
        //    };
        //    return traza;
        //}

        //private static Simulacion ObtenerSimulacionDePrueba()
        //{
        //    var simulacion = new Simulacion()
        //    {
        //        Nombre = "nombre de simulacion",
        //        FrecuenciaDeSalida = 7
        //    };
        //    return simulacion;
        //}
    }
}
