using SimuRails.Models;
using System.Collections.Generic;
using Moq;

namespace Tests.ModelsTests
{
    class ModelMock
    {
        public Traza Traza { get; }

        private Dictionary<string, Coche> Coches;
        private Dictionary<string, Formacion> Formaciones;
        private Dictionary<string, Estacion> Estaciones;

        public void MockResultados()
        {
            Mock<ResultadoEstacion> mockResultado = new Mock<ResultadoEstacion>();
            mockResultado.Setup(x => x.CantFormaciones).Returns(FDP.Rand(0, 100));
            mockResultado.Setup(x => x.PorcentajeOcupacion).Returns(FDP.Rand(0, 100));
            mockResultado.Setup(x => x.PorcentajePersonasParadas).Returns(FDP.Rand(0, 100));
            mockResultado.Setup(x => x.PorcentajeSuperaronMaxCantLegal).Returns(FDP.Rand(0, 100));
            mockResultado.Setup(x => x.PorcentajeRegularidadAbsoluta).Returns(FDP.Rand(0, 100));
            mockResultado.Setup(x => x.PorcentajeCumplimientoPrograma).Returns(FDP.Rand(0, 100));
            mockResultado.Setup(x => x.PorcentajeDemoraPorIncidentes).Returns(FDP.Rand(0, 100));

            foreach (Estacion estacion in Estaciones.Values)
            {
                estacion.Resultado = mockResultado.Object;
            }
        }

        public ModelMock()
        {
            InitCoches();
            InitFormaciones();
            InitEstaciones();

            Traza = new Traza()
            {
                Id = 100,
                Nombre = "Mitre",
                Servicios = new List<Servicio>()
                {
                    new Servicio()
                    {
                        Id = 201,
                        Nombre = "Villa Ballester - Zarate",
                        Tramos = new List<Tramo>
                        {
                            new Tramo()
                            {
                                Id = 301,
                                EstacionOrigen = Estaciones["Villa Ballester"],
                                EstacionDestino = Estaciones["Bancalari"],
                                Distancia = 9,
                                TiempoViaje = 26
                            },
                            new Tramo()
                            {
                                Id = 302,
                                EstacionOrigen = Estaciones["Bancalari"],
                                EstacionDestino = Estaciones["Pacheco"],
                                Distancia = 3,
                                TiempoViaje = 5
                            },
                            new Tramo()
                            {
                                Id = 303,
                                EstacionOrigen = Estaciones["Pacheco"],
                                EstacionDestino = Estaciones["Benavidez"],
                                Distancia = 8,
                                TiempoViaje = 9
                            },
                            new Tramo()
                            {
                                Id = 304,
                                EstacionOrigen = Estaciones["Benavidez"],
                                EstacionDestino = Estaciones["Maschwitz"],
                                Distancia = 5,
                                TiempoViaje = 17
                            },
                            new Tramo()
                            {
                                Id = 305,
                                EstacionOrigen = Estaciones["Maschwitz"],
                                EstacionDestino = Estaciones["Escobar"],
                                Distancia = 7,
                                TiempoViaje = 9
                            },
                            new Tramo()
                            {
                                Id = 306,
                                EstacionOrigen = Estaciones["Escobar"],
                                EstacionDestino = Estaciones["Río Luján"],
                                Distancia = 19,
                                TiempoViaje = 15
                            },
                            new Tramo()
                            {
                                Id = 307,
                                EstacionOrigen = Estaciones["Río Luján"],
                                EstacionDestino = Estaciones["Otamendi"],
                                Distancia = 6,
                                TiempoViaje = 7
                            },
                            new Tramo()
                            {
                                Id = 308,
                                EstacionOrigen = Estaciones["Otamendi"],
                                EstacionDestino = Estaciones["Campana"],
                                Distancia = 10,
                                TiempoViaje = 9
                            },
                            new Tramo()
                            {
                                Id = 309,
                                EstacionOrigen = Estaciones["Campana"],
                                EstacionDestino = Estaciones["Km. 83"],
                                Distancia = 2,
                                TiempoViaje = 2
                            },
                            new Tramo()
                            {
                                Id = 310,
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
                        Id = 202,
                        Nombre = "Victoria - Capilla del Señor",
                        Tramos = new List<Tramo>
                        {
                            new Tramo()
                            {
                                Id = 311,
                                EstacionOrigen = Estaciones["Victoria"],
                                EstacionDestino = Estaciones["Schweitzer"],
                                Distancia = 4,
                                TiempoViaje = 8
                            },
                            new Tramo()
                            {
                                Id = 312,
                                EstacionOrigen = Estaciones["Schweitzer"],
                                EstacionDestino = Estaciones["El Talar"],
                                Distancia = 7,
                                TiempoViaje = 24
                            },
                            new Tramo()
                            {
                                Id = 313,
                                EstacionOrigen = Estaciones["El Talar"],
                                EstacionDestino = Estaciones["López Camelo"],
                                Distancia = 3,
                                TiempoViaje = 8
                            },
                            new Tramo()
                            {
                                Id = 314,
                                EstacionOrigen = Estaciones["López Camelo"],
                                EstacionDestino = Estaciones["Garín"],
                                Distancia = 6,
                                TiempoViaje = 14
                            },
                            new Tramo()
                            {
                                Id = 315,
                                EstacionOrigen = Estaciones["Garín"],
                                EstacionDestino = Estaciones["Maq. Savio"],
                                Distancia = 4,
                                TiempoViaje = 8
                            },
                            new Tramo()
                            {
                                Id = 316,
                                EstacionOrigen = Estaciones["Maq. Savio"],
                                EstacionDestino = Estaciones["Matheu"],
                                Distancia = 6,
                                TiempoViaje = 12
                            },
                            new Tramo()
                            {
                                Id = 317,
                                EstacionOrigen = Estaciones["Matheu"],
                                EstacionDestino = Estaciones["Zelaya"],
                                Distancia = 4,
                                TiempoViaje = 7
                            },
                            new Tramo()
                            {
                                Id = 318,
                                EstacionOrigen = Estaciones["Zelaya"],
                                EstacionDestino = Estaciones["Los Cardales"],
                                Distancia = 12,
                                TiempoViaje = 17
                            },
                            new Tramo()
                            {
                                Id = 319,
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
                    Id = 601,
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
                    Id = 602,
                    Modelo = "Coche General Motors-EMD G10",
                    EsLocomotora = false,
                    CantidadAsientos = 60,
                    MaximoLegalPasajeros = 80,
                    CapacidadMaximaPasajeros = 130,
                },
                ["Loc. General Motors-EMD E80"] = new Coche()
                {
                    Id = 603,
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
                    Id = 604,
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
                    Id = 501,
                    Nombre = "Form. Elec. Mitre",
                    TiposCoche = new Dictionary<Coche,int>()
                    {
                        [Coches["Loc. General Motors-EMD G22"]] = 1,
                        [Coches["Loc. General Motors-EMD G22"]] = 5
                    }
                },
                ["Form. Diesel Mitre"] = new Formacion()
                {
                    Id = 502,
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
                    Id = 401,
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
                    Id = 402,
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
                    Id = 403,
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
                    Id = 404,
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
                    Id = 405,
                    Nombre = "Maschwitz",
                    PersonasDesciendenMaxIda = 40,
                    PersonasDesciendenMinIda = 5,
                    PersonasEsperandoMaxIda = 40,
                    PersonasEsperandoMinIda = 5,
                    PersonasDesciendenMaxVuelta = 40,
                    PersonasDesciendenMinVuelta = 5,
                    PersonasEsperandoMaxVuelta = 40,
                    PersonasEsperandoMinVuelta = 5,
                    EsEstacionDeMantenimiento = true
                },

                ["Escobar"] = new Estacion()
                {
                    Id = 406,
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
                    Id = 407,
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
                    Id = 408,
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
                    Id = 409,
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
                    Id = 410,
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
                    Id = 411,
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
                    Id = 412,
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
                    Id = 413,
                    Nombre = "Schweitzer",
                    PersonasDesciendenMaxIda = 10,
                    PersonasDesciendenMinIda = 0,
                    PersonasEsperandoMaxIda = 70,
                    PersonasEsperandoMinIda = 5,
                    PersonasDesciendenMaxVuelta = 70,
                    PersonasDesciendenMinVuelta = 5,
                    PersonasEsperandoMaxVuelta = 10,
                    PersonasEsperandoMinVuelta = 0,
                    EsEstacionDeMantenimiento = true
                },

                ["El Talar"] = new Estacion()
                {
                    Id = 414,
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
                    Id = 415,
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
                    Id = 416,
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
                    Id = 417,
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
                    Id = 418,
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
                    Id = 419,
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
                    Id = 420,
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
                    Id = 421,
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
