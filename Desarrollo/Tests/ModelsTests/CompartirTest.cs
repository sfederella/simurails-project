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


    }
}
