using SimuRails.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimuRails.Report
{
    public partial class ReportGraphsForm : Form
    {

        private Simulacion simulacion;
        private Color color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));

        public ReportGraphsForm(Simulacion simu)
        {
            InitializeComponent();
            simulacion = simu;
            LabelNombreSimulacion.Text = simu.Nombre;
            LabelDuracion.Text = simu.Duracion.ToString() + " minutos";
            BindCombo();
          }

        #region " Buttons "
        private void ButtonVerReporte_Click(object sender, EventArgs e)
        {
            FlowLayOutPanel1.Controls.Clear();
            GraficoTraza.Visible = false;
            ReportHelperGrafico itm = (ReportHelperGrafico)ComboBoxReportes.SelectedItem;
            if (itm.Valor==0) { return; }

            this.PanelGraficoTraza.BackColor = color;
            this.FlowLayOutPanel1.BackColor = color;
            this.panelGraficos.BackColor = color;
            string msgAxisY = "";
            if (itm.Valor == 1 || itm.Valor == 2) { msgAxisY = "% Pasajeros"; }
            else if (itm.Valor == 3 || itm.Valor == 4) { msgAxisY = "% trenes"; }
            else if (itm.Valor == 5) { msgAxisY = "% tiempo"; }


            List<ReportHelperValorIdaVuelta> listServicios = new List<ReportHelperValorIdaVuelta>();
            foreach (Servicio servicio in simulacion.TrazaSimulada.Servicios)
            {
                List<ReportHelperValorIdaVuelta> lstEstaciones = getListByEstacion(itm.Valor,servicio);
                Chart ch = CloneChart(GraphPorEstaciones);
                ch.DataSource = lstEstaciones;
                ch.Visible = true;
                //ch.Width = (FlowLayOutPanel1.Width / 2) ;
                ch.Titles[0].Text = servicio.Nombre;
                ch.ChartAreas[0].AxisY.Title = msgAxisY;
                FlowLayOutPanel1.Controls.Add(ch);
                
                //TODOS LOS RESULTADOS A NIVEL SERVICIO SON PROMEDIOS DE LOS % EN LAS ESTACIONES
                listServicios.Add(new ReportHelperValorIdaVuelta(servicio.Nombre, lstEstaciones.Average(x => x.ValorIda), lstEstaciones.Average(x => x.ValorVuelta)));
            }

            BindingSourceTraza.DataSource = listServicios;
            GraficoTraza.Titles[0].Text = itm.Nombre;
            GraficoTraza.ChartAreas[0].AxisY.Title = msgAxisY;
            GraficoTraza.Visible = true;

            //Esto es una negrda pero funciona al menos si hay 2
            this.Width++;
            this.Width--;
        }

        private void ButtonGenerarArchivo_Click(object sender, EventArgs e)
        {
            if (GraficoTraza.Visible == false) { return; };
            List<ReportHelperGrafico> lstRutas = new List<ReportHelperGrafico>();
            string rutaTraza = Path.GetTempPath() + "rutaTraza" + DateTime.Now.ToString("MMddyy HHmmss")+".png";
            CloneChartSinBorde(GraficoTraza).SaveImage(rutaTraza, ChartImageFormat.Png);
            lstRutas.Add(new ReportHelperGrafico(rutaTraza, 0));
            foreach (Chart chartEstacion in FlowLayOutPanel1.Controls)
            {
                string rutaEstacion = Path.GetTempPath() + "rutaEstacion" + DateTime.Now.ToString("MMddyy HHmmss") + ".png";
                CloneChartSinBorde(chartEstacion).SaveImage(rutaEstacion, ChartImageFormat.Png);
                lstRutas.Add(new ReportHelperGrafico(rutaEstacion, 0));
            }

            ReportViewerForm f = new ReportViewerForm()
            {
                Width = 830,
                Height = 900,
                FormBorderStyle = FormBorderStyle.FixedToolWindow,
                WindowState = FormWindowState.Normal,
                StartPosition = FormStartPosition.CenterScreen,
                Text = "Reporte"
            };
            ReportHelper.ProcessReport(simulacion, lstRutas, f.ReportViewerObject);
            f.ShowDialog();          
        }
        #endregion

        #region " Helpers "
        private List<ReportHelperValorIdaVuelta> getListByEstacion(double tipoReporte,Servicio servicio)
        {
            List<ReportHelperValorIdaVuelta> listEstaciones = new List<ReportHelperValorIdaVuelta>();
            Tramo ultimoTramo = servicio.Tramos.Last();
            foreach (Tramo tramo in servicio.Tramos)
            {
                Estacion estacionOrigen = tramo.EstacionOrigen;
                Estacion estacionDestino = null;
                if (tramo.Equals(ultimoTramo)) { estacionDestino = tramo.EstacionDestino; };
                if (tipoReporte == 1)
                {              
                    listEstaciones.Add(new ReportHelperValorIdaVuelta(estacionOrigen.Nombre, estacionOrigen.ResultadoIda.PorcentajeOcupacion, estacionOrigen.ResultadoVuelta.PorcentajeOcupacion));
                    if (estacionDestino!=null) { listEstaciones.Add(new ReportHelperValorIdaVuelta(estacionDestino.Nombre, estacionDestino.ResultadoIda.PorcentajeOcupacion, estacionDestino.ResultadoVuelta.PorcentajeOcupacion)); }     
                }
                else if (tipoReporte == 2)
                {
                    listEstaciones.Add(new ReportHelperValorIdaVuelta(estacionOrigen.Nombre, estacionOrigen.ResultadoIda.PorcentajePersonasParadas, estacionOrigen.ResultadoVuelta.PorcentajePersonasParadas));
                    if (estacionDestino!=null) { listEstaciones.Add(new ReportHelperValorIdaVuelta(estacionDestino.Nombre, estacionDestino.ResultadoIda.PorcentajePersonasParadas, estacionDestino.ResultadoVuelta.PorcentajePersonasParadas)); }
                }
                else if (tipoReporte == 3)
                {
                    listEstaciones.Add(new ReportHelperValorIdaVuelta(estacionOrigen.Nombre, estacionOrigen.ResultadoIda.PorcentajeSuperaronMaxCantLegal, estacionOrigen.ResultadoVuelta.PorcentajeSuperaronMaxCantLegal));
                    if (estacionDestino!=null) { listEstaciones.Add(new ReportHelperValorIdaVuelta(estacionDestino.Nombre, estacionDestino.ResultadoIda.PorcentajeSuperaronMaxCantLegal,estacionDestino.ResultadoVuelta.PorcentajeSuperaronMaxCantLegal)); }
                }
                else if (tipoReporte == 4)
                {
                    listEstaciones.Add(new ReportHelperValorIdaVuelta(estacionOrigen.Nombre, estacionOrigen.ResultadoIda.PorcentajeRegularidadAbsoluta, estacionOrigen.ResultadoVuelta.PorcentajeRegularidadAbsoluta));
                    if (estacionDestino!=null) { listEstaciones.Add(new ReportHelperValorIdaVuelta(estacionDestino.Nombre, estacionDestino.ResultadoIda.PorcentajeRegularidadAbsoluta, estacionDestino.ResultadoVuelta.PorcentajeRegularidadAbsoluta)); }
                }
                else if (tipoReporte == 5)
                {
                    listEstaciones.Add(new ReportHelperValorIdaVuelta(estacionOrigen.Nombre, estacionOrigen.ResultadoIda.PorcentajeDemoraPorIncidentes, estacionOrigen.ResultadoVuelta.PorcentajeDemoraPorIncidentes));
                    if (estacionDestino!=null) { listEstaciones.Add(new ReportHelperValorIdaVuelta(estacionDestino.Nombre, estacionDestino.ResultadoIda.PorcentajeDemoraPorIncidentes, estacionDestino.ResultadoVuelta.PorcentajeDemoraPorIncidentes)); }
                }
            }           
            return listEstaciones;
        }

        private void BindCombo()
        {
            List<ReportHelperGrafico> listReportes = new List<ReportHelperGrafico>
                                    { new ReportHelperGrafico("< Seleccionar >", 0) ,
                                      new ReportHelperGrafico("% de Ocupación", 1) ,
                                      new ReportHelperGrafico("% de Personas que viajaron paradas", 2) ,
                                      new ReportHelperGrafico("% de trenes que superaron la máxima cantidad de pasajeros permitidos", 3) ,
                                      new ReportHelperGrafico("% de cumplimiento de la programación (Regularidad Absoluta)", 4) ,
                                      new ReportHelperGrafico("% del tiempo perdido por incidente", 5) ,
                                                };
            ComboBoxReportes.DataSource = listReportes;
            ComboBoxReportes.listaDatos = listReportes.Select(x => x.Nombre).ToList();
            ComboBoxReportes.DisplayMember = "Nombre";
            ComboBoxReportes.ValueMember = "Valor";
        }
        private Chart CloneChart(Chart Graph)
        {
            MemoryStream stream = new MemoryStream();
            Graph.Serializer.Save(stream);
            Chart clonedChart = new Chart();
            clonedChart.Serializer.Load(stream);
            return clonedChart;
        }
        private Chart CloneChartSinBorde(Chart Graph)
        {
            Chart clonedChart = CloneChart(Graph);
            clonedChart.BorderSkin.SkinStyle= BorderSkinStyle.None;
            clonedChart.BorderlineDashStyle = ChartDashStyle.NotSet;
            return clonedChart;
        }

        private void ReportGraphsForm_SizeChanged(object sender, EventArgs e)
        {
            foreach (Chart chart in FlowLayOutPanel1.Controls)
            {
                chart.Width = (GraficoTraza.Size.Width / 2) - 6;
            }
        }


        #endregion
    }
}