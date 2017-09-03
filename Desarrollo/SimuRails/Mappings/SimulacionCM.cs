using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using SimuRails.Models;

namespace SimuRails.Mappings
{
    public class SimulacionCM : ClassMapping<Simulacion>
    {
        public SimulacionCM()
        {
            Id(x => x.Id, m => m.Generator(Generators.Identity));
            Property(x => x.Nombre);
            Property(x => x.FrecuenciaDeSalida);
        }
    }
}
