using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuRails.Views.Validables
{
    public class ReglaConcreta<V> : Regla<V>
    {
        private Func<V, Boolean> condicion;
        private string mensaje;

        public static ReglaConcreta<V> dePresencia(Func<V, string> extractor) {
            return new ReglaConcreta<V>((validado => extractor.Invoke(validado) != null && extractor.Invoke(validado) != ""), "Este campo es requerido");
        }

        public static ReglaConcreta<V> dePositivo(Func<V, int> extractor)
        {
            return new ReglaConcreta<V>((validado => extractor.Invoke(validado) > 0), "Este campo debe ser positivo");
        }

            public ReglaConcreta(Func<V, Boolean> condicion, String mensaje) {
            this.condicion = condicion;
            this.mensaje = mensaje;
        }

        public bool esValidaPara(V validado)
        {
            return condicion.Invoke(validado);
        }

        public string mensajePara(V validado)
        {
            if(!this.esValidaPara(validado))
            {
                return this.mensaje;
            }
            return "";
        }
    }
}
