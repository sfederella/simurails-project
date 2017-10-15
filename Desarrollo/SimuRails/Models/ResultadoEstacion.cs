using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuRails.Models
{
    public class ResultadoEstacion
    {
        public int CantFormaciones { get; private set; }

        public double PorcentajeOcupacion { get; private set; }
        public double PorcentajePersonasParadas { get; private set; }
        public double PorcentajeSuperaronMaxCantLegal { get; private set; }
        public double PorcentajeRegularidadAbsoluta { get; private set; }
        public double PorcentajeCumplimientoPrograma { get; private set; }
        public double PorcentajeDemoraPorIncidentes { get; private set; }

        public ResultadoEstacion()
        {
            CantFormaciones = 0;
            PorcentajeOcupacion = double.MinValue;
            PorcentajePersonasParadas = double.MinValue;
            PorcentajeSuperaronMaxCantLegal = double.MinValue;
            PorcentajeRegularidadAbsoluta = double.MinValue;
            PorcentajeCumplimientoPrograma = double.MinValue;
            PorcentajeDemoraPorIncidentes = double.MinValue;
        }

        public void RegistrarNuevaFormacion()
        {
            CantFormaciones++;
        }

        private double PromediarValor(double nuevoValor, double promedioAnterior)
        {
            return (promedioAnterior * (CantFormaciones - 1) + nuevoValor) / CantFormaciones;
        }

        public void AgregarPorcentajeOcupacion(double valor)
        {
            if (PorcentajeOcupacion != double.MinValue)
            {
                PorcentajeOcupacion = PromediarValor(valor, PorcentajeOcupacion);
            }
            else
            {
                PorcentajeOcupacion = valor;
            }
        }

        public void AgregarPorcentajePersonasParadas(double valor)
        {
            if (PorcentajePersonasParadas != double.MinValue)
            {
                PorcentajePersonasParadas = PromediarValor(valor, PorcentajePersonasParadas);
            }
            else
            {
                PorcentajePersonasParadas = valor;
            }
        }

        public void AgregarPorcentajeSuperaronMaxCantLegal(double valor)
        {
            if (PorcentajeSuperaronMaxCantLegal != double.MinValue)
            {
                PorcentajeSuperaronMaxCantLegal = PromediarValor(valor, PorcentajeSuperaronMaxCantLegal);
            }
            else
            {
                PorcentajeSuperaronMaxCantLegal = valor;
            }
        }

        public void AgregarPorcentajeRegularidadAbsoluta(double valor)
        {
            if (PorcentajeRegularidadAbsoluta != double.MinValue)
            {
                PorcentajeRegularidadAbsoluta = PromediarValor(valor, PorcentajeRegularidadAbsoluta);
            }
            else
            {
                PorcentajeRegularidadAbsoluta = valor;
            }
        }

        public void AgregarPorcentajeCumplimientoPrograma(double valor)
        {
            if (PorcentajeCumplimientoPrograma != double.MinValue)
            {
                PorcentajeCumplimientoPrograma = PromediarValor(valor, PorcentajeCumplimientoPrograma);
            }
            else
            {
                PorcentajeCumplimientoPrograma = valor;
            }
        }

        public void AgregarPorcentajeDemoraPorIncidentes(double valor)
        {
            if (PorcentajeDemoraPorIncidentes != double.MinValue)
            {
                PorcentajeDemoraPorIncidentes = PromediarValor(valor, PorcentajeDemoraPorIncidentes);
            }
            else
            {
                PorcentajeDemoraPorIncidentes = valor;
            }
        }
    }
}
