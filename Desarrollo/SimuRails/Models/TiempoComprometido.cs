using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuRails.Models
{
    public class TiempoComprometido : IMetodoSimulacion
    {
        private Traza Traza;
        private long TiempoFinal;

        public TiempoComprometido() { }

        public void EjecutarSimulacion(Traza traza, long tiempoFinal)
        {
            Traza = traza;
            TiempoFinal = tiempoFinal;

            // Inicializa la traza configurando y creando los objetos dinámicos que no se traen de la base
            Traza.Inicializar();

            int t = 0;

            // A partir del tiempo t, la traza le devuelve la instancia de formacion que tiene el horario de salida mas proximo.
            Formacion formacion = traza.GetProximaFormacion(t);

            t = formacion.HoraSalida;

            while (t < tiempoFinal)
            {
                int tiempoDeLaFormacion = t;

                Servicio servicio = formacion.Servicio;

                // Calcular ingreso de pasajeros en estación Cabecera Inicial o Final del recorrido.
                tiempoDeLaFormacion = formacion.InicioRecorrido(t);

                //Calculo viaje hasta que llegue a destino, ya sea estacion Final o Mantenimiento.
                while (formacion.EstacionActual != formacion.EstacionDestino)
                {
                    //Obtengo el camino a recorrer hasta la próxima estación.
                    //Debe poder obtener el tramo comprendido entre la estacionActual y la estacionSiguiente 
                    //en el sentido desde estacionActual -> formacion.getEstacionDestino()
                    Tramo tramo = servicio.GetTramo(formacion.EstacionActual, formacion.SentidoActual);
                    
                    //Realizo todos los calculos de entre estacion 1 y estacion 2
                    tiempoDeLaFormacion = formacion.ArriboEstacion(tramo, tiempoDeLaFormacion);

                } 

                // Calcular ingreso de pasajeros en estación Cabecera Final del recorrido.
                // Cambiar el sentido de circulacion de la formacion formacion.invertirSentido();

                formacion = traza.GetProximaFormacion(t);

                t = formacion.HoraSalida;

            }

        }

    }

}