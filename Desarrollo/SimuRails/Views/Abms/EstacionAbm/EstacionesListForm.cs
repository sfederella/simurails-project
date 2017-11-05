using SimuRails.DB;
using SimuRails.Models;
using SimuRails.Views.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SimuRails.Views.Abms
{
    public partial class EstacionesListForm : Form
    {
        private MainForm mainForm;
        private TabPage tabPage;
        private List<Control> renglones = new List<Control>();

        public EstacionesListForm()
        {
            InitializeComponent();
        }

        public EstacionesListForm(MainForm mainForm, TabPage tabPage)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tabPage = tabPage;
        }

        private void EstacionesListForm_Load(object sender, EventArgs e)
        {
            using (var repositorio = new Repositorio())
            {
                this.dibujarRenglones(repositorio);
            }
        }

        public void addEstacion(Estacion estacion)
        {
            using (var repositorio = new Repositorio())
            {
                repositorio.Guardar(estacion);
                this.dibujarRenglones(repositorio);
            }
        }

        private RenglonDeEstacion renglonDe(Estacion estacion, int indice)
        {
            var renglon = new RenglonDeEstacion(estacion, this.OnestacionEdit, this.onEstacionRemove);
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

        private void onEstacionRemove(int id)
        {
            using (var repositorio = new Repositorio())
            {
                Estacion estacion = repositorio.Obtener<Estacion>(id);
                repositorio.Eliminar(estacion);
                this.dibujarRenglones(repositorio);
            }
        }

        public void dibujarRenglones(Repositorio repositorio)
        {
            var estacions = repositorio.Listar<Estacion>();

            renglones.ForEach(unRenglon => this.removeRenglon(unRenglon));
            for (int i = 0; i < estacions.Count; i++)
            {
                renglones.Add(this.renglonDe(estacions.ElementAt(i), i));

            }
            if (estacions.Count == 0)
            {
                this.incluirEnLista(0, new RenglonListaVacia());
            }
        }

        private void removeRenglon(Control unRenglon)
        {
            this.Controls.Remove(unRenglon);
            unRenglon.Dispose();
        }

        public void OnestacionEdit(int estacionId)
        {
            using (var repositorio = new Repositorio())
            {
                Estacion estacion = repositorio.Obtener<Estacion>(estacionId);
                this.mainForm.EmbedForm(new EditEstacionForm(this, repositorio, estacion), tabPage);
            }
                
            this.Visible = false;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            using (var repositorio = new Repositorio())
            {
                Estacion estacion = new Estacion();
                this.mainForm.EmbedForm(new CreateEstacionForm(this, estacion, repositorio), tabPage);
            }

            this.Visible = false;
        }
    }
}
