using MaterialSkin;
using MaterialSkin.Controls;
using SimuRails.Views.Abms;
using SimuRails.Views.Abms.FormacionAbm;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SimuRails.Views
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public MainForm()
        {
            Sizable = true;
            
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            var serviForm = new ServiciosListForm(this, tabServicios);
            var estaForm = new EstacionesListForm(this, tabEstaciones);
            var cocheForm = new CochesListForm(this, tabCoches);
            var inciForm = new IncidentesListForm(this, tabIncidentes);
            var trazaForm = new TrazasListForm(this, tabTrazas);
            var formaForm = new FormacionListForm(this, tabFormaciones);
            var simuForm = new SimulacionesListForm(this, tabSimulacion);

            // Embeber formularios en los tabs respectivos
            EmbedForm(serviForm, tabServicios, serviForm.onTabEnter);
            EmbedForm(estaForm, tabEstaciones, estaForm.onTabEnter);
            EmbedForm(cocheForm, tabCoches, cocheForm.onTabEnter);
            EmbedForm(inciForm, tabIncidentes, inciForm.onTabEnter);
            EmbedForm(trazaForm, tabTrazas, trazaForm.onTabEnter);
            EmbedForm(formaForm, tabFormaciones, formaForm.onTabEnter);
            EmbedForm(simuForm, tabSimulacion, simuForm.onTabEnter);
        }
        
        public void EmbedForm(Form form, TabPage tabPage)
        {
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            tabPage.Controls.Add(form);
        }

        public void EmbedForm(Form form, TabPage tabPage, EventHandler handlerOnEnter)
        {
            this.EmbedForm(form, tabPage);
            form.VisibleChanged += new EventHandler(delegate (Object sender, EventArgs a)
            {
                if (form.Visible)
                    handlerOnEnter.Invoke(sender, a);
            });
        }

        private void label1_Click(object sender, System.EventArgs e)
        {
            SobreNosotrosForm frm = new SobreNosotrosForm();
            frm.ShowDialog();
        }

        private void label2_Click(object sender, System.EventArgs e)
        {
            string pathManual = Path.Combine(Application.StartupPath, "ManualDeUsuario.pdf");
            try
            {
                //Process.Start(pathManual);
                string openPDFFile =Path.Combine(Application.StartupPath,"ManualUsuario.PDF");
                System.IO.File.WriteAllBytes(openPDFFile, global::SimuRails.Properties.Resources.ManualDeUsuario);
                System.Diagnostics.Process.Start(openPDFFile);    
            }
            catch
            {
                MaterialMessageBox.Show("Error de Apertura", "No se puede acceder al Manual de Usuario.");
            }         
        }
    }
}
