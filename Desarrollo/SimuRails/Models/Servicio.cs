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

        public virtual int Id { get; set; }
        public virtual string Nombre { get; set; }
        public virtual SortedDictionary<int, bool> ProgramacionIda { get; set; }
        public virtual SortedDictionary<int, bool> ProgramacionVuelta { get; set; }
        public virtual List<Tramo> Tramos { get; set; }
        public virtual Dictionary<Formacion, int> TiposFormacion { get; set; }
        public virtual int CantidadFormacionesInicio { get; set; }

        public virtual Estacion Desde { get; set; }
        public virtual Estacion Hasta { get; set; }

        public virtual IList<Formacion> Formaciones { get; set; }

        public virtual void Inicializar()
        {
            Desde = Tramos[0].EstacionOrigen;
            Hasta = Tramos[Tramos.Count - 1].EstacionDestino;

            int count = 0; 
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

                    if (count < CantidadFormacionesInicio)
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
                    count++;
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

        public virtual void MarcarProgramacion(int programacion,Sentido sentido)
        {
            if (sentido == Formacion.Sentido.IDA)
            {
                if (ProgramacionIda.ContainsKey(programacion))
                {
                    ProgramacionIda[programacion] = true;
                }
                else
                {
                    throw new Exception("Programación Inexistente");
                }
            }
            else
            {
                if (ProgramacionVuelta.ContainsKey(programacion))
                {
                    ProgramacionVuelta[programacion] = true;
                }
                else
                {
                    throw new Exception("Programación Inexistente");
                }
            }
        }

        public virtual void LimpiarProgramacion(SortedDictionary<int, bool> Programacion)
        {
            foreach (KeyValuePair<int,bool> salida in Programacion)
            {
                Programacion[salida.Key] = false;
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

            int minHoraProgramada;
            if (formacionMinHoraSalida.SentidoActual == Formacion.Sentido.IDA)
            {
                minHoraProgramada = GetProximaProgramacion(ProgramacionIda);
            }
            else
            {
                minHoraProgramada = GetProximaProgramacion(ProgramacionVuelta);
            }

            int acumDias = (t / 1440) * 1440;
            if ((minHoraProgramada + acumDias) > formacionMinHoraSalida.HoraSalida)
            {
                formacionMinHoraSalida.HoraSalida = minHoraProgramada + acumDias;
            }

            formacionMinHoraSalida.ProgramacionCorrespondiente = (minHoraProgramada < 1440) ? minHoraProgramada : minHoraProgramada - 1440;

            return formacionMinHoraSalida;
        }

        private int GetProximaProgramacion(SortedDictionary<int, bool> Programacion)
        {
            int minHoraProgramada = int.MinValue;

            foreach (KeyValuePair<int, bool> kvp in Programacion)
            {
                if (!kvp.Value)
                {
                    minHoraProgramada = kvp.Key;
                    break;
                }
            }

            if (minHoraProgramada == int.MinValue)
            {
                LimpiarProgramacion(Programacion);
                minHoraProgramada = Programacion.Keys.First() + 1440;
            }

            return minHoraProgramada;
        }

    }
}
