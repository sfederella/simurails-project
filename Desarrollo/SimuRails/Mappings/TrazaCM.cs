using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using SimuRails.Models;

namespace SimuRails.Mappings
{
    public class TrazaCM : ClassMapping<Traza>
    {
        public TrazaCM ()
        {
            Id(x => x.Id, m => m.Generator(Generators.Identity));

            Property(x => x.Nombre);

            Bag(x => x.Servicios, collectionMapping =>
            {
                collectionMapping.Table("ServicioXTraza");
                collectionMapping.Key(k => k.Column("TrazaId"));
                collectionMapping.Cascade(Cascade.Persist);
                collectionMapping.Lazy(CollectionLazy.NoLazy);
            },
            map => map.ManyToMany(c => c.Column("ServicioId")));
        }
    }
}
