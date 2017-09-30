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
        public virtual SortedDictionary<int,bool> ProgramacionIda { get; set; }
        public virtual SortedDictionary<int,bool> ProgramacionVuelta { get; set; }

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

        public virtual void MarcarProgramacion(Formacion formacion)
        {
            if (formacion.SentidoActual == Formacion.Sentido.IDA)
            {
                ProgramacionIda[formacion.HoraSalida] = true;
            }
            else if (formacion.SentidoActual == Formacion.Sentido.VUELTA)
            {
                ProgramacionVuelta[formacion.HoraSalida] = true;
            }
        }

        public virtual void LimpiarProgramaciones()
        {
            foreach (KeyValuePair<int,bool> salida in ProgramacionIda)
            {
                ProgramacionIda[salida.Key] = false;
            }
            foreach (KeyValuePair<int, bool> salida in ProgramacionVuelta)
            {
                ProgramacionVuelta[salida.Key] = false;
            }
        }


        public virtual Formacion GetProximaFormacion(int t)
        {
            Formacion formacionMinHoraSalida = null;
            foreach (Formacion formacion in Formaciones)
            {
                if (formacionMinHoraSalida != null)
                {
                    if (formacion.HoraSalida < formacionMinHoraSalida.HoraSalida)
                    {
                        formacionMinHoraSalida = formacion;
                    }
                }
                else
                {
                    formacionMinHoraSalida = formacion;
                }
            }

            int minHoraProgramada = 0;

            // Si ya no hay más programaciones en el día y un tren está disponible para salir, sale.
            if (formacionMinHoraSalida.SentidoActual == Formacion.Sentido.IDA)
            {
                minHoraProgramada = ProgramacionIda.FirstOrDefault(x => !x.Value).Key;
            }
            else if (formacionMinHoraSalida.SentidoActual == Formacion.Sentido.VUELTA)
            {
                minHoraProgramada = ProgramacionVuelta.FirstOrDefault(x => !x.Value).Key;
            }

            if (minHoraProgramada > formacionMinHoraSalida.HoraSalida)
            {
                formacionMinHoraSalida.HoraSalida = minHoraProgramada;
            }

            return formacionMinHoraSalida;
        }
    }
}