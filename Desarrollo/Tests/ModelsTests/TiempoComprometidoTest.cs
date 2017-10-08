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
        Traza traza;
        
        [TestInitialize]
        public void Init()
        {
            traza = new ModelMock().Traza;
        }
        
        [TestMethod]
        public void EjecutarSimulacion()
        {
            int tiempoFinal = 1000;

            System.Diagnostics.Debug.WriteLine("########### Iniciando test de tiempo comprometido ###########");
            new TiempoComprometido(traza, tiempoFinal).EjecutarSimulacion();
            System.Diagnostics.Debug.WriteLine("########### Fin test de tiempo comprometido ###########");
            Assert.IsTrue(false);
        }

    }
}
