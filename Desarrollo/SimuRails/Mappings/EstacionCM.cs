using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using SimuRails.Models;

namespace SimuRails.Mappings
{
    public class EstacionCM : ClassMapping<Estacion>
    {
        public EstacionCM()
        {
            Id(x => x.Id, m => m.Generator(Generators.Identity));
            Property(x => x.Nombre);
            Property(x => x.PersonasEsperandoMax);
            Property(x => x.PersonasEsperandoMin);
            Property(x => x.TipoFDP);
        }
    }
}
