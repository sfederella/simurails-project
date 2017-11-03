using SimuRails.DB;
using SimuRails.Models;
using SimuRails.Views.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SimuRails.Views.Abms
{
    public partial class SimulacionesListForm : Form
    {
        internal MainForm mainForm;
        internal TabPage tabPage;
        private Repositorio repositorioSimulacion = new Repositorio();
        private List<Control> renglones = new List<Control>();

        public SimulacionesListForm()
        {
            InitializeComponent();
        }

        public SimulacionesListForm(MainForm mainForm, TabPage tabPage)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tabPage = tabPage;
        }

        private void SimulacionesListForm_Load_1(object sender, EventArgs e)
        {
            this.dibujarRenglones();
        }

        internal void updateList()
        {
            this.dibujarRenglones();
        }

        public void addSimulacion(Simulacion simulacion)
        {
            repositorioSimulacion.Guardar(simulacion);
            this.dibujarRenglones();
        }

        private RenglonDeSimulacion renglonDe(Simulacion simulacion, int indice)
        {
            var renglon = new RenglonDeSimulacion(simulacion, this.OnSimulacionEdit, this.onSimulacionRemove,this);
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

        private void onSimulacionRemove(int id)
        {
            Simulacion simulacion = this.findSimulacion(id);
            repositorioSimulacion.Eliminar(simulacion);
            this.dibujarRenglones();
        }

        private void dibujarRenglones()
        {
            var simulacions = repositorioSimulacion.Listar<Simulacion>();

            renglones.ForEach(unRenglon => this.removeRenglon(unRenglon));
            for (int i = 0; i < simulacions.Count; i++)
            {
                renglones.Add(this.renglonDe(simulacions.ElementAt(i), i));

            }
            if (simulacions.Count == 0)
            {
                this.incluirEnLista(0, new RenglonListaVacia());
            }
        }

        private void removeRenglon(Control unRenglon)
        {
            this.Controls.Remove(unRenglon);
            unRenglon.Dispose();
        }

        public void OnSimulacionEdit(int simulacionId)
        {
            Simulacion simulacion = findSimulacion(simulacionId);
            this.mainForm.EmbedForm(new EditSimulacionForm(this, repositorioSimulacion, simulacion), tabPage);
            this.Visible = false;
        }

        private Simulacion findSimulacion(int simulacionId)
        {
            return repositorioSimulacion.Obtener<Simulacion>(simulacionId);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Simulacion simulacion = new Simulacion();
            this.mainForm.EmbedForm(new CreateSimulacionForm(this, simulacion), tabPage);
            this.Visible = false;
        }
    }
}
