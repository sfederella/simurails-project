using NHibernate.Linq;
using System.Collections.Generic;
using System.Linq;

namespace SimuRails.DB
{
    public class Repositorio
    {
        public void Guardar<T>(T objeto)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.Save(objeto);
                transaction.Commit();
            }
        }

        public T Obtener<T>(int id)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return session.Get<T>(id);
            }
        }

        public List<T> Listar<T>()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return session.Query<T>().ToList();
            }
        }

        public void Actualizar<T>(T objeto)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.Update(objeto);
                transaction.Commit();
            }
        }

        public void Eliminar<T>(T objeto)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.Delete(objeto);
                transaction.Commit();
            }
        }

    }
}