using NHibernate.Linq;
using SimuRails.DB;
using SimuRails.Models;
using SimuRails.Sharing;
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
            using (var repositorio = new Repositorio())
            {
                this.dibujarRenglones(repositorio);
            }
        }

        public void addTraza(Traza Traza)
        {
            using (var repositorio = new Repositorio())
            {
                repositorio.Guardar(Traza);
                this.dibujarRenglones(repositorio);
            }
                
        }

        private RenglonDeTraza renglonDe(Traza traza, int indice)
        {
            var renglon = new RenglonDeTraza(traza, this.OnTrazaEdit, this.onTrazaRemove, this.OnTrazaExport);
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
            using (var repositorio = new Repositorio())
            {
                Traza traza = this.findTraza(id);
                repositorio.Eliminar(traza);
                this.dibujarRenglones(repositorio);
            }
        }

        private void OnTrazaExport(int id)
        {
            using (var repositorio = new Repositorio())
            {
                var trazaAExportar = repositorio.Obtener<Traza>(id);
                SharingUtils.Exportar(trazaAExportar);
            }

        }

        public void dibujarRenglones(Repositorio repositorio)
        {
            var trazas = repositorio.Listar<Traza>();

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
            using (var repositorio = new Repositorio())
            {
                Traza traza = findTraza(trazaId);
                this.mainForm.EmbedForm(new EditTrazaForm(this, repositorio, traza), tabPage);
            }

            this.Visible = false;
        }

        private Traza findTraza(int trazaId)
        {
            using (var repositorio = new Repositorio())
            {
                return repositorio.Obtener<Traza>(trazaId);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            using (var repositorio = new Repositorio())
            {
                Traza traza = new Traza();
                this.mainForm.EmbedForm(new CreateTrazaForm(this, traza, repositorio), tabPage);
                this.Visible = false;
            }
        }

        private void ImportarButton_Click(object sender, EventArgs e)
        {
            Traza trazaRecuperada = SharingUtils.Importar();
            if (trazaRecuperada != null)
            {
                using (var repositorio = new Repositorio())
                {
                    //session.Replicate(trazaRecuperada, NHibernate.ReplicationMode.Overwrite);
                    repositorio.Persistir(trazaRecuperada);
                    dibujarRenglones(repositorio);
                }
            }
        }
    }
}
