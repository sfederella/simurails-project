using SimuRails.Models;
using SimuRails.Views.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuRails.Views
{
    public partial class ServiciosListForm : Form
    {
        public ServiciosListForm()
        {
            InitializeComponent();
        }

        private void ServiciosListForm_Load(object sender, EventArgs e)
        {
            List<Servicio> servicios = new List<Servicio>();
            var servicio1 = new Servicio();
            servicio1.Nombre = "Sarmiento";
            servicio1.Desde = new Estacion() { Nombre = "Once" };
            servicio1.Hasta = new Estacion() { Nombre = "Moreno" };
            servicios.Add(servicio1);
            var servicio2 = new Servicio();
            servicio2.Nombre = "Urquiza";
            servicio2.Desde = new Estacion() { Nombre = "Lacroze" };
            servicio2.Hasta = new Estacion() { Nombre = "Lemos" };
            servicios.Add(servicio2);
            var servicio3 = new Servicio();
            servicio3.Nombre = "Mitre";
            servicio3.Desde = new Estacion() { Nombre = "Retiro" };
            servicio3.Hasta = new Estacion() { Nombre = "Tigre" };
            servicios.Add(servicio3);

            for (int i = 0; i < servicios.Count; i++)
            {
                var renglon = this.renglonDe(servicios.ElementAt(i), i);

            }


        }

        private RenglonDeServicio renglonDe(Servicio servicio, Int32 indice)
        {
            var renglon = new RenglonDeServicio(servicio);
            renglon.Location = new System.Drawing.Point(5, 25 + indice * 48);
            renglon.Width = this.listPanel.Width;
            renglon.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            this.listPanel.Controls.Add(renglon);
            return renglon;
        }
        
    }
}
