using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Mapping.ByCode;
using NHibernate.Tool.hbm2ddl;
using System.Collections.Generic;
using System.Xml.Serialization;
using SimuRails.Mappings;
using System;
using System.IO;
using System.Xml;

namespace SimuRails.DB
{
    public static class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static Configuration _configuration;
        private static HbmMapping _mapping;

        public static ISession OpenSession()
        {
            //Open and return the nhibernate session
            var schemaUpdate = new SchemaUpdate(Configuration);
            schemaUpdate.Execute(Console.WriteLine, true);

            return SessionFactory.OpenSession();
        }

        public static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    //Create the session factory
                    _sessionFactory = Configuration.BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }

        public static Configuration Configuration
        {
            get
            {
                if (_configuration == null)
                {
                    //Create the nhibernate configuration
                    _configuration = CreateConfiguration();
                }
                return _configuration;
            }
        }

        public static HbmMapping Mapping
        {
            get
            {
                if (_mapping == null)
                {
                    //Create the mapping
                    _mapping = CreateMapping();
                }

                var xmlSerializer = new XmlSerializer(_mapping.GetType());

                xmlSerializer.Serialize(Console.Out, _mapping);

                return _mapping;
            }
        }

        private static Configuration CreateConfiguration()
        {
            var configuration = new Configuration();
            //Loads properties from hibernate.cfg.xml
            XmlReader xmlReader = XmlReader.Create(new StringReader(global::SimuRails.Properties.Resources.HibernateXLM));
            configuration.Configure(xmlReader);
            //Loads nhibernate mappings 
            configuration.AddDeserializedMapping(Mapping, null);

            return configuration;
        }

        private static HbmMapping CreateMapping()
        {
            var mapper = new ModelMapper();
            //Add the person mapping to the model mapper
            mapper.AddMappings(new List<System.Type> { typeof(TrazaCM) });
            mapper.AddMappings(new List<System.Type> { typeof(IncidenteCM) });
            mapper.AddMappings(new List<System.Type> { typeof(EstacionCM) });
            mapper.AddMappings(new List<System.Type> { typeof(TramoCM) });
            mapper.AddMappings(new List<System.Type> { typeof(ServicioCM) });
            mapper.AddMappings(new List<System.Type> { typeof(SimulacionCM) });
            mapper.AddMappings(new List<System.Type> { typeof(FormacionCM) });
            mapper.AddMappings(new List<System.Type> { typeof(CocheCM) });
            mapper.AddMappings(new List<System.Type> { typeof(ComposicionDeCochesCM) });
            //Create and return a HbmMapping of the model mapping in code
            return mapper.CompileMappingForAllExplicitlyAddedEntities();
        }
    }
}
