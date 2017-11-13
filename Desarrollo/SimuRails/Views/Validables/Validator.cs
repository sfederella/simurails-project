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
        public virtual V Validado { get; set; }
        private Regla<V> regla;
        private Label label;

        public Validator(V validado, Regla<V> regla, Label label) 
        {
            this.Validado = validado;
            this.regla = regla;
            this.label = label;
        }

        public Validator(V validado, Regla<V> regla, Label label, Control observado) : this(validado, regla, label)
        {
            observado.Leave += this.triggerValidacion;
        }

        public Validator(V validado, Regla<V> regla, Label label, BindingSource observado) : this(validado, regla, label)
        {
            observado.BindingComplete += this.triggerValidacion;
        }

        public void mostrarError()
        {
            var validez = this.esValido();
            if (!validez)
            {
                label.Text = regla.mensajePara(Validado);  
            } 

            label.Visible = !validez;
        }

        public Boolean esValido()
        {
            return regla.esValidaPara(Validado);
        }

        private void triggerValidacion(object sender, System.EventArgs e)
        {
            this.mostrarError();
        }
    }
}
