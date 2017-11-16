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
           
        }

        internal void updateList()
        {
            this.dibujarRenglones();
        }

        public void addServicio(Servicio Servicio)
        {
            using (var repositorioServicio = new Repositorio())
            {
                repositorioServicio.Guardar(Servicio);
                this.dibujarRenglones();
            }
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

        internal void onTabEnter(object sender, EventArgs e)
        {
            this.dibujarRenglones();
        }

        private void onServicioRemove(int id)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el servicio?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var repositorioServicio = new Repositorio())
                {
                    Servicio servicio = repositorioServicio.Obtener<Servicio>(id);
                    repositorioServicio.Eliminar(servicio);
                    this.dibujarRenglones();
                }
            }
        }

        public void dibujarRenglones()
        {
            using (var repositorioServicio = new Repositorio())
            {
                var servicios = repositorioServicio.Listar<Servicio>();

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
            using (var repositorioServicio = new Repositorio())
            {
                Servicio servicio = repositorioServicio.Obtener<Servicio>(servicioId);
                NHibernateUtil.Initialize(servicio.ProgramacionIda);
                NHibernateUtil.Initialize(servicio.ProgramacionVuelta);
                this.mainForm.EmbedForm(new EditServicioForm(this, repositorioServicio, servicio), tabPage);
                this.Visible = false;
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            using (var repositorio = new Repositorio())
            {
                Servicio servicio = new Servicio();
                this.mainForm.EmbedForm(new CreateServicioForm(this, servicio, repositorio), tabPage);
            }
            this.Visible = false;
        }
    }
}
