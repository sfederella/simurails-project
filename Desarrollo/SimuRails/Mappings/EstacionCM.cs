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

            Bag(x => x.Incidentes, collectionMapping =>
            {
                collectionMapping.Table("EstacionesXIncidentes");
                collectionMapping.Key(k => k.Column("EstacionId"));
                collectionMapping.Cascade(Cascade.None);
                collectionMapping.Inverse(true);
            },
            map => map.ManyToMany(c => c.Column("IncidenteId")));

            /*Bag(x => x.Relaciones, collectionMapping =>
            {
                collectionMapping.Table("Relacion");
                collectionMapping.Cascade(Cascade.None);
                collectionMapping.Key(k => k.Column("EstacionId"));
            },
            map => map.OneToMany());*/
        }
    }
}
