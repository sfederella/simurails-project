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
using NHibernate;

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

        private RenglonDeFormacion renglonDe(Formacion formacion)
        {
            return new RenglonDeFormacion(formacion, this.OnformacionEdit, this.onformacionRemove);
        }

        private void onformacionRemove(int id)
        {
            Formacion formacion = this.findFormacion(id);
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

            var renglones = formaciones.Select(formacion => this.renglonDe(formacion)).ToList<Control>();
            this.formacionesList.setearRenglones(renglones);
        }

        public void OnformacionEdit(int formacionId)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                Formacion formacion = findFormacion(session, formacionId);
                this.mainForm.EmbedForm(new EditFormacionForm(this, formacion), tabPage);
                this.Visible = false;
            }
        }

        private Formacion findFormacion(ISession session, int formacionId)
        {
            return session.Get<Formacion>(formacionId);
        }

        private Formacion findFormacion(int formacionId)
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
            this.mainForm.EmbedForm(new CreateFormacionForm(this, formacion), tabPage);
            this.Visible = false;
        }
    }
}
