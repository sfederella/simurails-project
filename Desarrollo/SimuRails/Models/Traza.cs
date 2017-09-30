using System;
using System.Collections.Generic;

namespace SimuRails.Models
{
    public class Traza
    {
        public Traza() { }
    
        public virtual int Id { get; protected set; }
        public virtual string Nombre { get; set; }
        public virtual HashSet<Servicio> Servicios { get; set; }

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

        //public virtual ICollection<Simulacion> Simulacion { get; set; }
        //public virtual ICollection<Traza_X_Servicio> Traza_X_Servicio { get; set; }
    }
}
