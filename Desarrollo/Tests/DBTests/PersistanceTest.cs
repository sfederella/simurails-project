using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimuRails;
using SimuRails.DB;
using SimuRails.Models;
using NHibernate.Linq;
using System.Linq;

namespace Tests.DBTests
{
    [TestClass]
    public class PersistanceTest
    {
        [TestMethod]
        public void seGuardaLaTrazaTest()
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var traza = new Traza()
                {
                    Nombre = "Traza1"
                };

                session.SaveOrUpdate(traza);
                session.Flush();

                var existeTraza = session.Query<Traza>()
                   .Any(x => x.Nombre == traza.Nombre);

                Assert.IsTrue(existeTraza);
            }
        }

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
                var estacion = new Estacion()
                {
                    Nombre = "nombre de estacion",
                    PersonasEsperandoMax = 300,
                    PersonasEsperandoMin = 20,
                    TipoFDP = "tipo de fdp"
                };

                session.SaveOrUpdate(estacion);
                session.Flush();

                var estacionDB = session.Query<Estacion>()
                   .Where(x => x.PersonasEsperandoMax == estacion.PersonasEsperandoMax && x.Nombre == estacion.Nombre)
                   .FirstOrDefault();

                Assert.IsNotNull(estacionDB);

                estacionDB.PersonasEsperandoMax = 1000;
                estacionDB.Nombre = "otro nombre";

                session.SaveOrUpdate(estacion);
                session.Flush();

                estacionDB = session.Query<Estacion>()
                   .Where(x => x.TipoFDP == estacion.TipoFDP && x.PersonasEsperandoMin == estacion.PersonasEsperandoMin)
                   .FirstOrDefault();

                Assert.AreEqual(estacionDB.Nombre, "otro nombre");
                Assert.AreEqual(estacionDB.PersonasEsperandoMax, 1000);

                session.Delete(estacionDB);

                var existeEstacion = session.Query<Estacion>()
                   .Any(x => x.Nombre == estacion.Nombre && x.PersonasEsperandoMax == estacion.PersonasEsperandoMax);

                Assert.IsFalse(existeEstacion);
            }
        }

        [TestMethod]
        public void CRUDRelacion()
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var relacion = new Relacion()
                {
                    Distancia = 1000,
                    VelocidadPromedio = 300,
                    TiempoViaje = 20
                };

                session.SaveOrUpdate(relacion);
                session.Flush();

                var relacionDB = session.Query<Relacion>()
                   .Where(x => x.Distancia == relacion.Distancia && x.VelocidadPromedio == relacion.VelocidadPromedio)
                   .FirstOrDefault();

                Assert.IsNotNull(relacionDB);

                relacionDB.TiempoViaje = 30;

                session.SaveOrUpdate(relacion);
                session.Flush();

                relacionDB = session.Query<Relacion>()
                   .Where(x => x.Distancia == relacion.Distancia && x.VelocidadPromedio == relacion.VelocidadPromedio)
                   .FirstOrDefault();

                Assert.AreEqual(relacionDB.TiempoViaje, 30);

                session.Delete(relacionDB);

                var existeRelacion = session.Query<Relacion>()
                   .Any(x => x.Distancia == relacion.Distancia && x.VelocidadPromedio == relacion.VelocidadPromedio);

                Assert.IsFalse(existeRelacion);
            }
        }

        [TestMethod]
        public void CRUDServicio()
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var servicio = new Servicio()
                {
                    Nombre = "nombre de servicio"
                };

                session.SaveOrUpdate(servicio);
                session.Flush();

                var servicioDB = session.Query<Servicio>()
                   .Where(x => x.Nombre == servicio.Nombre)
                   .FirstOrDefault();

                Assert.IsNotNull(servicioDB);

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

        [TestMethod]
        public void CRUDSimulacion()
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var simulacion = new Simulacion()
                {
                    Nombre = "nombre de simulacion",
                    FrecuenciaDeSalida = 7
                };

                session.SaveOrUpdate(simulacion);
                session.Flush();

                var simulacionDB = session.Query<Simulacion>()
                   .Where(x => x.Nombre == simulacion.Nombre)
                   .FirstOrDefault();

                Assert.IsNotNull(simulacionDB);

                simulacionDB.Nombre = "otro nombre";
                simulacionDB.FrecuenciaDeSalida = 6;

                session.SaveOrUpdate(simulacion);
                session.Flush();

                simulacionDB = session.Query<Simulacion>()
                   .Where(x => x.Nombre == simulacion.Nombre)
                   .FirstOrDefault();

                Assert.AreEqual(simulacionDB.Nombre, "otro nombre");
                Assert.AreEqual(simulacionDB.FrecuenciaDeSalida, 6);

                session.Delete(simulacionDB);

                var existeSimulacion = session.Query<Simulacion>()
                   .Any(x => x.Nombre == simulacion.Nombre);

                Assert.IsFalse(existeSimulacion);
            }
        }

        [TestMethod]
        public void CRUDFormacion()
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var formacion = new Formacion()
                {
                    Nombre = "nombre de formacion",
                };

                session.SaveOrUpdate(formacion);
                session.Flush();

                var formacionDB = session.Query<Formacion>()
                   .Where(x => x.Nombre == formacion.Nombre)
                   .FirstOrDefault();

                Assert.IsNotNull(formacionDB);

                formacionDB.Nombre = "otro nombre";

                session.SaveOrUpdate(formacion);
                session.Flush();

                formacionDB = session.Query<Formacion>()
                   .Where(x => x.Nombre == formacion.Nombre)
                   .FirstOrDefault();

                Assert.AreEqual(formacionDB.Nombre, "otro nombre");

                session.Delete(formacionDB);

                var existeFormacion = session.Query<Formacion>()
                   .Any(x => x.Nombre == formacion.Nombre);

                Assert.IsFalse(existeFormacion);
            }
        }

        [TestMethod]
        public void RelacionEntreFormacionYCochesCorrecta()
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var formacion = ObtenerFormacionDePrueba();
                var unCoche = ObtenerCocheDePrueba();
                var otroCoche = ObtenerCocheDePrueba();

                session.SaveOrUpdate(unCoche);
                session.SaveOrUpdate(otroCoche);
                session.Flush();
                
                formacion.Coches.Add(unCoche);
                formacion.Coches.Add(otroCoche);

                session.SaveOrUpdate(formacion);
                session.Flush();

                var formacionDB = session.Query<Formacion>()
                   .Where(x => x.Nombre == formacion.Nombre)
                   .FirstOrDefault();

                Assert.IsNotNull(formacionDB);
                Assert.IsTrue(formacionDB.Coches.Count() == 2);
                Assert.AreEqual(formacion.Coches.First(), unCoche);
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

                session.Delete(cocheDB);

                var existeCoche = session.Query<Coche>()
                   .Any(x => x.MaximoLegalPasajeros == coche.MaximoLegalPasajeros && x.Modelo == coche.Modelo);

                Assert.IsFalse(existeCoche);
            }
        }

        private Coche ObtenerCocheDePrueba()
        {
            return new Coche()
            {
                Modelo = "modelo",
                EsLocomotora = false,
                TipoDeConsumo = "bajo",
                ConsumoMovimiento = 400,
                ConsumoParado = 40,
                MaximoLegalPasajeros = 200,
                CapacidadMaximaPasajeros = 260
            };
        }

        private Formacion ObtenerFormacionDePrueba()
        {
            return new Formacion()
            {
                Nombre = "nombre de formacion",
            };
        }
    }
}
