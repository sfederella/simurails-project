using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using SimuRails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuRails.Mappings
{
    public class ComposicionDeCochesCM : ClassMapping<ComposicionDeCoches>
    {
        public ComposicionDeCochesCM()
        {
            Id(x => x.Id, m =>
            {
                m.Generator(Generators.Identity);
            });

            ManyToOne(x => x.Coche, mapping =>
            {
                mapping.Column("CocheId");
                mapping.Cascade(Cascade.Persist);
            });

            Property(x => x.VecesRepetido);
        }
    }
}
