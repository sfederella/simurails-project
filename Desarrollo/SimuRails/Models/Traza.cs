using System;
using System.Collections.Generic;

namespace SimuRails.Models
{
    public class Traza
    {
        public Traza() 
        {
            Servicios = new List<Servicio>();
        }
    
        // Persistentes
        public virtual int Id { get; set; }
        public virtual string Nombre { get; set; }
        public virtual IList<Servicio> Servicios { get; set; }

        public virtual void Inicializar()
        {
            foreach (Servicio servicio in Servicios)
            {
                servicio.Inicializar();
            }


            int i = 1;

            foreach (Servicio servicio in Servicios)
            {
                foreach (Formacion formacion in servicio.Formaciones)
                {
                    formacion.Id = i;
                    i++;
                }
            }
        }

        public virtual Formacion GetProximaFormacion(int t)
        {
            Formacion fMin = null;
            foreach (Servicio servicio in Servicios)
            {
                Formacion formacion = servicio.GetProximaFormacion(t);
                if (fMin != null)
                {
                    if (formacion.HoraPosibleSalida < fMin.HoraPosibleSalida)
                    {
                        fMin = formacion;
                    }
                }
                else
                {
                    fMin = formacion;
                }
            }

            fMin.ActualizarHoraSalida(fMin.HoraPosibleSalida);
            fMin.MarcarProgramacionCorrespondiente();

            return fMin;
        }
    }
}
