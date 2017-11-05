using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuRails.Models;
using log4net.Config;
using log4net;
using System.Reflection;
using System.ComponentModel;

namespace Tests.ModelsTests
{
    [TestClass]
    public class TiempoComprometidoTest
    {
        Traza traza;
        private readonly ILog log = LogManager.GetLogger("");

        [TestInitialize]
        public void Init()
        {
            XmlConfigurator.Configure();

            traza = new ModelMock().Traza;

        }
        
        [TestMethod]
        public void EjecutarSimulacion()
        {
            Simulacion simulacion = new Simulacion()
            {
                Nombre = "Simulacion Test",
                Duracion = 2880,
                Metodo = new TiempoComprometido(),
                TrazaSimulada = traza
            };

            this.log.Info("Iniciando test de tiempo comprometido");
            simulacion.Ejecutar(new BackgroundWorker());
            this.log.Info("Fin test de tiempo comprometido");
            Assert.IsTrue(true);
        }

    }
}
