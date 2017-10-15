using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using SimuRails.Models;

namespace SimuRails.Mappings
{
    public class ServicioCM : ClassMapping<Servicio>
    {
        public ServicioCM()
        {
            Id(x => x.Id, m => m.Generator(Generators.Identity));
            Property(x => x.Nombre);

            Bag(x => x.Tramos, collectionMapping =>
            {
                collectionMapping.Table("Tramo");
                collectionMapping.Cascade(Cascade.None);
                collectionMapping.Key(k => k.Column("ServicioId"));
            },
            map => map.OneToMany());

            Bag(x => x.Formaciones, collectionMapping =>
            {
                collectionMapping.Table("ServiciosXFormaciones");
                collectionMapping.Key(k => k.Column("ServicioId"));
                collectionMapping.Cascade(Cascade.None);
                collectionMapping.Inverse(true);
            },
            map => map.ManyToMany(c => c.Column("FormacionId")));
        }
    }
}
