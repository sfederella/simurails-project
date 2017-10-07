using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuRails.Models
{
    public class TiempoComprometido : IMetodoSimulacion
    {
        private Traza traza;
        private long tiempoFinal;

        public TiempoComprometido(Traza traza, long tiempoFinal)
        {
            this.traza = traza;
            this.tiempoFinal = tiempoFinal;
        }

        public void EjecutarSimulacion()
        {

            int t = 0;

            // A partir del tiempo t, la traza le devuelve la instancia de formacion que tiene el horario de salida mas proximo.
            Formacion formacion = traza.GetProximaFormacion(t);

            t = formacion.HoraSalida;

            while (t < tiempoFinal)
            {
                int tiempoDeLaFormacion = t;

                Servicio servicio = formacion.Servicio;

                // Calcular ingreso de pasajeros en estación Cabecera Inicial del recorrido.
                tiempoDeLaFormacion = formacion.InicioRecorrido(t);

                //Calculo Tramo de ida y vuelta
                while (formacion.EstacionActual != formacion.EstacionDestino)
                {
                    // TODO nunca se actualiza la estacion actual?

                    //Obtengo el camino a recorrer hasta la próxima estación.
                    //Debe poder obtener el tramo comprendido entre la estacionActual y la estacionSiguiente 
                    //en el sentido desde estacionActual -> formacion.getEstacionDestino()
                    Tramo tramo = servicio.GetTramo(formacion.EstacionActual, formacion.SentidoActual);
                    
                    //Realizo todos los calculos de entre estacion 1 y estacion 2
                    tiempoDeLaFormacion = formacion.ArriboEstacion(tramo, tiempoDeLaFormacion);

                } 

                // TODO Meter adentro de ArriboEstacion 
                tiempoDeLaFormacion = formacion.FinRecorrido(tiempoDeLaFormacion);

                // Calcular ingreso de pasajeros en estación Cabecera Final del recorrido.
                // Cambiar el sentido de circulacion de la formacion formacion.invertirSentido();

                formacion = traza.GetProximaFormacion(t);

                t = formacion.HoraSalida;

            }

        }

    }

}