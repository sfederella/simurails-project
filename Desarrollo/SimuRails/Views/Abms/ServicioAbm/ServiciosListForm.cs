using NHibernate;
using NHibernate.Linq;
using SimuRails.DB;
using SimuRails.Models;
using SimuRails.Views.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SimuRails.Views.Abms
{
    public partial class ServiciosListForm : Form
    {
        private MainForm mainForm;
        private TabPage tabPage;
        private Repositorio repositorioServicio = new Repositorio();
        private List<Control> renglones = new List<Control>();

        public ServiciosListForm()
        {
            InitializeComponent();
        }

        public ServiciosListForm(MainForm mainForm, TabPage tabPage)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tabPage = tabPage;
        }

        private void ServiciosListForm_Load_1(object sender, EventArgs e)
        {
            this.dibujarRenglones();
        }

        internal void updateList()
        {
            this.dibujarRenglones();
        }

        public void addServicio(Servicio Servicio)
        {
            repositorioServicio.Guardar(Servicio);
            this.dibujarRenglones();
        }

        private RenglonDeServicio renglonDe(Servicio servicio, int indice)
        {
            var renglon = new RenglonDeServicio(servicio, this.OnServicioEdit, this.onServicioRemove);
            this.incluirEnLista(indice, renglon);
            return renglon;
        }

        private void incluirEnLista(int indice, Control renglon)
        {
            renglon.Location = new System.Drawing.Point(5, 25 + indice * 50);
            renglon.Width = this.listPanel.Width;
            renglon.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            this.listPanel.Controls.Add(renglon);
            renglones.Add(renglon);
        }

        private void onServicioRemove(int id)
        {
            Servicio servicio = this.findServicio(id);
            repositorioServicio.Eliminar(servicio);
            this.dibujarRenglones();
        }

        private void dibujarRenglones()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var servicios = session.Query<Servicio>().ToList();

                renglones.ForEach(unRenglon => this.removeRenglon(unRenglon));
                for (int i = 0; i < servicios.Count; i++)
                {
                    renglones.Add(this.renglonDe(servicios.ElementAt(i), i));

                }
                if (servicios.Count == 0)
                {
                    this.incluirEnLista(0, new RenglonListaVacia());
                }
            }
        }

        private void removeRenglon(Control unRenglon)
        {
            this.Controls.Remove(unRenglon);
            unRenglon.Dispose();
        }

        public void OnServicioEdit(int servicioId)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                Servicio servicio = findServicio(servicioId, session);
                this.mainForm.EmbedForm(new EditServicioForm(this, repositorioServicio, servicio), tabPage);
                this.Visible = false;
            }

        }

        private Servicio findServicio(int servicioId)
        {
            return repositorioServicio.Obtener<Servicio>(servicioId);
        }

        private Servicio findServicio(int servicioId, ISession session)
        {
            return session.Get<Servicio>(servicioId);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Servicio servicio = new Servicio();
            this.mainForm.EmbedForm(new CreateServicioForm(this, servicio), tabPage);
            this.Visible = false;
        }
    }
}
