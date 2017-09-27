using System;
using System.Collections.Generic;

namespace SimuRails.Models
{
    public class Formacion
    {

        public virtual int Id { get; protected set; }
        public virtual string Nombre { get; set; }
        public virtual IList<Coche> Coches { get; set; }

        public virtual int HoraSalida { get; set; }
        public virtual int Pasajeros { get; set; }
        public virtual Servicio Servicio { get; set; }
        public virtual Estacion EstacionActual { get; set; }
        public virtual Estacion EstacionDestino { get; set; }

        public enum Sentido
        {
            IDA,
            VUELTA
        }
        public virtual Sentido SentidoActual { get; set; }

        private bool vacio;

        public Formacion() { }

        public Formacion(Servicio servicio)
        {
            this.vacio = true;
            this.Pasajeros = 0;
            this.EstacionActual = servicio.Desde;
            this.EstacionDestino = servicio.Hasta;
            this.SentidoActual = Sentido.IDA;
            this.Servicio = servicio;
        }

        public int inicioRecorrido(int t)
        {

            int tiempoAtencion = 0;

            int pasajerosAscendidos = 0;

            Tramo tramo = this.Servicio.GetTramo(this.EstacionActual, this.EstacionDestino);

            if (!vacio)
            {
                throw new SystemException("El tren no esta vacio al iniciar el recorrido.");
            }

            pasajerosAscendidos = tramo.EstacionDestino.pasajerosAscendidos(this.EstacionActual, t);

            this.Pasajeros = pasajerosAscendidos;

            this.vacio = false;

            tiempoAtencion = tramo.EstacionDestino.getTiempoAtencion(pasajerosAscendidos);
                        
            if (this.EstacionActual.getTiempoComprometido(SentidoActual) < t){
                this.EstacionActual.setTiempoComprometido(SentidoActual, t + tiempoAtencion);
            }else{
                this.EstacionActual.addTiempoComprometido(SentidoActual, tiempoAtencion);
            }

            return this.EstacionActual.getTiempoComprometido(SentidoActual);
        }

        public int arriboEstacion(Tramo tramo, int t)
        {

            int pasajerosDescendidos = 0;
            int pasajerosAscendidos = 0;
            int distancia = tramo.Distancia;
            int tiempoDeViaje = tramo.TiempoViaje;
            int tiempoAtencion = 0;

            List<Incidente> incidentes = tramo.EstacionDestino.getIncidentes();

            if (incidentes != null)
            {
                // tiempoDeViaje+=incidentes. lamda suma bla bla;

                //for (Incidente incidente : incidentes )

            }

            //Primero se calcula el descenso de pasajeros.
            if (!vacio)
            {
                pasajerosDescendidos = tramo.EstacionDestino.pasajerosDescendidos(this.EstacionActual, t);
            }

            pasajerosAscendidos = tramo.EstacionDestino.pasajerosAscendidos(this.EstacionActual, t);

            tiempoAtencion = tramo.EstacionDestino.getTiempoAtencion(pasajerosAscendidos + pasajerosDescendidos);

            this.Pasajeros += (pasajerosAscendidos - pasajerosDescendidos);

            if (this.EstacionActual.getTiempoComprometido(SentidoActual) < t + tiempoDeViaje){
                this.EstacionActual.setTiempoComprometido(SentidoActual, t + tiempoDeViaje + tiempoAtencion);
            }else{
                this.EstacionActual.addTiempoComprometido(SentidoActual, tiempoAtencion);
            }

            if (tramo.EstacionDestino.Nombre == this.Servicio.Hasta.Nombre)
            {
                this.invertirSentido();
            }

            return tramo.EstacionDestino.getTiempoComprometido(SentidoActual);
        }
        
        public int finRecorrido(int t)
        {

            int tiempoAtencion = 0;

            int pasajerosDescendidos = 0;

            Tramo tramo = this.Servicio.GetTramo(this.EstacionActual, this.EstacionDestino);

            pasajerosDescendidos = this.Pasajeros;

            this.Pasajeros = 0;

            this.vacio = true;

            tiempoAtencion = tramo.EstacionDestino.getTiempoAtencion(pasajerosDescendidos);

            this.EstacionActual.setTiempoComprometido(SentidoActual, t + tiempoAtencion);

            return this.EstacionActual.getTiempoComprometido(SentidoActual);
        }

        public void invertirSentido()
        {
            if (SentidoActual == Sentido.IDA)
            {
                this.EstacionDestino = this.Servicio.Desde;
                this.SentidoActual = Sentido.VUELTA;
            }
            else
            {
                this.EstacionDestino = this.Servicio.Hasta;
                this.SentidoActual = Sentido.VUELTA;
            }
        }
    }

}