using System;
using System.Collections.Generic;

namespace SimuRails.Models
{
    public class Servicio
    {
        public Servicio() { }

        public virtual int Id { get; protected set; }
        public virtual string Nombre { get; set; }

        public virtual Estacion Desde { get; set; }
        public virtual HashSet<Formacion> Formaciones { get; set; }

        public virtual Tramo GetTramo(Estacion estacionActual, Estacion estacion)
        {
            //TODO Implementar
            throw new NotImplementedException();
        }
        //Todo optimizar para usar una lista con punteros o un array ordenado.
        public virtual Formacion GetProximaFormacion(int t)
        {
            int minHoraSalida = int.MaxValue;
            Formacion formacionMinHoraSalida = null;
            foreach (Formacion formacion in Formaciones)
            {
                if (formacion.HoraSalida < minHoraSalida && formacion.HoraSalida > t)
                {
                    formacionMinHoraSalida = formacion;
                }
            }

            return formacionMinHoraSalida;
        }
    }
}