using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuRails.Models;

namespace SimuRails.Resources
{
    class LogHelper
    {
        internal static String timeConvert(int time, bool mostrarDia)
        {
            string result = "Hora: " + (time / 60 % 24).ToString("D2") + ':' + (time % 60).ToString("D2");
            if (mostrarDia)
            {
                result = "Día: " + time / 24 / 60 + " " + result;
            }
            return result;
        }

        internal static object MostrarTiemposDeSalida(Traza traza)
        {
            SortedDictionary<int, string> map = new SortedDictionary<int, string>();
            String result = "";
            foreach (Servicio servicio in traza.Servicios)
            {
                foreach (Formacion formacion in servicio.Formaciones)
                {
                    if (formacion.HoraSalida != 0)
                    {
                        String value = "";
                        if (!map.TryGetValue(formacion.HoraSalida, out value))
                        {
                            map.Add(formacion.HoraSalida, SentidoServicio(formacion) + "-" + formacion.Nombre + ":" + formacion.Id);
                        }
                        else
                        {
                            map.Remove(formacion.HoraSalida);
                            map.Add(formacion.HoraSalida, value + " | " + SentidoServicio(formacion) + "-" + formacion.Nombre + ":" + formacion.Id);
                        }
                    }
                        
                }
            }

            foreach (KeyValuePair<int, string> kvp in map)
            {
                result = result +  (timeConvert(kvp.Key,true) +" | Formacion: " +  kvp.Value + "\n");
            }

            return result;
        }

        internal static string SentidoServicio(Formacion formacion)
        {
            string servicio = formacion.Servicio.Nombre;

            if (formacion.EstacionActual.Equals(formacion.Servicio.Hasta))
            {
                return servicio.Split('-')[1] + " - " + servicio.Split('-')[0];
            }

            return servicio;
        }

        internal static string MostrarProgramaciones(Traza traza)
        {
            SortedDictionary<int, string> map = new SortedDictionary<int, string>();
            String result = "";
            foreach (Servicio servicio in traza.Servicios)
            {
                foreach (KeyValuePair<int, bool> kvp in servicio.ProgramacionIda)
                {
                    map.Add(kvp.Key, kvp.Value.ToString().PadRight(5) + " Servicio: " + servicio.Nombre + " | Programacion Ida");

                    //result = result + ("Hora: " + timeConvert(kvp.Key) + " | Value: " + kvp.Value + "\n");
                }

                //result = result + "Servicio: " + servicio.Nombre + " | Programacion Vuelta: \n";
                foreach (KeyValuePair<int, bool> kvp in servicio.ProgramacionVuelta)
                {
                    map.Add(kvp.Key, kvp.Value.ToString().PadRight(5) + " Servicio: " + servicio.Nombre + " | Programacion Vuelta" );

                    //result = result + ("Hora: " + timeConvert(kvp.Key) + " | Value: " + kvp.Value + "\n");
                }
            }

            foreach (KeyValuePair<int, string> kvp in map)
            {
                result = result + (timeConvert(kvp.Key,false) + " " + kvp.Value + "\n");
            }

            return result;
        }
    }
}
