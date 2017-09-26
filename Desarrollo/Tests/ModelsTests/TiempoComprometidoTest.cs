using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuRails.Models;

namespace Tests.ModelsTests
{
    [TestClass]
    public class TiempoComprometidoTest
    {
        Traza traza;
        
        [TestMethod]
        public void ejecutarSimulacion()
        {
            int tiempoFinal = 1000;

            init();

            System.Diagnostics.Debug.WriteLine("########### Iniciando test de tiempo comprometido ###########");
            new TiempoComprometido(traza, tiempoFinal).ejecutarSimulacion();
            System.Diagnostics.Debug.WriteLine("########### Fin test de tiempo comprometido ###########");
            Assert.IsTrue(false);
        }

        public void init()
        {
            traza = new Traza()
            {
                Nombre = "Sarmiento"
            };
                        
            Estacion once = new Estacion();
            once.Nombre = "ONCE";
            once.PersonasEsperandoMax = 300;
            once.PersonasEsperandoMax = 100;
            
            Estacion liniers = new Estacion();
            liniers.Nombre = "LINIERS";
            liniers.PersonasEsperandoMax = 200;
            liniers.PersonasEsperandoMax = 50;

            Estacion moreno = new Estacion();
            moreno.Nombre = "MORENO";
            moreno.PersonasEsperandoMax = 500;
            moreno.PersonasEsperandoMax = 70;

            Servicio servicio = new Servicio();
            servicio.Desde = once;
            servicio.Hasta = moreno;
            servicio.Formaciones = new HashSet<Formacion>();

            Formacion formacion1 = new Formacion(servicio);
            formacion1.HoraSalida = 5;
            servicio.Formaciones.Add(formacion1);

            Formacion formacion2 = new Formacion(servicio);
            formacion2.HoraSalida = 15;
            servicio.Formaciones.Add(formacion2);

            Formacion formacion3 = new Formacion(servicio);
            formacion3.HoraSalida = 25;
            servicio.Formaciones.Add(formacion3);

            traza.Servicios = new HashSet<Servicio>();
            traza.Servicios.Add(servicio);

        }
    }
}
