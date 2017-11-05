using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimuRails.DB
{
    public class Repositorio : IDisposable
    {
        private ISession pSession;

        public Repositorio()
        {
            this.pSession = NHibernateHelper.OpenSession();
        }

        public void GuardarOActualizar<T>(T objeto)
        {
            using (var transaction = pSession.BeginTransaction())
            {
                pSession.SaveOrUpdate(objeto);
                transaction.Commit();
            }
        }

        public void Guardar<T>(T objeto)
        {
            using (var transaction = pSession.BeginTransaction())
            {
                pSession.Save(objeto);
                transaction.Commit();
            }
        }

        public T Obtener<T>(int id)
        {
            return pSession.Get<T>(id);
            
        }

        public List<T> Listar<T>()
        {
            return pSession.Query<T>().ToList();
        }

        public void Actualizar<T>(T objeto)
        {
            using (var transaction = pSession.BeginTransaction())
            {
                pSession.Update(objeto);
                transaction.Commit();
            }
        }

        public void Eliminar<T>(T objeto)
        {
            using (var transaction = pSession.BeginTransaction())
            {
                pSession.Delete(objeto);
                transaction.Commit();
            }
        }

        public void Persistir<T>(T objeto)
        {
            using (var transaction = pSession.BeginTransaction())
            {
                pSession.Persist(objeto);
                transaction.Commit();
            }
        }

        public void Dispose()
        {
            this.pSession.Dispose();
        }
    }
}