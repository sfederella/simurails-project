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
            Formaciones = new SortedSet<Formacion>(new FormacionComparer());
            ProgramacionIda = new SortedDictionary<int, bool>();
            ProgramacionVuelta = new SortedDictionary<int, bool>();
            Tramos = new List<Tramo>();
            TiposFormacion = new Dictionary<Formacion, int>();
        }

        // Persistente
        public virtual int Id { get; set; }
        public virtual string Nombre { get; set; }
        public virtual IDictionary<int, bool> ProgramacionIda { get; set; }
        public virtual IDictionary<int, bool> ProgramacionVuelta { get; set; }
        public virtual IList<Tramo> Tramos { get; set; }
        public virtual IDictionary<Formacion, int> TiposFormacion { get; set; }
        public virtual int CantidadFormacionesInicio { get; set; }

        // No persistente
        public virtual Estacion Desde { get; set; }
        public virtual Estacion Hasta { get; set; }
        public virtual SortedSet<Formacion> Formaciones { get; set; }
        public virtual Int32 AcumDiasIda { get; set; }
        public virtual Int32 AcumDiasVuelta { get; set; }

        public virtual void Inicializar()
        {
            Desde = Tramos[0].EstacionOrigen;
            Desde.EsEstacionTerminal = true;

            Hasta = Tramos[Tramos.Count - 1].EstacionDestino;
            Hasta.EsEstacionTerminal = true;

            int count = 0;
            foreach (KeyValuePair<Formacion, int> kvp in TiposFormacion)
            {
                for (int i = 0; i < kvp.Value; i++)
                {
                    Formacion tipoFormacion = kvp.Key;
                    Formacion formacion = new Formacion()
                    {
                        Id = count,
                        Nombre = tipoFormacion.Nombre,
                        Servicio = this,
                        TiposCoche = tipoFormacion.TiposCoche,
                        HoraSalida = 0
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

        public virtual void MarcarProgramacion(int programacionCorrespondiente, IDictionary<int, bool> programaciones)
        {
            if (programacionCorrespondiente != int.MinValue)
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

        public virtual void LimpiarProgramacion(IDictionary<int, bool> programaciones)
        {
            foreach (int programacion in programaciones.Keys.ToList())
            {
                programaciones[programacion] = false;
            }
        }

        public virtual Formacion GetProximaFormacion(int t)
        {
            Formacion formacionMinHoraSalida = null;
            int minHoraProgramada = int.MinValue;
            int auxHoraProgramada;
            foreach (Formacion formacion in Formaciones)
            {
                if (minHoraProgramada == int.MinValue)
                {
                    formacionMinHoraSalida = formacion;
                    if (formacion.EstacionActual.EsEstacionTerminal)
                    {
                        minHoraProgramada = GetProximaProgramacion(formacion.SentidoActual);
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    if (formacion.HoraSalida < (minHoraProgramada))
                    {
                        if (formacion.EstacionActual.EsEstacionTerminal)
                        {
                            auxHoraProgramada = GetProximaProgramacion(formacion.SentidoActual);

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

                if (formacionMinHoraSalida.HoraSalida > (minHoraProgramada)) break;
            }

            if (formacionMinHoraSalida.EstacionActual.EsEstacionTerminal)
            {
                if ((minHoraProgramada) > formacionMinHoraSalida.HoraSalida)
                {

                    formacionMinHoraSalida.HoraPosibleSalida = minHoraProgramada;
                }
                else
                {
                    formacionMinHoraSalida.HoraPosibleSalida = formacionMinHoraSalida.HoraSalida;
                }

                formacionMinHoraSalida.ProgramacionCorrespondiente = minHoraProgramada % 1440;
            }
            else
            {
                formacionMinHoraSalida.HoraPosibleSalida = formacionMinHoraSalida.HoraSalida;
                formacionMinHoraSalida.ProgramacionCorrespondiente = int.MinValue;
            }

            return formacionMinHoraSalida;
        }

        private int GetProximaProgramacion(Sentido sentido)
        {
            IDictionary<int, bool> programacion = sentido == Sentido.IDA ? ProgramacionIda : ProgramacionVuelta;
            int minHoraProgramada = int.MinValue;

            foreach (KeyValuePair<int, bool> kvp in programacion)
            {
                if (!kvp.Value)
                {
                    minHoraProgramada = kvp.Key;
                    break;
                }
            }

            if (minHoraProgramada == int.MinValue)
            {
                LimpiarProgramacion(programacion);
                minHoraProgramada = programacion.Keys.First();
                if (sentido == Sentido.IDA)
                {
                    AcumDiasIda++;
                }
                else
                {
                    AcumDiasVuelta++;
                }
            }

            return minHoraProgramada + (sentido == Sentido.IDA ? AcumDiasIda : AcumDiasVuelta) * 1440;
        }

    }
}