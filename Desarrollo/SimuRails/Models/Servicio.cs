using System;
using System.Collections.Generic;
using System.Linq;

namespace SimuRails.Models
{
    public class Servicio
    {
        public Servicio() { }

        public virtual int Id { get; protected set; }
        public virtual string Nombre { get; set; }

        public virtual Estacion Desde { get; set; }
        public virtual Estacion Hasta { get; set; }
        public virtual HashSet<Formacion> Formaciones { get; set; }
        public virtual SortedSet<int> Programacion { get; set; }

        public virtual Tramo GetTramo(Estacion estacionActual, Estacion estacionDestino)
        {
            //TODO Implementar
            //throw new NotImplementedException();

            Tramo tramo = new Tramo();

            if (estacionDestino.Nombre == "MORENO")
            {
                if (estacionActual.Nombre == "ONCE")
                {
                    tramo.EstacionOrigen = estacionActual;
                    Estacion liniers = new Estacion();
                    liniers.Nombre = "LINIERS";
                    liniers.PersonasEsperandoMax = 200;
                    liniers.PersonasEsperandoMax = 50;
                    tramo.EstacionDestino = liniers;
                }
                else
                {
                    Estacion liniers = new Estacion();
                    liniers.Nombre = "LINIERS";
                    liniers.PersonasEsperandoMax = 200;
                    liniers.PersonasEsperandoMax = 50;
                    tramo.EstacionOrigen = liniers;
                    tramo.EstacionDestino = estacionDestino;
                }
            }else if (estacionDestino.Nombre =="ONCE")
            {
                if (estacionActual.Nombre == "MORENO")
                {
                    tramo.EstacionOrigen = estacionActual;
                    Estacion liniers = new Estacion();
                    liniers.Nombre = "LINIERS";
                    liniers.PersonasEsperandoMax = 200;
                    liniers.PersonasEsperandoMax = 50;
                    tramo.EstacionDestino = liniers;
                }
                else
                {
                    Estacion liniers = new Estacion();
                    liniers.Nombre = "LINIERS";
                    liniers.PersonasEsperandoMax = 200;
                    liniers.PersonasEsperandoMax = 50;
                    tramo.EstacionOrigen = liniers;
                    tramo.EstacionDestino = estacionDestino;
                }
            }

            return tramo;

        }

        //TODO optimizar para usar una lista con punteros o un array ordenado.
        public virtual Formacion GetProximaFormacion(int t)
        {
            int minHoraSalida = int.MaxValue;
            Formacion formacionMinHoraSalida = null;
            // Obtengo la proxima programación disponible
            int proxSalidaProgramada = Programacion.Where(x => x > t).First();
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