using System;
using System.Collections.Generic;
using System.Linq;
using static SimuRails.Models.Formacion;

namespace SimuRails.Models
{
    public class Servicio
    {
        public Servicio()
        {
            Formaciones = new List<Formacion>();
        }

        public virtual int Id { get; protected set; }
        public virtual string Nombre { get; set; }
        public virtual SortedDictionary<int, bool> ProgramacionIda { get; set; }
        public virtual SortedDictionary<int, bool> ProgramacionVuelta { get; set; }
        public virtual List<Tramo> Tramos { get; set; }
        public virtual Dictionary<Formacion, int> TiposFormacion { get; set; }
        public virtual int PorcentajeFormacionesInicio { get; set; }

        public virtual Estacion Desde { get; set; }
        public virtual Estacion Hasta { get; set; }

        public virtual IList<Formacion> Formaciones { get; set; }

        public void Inicializar()
        {
            Desde = Tramos[0].EstacionOrigen;
            Hasta = Tramos[Tramos.Count - 1].EstacionDestino;
            foreach (KeyValuePair<Formacion,int> kvp in TiposFormacion)
            {
                for (int i = 0; i < kvp.Value; i++)
                {
                    Formacion tipoFormacion = kvp.Key;
                    Formacion formacion = new Formacion()
                    {
                        Nombre = tipoFormacion.Nombre,
                        Servicio = this,
                        TiposCoche = tipoFormacion.TiposCoche
                    };

                    int r = FDP.Rand(0, 100);
                    if (r < PorcentajeFormacionesInicio)
                    {
                        formacion.SentidoActual = Sentido.IDA;
                        formacion.EstacionActual = Desde;
                        formacion.EstacionDestino = Hasta;
                    } 
                    else
                    {
                        formacion.SentidoActual = Sentido.VUELTA;
                        formacion.EstacionActual = Hasta;
                        formacion.EstacionDestino = Desde;
                    }
                    Formaciones.Add(formacion);
                }
            }
            
        }

        public virtual Tramo GetTramo(Estacion estacionActual, Sentido sentido)
        {
            Tramo proximoTramo;
            if (sentido == Sentido.IDA)
            {
                proximoTramo = Tramos.First(x => x.EstacionOrigen == estacionActual);
            }
            else
            {
                proximoTramo = Tramos.First(x => x.EstacionDestino == estacionActual);
                Tramo tramoInvertido = new Tramo
                {
                    Distancia = proximoTramo.Distancia,
                    TiempoViaje = proximoTramo.TiempoViaje,
                    EstacionOrigen = proximoTramo.EstacionDestino,
                    EstacionDestino = proximoTramo.EstacionOrigen
                };
                proximoTramo = tramoInvertido;
            }
            return proximoTramo;
        }

        public virtual void MarcarProgramacion(Formacion formacion)
        {
            if (formacion.SentidoActual == Formacion.Sentido.IDA)
            {
                ProgramacionIda[formacion.HoraSalida] = true;
            }
            else
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
            else
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
