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

namespace SimuRails.Views.Abms.IncidenteAbm
{
    public partial class IncidentesListForm : Form
    {
        private MainForm mainForm;
        private TabPage tabPage;
        private Repositorio repositorioIncidente = new Repositorio();
        private List<Control> renglones = new List<Control>();

        public IncidentesListForm()
        {
            InitializeComponent();
        }

        public IncidentesListForm(MainForm mainForm, TabPage tabPage)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tabPage = tabPage;
        }

        private void IncidentesListForm_Load_1(object sender, EventArgs e)
        {
            this.dibujarRenglones();
        }

        internal void updateList()
        {
            this.dibujarRenglones();
        }

        public void addIncidente(Incidente incidente)
        {
            repositorioIncidente.Guardar(incidente);
            this.dibujarRenglones();
        }

        private RenglonDeIncidente renglonDe(Incidente incidente, int indice)
        {
            var renglon = new RenglonDeIncidente(incidente, this.OnIncidenteEdit, this.onIncidenteRemove);
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

        private void onIncidenteRemove(int id)
        {
            Incidente incidente = this.findIncidente(id);
            repositorioIncidente.Eliminar(incidente);
            this.dibujarRenglones();
        }

        private void dibujarRenglones()
        {
            var incidentes = repositorioIncidente.Listar<Incidente>();

            renglones.ForEach(unRenglon => this.removeRenglon(unRenglon));
            for (int i = 0; i < incidentes.Count; i++)
            {
                renglones.Add(this.renglonDe(incidentes.ElementAt(i), i));

            }
            if (incidentes.Count == 0)
            {
                this.incluirEnLista(0, new RenglonListaVacia());
            }
        }

        private void removeRenglon(Control unRenglon)
        {
            this.Controls.Remove(unRenglon);
            unRenglon.Dispose();
        }

        public void OnIncidenteEdit(int incidenteId)
        {
            Incidente incidente = findIncidente(incidenteId);
            this.mainForm.embedForm(new EditIncidenteForm(this, repositorioIncidente, incidente), tabPage);
            this.Visible = false;
        }

        private Incidente findIncidente(int incidenteId)
        {
            return repositorioIncidente.Obtener<Incidente>(incidenteId);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Incidente incidente = new Incidente();
            this.mainForm.embedForm(new CreateIncidenteForm(this, incidente), tabPage);
            this.Visible = false;
        }
    }
}
