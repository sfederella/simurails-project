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
            using (var repositorio = new Repositorio())
            {
                this.dibujarRenglones(repositorio);
            }
                
        }

        public void addSimulacion(Simulacion simulacion)
        {
            using (var repositorio = new Repositorio())
            {
                repositorio.Guardar(simulacion);
                this.dibujarRenglones(repositorio);
            }
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
             if (MessageBox.Show("¿Está seguro que desea eliminar la simulación?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
             {
                using (var repositorio = new Repositorio())
                {
                    Simulacion simulacion = repositorio.Obtener<Simulacion>(id);
                    repositorio.Eliminar(simulacion);
                    this.dibujarRenglones(repositorio);
                }
            }                 
        }

        public void dibujarRenglones(Repositorio repositorio)
        {
            var simulacions = repositorio.Listar<Simulacion>();

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
            using (var repositorio = new Repositorio())
            {
                Simulacion simulacion = repositorio.Obtener<Simulacion>(simulacionId);
                this.mainForm.EmbedForm(new EditSimulacionForm(this, repositorio, simulacion), tabPage);
            }
            this.Visible = false;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            using (var repositorio = new Repositorio())
            {
                Simulacion simulacion = new Simulacion();
                this.mainForm.EmbedForm(new CreateSimulacionForm(this, simulacion, repositorio), tabPage);
            }

            this.Visible = false;
        }
    }
}
