using System;

namespace SimuRails.Models
{
    public class Formacion
    {

        public int HoraSalida { get; set; }

        public Servicio Servicio { get; set; }

        public Estacion EstacionActual { get; set; }

        public Estacion EstacionDestino { get; set; }

    }
}