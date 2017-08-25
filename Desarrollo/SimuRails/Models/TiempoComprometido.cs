namespace SimuRails.Models
{
    
    public class TiempoComprometido
    {   
        public Traza Traza{get;set;}
        
        public int TiempoFinal{get;set;}
        
        public void ejecutarSimulacion(){
            
            // A partir del tiempo t, la traza le devuelve la instancia de formacion que tiene el horario de salida mas proximo.
            Formacion formacion = Traza.getProximaFormacion(t);
            
            int t = formacion.getHoraSalida();
            
            while (t < TiempoFinal){
                
                Servicio servicio = formacion.getServicio();
            
                Estacion estacionActual = formacion.getEstacionActual();
                
                // Calcular ingreso de pasajeros en estación Cabecera Inicial del recorrido.
                
                //Calculo Tramo de ida
                while (estacionActual != formacion.getEstacionDestino()){
                    
                    //Obtengo el camino a recorrer hasta la próxima estación.
                    //Debe poder obtener el tramo comprendido entre la estacionActual y la estacionSiguiente 
                    //en el sentido desde estacionActual -> formacion.getEstacionDestino()
                    Tramo relacionActual = servicio.getTramo(estacionActual, formacion.getEstacionDestino());

                    //Busco la siguiente estación en el recorrido.
                    Estacion siguienteEstacion = relacionActual.Estacion1;
                    
                    //Realizo todos los calculos de entre estacion 1 y estacion 2
                    
                    //Actualizo el nodo que será el inicial en la siguiente iteracion.
                    estacionActual = siguienteEstacion;
                }
                
                // Calcular ingreso de pasajeros en estación Cabecera Final del recorrido.
                // Cambiar el sentido de circulacion de la formacion formacion.invertirSentido();
                
                //Calculo Tramo de vuelta
                while (estacionActual != servicio.Desde){
                    
                    //Obtengo el camino a recorrer hasta la próxima estación.
                    //Debe poder obtener el tramo comprendido entre la estacionActual y la estacionSiguiente 
                    //en el sentido desde estacionActual -> formacion.getEstacionDestino()
                    Tramo relacionActual = servicio.getTramo(estacionActual, formacion.getEstacionDestino());

                    //Busco la siguiente estación en el recorrido.
                    Estacion siguienteEstacion = relacionActual.Estacion;
                    
                    //Realizo todos los calculos de entre estacion 1 y estacion 2
                    
                    //Actualizo el nodo que será el inicial en la siguiente iteracion.
                    estacionActual = siguienteEstacion;
                }
                
            }
            
        }
        
    }
}
