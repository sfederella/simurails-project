using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Collection.Generic;
using NHibernate.Collection;
using SimuRails.Models;

namespace SimuRails.Sharing
{
    public class DictionaryJsonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value.GetType().Name == "PersistentGenericMap`2")
            {
                Type[] types = value.GetType().GetGenericArguments();
                if (types[0].Name == "Int32" && types[1].Name == "Boolean") {
                    var dictionary = ((PersistentGenericMap<int, bool>)value).ToDictionary(x => x.Key, x => x.Value);
                    ConvertDictionary(writer, (IDictionary)dictionary, serializer);
                }
                else if (types[0].Name == "Formacion" && types[1].Name == "Int32")
                {
                    var dictionary = ((PersistentGenericMap<Formacion, Int32>)value).ToDictionary(x => x.Key, x => x.Value);
                    ConvertKeyValue(writer, (IDictionary)dictionary, serializer);
                }
                else if (types[0].Name == "Coche" && types[1].Name == "Int32")
                {
                    var dictionary = ((PersistentGenericMap<Coche, Int32>)value).ToDictionary(x => x.Key, x => x.Value);
                    ConvertKeyValue(writer, (IDictionary)dictionary, serializer);
                }
            }
            else
            {
                ConvertKeyValue(writer, (IDictionary)value, serializer);
            }

        }

        private void ConvertDictionary(JsonWriter writer, IDictionary dictionary, JsonSerializer serializer)
        {
            writer.WriteStartObject();
            foreach (var key in dictionary.Keys)
            {
                writer.WritePropertyName(key.ToString());
                serializer.Serialize(writer, dictionary[key]);
            }
            writer.WriteEndObject();
        }

        private void ConvertKeyValue(JsonWriter writer, IDictionary dictionary, JsonSerializer serializer)
        {
            writer.WriteStartArray();

            foreach (var key in dictionary.Keys)
            {
                writer.WriteStartObject();

                writer.WritePropertyName("Key");

                serializer.Serialize(writer, key);

                writer.WritePropertyName("Value");

                serializer.Serialize(writer, dictionary[key]);

                writer.WriteEndObject();
            }

            writer.WriteEndArray();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (!CanConvert(objectType))
                throw new Exception(string.Format("This converter is not for {0}.", objectType));

            var keyType = objectType.GetGenericArguments()[0];
            var valueType = objectType.GetGenericArguments()[1];
            var dictionaryType = typeof(Dictionary<,>).MakeGenericType(keyType, valueType);
            var result = (IDictionary)Activator.CreateInstance(dictionaryType);

            if (reader.TokenType == JsonToken.Null)
                return null;

            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.EndArray)
                {
                    return result;
                }

                if (reader.TokenType == JsonToken.StartObject)
                {
                    AddObjectToDictionary(reader, result, serializer, keyType, valueType);
                }
            }

            return result;
        }

        public override bool CanConvert(Type objectType)
        {
            if (objectType.IsGenericType)
            {
                bool isDictionary = objectType.GetGenericTypeDefinition() == typeof(IDictionary<,>) || objectType.GetGenericTypeDefinition() == typeof(Dictionary<,>);
                bool isNhibernateMap = objectType.GetGenericTypeDefinition() == typeof(PersistentGenericMap<,>);
                return isDictionary || isNhibernateMap;
            }
            return false;
        }

        private void AddObjectToDictionary(JsonReader reader, IDictionary result, JsonSerializer serializer, Type keyType, Type valueType)
        {
            object key = null;
            object value = null;

            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.EndObject && key != null)
                {
                    result.Add(key, value);
                    return;
                }

                var propertyName = reader.Value.ToString();
                if (propertyName == "Key")
                {
                    reader.Read();
                    key = serializer.Deserialize(reader, keyType);
                }
                else if (propertyName == "Value")
                {
                    reader.Read();
                    value = serializer.Deserialize(reader, valueType);
                }
            }
        }
    }

}
