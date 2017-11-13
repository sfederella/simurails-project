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

        public static ReglaConcreta<V> dePresencia(Func<V, Object> extractor)
        {
            return new ReglaConcreta<V>((validado => extractor.Invoke(validado) != null), "Este campo es requerido");
        }

        public static ReglaConcreta<V> dePositivo(Func<V, decimal> extractor)
        {
            return new ReglaConcreta<V>((validado => extractor.Invoke(validado) > 0), "Debe ser mayor a 0");
        }

        public static ReglaConcreta<V> minimoMaximo(Func<V, int> extractorMinimo, Func<V, int> extractorMaximo)
        {
            return new ReglaConcreta<V>(validado => extractorMaximo.Invoke(validado) >= extractorMinimo.Invoke(validado), "La cantidad máxima no puede\nser menor a la mínima");
        }

        public static ReglaConcreta<V> noNegativo(Func<V, decimal> extractor)
        {
            return new ReglaConcreta<V>(validado => extractor.Invoke(validado) >= 0, "Debe ser positivos");
        }

        public static ReglaConcreta<V> noNegativos(Func<V, int> extractorMinimo, Func<V, int> extractorMaximo)
        {
            return new ReglaConcreta<V>(validado => extractorMaximo.Invoke(validado) >= 0 && extractorMinimo.Invoke(validado) >= 0, "Los campos deben ser positivos");
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
