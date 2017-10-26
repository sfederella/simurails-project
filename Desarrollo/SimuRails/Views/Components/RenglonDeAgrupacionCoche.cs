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
    public partial class RenglonDeAgrupacionCoche : UserControl
    {
        public delegate void DelAgrupacion(AgrupacionCoche agrupacion);
        private DelAgrupacion handleRemove;

        public AgrupacionCoche Agrupacion{ get; set; }

        public RenglonDeAgrupacionCoche(AgrupacionCoche agrupacion, DelAgrupacion handleRemove)
        {
            InitializeComponent();
            this.Agrupacion = agrupacion;
            this.modeloLbl.Text = agrupacion.Coche.Modelo;
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

        private void modeloLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
