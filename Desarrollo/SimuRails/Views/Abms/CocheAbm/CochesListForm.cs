using SimuRails.DB;
using SimuRails.Models;
using SimuRails.Views.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SimuRails.Views.Abms
{
    public partial class CochesListForm : Form
    {
        private MainForm mainForm;
        private TabPage tabPage;
        private Repositorio repositorioCoche= new Repositorio();
        private List<Control> renglones = new List<Control>();

        public CochesListForm(MainForm mainForm, TabPage tabPage)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tabPage = tabPage;
        }

        private void CochesListForm_Load(object sender, EventArgs e)
        {
            this.dibujarRenglones();
        }

        internal void updateList()
        {
            this.dibujarRenglones();
        }

        public void addCoche(Coche coche)
        {
            repositorioCoche.Guardar(coche);
            this.dibujarRenglones();
        }

        private RenglonDeCoche renglonDe(Coche coche, int indice)
        {
            var renglon = new RenglonDeCoche(coche, this.OnCocheEdit, this.onCocheRemove);
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

        private void onCocheRemove(int id)
        {
            Coche coche = this.findCoche(id);
            repositorioCoche.Eliminar(coche);
            this.dibujarRenglones();
        }

        private void dibujarRenglones()
        {
            var coches = repositorioCoche.Listar<Coche>();

            renglones.ForEach(unRenglon => this.removeRenglon(unRenglon));
            for (int i = 0; i < coches.Count; i++)
            {
                renglones.Add(this.renglonDe(coches.ElementAt(i), i));

            }
            if(coches.Count == 0)
            {
                this.incluirEnLista(0, new RenglonListaVacia());
            }
        }

        private void removeRenglon(Control unRenglon)
        {
            this.Controls.Remove(unRenglon);
            unRenglon.Dispose();
        }

        public void OnCocheEdit(int cocheId)
        {
            Coche coche = findCoche(cocheId);
            this.mainForm.EmbedForm(new EditCocheForm(this, repositorioCoche, coche), tabPage);
            this.Visible = false;
        }

        private Coche findCoche(int cocheId)
        {
            return repositorioCoche.Obtener<Coche>(cocheId);
        }


        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Coche coche = new Coche();
            this.mainForm.EmbedForm(new CreateCocheForm(this, coche), tabPage);
            this.Visible = false;
        }

        private void listPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
