namespace SimuRails.Models
{
    public class Traza
    {
        public Traza() { }
    
        public virtual int Id { get; protected set; }
        public virtual string Nombre { get; set; }
    
        //public virtual ICollection<Simulacion> Simulacion { get; set; }
        //public virtual ICollection<Traza_X_Servicio> Traza_X_Servicio { get; set; }
    }
}
