namespace SimuRails.Models
{
    public class Estacion
    {
        public Estacion() { }

        public virtual int Id { get; protected set; }
        public virtual string Nombre { get; set; }
        public virtual int PersonasEsperandoMax { get; set; }
        public virtual int PersonasEsperandoMin { get; set; }
        public virtual string TipoFDP { get; set; } //TODO: Acá no sé de qué tipo es. Quizá se pueda hacer un enum
    }
}