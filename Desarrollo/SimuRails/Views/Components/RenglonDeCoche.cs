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
    public partial class RenglonDeCoche : UserControl
    {
        private int id;
        public delegate void Del(int id);
        private Del handleEdit;
        private Del handleRemove;

        public int Id { get; set; }

        public RenglonDeCoche(Coche coche, Del handleEdit, Del handleRemove)
        {
            InitializeComponent();
            this.modeloLbl.Text = coche.Modelo;
            this.capacidadLegalLbl.Text = coche.MaximoLegalPasajeros.ToString();
            this.capacidadTotalLbl.Text = coche.CapacidadMaximaPasajeros.ToString();
            this.id = coche.Id;
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
    }
}
