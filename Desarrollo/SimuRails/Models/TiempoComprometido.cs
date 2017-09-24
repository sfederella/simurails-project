using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuRails.Models
{
    public class TiempoComprometido
    {
        private Traza traza;
        private int tiempoFinal;

        public TiempoComprometido(Traza traza, int tiempoFinal)
        {
            this.traza = traza;
            this.tiempoFinal = tiempoFinal;
        }

        public void ejecutarSimulacion()
        {

            int t = 0;

            // A partir del tiempo t, la traza le devuelve la instancia de formacion que tiene el horario de salida mas proximo.
            Formacion formacion = traza.GetProximaFormacion(t);

            t = formacion.HoraSalida;

            while (t < tiempoFinal)
            {
                int tiempoDeLaFormacion = t;

                Servicio servicio = formacion.Servicio;

                Estacion estacionActual = formacion.EstacionActual;

                // Calcular ingreso de pasajeros en estación Cabecera Inicial del recorrido.
                tiempoDeLaFormacion = formacion.inicioRecorrido(t);

                //Calculo Tramo de ida y vuelta
                while (estacionActual != formacion.EstacionDestino)
                {

                    //Obtengo el camino a recorrer hasta la próxima estación.
                    //Debe poder obtener el tramo comprendido entre la estacionActual y la estacionSiguiente 
                    //en el sentido desde estacionActual -> formacion.getEstacionDestino()
                    Tramo tramo = servicio.GetTramo(estacionActual, formacion.EstacionDestino);
                    
                    //Realizo todos los calculos de entre estacion 1 y estacion 2
                    tiempoDeLaFormacion = formacion.arriboEstacion(tramo, tiempoDeLaFormacion);

                }

                tiempoDeLaFormacion = formacion.finRecorrido(tiempoDeLaFormacion);

                // Calcular ingreso de pasajeros en estación Cabecera Final del recorrido.
                // Cambiar el sentido de circulacion de la formacion formacion.invertirSentido();

                formacion = traza.GetProximaFormacion(t);

                t = formacion.HoraSalida;

            }

        }

    }

}