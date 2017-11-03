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
        private Repositorio repositorioestacion = new Repositorio();
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
            this.dibujarRenglones();
        }

        internal void updateList()
        {
            this.dibujarRenglones();
        }

        public void addEstacion(Estacion estacion)
        {
            repositorioestacion.Guardar(estacion);
            this.dibujarRenglones();
        }

        private RenglonDeEstacion renglonDe(Estacion estacion, int indice)
        {
            var renglon = new RenglonDeEstacion(estacion, this.OnestacionEdit, this.onestacionRemove);
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

        private void onestacionRemove(int id)
        {
            Estacion estacion = this.findestacion(id);
            repositorioestacion.Eliminar(estacion);
            this.dibujarRenglones();
        }

        private void dibujarRenglones()
        {
            var estacions = repositorioestacion.Listar<Estacion>();

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
            Estacion estacion = findestacion(estacionId);
            this.mainForm.EmbedForm(new EditEstacionForm(this, repositorioestacion, estacion), tabPage);
            this.Visible = false;
        }

        private Estacion findestacion(int estacionId)
        {
            return repositorioestacion.Obtener<Estacion>(estacionId);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Estacion estacion = new Estacion();
            this.mainForm.EmbedForm(new CreateEstacionForm(this, estacion), tabPage);
            this.Visible = false;
        }
    }
}
