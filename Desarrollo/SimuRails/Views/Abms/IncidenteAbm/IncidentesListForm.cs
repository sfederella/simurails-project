using SimuRails.DB;
using SimuRails.Models;
using SimuRails.Views.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SimuRails.Views.Abms
{
    public partial class IncidentesListForm : Form
    {
        private MainForm mainForm;
        private TabPage tabPage;
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
            using (var repositorio = new Repositorio())
            {
                this.dibujarRenglones(repositorio);
            }
        }

        public void addIncidente(Incidente incidente)
        {
            using (var repositorio = new Repositorio())
            {
                repositorio.Guardar(incidente);
                this.dibujarRenglones(repositorio);
            }
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
            renglon.Width = this.listPanel.Width-5;
            renglon.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            this.listPanel.Controls.Add(renglon);
            renglones.Add(renglon);
        }

        private void onIncidenteRemove(int id)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el incidente?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var repositorio = new Repositorio())
                {
                    Incidente incidente = repositorio.Obtener<Incidente>(id);
                    repositorio.Eliminar(incidente);
                    this.dibujarRenglones(repositorio);
                }
            }
         }

        public void dibujarRenglones(Repositorio repositorio)
        {
            var incidentes = repositorio.Listar<Incidente>();

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
            using (var repositorio = new Repositorio())
            {
                Incidente incidente = repositorio.Obtener<Incidente>(incidenteId);
                this.mainForm.EmbedForm(new EditIncidenteForm(this, incidente), tabPage);
            }

            this.Visible = false;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Incidente incidente = new Incidente();
            this.mainForm.EmbedForm(new CreateIncidenteForm(this, incidente), tabPage);
            this.Visible = false;
        }
    }
}
