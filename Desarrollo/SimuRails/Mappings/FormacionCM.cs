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
            Property(x => x.KilometrosMantenimiento);
            Property(x => x.DuracionMantenimiento);

            Map(formacion => formacion.TiposCoche, 
                mapping => 
                {
                    mapping.Table("Dict");
                    mapping.Key(k => k.Column("FormacionId"));
                    mapping.Lazy(CollectionLazy.NoLazy);
                },
                mapkey =>
                {
                    mapkey.ManyToMany(x => x.Column("CocheId"));
                },
                mapvalue =>
                {
                    mapvalue.Element(k =>
                    {
                        k.Column("CantidadDeCoche");
                    });
                });

        }
    }
}
