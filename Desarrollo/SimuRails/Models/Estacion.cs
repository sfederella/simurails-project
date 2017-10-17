using System;
using System.Collections.Generic;
using System.Linq;
using static SimuRails.Models.Formacion;

namespace SimuRails.Models
{
    public class Estacion
    {
        public Estacion()
        {
            this.TiempoComprometidoSentidoVuelta = 0;
            this.TiempoComprometidoSentidoIda = 0;
            this.Resultado = new ResultadoEstacion();
        }

        public virtual int Id { get; set; }
        public virtual string Nombre { get; set; }
        public virtual bool EsEstacionDeMantenimiento { get; set; }
        public virtual IList<Incidente> Incidentes { get; set; }

        public virtual int PersonasEsperandoMaxIda { get; set; }
        public virtual int PersonasEsperandoMinIda { get; set; }
        public virtual int PersonasDesciendenMaxIda { get; set; }
        public virtual int PersonasDesciendenMinIda { get; set; }

        public virtual int PersonasEsperandoMaxVuelta { get; set; }
        public virtual int PersonasEsperandoMinVuelta { get; set; }
        public virtual int PersonasDesciendenMaxVuelta { get; set; }
        public virtual int PersonasDesciendenMinVuelta { get; set; }

        public virtual int TiempoComprometidoSentidoIda { get; set; }
        public virtual int TiempoComprometidoSentidoVuelta { get; set; }
        public virtual ResultadoEstacion Resultado { get; set; }
        public virtual bool EsEstacionTerminal { get; set; }

        public virtual int PasajerosAscendidos(Formacion formacion, int t)
        {
            if(formacion.SentidoActual == Sentido.IDA)
            {
                return FDP.Normal(PersonasEsperandoMinIda, PersonasEsperandoMaxIda);
            } 
            else
            {
                return FDP.Normal(PersonasEsperandoMinVuelta, PersonasEsperandoMaxVuelta);
            }
        }

        public virtual int PasajerosDescendidos(Formacion formacion, int t)
        {
            int pasajerosDescendidos;
            if (formacion.SentidoActual == Sentido.IDA)
            {
                pasajerosDescendidos = FDP.Normal(PersonasDesciendenMinIda, PersonasDesciendenMaxIda);
            }
            else
            {
                pasajerosDescendidos = FDP.Normal(PersonasDesciendenMinVuelta, PersonasDesciendenMaxVuelta);
            }
            if (pasajerosDescendidos > formacion.Pasajeros)
            {
                pasajerosDescendidos = formacion.Pasajeros;
            }
            return pasajerosDescendidos;
        }

        public virtual int GetTiempoAtencion(Formacion formacion, int cantidadDePersonas)
        {
            // Parámetros en segundos. Retorna minutos.
            int tiempoPorPersona = 4;
            int cantPersonasXPuerta = 2;
            int cantVagones = formacion.TiposCoche.Values.Sum();

            int cantPuertasXVagon = 3;
            int tiempoAtencionMinimo = 10;
            return ( (cantidadDePersonas * tiempoPorPersona) / (cantPersonasXPuerta * cantPuertasXVagon * cantVagones) 
                        + tiempoAtencionMinimo) / 60;
        }

        //Debe devolver una lista con incidentes. en casa de que no se produzcan, una lista vacía.
        public virtual List<Incidente> GetIncidentes()
        {
            List<Incidente> lista = new List<Incidente>();

            if (this.Incidentes == null) return lista;

            foreach(Incidente incidente in this.Incidentes)
            {
                if (incidente.ProbabilidadDeOcurrencia >= new Random().NextDouble() * (100 - 0) + 0)
                {
                    lista.Add(incidente);
                }
            }

            return lista;
        }

        public virtual int GetTiempoComprometido(Sentido sentido)
        {
            return sentido == Formacion.Sentido.IDA ? TiempoComprometidoSentidoIda : TiempoComprometidoSentidoVuelta;
        }

        public virtual int SetTiempoComprometido(Sentido sentido, int t, int tiempoDeViaje, int tiempoAtencion)
        {
            if (this.GetTiempoComprometido(sentido) < t + tiempoDeViaje)
            {
                this.SetTiempoComprometido(sentido, t + tiempoDeViaje + tiempoAtencion);
                return t + tiempoDeViaje + tiempoAtencion;
            }
            else
            {
                this.AddTiempoComprometido(sentido, tiempoAtencion);
                return this.GetTiempoComprometido(sentido);
            }
        }

        public virtual void SetTiempoComprometido(Sentido sentido, int tiempoComprometido)
        {
            if (sentido == Formacion.Sentido.IDA)
            {
                TiempoComprometidoSentidoIda = tiempoComprometido;
            }
            else
            {
                TiempoComprometidoSentidoVuelta = tiempoComprometido;
            }
        }

        public virtual void AddTiempoComprometido(Sentido sentido, int tiempoComprometido)
        {
            if (sentido == Formacion.Sentido.IDA)
            {
                TiempoComprometidoSentidoIda += tiempoComprometido;
            }
            else
            {
                TiempoComprometidoSentidoVuelta += tiempoComprometido;
            }
        }

        public virtual bool Equals(Estacion estacion)
        {
            //return Nombre.Equals(estacion.Nombre);
            return Id == estacion.Id;
        }

    }
}