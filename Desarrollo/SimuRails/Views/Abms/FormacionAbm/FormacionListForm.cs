using NHibernate.Linq;
using SimuRails.DB;
using SimuRails.Models;
using SimuRails.Views.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuRails.Views.Abms.FormacionAbm
{
    public partial class FormacionListForm : Form
    {
        public FormacionListForm()
        {
            InitializeComponent();
        }

        private MainForm mainForm;
        private TabPage tabPage;
        private List<Control> renglones = new List<Control>();

        public FormacionListForm(MainForm mainForm, TabPage tabPage)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tabPage = tabPage;
        }

        private void FormacionListForm_Load(object sender, EventArgs e)
        {
            this.dibujarRenglones();
        }

        internal void updateList()
        {
            this.dibujarRenglones();
        }

        public void addFormacion(Formacion formacion)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.SaveOrUpdate(formacion);
                transaction.Commit();
            }

            this.dibujarRenglones();
        }

        private RenglonDeFormacion renglonDe(Formacion formacion, int indice)
        {
            var renglon = new RenglonDeFormacion(formacion, this.OnformacionEdit, this.onformacionRemove);
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

        private void onformacionRemove(int id)
        {
            Formacion formacion = this.findformacion(id);
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.Delete(formacion);
                transaction.Commit();
            }
            this.dibujarRenglones();
        }

        private void dibujarRenglones()
        {
            List<Formacion> formaciones;
            using (var session = NHibernateHelper.OpenSession())
            {
                formaciones = session.Query<Formacion>().ToList();
            }

            renglones.ForEach(unRenglon => this.removeRenglon(unRenglon));
            for (int i = 0; i < formaciones.Count; i++)
            {
                renglones.Add(this.renglonDe(formaciones.ElementAt(i), i));

            }
            if (formaciones.Count == 0)
            {
                this.incluirEnLista(0, new RenglonListaVacia());
            }
        }

        private void removeRenglon(Control unRenglon)
        {
            this.Controls.Remove(unRenglon);
            unRenglon.Dispose();
        }

        public void OnformacionEdit(int formacionId)
        {
            Formacion formacion = findformacion(formacionId);
            this.mainForm.embedForm(new EditFormacionForm(this, formacion), tabPage);
            this.Visible = false;
        }

        private Formacion findformacion(int formacionId)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var formacion = session.Get<Formacion>(formacionId);
                return formacion;
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Formacion formacion = new Formacion();
            this.mainForm.embedForm(new CreateFormacionForm(this, formacion), tabPage);
            this.Visible = false;
        }
    }
}
