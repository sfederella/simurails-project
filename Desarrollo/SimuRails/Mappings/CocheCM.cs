using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using SimuRails.Models;

namespace SimuRails.Mappings
{
    public class CocheCM : ClassMapping<Coche>
    {
        public CocheCM()
        {
            Id(x => x.Id, m =>
            {
                m.Generator(Generators.Identity);
            });

            Property(x => x.Modelo);
            Property(x => x.EsLocomotora);
            Property(x => x.TipoDeConsumo);
            Property(x => x.ConsumoMovimiento);
            Property(x => x.ConsumoParado);
            Property(x => x.CantidadAsientos);
            Property(x => x.MaximoLegalPasajeros);
            Property(x => x.CapacidadMaximaPasajeros);
        }
    }
}
