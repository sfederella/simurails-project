using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using SimuRails.Models;

namespace SimuRails.Mappings
{
    public class TramoCM : ClassMapping<Tramo>
    {
        public TramoCM()
        {
            Id(x => x.Id, m => m.Generator(Generators.Identity));

            Property(x => x.Distancia);
            Property(x => x.TiempoViaje);

            ManyToOne(x => x.EstacionOrigen, mapping =>
            {
                mapping.Column("EstacionId1");
                mapping.Cascade(Cascade.All);
            });

            ManyToOne(x => x.EstacionDestino, mapping =>
            {
                mapping.Column("EstacionId2");
                mapping.Cascade(Cascade.All);
            });
        }
    }
}
