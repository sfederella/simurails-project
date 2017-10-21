using SimuRails.DB;
using SimuRails.Models;
using SimuRails.Views.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SimuRails.Views.Abms
{
    public partial class TrazasListForm : Form
    {
        private MainForm mainForm;
        private TabPage tabPage;
        private Repositorio repositorioTraza = new Repositorio();
        private List<Control> renglones = new List<Control>();

        public TrazasListForm()
        {
            InitializeComponent();
        }

        public TrazasListForm(MainForm mainForm, TabPage tabPage)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tabPage = tabPage;
        }

        private void TrazasListForm_Load_1(object sender, EventArgs e)
        {
            this.dibujarRenglones();
        }

        internal void updateList()
        {
            this.dibujarRenglones();
        }

        public void addTraza(Traza Traza)
        {
            repositorioTraza.Guardar(Traza);
            this.dibujarRenglones();
        }

        private RenglonDeTraza renglonDe(Traza traza, int indice)
        {
            var renglon = new RenglonDeTraza(traza, this.OnTrazaEdit, this.onTrazaRemove);
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

        private void onTrazaRemove(int id)
        {
            Traza traza = this.findTraza(id);
            repositorioTraza.Eliminar(traza);
            this.dibujarRenglones();
        }

        private void dibujarRenglones()
        {
            var trazas = repositorioTraza.Listar<Traza>();

            renglones.ForEach(unRenglon => this.removeRenglon(unRenglon));
            for (int i = 0; i < trazas.Count; i++)
            {
                renglones.Add(this.renglonDe(trazas.ElementAt(i), i));

            }
            if (trazas.Count == 0)
            {
                this.incluirEnLista(0, new RenglonListaVacia());
            }
        }

        private void removeRenglon(Control unRenglon)
        {
            this.Controls.Remove(unRenglon);
            unRenglon.Dispose();
        }

        public void OnTrazaEdit(int trazaId)
        {
            Traza traza = findTraza(trazaId);
            this.mainForm.embedForm(new EditTrazaForm(this, repositorioTraza, traza), tabPage);
            this.Visible = false;
        }

        private Traza findTraza(int trazaId)
        {
            return repositorioTraza.Obtener<Traza>(trazaId);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Traza traza = new Traza();
            this.mainForm.embedForm(new CreateTrazaForm(this, traza), tabPage);
            this.Visible = false;
        }
    }
}
