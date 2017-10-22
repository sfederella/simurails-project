using SimuRails.Models;
//using SimuRails.Report;
using SimuRails.Views.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SimuRails.Views
{
    public partial class SimulacionList : Form
    {
        private MainForm mainForm;
        private TabPage tabPage;
        private List<RenglonDeTrazaSimu> renglonesDeTraza;

        public SimulacionList(MainForm mainForm, TabPage tabPage)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.tabPage = tabPage;
            renglonesDeTraza = new List<RenglonDeTrazaSimu>();
        }

        private void Simulacion_Load(object sender, EventArgs e)
        {
            List<Traza> trazas = new List<Traza>();
            var traza1 = new Traza();
            traza1.Nombre = "San Martín Completo";
            trazas.Add(traza1);
            var traza2 = new Traza();
            traza2.Nombre = "Mitre (Retiro - Tigre)";
            trazas.Add(traza2);
            var traza3 = new Traza();
            traza3.Nombre = "Belgrano Sur";
            trazas.Add(traza3);

            for (int i = 0; i < trazas.Count; i++)
            {
                var renglon = this.renglonDe(trazas.ElementAt(i), i);
                renglon.Selected += Renglon_Selected;
                renglonesDeTraza.Add(renglon);
            }

                
        }

        void Renglon_Selected(object sender, EventArgs args)  // the Handler (reacts)
        {
            renglonesDeTraza.ForEach(renglon =>
            {
                if(!renglon.Equals(sender)) {
                    renglon.deseleccionar();
                }
            });
        }

        private RenglonDeTrazaSimu renglonDe(Traza traza, Int32 indice)
        {
            var renglon = new RenglonDeTrazaSimu(traza);
            renglon.Location = new System.Drawing.Point(5, 25 + indice * 48);
            renglon.Width = this.listPanel.Width;
            renglon.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            this.listPanel.Controls.Add(renglon);
            return renglon;
        }

        //private void materialRaisedButton1_Click(object sender, EventArgs e)
        //{
        //    this.mainForm.embedForm(new SpinnerForm(this), tabPage);
        //    this.Visible = false;
        //}

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            //ReportGraphsForm form = new ReportGraphsForm(new Models.Simulacion());
            //form.TopLevel = false;
            //form.Visible = true;
            //form.FormBorderStyle = FormBorderStyle.None;
            //form.Dock = DockStyle.Fill;
            //this.Controls.Add(form);
        }
    }
}
