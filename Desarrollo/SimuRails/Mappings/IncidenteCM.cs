using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using SimuRails.Models;

namespace SimuRails.Mappings
{
    public class IncidenteCM : ClassMapping<Incidente>
    {
        public IncidenteCM()
        {
            Id(x => x.Id, m => m.Generator(Generators.Identity));
            Property(x => x.Nombre);
            Property(x => x.Descripcion);
            Property(x => x.ProbabilidadDeOcurrencia);
            Property(x => x.TiempoDemora);
        }
    }
}
