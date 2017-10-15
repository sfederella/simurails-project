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
            InvertirSentidoFlag = false;
        }
        // Persistentes
        public virtual int Id { get; set; }
        public virtual string Nombre { get; set; }
        public virtual Dictionary<Coche, int> TiposCoche { get; set; }
        public virtual int KilometrosMantenimiento { get; set; }
        public virtual int DuracionMantenimiento { get; set; }

        // No persistentes
        public virtual int HoraSalida { get; set; }
        public virtual int Pasajeros { get; set; }
        public virtual Servicio Servicio { get; set; }
        public virtual Estacion EstacionActual { get; set; }
        public virtual Estacion EstacionDestino { get; set; }
        public virtual int KilometrosRecorridos { get; set; }
        public virtual Boolean InvertirSentidoFlag { get; set; }

        private int cantidadAsientos;
        private int capacidadLegal;
        private int capacidadReal;
        private int tiempoIncidentes;

        public virtual IList<ComposicionDeCoches> ComposicionesDeCoches { get; set; }

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
        }

        public virtual int InicioRecorrido(int t)
        {

            int tiempoAtencion = 0;
            int pasajerosAscendidos = 0;
            tiempoIncidentes = 0;

            Tramo tramo = this.Servicio.GetTramo(EstacionActual, SentidoActual);

            foreach (Incidente incidente in tramo.EstacionDestino.GetIncidentes())
            {
                tiempoIncidentes += incidente.TiempoDemora;
            }

            if (this.Pasajeros > 0)
            {
                throw new SystemException("El tren no esta vacio al iniciar el recorrido.");
            }

            pasajerosAscendidos = tramo.EstacionDestino.PasajerosAscendidos(this, t);

            this.Pasajeros = pasajerosAscendidos;

            tiempoAtencion = tramo.EstacionDestino.GetTiempoAtencion(this, pasajerosAscendidos);
                        
            if (this.EstacionActual.GetTiempoComprometido(SentidoActual) < t){
                this.EstacionActual.SetTiempoComprometido(SentidoActual, t + tiempoAtencion);
            }else{
                this.EstacionActual.AddTiempoComprometido(SentidoActual, tiempoAtencion);
            }

            //Se setea el tiempo comprometido de la estacion de la que acaba de salir.
            this.HoraSalida = tramo.EstacionOrigen.SetTiempoComprometido(SentidoActual, t, tiempoIncidentes, tiempoAtencion);

            System.Diagnostics.Debug.WriteLine("########### Formacion : " + this.Nombre + " inició recorrido en estacion: " + tramo.EstacionDestino.Nombre + " ###########");
            System.Diagnostics.Debug.WriteLine("########### Cantidad de pasajeros Ascendidos " + pasajerosAscendidos + ". Pasajeros totales: " + this.Pasajeros + "###########");

            CalcularResultados();

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
            
            foreach  (Incidente incidente in tramo.EstacionDestino.GetIncidentes())
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
                if (this.RequiereMantenimiento() && tramo.EstacionDestino.EsEstacionDeMantenimiento)
                {
                    //Actualizo el destino para que frene en la clase TiempoComprometido .
                    this.EstacionDestino = tramo.EstacionDestino;

                    // Si ya esta en la estacion de mantenimiento no sube nadie y queda ahí                   
                    tiempoAtencion = tramo.EstacionDestino.GetTiempoAtencion(this, this.Pasajeros);

                    //Esto no se que tan copado esta para las estadisticas, tecnicamente bajaron todos, pero xq los obligaron jaja
                    pasajerosDescendidos = this.Pasajeros;

                    this.Pasajeros = 0;

                    //Se setea el tiempo comprometido de la estacion a la que acaba de llegar, y por ser estacion Destino, 
                    // el tren esta disponible para salir a la misma hora que termina el TC en la estacion + lo que dure el mantenimiento
                    this.HoraSalida = tramo.EstacionDestino.SetTiempoComprometido(SentidoActual, t, tiempoDeViaje, tiempoAtencion) + this.DuracionMantenimiento ;

                }
                else {

                    pasajerosAscendidos = tramo.EstacionDestino.PasajerosAscendidos(this, t);

                    tiempoAtencion = tramo.EstacionDestino.GetTiempoAtencion(this, pasajerosAscendidos + pasajerosDescendidos);

                    this.Pasajeros += (pasajerosAscendidos - pasajerosDescendidos);

                    //Se setea el tiempo comprometido de la estacion a la que acaba de llegar.
                    tramo.EstacionDestino.SetTiempoComprometido(SentidoActual, t, tiempoDeViaje, tiempoAtencion);

                }                              
                                
            }
            else {
                pasajerosDescendidos = this.Pasajeros;

                this.Pasajeros = 0;

                tiempoAtencion = tramo.EstacionDestino.GetTiempoAtencion(this, pasajerosDescendidos);

                //Se setea el tiempo comprometido de la estacion a la que acaba de llegar, y por ser estacion Destino, 
                // el tren esta disponible para salir a la misma hora que termina el TC en la estacion
                this.HoraSalida = tramo.EstacionDestino.SetTiempoComprometido(SentidoActual, t, tiempoDeViaje, tiempoAtencion);

                this.InvertirSentidoFlag = true;                

            }
            //Sin importar que, la formacion ya llego a Destino.
            System.Diagnostics.Debug.WriteLine("########### Formacion : "+ this.Nombre + " arribó a estacion: " + tramo.EstacionDestino.Nombre +" ###########");
            System.Diagnostics.Debug.WriteLine("########### Cantidad de pasajeros Ascendidos " + pasajerosAscendidos + ". Cantidad de pasajeros Descendidos: "+ pasajerosDescendidos+". Pasajeros totales: "+this.Pasajeros +"###########");

            this.EstacionActual = tramo.EstacionDestino;

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

        //Ejemplo de lo que es esta clase. Aca saca el total de coches que tiene la formacion por ejemplo
        public virtual int TotalDeCoches()
        {
            return ComposicionesDeCoches.Sum(x => x.VecesRepetido);
        }
                
        public virtual Boolean RequiereMantenimiento()
        {
            return this.KilometrosRecorridos > this.KilometrosMantenimiento;
        }

        public virtual void CalcularResultados()
        {
            ResultadoEstacion rdo = EstacionActual.Resultado;
            rdo.RegistrarNuevaFormacion();

            double porcentajeOcupacion = Pasajeros * 100 / GetCapacidadReal();
            rdo.AgregarPorcentajeOcupacion(porcentajeOcupacion);

            double porcentajePersonasParadas = (Pasajeros - GetCantidadAsientos()) * 100 / Pasajeros;
            rdo.AgregarPorcentajePersonasParadas(porcentajePersonasParadas > 0 ? porcentajePersonasParadas : 0);

            rdo.AgregarPorcentajeSuperaronMaxCantLegal(Pasajeros > GetCapacidadLegal() ? 100 : 0);

            rdo.AgregarPorcentajeRegularidadAbsoluta(tiempoIncidentes > 0 ? 100 : 0);

            rdo.AgregarPorcentajeDemoraPorIncidentes(tiempoIncidentes);
        }

        public int GetCantidadAsientos()
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

        public int GetCapacidadLegal()
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

        public int GetCapacidadReal()
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
    }

}