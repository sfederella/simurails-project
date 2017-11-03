using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuRails.Views.Validables
{
    public class Validator<V> : Validable
    {
        private V validado;
        private Regla<V> regla;
        private Label label;

        public Validator(V validado, Regla<V> regla, Label label) 
        {
            this.validado = validado;
            this.regla = regla;
            this.label = label;
        }

        public Validator(V validado, Regla<V> regla, Label label, Control observado) : this(validado, regla, label)
        {
            observado.Leave += this.triggerValidacion;
        }

        public void mostrarError()
        {
            var validez = this.esValido();
            if (!validez)
            {
                label.Text = regla.mensajePara(validado);  
            } 

            label.Visible = !validez;
        }

        public Boolean esValido()
        {
            return regla.esValidaPara(validado);
        }

        private void triggerValidacion(object sender, System.EventArgs e)
        {
            this.mostrarError();
        }
    }
}
