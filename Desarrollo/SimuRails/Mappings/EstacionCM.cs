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
            Property(x => x.EsEstacionDeMantenimiento);
            Property(x => x.PersonasEsperandoMaxIda);
            Property(x => x.PersonasEsperandoMaxVuelta);
            Property(x => x.PersonasEsperandoMinIda);
            Property(x => x.PersonasEsperandoMinVuelta);
            Property(x => x.PersonasDesciendenMaxIda);
            Property(x => x.PersonasDesciendenMaxVuelta);
            Property(x => x.PersonasDesciendenMinIda);
            Property(x => x.PersonasDesciendenMinVuelta);

            Bag(x => x.Incidentes, collectionMapping =>
            {
                collectionMapping.Table("EstacionesXIncidentes");
                collectionMapping.Key(k => k.Column("EstacionId"));
                collectionMapping.Cascade(Cascade.None);
                collectionMapping.Inverse(true);
            },
            map => map.ManyToMany(c => c.Column("IncidenteId")));
        }
    }
}
