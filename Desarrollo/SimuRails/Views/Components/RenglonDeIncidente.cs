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
    public partial class RenglonDeIncidente : UserControl
    {
        private int id;
        public delegate void Del(int id);
        private Del handleEdit;
        private Del handleRemove;

        public int Id { get; set; }

        public RenglonDeIncidente(Incidente incidente, Del handleEdit, Del handleRemove)
        {
            InitializeComponent();
            this.nombreLbl.Text = incidente.Nombre;
            this.probabilidadLbl.Text = incidente.ProbabilidadDeOcurrencia.ToString();
            this.demoraLbl.Text = incidente.TiempoDemora.ToString();
            this.id = incidente.Id;
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

        private void capacidadTotalLbl_Click(object sender, EventArgs e)
        {

        }

        private void capacidadLegalLbl_Click(object sender, EventArgs e)
        {

        }

        private void modeloLbl_Click(object sender, EventArgs e)
        {

        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }
    }
}
