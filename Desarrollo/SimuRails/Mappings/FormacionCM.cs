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
            
            //TODO: En realidad no se va a poder hacer así de forma automática porque veo que
            //en el modelo pusieron atributos dentro de las clases de muchos a muchos (alta paja)
            //Entonces voy a tener que crear todas las tablas de muchos a muchos aparte y hacer todas las relaciones
            //muchos a muchos a manopla.

            Bag(x => x.Coches, collectionMapping =>
            {
                collectionMapping.Table("FormacionesXCoches");
                collectionMapping.Key(k => k.Column("FormacionId"));
                collectionMapping.Cascade(Cascade.None);
                collectionMapping.Inverse(true);
            },
            map => map.ManyToMany(c => c.Column("CocheId")));
        }
    }
}
