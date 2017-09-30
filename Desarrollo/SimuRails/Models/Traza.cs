using System;
using System.Collections.Generic;

namespace SimuRails.Models
{
    public class Traza
    {
        public Traza() 
        {
            Servicios = new List<Servicio>();
            Simulaciones = new List<Simulacion>();
        }
    
        public virtual int Id { get; protected set; }
        public virtual string Nombre { get; set; }

        public virtual IList<Servicio> Servicios { get; set; } //Ahora mapeo todas las relaciones como BAG (no lista en realidad) Si se necesita, se mapea distinto (es mas complejo)
        public virtual IList<Simulacion> Simulaciones { get; set; }

        //Todo optimizar para usar una lista con punteros o un array ordenado.
        public virtual Formacion GetProximaFormacion(int t)
        {
            Formacion formacionMinHoraSalida = null;
            foreach (Servicio servicio in Servicios)
            {
                Formacion formacion = servicio.GetProximaFormacion(t);
                if (formacionMinHoraSalida != null)
                {
                    if (formacion.HoraSalida < formacionMinHoraSalida.HoraSalida)
                    {
                        formacionMinHoraSalida = formacion;
                    }
                } else
                {
                    formacionMinHoraSalida = formacion;
                }
            }

            formacionMinHoraSalida.Servicio.MarcarProgramacion(formacionMinHoraSalida);

            return formacionMinHoraSalida;
        }
    }
}
