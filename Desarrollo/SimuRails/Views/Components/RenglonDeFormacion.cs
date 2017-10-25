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
    public partial class RenglonDeFormacion : UserControl
    {
        private int id;
        public delegate void Del(int id);
        private Del handleEdit;
        private Del handleRemove;

        public RenglonDeFormacion()
        {
            InitializeComponent();
        }

        public int Id { get; set; }

        public RenglonDeFormacion(Formacion formacion, Del handleEdit, Del handleRemove)
        {
            InitializeComponent();
            this.nombreLbl.Text = formacion.Nombre;
            this.mantenimientoEntreLbl.Text = formacion.KilometrosMantenimiento.ToString() + " Km";
            this.duracionMantenimientoLbl.Text = formacion.DuracionMantenimiento.ToString() + " Min";
            this.id = formacion.Id;
            this.handleEdit = handleEdit;
            this.handleRemove = handleRemove;
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if (this.handleEdit != null)
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
    }
}
