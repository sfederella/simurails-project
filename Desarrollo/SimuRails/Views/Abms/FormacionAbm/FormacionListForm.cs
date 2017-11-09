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
            using (var repositorio = new Repositorio())
            {
                repositorio.GuardarOActualizar(formacion);
            }

            this.dibujarRenglones();
        }

        private RenglonDeFormacion renglonDe(Formacion formacion)
        {
            return new RenglonDeFormacion(formacion, this.OnformacionEdit, this.onformacionRemove);
        }

        private void onformacionRemove(int id)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar la formación?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var repositorio = new Repositorio())
                {
                    Formacion formacion = repositorio.Obtener<Formacion>(id);
                    repositorio.Eliminar(formacion);
                }
                this.dibujarRenglones();
            }              
        }

        private void dibujarRenglones()
        {
            using (var repositorio = new Repositorio())
            {
                List<Formacion> formaciones = repositorio.Listar<Formacion>();
                var renglones = formaciones.Select(formacion => this.renglonDe(formacion)).ToList<Control>();
                this.formacionesList.setearRenglones(renglones);
            }   
        }

        public void OnformacionEdit(int formacionId)
        {
            using (var repositorio = new Repositorio())
            {
                Formacion formacion = repositorio.Obtener<Formacion>(formacionId);
                this.mainForm.EmbedForm(new EditFormacionForm(this, formacion, repositorio), tabPage);
                this.Visible = false;
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
