using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuRails.Models
{
    public class TiempoComprometido
    {
        private Traza Traza { get; set; }

        private int TiempoFinal { get; set; }

        public TiempoComprometido(Traza traza, int tiempoFinal)
        {
            this.Traza = traza;
            this.TiempoFinal = tiempoFinal;
        }

        public void ejecutarSimulacion()
        {

            int t = 0;

            // A partir del tiempo t, la traza le devuelve la instancia de formacion que tiene el horario de salida mas proximo.
            Formacion formacion = Traza.getProximaFormacion(t);

            t = formacion.HoraSalida;

            while (t < TiempoFinal)
            {

                Servicio servicio = formacion.Servicio;

                Estacion estacionActual = formacion.EstacionActual;

                // Calcular ingreso de pasajeros en estación Cabecera Inicial del recorrido.

                //Calculo Tramo de ida
                while (estacionActual != formacion.EstacionDestino)
                {

                    //Obtengo el camino a recorrer hasta la próxima estación.
                    //Debe poder obtener el tramo comprendido entre la estacionActual y la estacionSiguiente 
                    //en el sentido desde estacionActual -> formacion.getEstacionDestino()
                    Tramo relacionActual = servicio.GetTramo(estacionActual, formacion.EstacionDestino);

                    //Busco la siguiente estación en el recorrido.
                    Estacion siguienteEstacion = relacionActual.Estacion1;

                    //Realizo todos los calculos de entre estacion 1 y estacion 2

                    //Actualizo el nodo que será el inicial en la siguiente iteracion.
                    estacionActual = siguienteEstacion;
                }

                // Calcular ingreso de pasajeros en estación Cabecera Final del recorrido.
                // Cambiar el sentido de circulacion de la formacion formacion.invertirSentido();

                //Calculo Tramo de vuelta
                while (estacionActual != servicio.Desde)
                {

                    //Obtengo el camino a recorrer hasta la próxima estación.
                    //Debe poder obtener el tramo comprendido entre la estacionActual y la estacionSiguiente 
                    //en el sentido desde estacionActual -> formacion.getEstacionDestino()
                    Tramo relacionActual = servicio.GetTramo(estacionActual, formacion.EstacionDestino);

                    //Busco la siguiente estación en el recorrido.
                    Estacion siguienteEstacion = relacionActual.Estacion;

                    //Realizo todos los calculos de entre estacion 1 y estacion 2

                    //Actualizo el nodo que será el inicial en la siguiente iteracion.
                    estacionActual = siguienteEstacion;
                }

                formacion = Traza.getProximaFormacion(t);

                t = formacion.HoraSalida;

            }

        }

    }
}