using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuRails.Views.Validables
{
    public class ReglaCompuesta<V> : Regla<V>
    {
        private List<Regla<V>> subReglas = new List<Regla<V>>();

        public static ReglaCompuesta<V> minimoMaximoNoNegativos(Func<V, int> extractorMinimo, Func<V, int> extractorMaximo)
        {
            return new ReglaCompuesta<V>(new List<Regla<V>>
            {
                ReglaConcreta<V>.noNegativos(extractorMinimo, extractorMaximo),
                ReglaConcreta<V>.minimoMaximo(extractorMinimo, extractorMaximo)
            });
        }

        public ReglaCompuesta(List<Regla<V>> subReglas)
        {
            this.subReglas = subReglas;
        }

        public bool esValidaPara(V validado)
        {
            return subReglas.TrueForAll(subRegla => subRegla.esValidaPara(validado));
        }

        public string mensajePara(V validado)
        {
            Regla<V> reglaNoCumple = subReglas.Find(subRegla => !subRegla.esValidaPara(validado));
            if(reglaNoCumple != null)
            {
                return reglaNoCumple.mensajePara(validado);
            }
            return "";
        }
    }
}
