using log4net;
using SimuRails.Resources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimuRails.Models
{
    public class Formacion
    {
        private readonly ILog log = LogManager.GetLogger("");

        public Formacion()
        {
            InvertirSentidoFlag = false;
            TiposCoche = new Dictionary<Coche, int>();
        }
        // Persistentes
        public virtual int Id { get; set; }
        public virtual string Nombre { get; set; }
        public virtual IDictionary<Coche, int> TiposCoche { get; set; }
        public virtual int KilometrosMantenimiento { get; set; }
        public virtual int DuracionMantenimiento { get; set; }

        // No persistentes
        public virtual int HoraSalida { get; set; }
        public virtual int HoraPosibleSalida { get; set; }
        public virtual int Pasajeros { get; set; }
        public virtual Servicio Servicio { get; set; }
        public virtual Estacion EstacionActual { get; set; }
        public virtual Estacion EstacionDestino { get; set; }
        public virtual int KilometrosRecorridos { get; set; }
        public virtual Boolean InvertirSentidoFlag { get; set; }
        public virtual int ProgramacionCorrespondiente { get; set; }
        public virtual bool PasoPorMantenimiento { get; set; }
        public virtual bool EstaEnMantenimiento { get; set; }

        private int cantidadAsientos;
        private int capacidadLegal;
        private int capacidadReal;
        private int tiempoIncidentes;

        public enum Sentido
        {
            IDA,
            VUELTA
        }
        public virtual Sentido SentidoActual { get; set; }

        // TODO esto iniciaría todas las formaciones con sentiodo IDA
        public Formacion(Servicio servicio)
        {
            this.Pasajeros = 0;
            this.EstacionActual = servicio.Desde;
            this.EstacionDestino = servicio.Hasta;
            this.SentidoActual = Sentido.IDA;
            this.Servicio = servicio;
            this.PasoPorMantenimiento = false;
            this.EstaEnMantenimiento = false;
        }

        public virtual void ActualizarHoraSalida(int horaSalida)
        {
            Servicio.Formaciones.Remove(this);
            HoraSalida = horaSalida;
            Servicio.Formaciones.Add(this);
        }

        public virtual int InicioRecorrido(int t)
        {
            //TODO : esto no debe ir aca, debe ir en la instanciacion de la formacion
            DuracionMantenimiento = 120;
            KilometrosMantenimiento = 100;

            int tiempoAtencion = 0;
            int pasajerosAscendidos = 0;
            tiempoIncidentes = 0;

            Tramo tramo = this.Servicio.GetTramo(EstacionActual, SentidoActual);

            // En cualquiera de estos dos casos, el tren esta vacio y debe subir gente. La salida del else, 
            // representa que la formacion paso por una estacion de mantenimiento pero no le tocaba
            if (EstacionActual.EsEstacionTerminal || this.EstaEnMantenimiento)
            {
                this.EstaEnMantenimiento = false;

                foreach (Incidente incidente in tramo.EstacionOrigen.GetIncidentes())
                {
                    tiempoIncidentes += incidente.TiempoDemora;
                }

                    pasajerosAscendidos = tramo.EstacionOrigen.PasajerosAscendidos(this, t);
                    this.Pasajeros = pasajerosAscendidos;

                    tiempoAtencion = tramo.EstacionOrigen.GetTiempoAtencion(this, pasajerosAscendidos);

                //Se setea el tiempo comprometido de la estacion de la que acaba de salir.

                tramo.EstacionOrigen.SetTiempoComprometido(SentidoActual, t, tiempoIncidentes, tiempoAtencion);
                this.log.Info("# T: " + LogHelper.TimeConvert(this.EstacionActual.GetTiempoComprometido(SentidoActual), true) + " | Estacion: " + (this.EstacionActual.Nombre + new string(' ', 20)).Substring(0, 20) + " | Ascendidos " + pasajerosAscendidos + " | Descendidos: " + 0 + " | Totales: " + this.Pasajeros);

                CalcularResultados();
            }else
            {
                tramo.EstacionOrigen.SetTiempoComprometido(SentidoActual, t, tiempoIncidentes, tiempoAtencion);
            }

            return this.EstacionActual.GetTiempoComprometido(SentidoActual);
        }

        public virtual int ArriboEstacion(Tramo tramo, int t)
        {
            int pasajerosDescendidos = 0;
            int pasajerosAscendidos = 0;
            int distancia = tramo.Distancia;
            int tiempoDeViaje = tramo.TiempoViaje;
            int tiempoAtencion = 0;
            tiempoIncidentes = 0;

            foreach (Incidente incidente in tramo.EstacionDestino.GetIncidentes())
            {
                tiempoIncidentes += incidente.TiempoDemora;
            }
            tiempoDeViaje += tiempoIncidentes;

            //Primero se calcula el descenso de pasajeros propio de la estacion.
            if (this.Pasajeros > 0)
            {
                pasajerosDescendidos = tramo.EstacionDestino.PasajerosDescendidos(this, t);
            }

            //Esto nos dice si la estacion llego a donde queria llegar
            if (!tramo.EstacionDestino.Equals(this.EstacionDestino))
            {

                if (tramo.EstacionDestino.EsEstacionDeMantenimiento)
                {

                    if (this.RequiereMantenimiento())
                    {
                        //Actualizo el destino para que frene en la clase TiempoComprometido .
                        //this.EstacionDestino = tramo.EstacionDestino;

                        // Si ya esta en la estacion de mantenimiento no sube nadie y queda ahí                   
                        tiempoAtencion = tramo.EstacionDestino.GetTiempoAtencion(this, this.Pasajeros);

                        //Esto no se que tan copado esta para las estadisticas, tecnicamente bajaron todos, pero xq los obligaron jaja
                        pasajerosDescendidos = this.Pasajeros;

                        this.Pasajeros = 0;

                        //Se setea el tiempo comprometido de la estacion a la que acaba de llegar, y por ser estacion Destino, 
                        // el tren esta disponible para salir a la misma hora que termina el TC en la estacion + lo que dure el mantenimiento
                        ActualizarHoraSalida(t + tiempoDeViaje + tiempoAtencion + this.DuracionMantenimiento);

                        this.KilometrosRecorridos = 0;
                        this.EstaEnMantenimiento = true;
                        this.PasoPorMantenimiento = true;
                        this.log.Info("# T: " + LogHelper.TimeConvert(t + tiempoDeViaje + tiempoAtencion, true) + " | Estacion: " + (this.EstacionActual.Nombre + new string(' ', 20)).Substring(0, 20) + " | Entrando a Mantenimiento | Duracion: " + this.DuracionMantenimiento);

                        this.EstacionActual = tramo.EstacionDestino;
                        this.KilometrosRecorridos += distancia;
                        //if (this.InvertirSentidoFlag)
                        this.log.Info("# T: " + LogHelper.TimeConvert(t + tiempoDeViaje + tiempoAtencion, true) + " | Estacion: " + (this.EstacionActual.Nombre + new string(' ', 20)).Substring(0, 20) + " | Ascendidos " + pasajerosAscendidos + " | Descendidos: " + pasajerosDescendidos + " | Totales: " + this.Pasajeros);

                        CalcularResultados();

                        return this.HoraSalida;
                    }

                    this.PasoPorMantenimiento = true;
                }

                pasajerosAscendidos = tramo.EstacionDestino.PasajerosAscendidos(this, t);

                tiempoAtencion = tramo.EstacionDestino.GetTiempoAtencion(this, pasajerosAscendidos + pasajerosDescendidos);

                this.Pasajeros += (pasajerosAscendidos - pasajerosDescendidos);

                if (this.PasoPorMantenimiento)
                {
                    this.EstacionActual = tramo.EstacionDestino;
                    this.KilometrosRecorridos += distancia;
                    ActualizarHoraSalida(t + tiempoDeViaje + tiempoAtencion);
                    this.log.Info("# T: " + LogHelper.TimeConvert(this.HoraSalida, true) + " | Estacion: " + (this.EstacionActual.Nombre + new string(' ', 20)).Substring(0, 20) + " | Ascendidos " + pasajerosAscendidos + " | Descendidos: " + pasajerosDescendidos + " | Totales: " + this.Pasajeros);
                    return t + tiempoDeViaje + tiempoAtencion;
                }
                //Se setea el tiempo comprometido de la estacion a la que acaba de llegar.
                tramo.EstacionDestino.SetTiempoComprometido(SentidoActual, t, tiempoDeViaje, tiempoAtencion);

            }
            else
            {
                pasajerosDescendidos = this.Pasajeros;

                this.Pasajeros = 0;

                tiempoAtencion = tramo.EstacionDestino.GetTiempoAtencion(this, pasajerosDescendidos);

                //Se setea el tiempo comprometido de la estacion a la que acaba de llegar, y por ser estacion Destino, 
                // el tren esta disponible para salir a la misma hora que termina el TC en la estacion
                ActualizarHoraSalida(tramo.EstacionDestino.SetTiempoComprometido(SentidoActual, t, tiempoDeViaje, tiempoAtencion));

                this.InvertirSentidoFlag = true;

            }
            //Sin importar que, la formacion ya llego a Destino.         

            this.EstacionActual = tramo.EstacionDestino;
            this.KilometrosRecorridos += distancia;
            if (this.InvertirSentidoFlag)
            this.log.Info("# T: " + LogHelper.TimeConvert(tramo.EstacionDestino.GetTiempoComprometido(SentidoActual), true) + " | Estacion: " + (this.EstacionActual.Nombre + new string(' ', 20)).Substring(0, 20) + " | Ascendidos " + pasajerosAscendidos + " | Descendidos: " + pasajerosDescendidos + " | Totales: " + this.Pasajeros);

            CalcularResultados();

            return tramo.EstacionDestino.GetTiempoComprometido(SentidoActual);
        }

        public virtual void InvertirSentido()
        {
            if (SentidoActual == Sentido.IDA)
            {
                this.EstacionDestino = this.Servicio.Desde;
                this.SentidoActual = Sentido.VUELTA;
            }
            else
            {
                this.EstacionDestino = this.Servicio.Hasta;
                this.SentidoActual = Sentido.IDA;
            }

            this.InvertirSentidoFlag = false;
        }
                
        public virtual Boolean RequiereMantenimiento()
        {
            return this.KilometrosRecorridos > this.KilometrosMantenimiento;
        }

        public virtual void CalcularResultados()
        {
            ResultadoEstacion rdo;
            if(SentidoActual == Sentido.IDA)
            {
                rdo = EstacionActual.ResultadoIda;
            }
            else
            {
                rdo = EstacionActual.ResultadoVuelta;
            }
            rdo.RegistrarNuevaFormacion();

            double porcentajeOcupacion = Pasajeros * 100 / GetCapacidadReal();
            rdo.AgregarPorcentajeOcupacion(porcentajeOcupacion);

            double porcentajePersonasParadas = Pasajeros > GetCantidadAsientos() ? (Pasajeros - GetCantidadAsientos()) * 100 / Pasajeros : 0;
            rdo.AgregarPorcentajePersonasParadas(porcentajePersonasParadas);

            rdo.AgregarPorcentajeSuperaronMaxCantLegal(Pasajeros > GetCapacidadLegal() ? 100 : 0);

            rdo.AgregarPorcentajeRegularidadAbsoluta(tiempoIncidentes > 0 ? 100 : 0);

            rdo.AgregarPorcentajeDemoraPorIncidentes(tiempoIncidentes);
        }

        public virtual int GetCantidadAsientos()
        {
            if (cantidadAsientos == 0)
            {
                foreach (KeyValuePair<Coche, int> kvp in TiposCoche)
                {
                    for (int i = 0; i < kvp.Value; i++)
                    {
                        cantidadAsientos += kvp.Key.CantidadAsientos;
                    }
                }
            }
            return cantidadAsientos;
        }

        public virtual int GetCapacidadLegal()
        {
            if (capacidadLegal == 0)
            {
                foreach (KeyValuePair<Coche,int> kvp in TiposCoche)
                {
                    for (int i = 0; i < kvp.Value; i++)
                    {
                        capacidadLegal += kvp.Key.MaximoLegalPasajeros;
                    }
                }
            }
            return capacidadLegal;
        }

        public virtual int GetCapacidadReal()
        {
            if (capacidadReal == 0)
            {
                foreach (KeyValuePair<Coche, int> kvp in TiposCoche)
                {
                    for (int i = 0; i < kvp.Value; i++)
                    {
                        capacidadReal += kvp.Key.CapacidadMaximaPasajeros;
                    }
                }
            }
            return capacidadReal;
        }

        public virtual void MarcarProgramacionCorrespondiente()
        {
            if(SentidoActual == Sentido.IDA)
            {
                Servicio.MarcarProgramacion(ProgramacionCorrespondiente, Servicio.ProgramacionIda);
            }
            else
            {
                Servicio.MarcarProgramacion(ProgramacionCorrespondiente, Servicio.ProgramacionVuelta);
            }
        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }

}