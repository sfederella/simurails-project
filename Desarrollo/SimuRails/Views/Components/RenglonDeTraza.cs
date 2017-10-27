using System;
using System.Windows.Forms;
using SimuRails.Models;

namespace SimuRails.Views.Components
{
    public partial class RenglonDeTraza : UserControl
    {
        private int id;
        public delegate void Del(int id);
        private Del handleEdit;
        private Del handleRemove;
        private Del handleExport;

        public int Id { get; set; }

        public RenglonDeTraza(Traza traza, Del handleEdit, Del handleRemove, Del handleExport)
        {
            InitializeComponent();
            this.nombreLbl.Text = traza.Nombre;
            this.cantServiciosLbl.Text = traza.Servicios.Count.ToString();
            this.id = traza.Id;
            this.handleEdit = handleEdit;
            this.handleRemove = handleRemove;
            this.handleExport = handleExport;
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

        private void exportarButton_Click(object sender, EventArgs e)
        {
            if (this.handleExport != null)
            {
                handleExport(id);
            }
        }
    }
}
