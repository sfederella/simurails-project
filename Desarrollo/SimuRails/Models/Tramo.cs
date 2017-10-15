namespace SimuRails.Models
{
    public class Tramo
    {
        public virtual int Id { get; set; }
        public virtual Estacion EstacionOrigen { get; set; }
        public virtual Estacion EstacionDestino { get; set; }
        public virtual int Distancia { get; set; }
        public virtual int TiempoViaje { get; set; }
    }
}