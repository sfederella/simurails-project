using System;
using System.Collections.Generic;
using System.Linq;

namespace SimuRails.Models
{
    public class Formacion
    {
        public Formacion()
        {
            ComposicionesDeCoches = new List<ComposicionDeCoches>();
        }

        public virtual int Id { get; protected set; }
        public virtual string Nombre { get; set; }
        public virtual IList<Coche> Coches { get; set; }

        public virtual int HoraSalida { get; set; }
        public virtual int Pasajeros { get; set; }
        public virtual Servicio Servicio { get; set; }
        public virtual Estacion EstacionActual { get; set; }
        public virtual Estacion EstacionDestino { get; set; }

        public virtual IList<ComposicionDeCoches> ComposicionesDeCoches { get; set; }

        public enum Sentido
        {
            IDA,
            VUELTA
        }
        public virtual Sentido SentidoActual { get; set; }

        private bool vacio;


        // TODO esto iniciaría todas las formaciones con sentiodo IDA
        public Formacion(Servicio servicio)
        {
            this.vacio = true;
            this.Pasajeros = 0;
            this.EstacionActual = servicio.Desde;
            this.EstacionDestino = servicio.Hasta;
            this.SentidoActual = Sentido.IDA;
            this.Servicio = servicio;
        }

        public int InicioRecorrido(int t)
        {

            int tiempoAtencion = 0;

            int pasajerosAscendidos = 0;

            Tramo tramo = this.Servicio.GetTramo(EstacionActual, SentidoActual);

            if (!vacio)
            {
                throw new SystemException("El tren no esta vacio al iniciar el recorrido.");
            }

            pasajerosAscendidos = tramo.EstacionDestino.PasajerosAscendidos(this, t);

            this.Pasajeros = pasajerosAscendidos;

            this.vacio = false;

            tiempoAtencion = tramo.EstacionDestino.GetTiempoAtencion(this, pasajerosAscendidos);
                        
            if (this.EstacionActual.GetTiempoComprometido(SentidoActual) < t){
                this.EstacionActual.SetTiempoComprometido(SentidoActual, t + tiempoAtencion);
            }else{
                this.EstacionActual.AddTiempoComprometido(SentidoActual, tiempoAtencion);
            }

            return this.EstacionActual.GetTiempoComprometido(SentidoActual);
        }

        // TODO agregar mantenimiento
        public int ArriboEstacion(Tramo tramo, int t)
        {

            int pasajerosDescendidos = 0;
            int pasajerosAscendidos = 0;
            int distancia = tramo.Distancia;
            int tiempoDeViaje = tramo.TiempoViaje;
            int tiempoAtencion = 0;

            List<Incidente> incidentes = tramo.EstacionDestino.GetIncidentes();

            if (incidentes != null)
            {
                //TODO tiempoDeViaje+=incidentes. lamda suma bla bla;

                //for (Incidente incidente : incidentes )

            }

            //Primero se calcula el descenso de pasajeros.
            if (!vacio)
            {
                pasajerosDescendidos = tramo.EstacionDestino.PasajerosDescendidos(this, t);
            }

            pasajerosAscendidos = tramo.EstacionDestino.PasajerosAscendidos(this, t);

            tiempoAtencion = tramo.EstacionDestino.GetTiempoAtencion(this, pasajerosAscendidos + pasajerosDescendidos);

            this.Pasajeros += (pasajerosAscendidos - pasajerosDescendidos);

            if (this.EstacionActual.GetTiempoComprometido(SentidoActual) < t + tiempoDeViaje){
                this.EstacionActual.SetTiempoComprometido(SentidoActual, t + tiempoDeViaje + tiempoAtencion);
            }else{
                this.EstacionActual.AddTiempoComprometido(SentidoActual, tiempoAtencion);
            }

            if (tramo.EstacionDestino.Nombre == this.Servicio.Hasta.Nombre)
            {
                this.InvertirSentido();
            }
            
            this.EstacionActual = tramo.EstacionDestino;

            return tramo.EstacionDestino.GetTiempoComprometido(SentidoActual);
        }

        public int FinRecorrido(int t)
        {

            int tiempoAtencion = 0;

            int pasajerosDescendidos = 0;

            Tramo tramo = this.Servicio.GetTramo(EstacionActual, SentidoActual);

            pasajerosDescendidos = this.Pasajeros;

            this.Pasajeros = 0;

            this.vacio = true;

            tiempoAtencion = tramo.EstacionDestino.GetTiempoAtencion(this, pasajerosDescendidos);

            this.EstacionActual.SetTiempoComprometido(SentidoActual, t + tiempoAtencion);

            return this.EstacionActual.GetTiempoComprometido(SentidoActual);
        }

        public void InvertirSentido()
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
        }

        //Ejemplo de lo que es esta clase. Aca saca el total de coches que tiene la formacion por ejemplo
        public virtual int TotalDeCoches()
        {
            return ComposicionesDeCoches.Sum(x => x.VecesRepetido);
        }
    }

}