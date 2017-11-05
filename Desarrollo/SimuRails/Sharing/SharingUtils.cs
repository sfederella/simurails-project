using Newtonsoft.Json;
using SimuRails.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuRails.Sharing
{
    public class SharingUtils
    {      

        public static void Exportar(Traza traza)
        {
            SaveFileDialog savefile = new SaveFileDialog
            {
                FileName = traza.Nombre,
                Filter = "Archivo SimuRails (*.sr)|*.sr"
            };

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                JsonSerializerSettings settings = new JsonSerializerSettings()
                {
                    ContractResolver = new NHibernateContractResolver()
                };
                settings.Converters.Add(new DictionaryJsonConverter());
                string json = JsonConvert.SerializeObject(traza, settings);
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                {
                    sw.WriteLine(json);
                }
            }

        }

        public static Traza Importar()
        {
            Traza traza = null;

            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "Archivo SimuRails (*.sr)|*.sr|Todos los archivos (*.*)|*.*",
                RestoreDirectory = true
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = File.ReadAllText(openFile.FileName);
                    JsonSerializerSettings settings = new JsonSerializerSettings();
                    settings.Converters.Add(new DictionaryJsonConverter());
                    traza = JsonConvert.DeserializeObject<Traza>(json, settings);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al abrir el archivo. Verifique que el mismo no está corrupto.");
                }
            }

            return traza;
        }


    }
}
