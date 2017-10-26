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

namespace SimuRails.Views.Components
{
    public partial class RenglonDeAgrupacionFormacion : UserControl
    {
        public RenglonDeAgrupacionFormacion()
        {
            InitializeComponent();
        }

        public delegate void DelAgrupacionFormacion(AgrupacionFormacion agrupacion);
        private DelAgrupacionFormacion handleRemove;

        public AgrupacionFormacion Agrupacion { get; set; }

        public RenglonDeAgrupacionFormacion(AgrupacionFormacion agrupacion, DelAgrupacionFormacion handleRemove)
        {
            InitializeComponent();
            this.Agrupacion = agrupacion;
            this.nombreLbl.Text = agrupacion.Formacion.Nombre;
            this.cantidadLbl.Text = agrupacion.Cantidad.ToString();
            this.handleRemove = handleRemove;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (this.handleRemove != null)
            {
                handleRemove(Agrupacion);
            }
        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void cantidadLbl_Click(object sender, EventArgs e)
        {

        }

        private void nombreLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
