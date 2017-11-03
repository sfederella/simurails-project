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
            Property(x => x.CantidadFormacionesInicio);

            Bag(x => x.Tramos, collectionMapping =>
            {
                collectionMapping.Table("Tramo");
                collectionMapping.Cascade(Cascade.All);
                collectionMapping.Key(k => k.Column("ServicioId"));
            },
            map => map.OneToMany());

            Map(servicio => servicio.TiposFormacion,
                mapping =>
                {
                    mapping.Table("DictTiposFormacion");
                    mapping.Cascade(Cascade.All);
                    mapping.Key(k => k.Column("ServicioId"));
                },
                mapkey =>
                {
                    mapkey.ManyToMany(x => x.Column("FormacionId"));
                },
                mapvalue =>
                {
                    mapvalue.Element(k =>
                    {
                        k.Column("CantidadDeFormaciones");
                    });
                });

            Map(servicio => servicio.ProgramacionIda,
                mapping =>
                {
                    mapping.Table("DictIda");
                    mapping.Cascade(Cascade.All);
                    mapping.Key(k => k.Column("ServicioId"));
                },
                mapkey =>
                {
                    mapkey.Element(k =>
                    {
                        k.Column("horario");
                    });
                },
                mapvalue =>
                {
                    mapvalue.Element(k =>
                    {
                        k.Column("habilitado");
                    });
                });

            Map(servicio => servicio.ProgramacionVuelta,
                mapping =>
                {
                    mapping.Table("DictVuelta");
                    mapping.Cascade(Cascade.All);
                    mapping.Key(k => k.Column("ServicioId"));
                },
                mapkey =>
                {
                    mapkey.Element(k =>
                    {
                        k.Column("horario");
                    });
                },
                mapvalue =>
                {
                    mapvalue.Element(k =>
                    {
                        k.Column("habilitado");
                    });
                });
        }
    }
}
