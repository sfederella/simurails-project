using SimuRails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.ModelsTests
{
    class ModelMock
    {
        public Traza Traza { get; }

        private Dictionary<string, Coche> Coches;
        private Dictionary<string, Formacion> Formaciones;
        private Dictionary<string, Estacion> Estaciones;

        public ModelMock()
        {
            InitCoches();
            InitFormaciones();
            InitEstaciones();

            Traza = new Traza()
            {
                Nombre = "Mitre",
                Servicios = new List<Servicio>()
                {
                    new Servicio()
                    {
                        Nombre = "Villa Ballester - Zarate",
                        Tramos = new List<Tramo>
                        {
                            new Tramo()
                            {
                                EstacionOrigen = Estaciones["Villa Ballester"],
                                EstacionDestino = Estaciones["Bancalari"],
                                Distancia = 9,
                                TiempoViaje = 26
                            },
                            new Tramo()
                            {
                                EstacionOrigen = Estaciones["Bancalari"],
                                EstacionDestino = Estaciones["Pacheco"],
                                Distancia = 3,
                                TiempoViaje = 5
                            },
                            new Tramo()
                            {
                                EstacionOrigen = Estaciones["Pacheco"],
                                EstacionDestino = Estaciones["Benavidez"],
                                Distancia = 8,
                                TiempoViaje = 9
                            },
                            new Tramo()
                            {
                                EstacionOrigen = Estaciones["Benavidez"],
                                EstacionDestino = Estaciones["Maschwitz"],
                                Distancia = 5,
                                TiempoViaje = 17
                            },
                            new Tramo()
                            {
                                EstacionOrigen = Estaciones["Maschwitz"],
                                EstacionDestino = Estaciones["Escobar"],
                                Distancia = 7,
                                TiempoViaje = 9
                            },
                            new Tramo()
                            {
                                EstacionOrigen = Estaciones["Escobar"],
                                EstacionDestino = Estaciones["Río Luján"],
                                Distancia = 19,
                                TiempoViaje = 15
                            },
                            new Tramo()
                            {
                                EstacionOrigen = Estaciones["Río Luján"],
                                EstacionDestino = Estaciones["Otamendi"],
                                Distancia = 6,
                                TiempoViaje = 7
                            },
                            new Tramo()
                            {
                                EstacionOrigen = Estaciones["Otamendi"],
                                EstacionDestino = Estaciones["Campana"],
                                Distancia = 10,
                                TiempoViaje = 9
                            },
                            new Tramo()
                            {
                                EstacionOrigen = Estaciones["Campana"],
                                EstacionDestino = Estaciones["Km. 83"],
                                Distancia = 2,
                                TiempoViaje = 2
                            },
                            new Tramo()
                            {
                                EstacionOrigen = Estaciones["Km. 83"],
                                EstacionDestino = Estaciones["Zárate"],
                                Distancia = 10,
                                TiempoViaje = 13
                            }
                        },
                        TiposFormacion = new Dictionary<Formacion, int>
                        {
                            [Formaciones["Form. Diesel Mitre"]] = 2,
                        },
                        PorcentajeFormacionesInicio = 60,
                        ProgramacionIda = new SortedDictionary<int,bool>()
                        {
                            [130] = false,
                            [571] = false,
                            [1110] = false,
                        },
                        ProgramacionVuelta = new SortedDictionary<int,bool>()
                        {
                            [310] = false,
                            [722] = false,
                            [1307] = false,
                        }
                    },

                    new Servicio()
                    {
                        Nombre = "Victoria - Capilla del Señor",
                        Tramos = new List<Tramo>
                        {
                            new Tramo()
                            {
                                EstacionOrigen = Estaciones["Victoria"],
                                EstacionDestino = Estaciones["Schweitzer"],
                                Distancia = 4,
                                TiempoViaje = 8
                            },
                            new Tramo()
                            {
                                EstacionOrigen = Estaciones["Schweitzer"],
                                EstacionDestino = Estaciones["El Talar"],
                                Distancia = 7,
                                TiempoViaje = 24
                            },
                            new Tramo()
                            {
                                EstacionOrigen = Estaciones["El Talar"],
                                EstacionDestino = Estaciones["López Camelo"],
                                Distancia = 3,
                                TiempoViaje = 8
                            },
                            new Tramo()
                            {
                                EstacionOrigen = Estaciones["López Camelo"],
                                EstacionDestino = Estaciones["Garín"],
                                Distancia = 6,
                                TiempoViaje = 14
                            },
                            new Tramo()
                            {
                                EstacionOrigen = Estaciones["Garín"],
                                EstacionDestino = Estaciones["Maq. Savio"],
                                Distancia = 4,
                                TiempoViaje = 8
                            },
                            new Tramo()
                            {
                                EstacionOrigen = Estaciones["Maq. Savio"],
                                EstacionDestino = Estaciones["Matheu"],
                                Distancia = 6,
                                TiempoViaje = 12
                            },
                            new Tramo()
                            {
                                EstacionOrigen = Estaciones["Matheu"],
                                EstacionDestino = Estaciones["Zelaya"],
                                Distancia = 4,
                                TiempoViaje = 7
                            },
                            new Tramo()
                            {
                                EstacionOrigen = Estaciones["Zelaya"],
                                EstacionDestino = Estaciones["Los Cardales"],
                                Distancia = 12,
                                TiempoViaje = 17
                            },
                            new Tramo()
                            {
                                EstacionOrigen = Estaciones["Los Cardales"],
                                EstacionDestino = Estaciones["Capilla del Señor"],
                                Distancia = 11,
                                TiempoViaje = 15
                            }
                        },
                        TiposFormacion = new Dictionary<Formacion, int>
                        {
                            [Formaciones["Form. Elec. Mitre"]] = 4,
                            [Formaciones["Form. Diesel Mitre"]] = 3,
                        },
                        PorcentajeFormacionesInicio = 60,
                        ProgramacionIda = new SortedDictionary<int,bool>()
                        {
                            [182] = false,
                            [460] = false,
                            [572] = false,
                            [836] = false,
                            [977] = false,
                            [1115] = false,
                            [1295] = false,
                            [1396] = false,
                        },
                        ProgramacionVuelta = new SortedDictionary<int,bool>()
                        {
                            [215] = false,
                            [328] = false,
                            [605] = false,
                            [730] = false,
                            [968] = false,
                            [1157] = false,
                            [1260] = false,
                            [1429] = false,
                        }
                    }
                }
            };

        }

        private void InitCoches()
        {
            Coches = new Dictionary<string, Coche>
            {
                ["Loc. General Motors-EMD G22"] = new Coche()
                {
                    Modelo = "Loc. General Motors-EMD G22",
                    EsLocomotora = true,
                    TipoDeConsumo = "Electrico", //TODO cambiar a enum
                    ConsumoParado = 50, 
                    ConsumoMovimiento = 300,
                    CantidadAsientos = 50,
                    MaximoLegalPasajeros = 80,
                    CapacidadMaximaPasajeros = 130,
                },
                ["Coche General Motors-EMD G10"] = new Coche()
                {
                    Modelo = "Coche General Motors-EMD G10",
                    EsLocomotora = false,
                    CantidadAsientos = 60,
                    MaximoLegalPasajeros = 80,
                    CapacidadMaximaPasajeros = 130,
                },
                ["Loc. General Motors-EMD E80"] = new Coche()
                {
                    Modelo = "Loc. General Motors-EMD E80",
                    EsLocomotora = true,
                    TipoDeConsumo = "Diesel", //TODO cambiar a enum
                    ConsumoParado = 1,
                    ConsumoMovimiento = 4,
                    CantidadAsientos = 50,
                    MaximoLegalPasajeros = 80,
                    CapacidadMaximaPasajeros = 130,
                },
                ["Coche General Motors-EMD E83"] = new Coche()
                {
                    Modelo = "Coche General Motors-EMD E83",
                    EsLocomotora = false,
                    CantidadAsientos = 60,
                    MaximoLegalPasajeros = 80,
                    CapacidadMaximaPasajeros = 130,
                }
            };
        }

        private void InitFormaciones()
        {
            Formaciones = new Dictionary<string, Formacion>
            {
                ["Form. Elec. Mitre"] = new Formacion()
                {
                    Nombre = "Form. Elec. Mitre",
                    TiposCoche = new Dictionary<Coche,int>()
                    {
                        [Coches["Loc. General Motors-EMD G22"]] = 1,
                        [Coches["Loc. General Motors-EMD G22"]] = 5
                    }
                },
                ["Form. Diesel Mitre"] = new Formacion()
                {
                    Nombre = "Form. Diesel Mitre",
                    TiposCoche = new Dictionary<Coche, int>()
                    {
                        [Coches["Loc. General Motors-EMD E80"]] = 1,
                        [Coches["Coche General Motors-EMD E83"]] = 5
                    }
                }
            };
        }

        private void InitEstaciones()
        {
            Estaciones = new Dictionary<string, Estacion>
            {
                ["Villa Ballester"] = new Estacion()
                {
                    Nombre = "Villa Ballester",
                    PersonasDesciendenMaxIda = 0,
                    PersonasDesciendenMinIda = 0,
                    PersonasEsperandoMaxIda = 80,
                    PersonasEsperandoMinIda = 5,
                    PersonasDesciendenMaxVuelta = 80,
                    PersonasDesciendenMinVuelta = 5,
                    PersonasEsperandoMaxVuelta = 0,
                    PersonasEsperandoMinVuelta = 0
                },

                ["Bancalari"] = new Estacion()
                {
                    Nombre = "Bancalari",
                    PersonasDesciendenMaxIda = 10,
                    PersonasDesciendenMinIda = 0,
                    PersonasEsperandoMaxIda = 70,
                    PersonasEsperandoMinIda = 5,
                    PersonasDesciendenMaxVuelta = 70,
                    PersonasDesciendenMinVuelta = 5,
                    PersonasEsperandoMaxVuelta = 10,
                    PersonasEsperandoMinVuelta = 0
                },

                ["Pacheco"] = new Estacion()
                {
                    Nombre = "Pacheco",
                    PersonasDesciendenMaxIda = 20,
                    PersonasDesciendenMinIda = 0,
                    PersonasEsperandoMaxIda = 60,
                    PersonasEsperandoMinIda = 5,
                    PersonasDesciendenMaxVuelta = 60,
                    PersonasDesciendenMinVuelta = 5,
                    PersonasEsperandoMaxVuelta = 20,
                    PersonasEsperandoMinVuelta = 0
                },

                ["Benavidez"] = new Estacion()
                {
                    Nombre = "Benavidez",
                    PersonasDesciendenMaxIda = 30,
                    PersonasDesciendenMinIda = 0,
                    PersonasEsperandoMaxIda = 50,
                    PersonasEsperandoMinIda = 5,
                    PersonasDesciendenMaxVuelta = 50,
                    PersonasDesciendenMinVuelta = 5,
                    PersonasEsperandoMaxVuelta = 30,
                    PersonasEsperandoMinVuelta = 0
                },

                ["Maschwitz"] = new Estacion()
                {
                    Nombre = "Maschwitz",
                    PersonasDesciendenMaxIda = 40,
                    PersonasDesciendenMinIda = 5,
                    PersonasEsperandoMaxIda = 40,
                    PersonasEsperandoMinIda = 5,
                    PersonasDesciendenMaxVuelta = 40,
                    PersonasDesciendenMinVuelta = 5,
                    PersonasEsperandoMaxVuelta = 40,
                    PersonasEsperandoMinVuelta = 5
                },

                ["Escobar"] = new Estacion()
                {
                    Nombre = "Escobar",
                    PersonasDesciendenMaxIda = 40,
                    PersonasDesciendenMinIda = 5,
                    PersonasEsperandoMaxIda = 40,
                    PersonasEsperandoMinIda = 5,
                    PersonasDesciendenMaxVuelta = 40,
                    PersonasDesciendenMinVuelta = 5,
                    PersonasEsperandoMaxVuelta = 40,
                    PersonasEsperandoMinVuelta = 5
                },

                ["Río Luján"] = new Estacion()
                {
                    Nombre = "Río Luján",
                    PersonasDesciendenMaxIda = 40,
                    PersonasDesciendenMinIda = 5,
                    PersonasEsperandoMaxIda = 40,
                    PersonasEsperandoMinIda = 5,
                    PersonasDesciendenMaxVuelta = 40,
                    PersonasDesciendenMinVuelta = 5,
                    PersonasEsperandoMaxVuelta = 40,
                    PersonasEsperandoMinVuelta = 5
                },

                ["Otamendi"] = new Estacion()
                {
                    Nombre = "Otamendi",
                    PersonasDesciendenMaxIda = 50,
                    PersonasDesciendenMinIda = 5,
                    PersonasEsperandoMaxIda = 30,
                    PersonasEsperandoMinIda = 0,
                    PersonasDesciendenMaxVuelta = 30,
                    PersonasDesciendenMinVuelta = 0,
                    PersonasEsperandoMaxVuelta = 50,
                    PersonasEsperandoMinVuelta = 5
                },

                ["Campana"] = new Estacion()
                {
                    Nombre = "Campana",
                    PersonasDesciendenMaxIda = 60,
                    PersonasDesciendenMinIda = 5,
                    PersonasEsperandoMaxIda = 20,
                    PersonasEsperandoMinIda = 0,
                    PersonasDesciendenMaxVuelta = 20,
                    PersonasDesciendenMinVuelta = 0,
                    PersonasEsperandoMaxVuelta = 60,
                    PersonasEsperandoMinVuelta = 5
                },

                ["Km. 83"] = new Estacion()
                {
                    Nombre = "Km. 83",
                    PersonasDesciendenMaxIda = 70,
                    PersonasDesciendenMinIda = 5,
                    PersonasEsperandoMaxIda = 10,
                    PersonasEsperandoMinIda = 0,
                    PersonasDesciendenMaxVuelta = 10,
                    PersonasDesciendenMinVuelta = 0,
                    PersonasEsperandoMaxVuelta = 70,
                    PersonasEsperandoMinVuelta = 5
                },

                ["Zárate"] = new Estacion()
                {
                    Nombre = "Zárate",
                    PersonasDesciendenMaxIda = 80,
                    PersonasDesciendenMinIda = 5,
                    PersonasEsperandoMaxIda = 0,
                    PersonasEsperandoMinIda = 0,
                    PersonasDesciendenMaxVuelta = 0,
                    PersonasDesciendenMinVuelta = 0,
                    PersonasEsperandoMaxVuelta = 80,
                    PersonasEsperandoMinVuelta = 5
                },

                ["Victoria"] = new Estacion()
                {
                    Nombre = "Victoria",
                    PersonasDesciendenMaxIda = 0,
                    PersonasDesciendenMinIda = 0,
                    PersonasEsperandoMaxIda = 80,
                    PersonasEsperandoMinIda = 5,
                    PersonasDesciendenMaxVuelta = 80,
                    PersonasDesciendenMinVuelta = 5,
                    PersonasEsperandoMaxVuelta = 0,
                    PersonasEsperandoMinVuelta = 0
                },

                ["Schweitzer"] = new Estacion()
                {
                    Nombre = "Schweitzer",
                    PersonasDesciendenMaxIda = 10,
                    PersonasDesciendenMinIda = 0,
                    PersonasEsperandoMaxIda = 70,
                    PersonasEsperandoMinIda = 5,
                    PersonasDesciendenMaxVuelta = 70,
                    PersonasDesciendenMinVuelta = 5,
                    PersonasEsperandoMaxVuelta = 10,
                    PersonasEsperandoMinVuelta = 0
                },

                ["El Talar"] = new Estacion()
                {
                    Nombre = "El Talar",
                    PersonasDesciendenMaxIda = 20,
                    PersonasDesciendenMinIda = 0,
                    PersonasEsperandoMaxIda = 60,
                    PersonasEsperandoMinIda = 5,
                    PersonasDesciendenMaxVuelta = 60,
                    PersonasDesciendenMinVuelta = 5,
                    PersonasEsperandoMaxVuelta = 20,
                    PersonasEsperandoMinVuelta = 0
                },

                ["López Camelo"] = new Estacion()
                {
                    Nombre = "Lopez Camelo",
                    PersonasDesciendenMaxIda = 30,
                    PersonasDesciendenMinIda = 0,
                    PersonasEsperandoMaxIda = 50,
                    PersonasEsperandoMinIda = 5,
                    PersonasDesciendenMaxVuelta = 50,
                    PersonasDesciendenMinVuelta = 5,
                    PersonasEsperandoMaxVuelta = 30,
                    PersonasEsperandoMinVuelta = 0
                },

                ["Garín"] = new Estacion()
                {
                    Nombre = "Garín",
                    PersonasDesciendenMaxIda = 40,
                    PersonasDesciendenMinIda = 5,
                    PersonasEsperandoMaxIda = 40,
                    PersonasEsperandoMinIda = 5,
                    PersonasDesciendenMaxVuelta = 40,
                    PersonasDesciendenMinVuelta = 5,
                    PersonasEsperandoMaxVuelta = 40,
                    PersonasEsperandoMinVuelta = 5
                },

                ["Maq. Savio"] = new Estacion()
                {
                    Nombre = "Maq. Savio",
                    PersonasDesciendenMaxIda = 40,
                    PersonasDesciendenMinIda = 5,
                    PersonasEsperandoMaxIda = 40,
                    PersonasEsperandoMinIda = 5,
                    PersonasDesciendenMaxVuelta = 40,
                    PersonasDesciendenMinVuelta = 5,
                    PersonasEsperandoMaxVuelta = 40,
                    PersonasEsperandoMinVuelta = 5
                },

                ["Matheu"] = new Estacion()
                {
                    Nombre = "Matheu",
                    PersonasDesciendenMaxIda = 50,
                    PersonasDesciendenMinIda = 5,
                    PersonasEsperandoMaxIda = 30,
                    PersonasEsperandoMinIda = 0,
                    PersonasDesciendenMaxVuelta = 30,
                    PersonasDesciendenMinVuelta = 0,
                    PersonasEsperandoMaxVuelta = 50,
                    PersonasEsperandoMinVuelta = 5
                },

                ["Zelaya"] = new Estacion()
                {
                    Nombre = "Zelaya",
                    PersonasDesciendenMaxIda = 60,
                    PersonasDesciendenMinIda = 5,
                    PersonasEsperandoMaxIda = 20,
                    PersonasEsperandoMinIda = 0,
                    PersonasDesciendenMaxVuelta = 20,
                    PersonasDesciendenMinVuelta = 0,
                    PersonasEsperandoMaxVuelta = 60,
                    PersonasEsperandoMinVuelta = 5
                },

                ["Los Cardales"] = new Estacion()
                {
                    Nombre = "Los Cardales",
                    PersonasDesciendenMaxIda = 70,
                    PersonasDesciendenMinIda = 5,
                    PersonasEsperandoMaxIda = 10,
                    PersonasEsperandoMinIda = 0,
                    PersonasDesciendenMaxVuelta = 10,
                    PersonasDesciendenMinVuelta = 0,
                    PersonasEsperandoMaxVuelta = 70,
                    PersonasEsperandoMinVuelta = 5
                },

                ["Capilla del Señor"] = new Estacion()
                {
                    Nombre = "Capilla del Señor",
                    PersonasDesciendenMaxIda = 80,
                    PersonasDesciendenMinIda = 5,
                    PersonasEsperandoMaxIda = 0,
                    PersonasEsperandoMinIda = 0,
                    PersonasDesciendenMaxVuelta = 0,
                    PersonasDesciendenMinVuelta = 0,
                    PersonasEsperandoMaxVuelta = 80,
                    PersonasEsperandoMinVuelta = 5
                }
            };
        }
    }
}
