namespace SimuRails.Models
{
    public class Tramo
    {
        public Estacion EstacionOrigen { get; internal set; }
        public Estacion EstacionDestino { get; internal set; }
        public int Distancia { get; internal set; }
        public int TiempoViaje { get; internal set; }
    }
}