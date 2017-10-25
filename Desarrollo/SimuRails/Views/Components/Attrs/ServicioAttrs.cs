using System;
using System.Windows.Forms;
using SimuRails.Models;
using System.Collections.Generic;
using SimuRails.DB;

namespace SimuRails.Views.Components.Attrs
{
    public partial class ServicioAttrs : UserControl
    {
        private Repositorio repositorioServicios = new Repositorio();
        private Servicio pServicio;
        public ServicioAttrs(Servicio servicio)
        {
            InitializeComponent();
            pServicio = servicio;
            BindingSourceServicio.DataSource = pServicio;
        }

        public bool applyTo(Servicio servicio)
        {
            if (pServicio.Nombre == null || pServicio.Nombre == "") { MessageBox.Show("Se debe completar un nombre que identifique al Servicio."); return false; }
            servicio = pServicio;
            return true;
          }


    }
}
