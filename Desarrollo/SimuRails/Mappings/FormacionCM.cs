using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using SimuRails.Models;

namespace SimuRails.Mappings
{
    public class FormacionCM : ClassMapping<Formacion>
    {
        public FormacionCM()
        {
            Id(x => x.Id, m => m.Generator(Generators.Identity));

            Property(x => x.Nombre);

            Bag(x => x.ComposicionesDeCoches, collectionMapping =>
            {
                collectionMapping.Table("ComposicionDeCoches");
                collectionMapping.Cascade(Cascade.All);
                collectionMapping.Key(k => k.Column("ComposicionDeCochesId"));
            },
            map => map.OneToMany());
        }
    }
}
