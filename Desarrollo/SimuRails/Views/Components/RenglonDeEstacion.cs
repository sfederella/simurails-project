using System;
using System.Windows.Forms;
using SimuRails.Models;

namespace SimuRails.Views.Components
{
    public partial class RenglonDeEstacion  : UserControl
    {
        private int id;
        public delegate void Del(int id);
        private Del handleEdit;
        private Del handleRemove;

        public int Id { get; set; }

        public RenglonDeEstacion(Estacion estacion, Del handleEdit, Del handleRemove)
        {
            InitializeComponent();
            this.nombreLbl.Text = estacion.Nombre;
            if (estacion.EsEstacionDeMantenimiento){this.EsMantenimientoLbl.Text = "Si";} else { this.EsMantenimientoLbl.Text = "No"; }
            this.id = estacion.Id;
            this.handleEdit = handleEdit;
            this.handleRemove = handleRemove;
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if(this.handleEdit != null)
            {
                handleEdit(id);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (this.handleRemove != null)
            {
                handleRemove(id);
            }
        }

        private void EsMantenimientoLbl_Click(object sender, EventArgs e)
        {

        }

        private void nombreLbl_Click(object sender, EventArgs e)
        {

        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }
    }
}
