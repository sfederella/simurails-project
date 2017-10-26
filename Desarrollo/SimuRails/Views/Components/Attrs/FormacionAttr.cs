using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimuRails.Models;
using SimuRails.DB;
using NHibernate.Linq;

namespace SimuRails.Views.Components.Attrs
{
    public partial class FormacionAttr : UserControl
    {
        private void FormacionAttr_Load(object sender, EventArgs e)
        {

        }

        private Formacion pFormacion;
        private AgrupacionCoche pCocheEditando = new AgrupacionCoche();
        private List<AgrupacionCoche> cochesListados = new List<AgrupacionCoche>();
        public FormacionAttr(Formacion formacion)
        {
            InitializeComponent();
            pFormacion = formacion;
            cochesListados = AgrupacionCoche.From(formacion.TiposCoche);
            var modelos = listaDeModelos();
            modeloCbo.Items.AddRange(modelos.ToArray());
            bindingSourceFormacion.DataSource = pFormacion;
            bindingSourceCocheEditando.DataSource = pCocheEditando;
            this.dibujarListado();
        }

        private void dibujarListado()
        {
            List<Control> renglones = this.cochesListados.Select(agrupacionCoche => this.renglonDe(agrupacionCoche)).ToList();
            this.listadoCoches.setearRenglones(renglones);
        }

        private Control renglonDe(AgrupacionCoche agrupacionCoche)
        {
            return new RenglonDeAgrupacionCoche(agrupacionCoche, this.onCocheRemove);
        }

        private void onCocheRemove(AgrupacionCoche agrupacion)
        {
            this.cochesListados.Remove(agrupacion);
            this.dibujarListado();
        }

        private List<Coche> listaDeModelos()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return session.Query<Coche>().ToList();
            }
        }

        public bool applyTo(Formacion formacion)
        {
            this.pFormacion.TiposCoche = AgrupacionCoche.ToDictionary(cochesListados);
            return true;
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            cochesListados.Add(pCocheEditando);
            this.listadoCoches.agregarRenglon(this.renglonDe(pCocheEditando));
            pCocheEditando = new AgrupacionCoche();
            bindingSourceCocheEditando.DataSource = pCocheEditando;
            modeloCbo.SelectedItem = null;
        }
    }
}
