using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using SimuRails.Models;

namespace SimuRails.Mappings
{
    public class RelacionCM : ClassMapping<Tramo>
    {
        public RelacionCM()
        {
            /*Id(x => x.Id, m => m.Generator(Generators.Identity));
            Property(x => x.Distancia);
            Property(x => x.VelocidadPromedio);
            Property(x => x.TiempoViaje);*/
        }
    }
}
