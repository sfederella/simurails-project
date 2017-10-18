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

        // Persistente
        public virtual int Id { get; set; }
        public virtual string Nombre { get; set; }
        public virtual SortedDictionary<int, bool> ProgramacionIda { get; set; }
        public virtual SortedDictionary<int, bool> ProgramacionVuelta { get; set; }
        public virtual List<Tramo> Tramos { get; set; }
        public virtual Dictionary<Formacion, int> TiposFormacion { get; set; }
        public virtual int CantidadFormacionesInicio { get; set; }

        // No persistente
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

        public virtual void MarcarProgramacion(int programacionCorrespondiente, SortedDictionary<int, bool> programaciones)
        {
            if(programacionCorrespondiente != int.MinValue)
            {
                if (programaciones.ContainsKey(programacionCorrespondiente))
                {
                    programaciones[programacionCorrespondiente] = true;
                }
                else
                {
                    throw new Exception("Programacion Inexistente");
                }
            }
        }

        public virtual void LimpiarProgramacion(SortedDictionary<int, bool> programaciones)
        {
            foreach (KeyValuePair<int,bool> salida in programaciones)
            {
                programaciones[salida.Key] = false;
            }
        }

        public virtual Formacion GetProximaFormacion(int t)
        {

            List<Formacion> formacionesOrdenadas = Formaciones.OrderBy(x => x.HoraSalida).ToList();
            int acumDias = (t / 1440) * 1440;

            Formacion formacionMinHoraSalida = null;
            int minHoraProgramada = int.MinValue;
            int auxHoraProgramada;
            foreach (Formacion formacion in formacionesOrdenadas)
            {
                if (minHoraProgramada == int.MinValue)
                {
                    formacionMinHoraSalida = formacion;
                    if (formacion.EstacionActual.EsEstacionTerminal)
                    {
                        if (formacion.SentidoActual == Formacion.Sentido.IDA)
                        {
                            minHoraProgramada = GetProximaProgramacion(ProgramacionIda);
                        }
                        else
                        {
                            minHoraProgramada = GetProximaProgramacion(ProgramacionVuelta);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    if (formacion.HoraSalida < (minHoraProgramada + acumDias))
                    {
                        if (formacion.EstacionActual.EsEstacionTerminal)
                        {
                            if (formacion.SentidoActual == Formacion.Sentido.IDA)
                            {
                                auxHoraProgramada = GetProximaProgramacion(ProgramacionIda);
                            }
                            else
                            {
                                auxHoraProgramada = GetProximaProgramacion(ProgramacionVuelta);
                            }

                            if (auxHoraProgramada < minHoraProgramada)
                            {
                                minHoraProgramada = auxHoraProgramada;
                                formacionMinHoraSalida = formacion;
                            }
                        }
                        else
                        {
                            minHoraProgramada = int.MinValue;
                            formacionMinHoraSalida = formacion;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }      
                }

                if (formacionMinHoraSalida.HoraSalida > (minHoraProgramada + acumDias)) break;
            }

            if (formacionMinHoraSalida.EstacionActual.EsEstacionTerminal)
            {
                if ((minHoraProgramada + acumDias) > formacionMinHoraSalida.HoraSalida)
                {
                    formacionMinHoraSalida.HoraSalida = minHoraProgramada + acumDias;
                }

                formacionMinHoraSalida.ProgramacionCorrespondiente = (minHoraProgramada < 1440) ? minHoraProgramada : minHoraProgramada - 1440;
            }
            else
            {
                formacionMinHoraSalida.ProgramacionCorrespondiente = int.MinValue;
            }
            
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
