using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            try
            {
                using (var transaction = pSession.BeginTransaction())
                {
                    pSession.Delete(objeto);
                    transaction.Commit();
                }
            }
            catch (Exception e)
            {
                if (e.HResult == -2146232832)
                {
                    string msg = string.Format("Este objeto no se puede borrar ya que se encuentra contenido en otra entidad", Environment.NewLine);

                    MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    string msg = string.Format("Ha ocurrido un error no identificado. Favor de reiniciar la aplicación y volver a intentar", Environment.NewLine);

                    MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
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