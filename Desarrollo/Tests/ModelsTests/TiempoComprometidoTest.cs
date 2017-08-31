using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuRails.Models;

namespace Tests.ModelsTests
{
    [TestClass]
    public class TiempoComprometidoTest
    {
        [TestMethod]
        public void ejecutarSimulacion()
        {
            var traza = new Traza()
            {
                Nombre = "Sarmiento"
            };

            var servicio = new Servicio();

            var formacion = new Formacion();
            formacion.HoraSalida = 5;
            var estacionOrigen = new Estacion();
            var estacionDestino = new Estacion();
            formacion.EstacionActual = estacionOrigen;
            formacion.EstacionDestino = estacionDestino;
            formacion.Servicio = servicio;

            servicio.Formaciones = new HashSet<Formacion>();
            servicio.Formaciones.Add(formacion);

            traza.Servicios = new HashSet<Servicio>();
            traza.Servicios.Add(servicio);

            int tiempoFinal = 1000;

            var tiempoComprometido = new TiempoComprometido(traza, tiempoFinal);

            tiempoComprometido.ejecutarSimulacion();

            Assert.IsTrue(false);
        }
    }
}
