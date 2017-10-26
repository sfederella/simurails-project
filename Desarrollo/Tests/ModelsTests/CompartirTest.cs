using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimuRails.Models;
using SimuRails.Sharing;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;

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
            SharingUtils.Exportar(traza);
            Traza trazaRecuperada = SharingUtils.Importar();
            Assert.IsNotNull(trazaRecuperada);
        }
    }
}
