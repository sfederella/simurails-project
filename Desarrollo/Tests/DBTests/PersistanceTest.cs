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

                transaction.Begin();
                session.SaveOrUpdate(traza);
                session.Flush();
                transaction.Commit();

                var existeTraza = session.Query<Traza>()
                   .Any(x => x.Nombre == traza.Nombre);

                Assert.IsTrue(existeTraza);


            }
        }
    }
}
