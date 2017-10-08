namespace SimuRails.Models
{
    public class Tramo
    {
        public Estacion EstacionOrigen { get; set; }
        public Estacion EstacionDestino { get; set; }
        public int Distancia { get; set; }
        public int TiempoViaje { get; set; }
    }
}