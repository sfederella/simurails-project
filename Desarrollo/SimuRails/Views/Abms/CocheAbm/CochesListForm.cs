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

namespace SimuRails.Views.Abms
{
    public partial class CochesListForm : Form
    {
        private MainForm mainForm;
        private TabPage tabPage;
        private List<Coche> coches = new List<Coche>();
        private List<RenglonDeCoche> renglones = new List<RenglonDeCoche>();

        public CochesListForm(MainForm mainForm, TabPage tabPage)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tabPage = tabPage;
        }

        private void CochesListForm_Load(object sender, EventArgs e)
        {
            var coche1 = new Coche();
            coche1.Id = 1;
            coche1.Modelo = "Unidad múltiple eléctrica CSR";
            coche1.TipoDeConsumo = "Diesel";
            coche1.MaximoLegalPasajeros = 60;
            coche1.CapacidadMaximaPasajeros = 80;
            coche1.ConsumoMovimiento = 50;
            coche1.ConsumoParado = 20;
            coche1.EsLocomotora = false;
            coches.Add(coche1);
            var coche2 = new Coche();
            coche2.Id = 2;
            coche2.Modelo = "Mitsubishi";
            coche2.TipoDeConsumo = "Electrico";
            coche2.MaximoLegalPasajeros = 65;
            coche2.CapacidadMaximaPasajeros = 84;
            coche2.ConsumoMovimiento = 50;
            coche2.ConsumoParado = 20;
            coche2.EsLocomotora = false;
            coches.Add(coche2);

            this.dibujarRenglones();
        }

        internal void updateList()
        {
            this.dibujarRenglones();
        }

        public void addCoche(Coche coche)
        {
            coches.Add(coche);
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
        }

        private void onCocheRemove(int id)
        {
            Coche coche = this.findCoche(id);
            coches.Remove(coche);
            this.dibujarRenglones();
        }

        private void dibujarRenglones()
        {
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

        private void removeRenglon(RenglonDeCoche unRenglon)
        {
            this.Controls.Remove(unRenglon);
            unRenglon.Dispose();
        }

        public void OnCocheEdit(int cocheId)
        {
            Coche coche = findCoche(cocheId);
            this.mainForm.embedForm(new EditCocheForm(this, coche), tabPage);
            this.Visible = false;
        }

        private Coche findCoche(int cocheId)
        {
            return this.coches.Find(unCoche => unCoche.Id.Equals(cocheId));
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Coche coche = new Coche();
            this.mainForm.embedForm(new CreateCocheForm(this, coche), tabPage);
            this.Visible = false;
        }
    }
}
