using System;
using System.Collections.Generic;

namespace SimuRails.Models
{
    public class Servicio
    {
        public Estacion Desde { get; set; }

        public HashSet<Formacion> Formaciones { get; set; }

        public Tramo getTramo(Estacion estacionActual, Estacion estacion)
        {
            //TODO Implementar
            throw new NotImplementedException();
        }

        //Todo optimizar para usar una lista con punteros o un array ordenado.
        public Formacion getProximaFormacion(int t)
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